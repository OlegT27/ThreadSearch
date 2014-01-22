using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Find_File_by_Mask;

namespace WindowsFormsApplication1
{


    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();

        }

        private void formSelect_Click(object sender, EventArgs e)
        {
            FormApp f = new FormApp();
            f.ShowDialog();
        }

        private void consoleSelect_Click(object sender, EventArgs e)
        {
            if (AllocConsole())
            {
                Engine.Start(null,true, true, null, null, null, true);
                FreeConsole();
            }
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();
    }
}