using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Find_File_by_Mask;

namespace WindowsFormsApplication1
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startProgram_Click(object sender, EventArgs e)
            
        {
            outputBox.ResetText();
            outputBox.Items.Clear();
            string mask = fileName.Text+"."+fileExtension.Text ;
            fileCount.Text=Engine.Start(outputBox,isTextSearch.Checked, isDirectory.Checked, mask , textSearch.Text, pathDirectory.Text,false).ToString();

        }

        private void isDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if (isDirectory.Checked)
                pathDirectory.Visible = true;
            else
            {
                pathDirectory.Visible = false;
                pathDirectory.Clear();
            }

        }

        private void isTextSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (isTextSearch.Checked)
                textSearch.Visible = true;
            else
            {
                textSearch.Visible = false;
                textSearch.Clear();
            }

             
        }
    }
}
