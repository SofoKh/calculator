using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        string a = "";
        string b = "";
        char function;
        double result = 0.0;
        string Input = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            a = "";
            b = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            b = Input;
            int aNum, bNum;

            

            
            if (function == '+')
            {
                b = textBox.Text.Split('+')[1];
                a = textBox.Text.Split('+')[0];
                aNum = int.Parse(a);
                bNum = int.Parse(b);
                result = aNum + bNum;
                textBox.Text = result.ToString();
            }
            
            if (function == '-')
            {
                b = textBox.Text.Split('-')[1];
                a = textBox.Text.Split('-')[0];
                aNum = int.Parse(a);
                bNum = int.Parse(b);
                result = aNum - bNum;
                textBox.Text = result.ToString();
            }
            
            if (function == '*')
            {
                b = textBox.Text.Split('*')[1];
                a = textBox.Text.Split('*')[0];
                aNum = int.Parse(a);
                bNum = int.Parse(b);
                result = aNum * bNum;
                textBox.Text = result.ToString();
            }
            
            if (function == '/')
            {
                b = textBox.Text.Split('/')[1];
                a = textBox.Text.Split('/')[0];
                aNum = int.Parse(a);
                bNum = int.Parse(b);
               
                if (bNum == 0)
                {
                    textBox.Text = "Error ... Can't divide by zero smh";
                }
                else { 
             
                 
                    result = aNum / bNum;
                textBox.Text = result.ToString();
                }
            }
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            function = '+';
            a = Input;
            Input = "";
            textBox.Text += '+';
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            function = '-';
            a = Input;
            Input = "";
            textBox.Text += '-';
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            function = '*';
            a = Input;
            Input = "";
            textBox.Text += '*';
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            function = '/';
            a = Input;
            Input = "";
            textBox.Text += '/';
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}