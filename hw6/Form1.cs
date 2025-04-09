using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;

namespace hw6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url= "file:///C:/Users/sheka/Desktop/html.html";
            System.Diagnostics.Process.Start(url);
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            string code = reader.ReadToEnd();
            var st = new Regex(@"\b[\w\.-]+@[\w\.-]+\.\w{2,}\b");
            var st1 = new Regex(@"(13\d|14[579]|15[^4\D]|17[^49\D]|18\d)\d{8}");
            var match = st.Match(code);
            var match1 = st1.Match(code);
            label1.Text = match.Value;
            label2.Text = match1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
