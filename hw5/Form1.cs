using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            button11.Click += button11_Click;
            button12.Click += button12_Click;
            button13.Click += button13_Click;
            button14.Click += button14_Click;
            button15.Click += button15_Click;
            button16.Click += button16_Click;
            button1.Text = "0";
            button2.Text = "1";
            button3.Text = "2";
            button4.Text = "3";
            button5.Text = "4";
            button6.Text = "5";
            button7.Text = "6";
            button8.Text = "7";
            button9.Text = "8";
            button10.Text = "9";
            button11.Text = "+";
            button12.Text = "-";
            button13.Text = "*";
            button14.Text = "/";
            button15.Text = "=";
            button16.Text = "rst";
            label1.Text = "";
            label2.Text = "";
            
        }
        private string num = "";
        public static string Trans(string exp)//中缀表达式转后缀表达式
        {
            Stack<char> opor = new Stack<char>();
            string postexp = "";
            int i = 0;
            while (i < exp.Length)
            {
                char ch = exp[i];

                if (ch == ' ')
                {
                    i++;
                    continue;
                }
                else if (ch == '+' || ch == '-')
                {
                    while (opor.Count > 0 && (opor.Peek() == '*' || opor.Peek() == '/' ||
                                            opor.Peek() == '+' || opor.Peek() == '-'))
                    {
                        postexp += opor.Pop();
                    }
                    opor.Push(ch);
                }
                else if (ch == '*' || ch == '/')
                {
                    while (opor.Count > 0 && (opor.Peek() == '*' || opor.Peek() == '/'))
                    {
                        postexp += opor.Pop();
                    }
                    opor.Push(ch);
                }
                else
                {
                    string d = "";
                    while (i < exp.Length && char.IsDigit(exp[i]))
                    {
                        d += exp[i];
                        i++;
                    }
                    i--;
                    postexp += d + "#";
                }
                i++;
            }
            while (opor.Count > 0)
            {
                postexp += opor.Pop();
            }

            return postexp;
        }

    public static double GetValue(string postexp)//后缀表达式求值
    {
        Stack<double> opand = new Stack<double>();
        double a, b, c, d;
        char ch;
        int i = 0;
        while (i < postexp.Length)
        {
            ch = postexp[i];
            switch (ch)
            {
                case '+':
                    a = opand.Pop();
                    b = opand.Pop();
                    c = b + a;
                    opand.Push(c);
                    break;
                case '-':
                    a = opand.Pop();
                    b = opand.Pop();
                    c = b - a;
                    opand.Push(c);
                    break;
                case '*':
                    a = opand.Pop();
                    b = opand.Pop();
                    c = b * a;
                    opand.Push(c);
                    break;
                case '/':
                    a = opand.Pop();
                    b = opand.Pop();
                    c = b / a;
                    opand.Push(c);
                    break;
                default:
                    d = 0;
                    while (ch >= '0' && ch <= '9')
                    {
                        d = 10 * d + (ch - '0');
                        i++;
                        ch = postexp[i];
                    }
                    opand.Push(d);
                    break;
            }
            i++;
        }
        return opand.Peek();
    }
    private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            num += "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            num += "1";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            num += "2";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            num += "3";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            num += "4";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            num += "5";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            num += "6";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            num += "7";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            num += "8";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            num += "9";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
            num += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
            num += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            num += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
            num += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string num1 = Trans(num);
            double num2 = GetValue(num1);
            label2.Text = num2.ToString();
            label1.Font = new Font(label1.Font.FontFamily, 10, label1.Font.Style);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            num = "";
            label1.Font = new Font(label1.Font.FontFamily, 18, label1.Font.Style);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
