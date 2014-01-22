using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Find_File_by_Mask
{

    public class CounterHelper
    {
        private long tasksCount;
        private long fileCounter;
        private long textCounter;
        public void IncrementTaskCount()
        {
            Interlocked.Increment(ref tasksCount);
        }

        public void DecrementTaskCount()
        {
            Interlocked.Decrement(ref tasksCount);
        }

        public long GetTaskCount()
        {
            return Interlocked.Read(ref tasksCount);
        }

        public void AddFoundCount(int count)
        {
            Interlocked.Add(ref fileCounter, count);
        }

        public long GetFoundCount()
        {
            return Interlocked.Read(ref fileCounter);
        }
        public void AddTextFoundCount(int count)
        {
            Interlocked.Add(ref textCounter, count);
        }

        public long GetTextFoundCount()
        {
            return Interlocked.Read(ref textCounter);
        }

    }

    public class TaskData
    {
        public string directory;
        public CounterHelper сounterHelper;
        public string mask;
        public bool isTextSearch;
        public String textToFind;
        public bool workType;

        public TaskData(string directory, CounterHelper сounterHelper, string mask, bool isTextSearch, string textToFind, bool workType)
        {
            this.directory = directory;
            this.сounterHelper = сounterHelper;
            this.mask = mask;
            this.isTextSearch = isTextSearch;
            this.textToFind = textToFind;
            this.workType = workType;
        }
    }

    public class TasksSet
    {

        public TasksSet(TaskData taskData)
        {
            string directory = taskData.directory;
            CounterHelper сounterHelper = taskData.сounterHelper;
            bool workType = taskData.workType;
            try
            {

                string[] directoriesIn = System.IO.Directory.GetDirectories(directory);
                if (directoriesIn.Length != 0)
                {    //все подпапки в этой папке
                    for (int i = 0; i < directoriesIn.Length; ++i)
                    {
                        System.IO.DirectoryInfo dirInf = new DirectoryInfo(directoriesIn[i]);
                        сounterHelper.IncrementTaskCount();
                        ThreadPool.QueueUserWorkItem(new WaitCallback(Engine.ThreadProc), new TaskData(directoriesIn[i], сounterHelper, taskData.mask, taskData.isTextSearch, taskData.textToFind, workType));

                    }
                }
                string[] inputNames = Directory.GetFiles(directory, taskData.mask, SearchOption.TopDirectoryOnly);

                сounterHelper.AddFoundCount(inputNames.Length);

                for (int i = 0; i < inputNames.Length; ++i)
                {
                    if (!taskData.isTextSearch)
                    {
                        if (workType)
                            Console.WriteLine(inputNames[i]);
                        else
                            UpdateText(inputNames[i]);
                    }
                    else
                    {
                        if (t_search(inputNames[i], taskData.textToFind, taskData.workType) == true)
                            сounterHelper.AddTextFoundCount(1);
                    }
                }// если файл, то выполняем поиск
                сounterHelper.DecrementTaskCount();
            }
            catch (UnauthorizedAccessException)
            {
                сounterHelper.DecrementTaskCount();

            }
        }

        bool t_search(string f_name, string textToFind, bool workType)
        {
                foreach (string line in File.ReadLines(f_name))
                    if (line.Contains(textToFind))
                    {

                        if (workType)
                            Console.WriteLine("Текст найден в " + f_name);
                        else
                            UpdateText(f_name);

                        return true;
                    }
                        return false;
            

        }//t_search

        private void UpdateText(string text)
        {
            try
            {
                if (Engine.myTextBox.InvokeRequired)
                    Engine.myTextBox.BeginInvoke(new Action<string>((s) => Engine.myTextBox.Items.Add(s)), text);
                else
                    Engine.myTextBox.Text = text;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Can't update!");
            }
        }

    }

    public class Engine
    {
        public static ListBox myTextBox = null;
        public static long Start(ListBox inputText, bool isTextSearch, bool isDirectory, string mask, string textToFind, string inputPath, bool workType)
        {
            myTextBox = inputText;
            if (workType)
            {
                ConsoleKeyInfo cki;
                Console.WriteLine("Имя файла");
                mask = Console.ReadLine();
                mask += ".";
                Console.WriteLine("Расширение файла");
                mask += Console.ReadLine();
                Console.WriteLine("Искать строку?\n(ENTER-YES)");
                cki = Console.ReadKey(true);
                isTextSearch = false;
                textToFind = null;
                if (cki.Key == ConsoleKey.Enter)
                {
                    isTextSearch = true;
                    Console.WriteLine("Искомый текст");
                    textToFind = Console.ReadLine();
                }
                Console.WriteLine("Глобальный поиск?\n(ENTER-YES)");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                    isDirectory = false;
            }

            CounterHelper counterHelper = new CounterHelper();

            var pathsToSearch = new List<string>();
            if (!isDirectory)
            {
                DriveInfo[] allDrivers = System.IO.DriveInfo.GetDrives();//получаем информацию о драйверах
                for (int i = 0; i < allDrivers.Length; ++i)
                {
                    if (allDrivers[i].IsReady)
                    {
                        pathsToSearch.Add(allDrivers[i].ToString());
                    }

                }
            }
            else
            {

                if (workType)
                {
                    Console.WriteLine("Введите путь, например C:\\...");
                    inputPath = Console.ReadLine();
                }

                if (Directory.Exists(inputPath))
                {
                    pathsToSearch.Add(inputPath);
                }
                else
                {

                    Console.WriteLine("Directory " + inputPath + " not found.");

                }

            }
            if (pathsToSearch.Count > 0)
            {
                foreach (string currentPath in pathsToSearch)
                {
                    counterHelper.IncrementTaskCount();
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc), new TaskData(currentPath, counterHelper, mask, isTextSearch, textToFind, workType));
                }
                while (counterHelper.GetTaskCount() > 0)
                {
                    Thread.Sleep(100);
                }


            }
            if (workType)
            {
                if (isTextSearch)
                    Console.WriteLine("foundCount - " + counterHelper.GetTextFoundCount());
                else
                Console.WriteLine("foundCount - " + counterHelper.GetFoundCount());
                Console.ReadLine();
            }
            if (isTextSearch)
                return counterHelper.GetTextFoundCount();
            return counterHelper.GetFoundCount();
        }



        public static void ThreadProc(object taskData)
        {
            TasksSet tmp = new TasksSet((TaskData)taskData);
        }
      }
    }
