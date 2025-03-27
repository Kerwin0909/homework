using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hw4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "save";
            button2.Text = "choose files";
        }
        private string allfiletext = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.InitialDirectory = "C:\\Users\\sheka\\Desktop";
            ofd.Filter = "文本文件 (*.txt)|*.txt";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] se = ofd.FileNames;
                string filetext1 = File.ReadAllText(se[0]);
                string filetext2 = File.ReadAllText(se[1]);
                allfiletext = filetext1 + filetext2;
                MessageBox.Show(allfiletext);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\sheka\Desktop\hw4";
            string dataFolderPath = Path.Combine(folderPath, "Data");
            Directory.CreateDirectory(dataFolderPath);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "文本文件 (*.txt)|*.txt";
            sd.FileName = "合并.txt";
            string folderPath1 = @"C:\Users\sheka\Desktop\hw4\Data";
            sd.InitialDirectory = folderPath1;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                string s = sd.FileName;
                System.IO.File.WriteAllText(s,allfiletext);
            }
        }
    }
    }
