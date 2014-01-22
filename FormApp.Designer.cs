namespace WindowsFormsApplication1
{
    partial class FormApp
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startProgram = new System.Windows.Forms.Button();
            this.isDirectory = new System.Windows.Forms.CheckBox();
            this.isTextSearch = new System.Windows.Forms.CheckBox();
            this.fileCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.pathDirectory = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileExtension = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startProgram
            // 
            this.startProgram.Location = new System.Drawing.Point(33, 362);
            this.startProgram.Name = "startProgram";
            this.startProgram.Size = new System.Drawing.Size(82, 25);
            this.startProgram.TabIndex = 0;
            this.startProgram.Text = "Start!";
            this.startProgram.UseVisualStyleBackColor = true;
            this.startProgram.Click += new System.EventHandler(this.startProgram_Click);
            // 
            // isDirectory
            // 
            this.isDirectory.AutoSize = true;
            this.isDirectory.Location = new System.Drawing.Point(33, 170);
            this.isDirectory.Name = "isDirectory";
            this.isDirectory.Size = new System.Drawing.Size(178, 17);
            this.isDirectory.TabIndex = 1;
            this.isDirectory.Text = "Поиск в заданной директории";
            this.isDirectory.UseVisualStyleBackColor = true;
            this.isDirectory.CheckedChanged += new System.EventHandler(this.isDirectory_CheckedChanged);
            // 
            // isTextSearch
            // 
            this.isTextSearch.AutoSize = true;
            this.isTextSearch.Location = new System.Drawing.Point(33, 221);
            this.isTextSearch.Name = "isTextSearch";
            this.isTextSearch.Size = new System.Drawing.Size(93, 17);
            this.isTextSearch.TabIndex = 2;
            this.isTextSearch.Text = "Поиск текста";
            this.isTextSearch.UseVisualStyleBackColor = true;
            this.isTextSearch.CheckedChanged += new System.EventHandler(this.isTextSearch_CheckedChanged);
            // 
            // fileCount
            // 
            this.fileCount.AutoSize = true;
            this.fileCount.Location = new System.Drawing.Point(449, 313);
            this.fileCount.Name = "fileCount";
            this.fileCount.Size = new System.Drawing.Size(0, 13);
            this.fileCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Число найденных файлов";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(26, 47);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 6;
            // 
            // pathDirectory
            // 
            this.pathDirectory.Location = new System.Drawing.Point(33, 193);
            this.pathDirectory.Name = "pathDirectory";
            this.pathDirectory.Size = new System.Drawing.Size(100, 20);
            this.pathDirectory.TabIndex = 7;
            this.pathDirectory.Visible = false;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(33, 244);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(100, 20);
            this.textSearch.TabIndex = 8;
            this.textSearch.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Имя файла";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Расширение файла";
            // 
            // fileExtension
            // 
            this.fileExtension.Location = new System.Drawing.Point(26, 86);
            this.fileExtension.Name = "fileExtension";
            this.fileExtension.Size = new System.Drawing.Size(100, 20);
            this.fileExtension.TabIndex = 11;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.HorizontalScrollbar = true;
            this.outputBox.Location = new System.Drawing.Point(247, 31);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(282, 251);
            this.outputBox.Sorted = true;
            this.outputBox.TabIndex = 12;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 407);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.fileExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.pathDirectory);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileCount);
            this.Controls.Add(this.isTextSearch);
            this.Controls.Add(this.isDirectory);
            this.Controls.Add(this.startProgram);
            this.Name = "FormApp";
            this.Text = "FormApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startProgram;
        private System.Windows.Forms.CheckBox isDirectory;
        private System.Windows.Forms.CheckBox isTextSearch;
        private System.Windows.Forms.Label fileCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox pathDirectory;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileExtension;
        private System.Windows.Forms.ListBox outputBox;
    }
}