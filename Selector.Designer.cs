namespace WindowsFormsApplication1
{
    partial class Selector
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
            this.formSelect = new System.Windows.Forms.Button();
            this.consoleSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formSelect
            // 
            this.formSelect.Location = new System.Drawing.Point(12, 44);
            this.formSelect.Name = "formSelect";
            this.formSelect.Size = new System.Drawing.Size(59, 32);
            this.formSelect.TabIndex = 0;
            this.formSelect.Text = "Form";
            this.formSelect.UseVisualStyleBackColor = true;
            this.formSelect.Click += new System.EventHandler(this.formSelect_Click);
            // 
            // consoleSelect
            // 
            this.consoleSelect.Location = new System.Drawing.Point(96, 44);
            this.consoleSelect.Name = "consoleSelect";
            this.consoleSelect.Size = new System.Drawing.Size(59, 32);
            this.consoleSelect.TabIndex = 1;
            this.consoleSelect.Text = "Console";
            this.consoleSelect.UseVisualStyleBackColor = true;
            this.consoleSelect.Click += new System.EventHandler(this.consoleSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите режим работы";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consoleSelect);
            this.Controls.Add(this.formSelect);
            this.Name = "Selector";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formSelect;
        private System.Windows.Forms.Button consoleSelect;
        private System.Windows.Forms.Label label1;
    }
}

