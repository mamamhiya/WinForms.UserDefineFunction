using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letter = (string)textBox1.Text;
            int size = int.Parse(textBox2.Text);
            textBox3.Clear();
            if (radioButton1.Checked)
            {
                
                textBox3.Text = Triangle1(letter, size);
            }
            else if (radioButton2.Checked)
            {
              
                textBox3.Text = Triangle2(letter);
            }
            else if (radioButton3.Checked)
            {
                
                Triangle3(letter, size,out string result);
            }
            
        }

        private string Triangle1(string letter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    textBox3.Text += letter;
                }
                textBox3.Text += Environment.NewLine;
            }
            return textBox3.Text;

        }

        private string Triangle2(string letter)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    textBox3.Text += letter;
                }
                textBox3.Text += Environment.NewLine;
            }
            return textBox3.Text;
        }

        private void Triangle3(string letter, int size, out string result)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    textBox3.Text += letter;
                }
                textBox3.Text += Environment.NewLine;
            }
            result = textBox3.Text;
        }
    }
}
