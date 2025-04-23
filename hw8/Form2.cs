using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hw8
{
    public partial class Form2: Form
    {
        private int i = 0;
        private string[] data;
        private string[] data1;
        private int num;
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            connect d = new connect();
            data = d.Data();
            data1 = d.Data1();
            num= d.num();
            label1.Text = data[i];
            label2.Text = "";
        }
        private async void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == data1[i])
            {
                label2.Text = "Good!";
                await Task.Delay(1000);
                i++;
                label1.Text = data[i];
                textBox1.Text = "";
                label2.Text = "";
            }
            else 
            {
                label2.Text = "The answer is "+ data1[i];
                await Task.Delay(2500);
                i++;
                label1.Text = data[i];
                textBox1.Text = "";
                label2.Text = "";
            }
            if (i == num)
            {
                label1.Text = "";
                label2.Text = "Congratulation all the exercises";
                await Task.Delay(2500);
                this.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
