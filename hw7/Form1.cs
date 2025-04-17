using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace hw7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task baidu = Task.Run(() =>
            {   string url= "https://www.baidu.com/s?wd=" + textBox1.Text;
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                string code = reader.ReadToEnd();
                textBox2.Text=code.Substring(0,200);
            });
            Task bing = Task.Run(() =>  
            {   string ur2 = "https://www.bing.com/search?q=" + textBox1.Text;
                WebRequest request1 = WebRequest.Create(ur2);
                WebResponse response1 = request1.GetResponse();
                Stream responseStream1 = response1.GetResponseStream();
                StreamReader reader1 = new StreamReader(responseStream1, Encoding.UTF8);
                var code1 = reader1.ReadToEnd();
                textBox3.Text = code1.Substring(0, 200);
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
