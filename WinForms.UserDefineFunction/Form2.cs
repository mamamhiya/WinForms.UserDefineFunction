using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace WinForms.UserDefineFunction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double Base = 0.0;
            double triangleArea = 0.0;
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out Base))
            {
                triangleArea = CalculateTriangleArea(height, Base);
                label7.Text = triangleArea.ToString("F2");
            }
            else
            {
                MessageBox.Show("กรุณาป้อนค่าตัวเลขที่ถูกต้องสำหรับฐานและความสูง");
            }

        }


        private double CalculateTriangleArea(double height, double Base)
        {
            double area = 0.5 * Base * height;
            return area;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radias = 0.0;
            double circleArea = 0.0;
            double Circumference = 0.0;
            if (double.TryParse(textBox4.Text, out radias))
            {
                circleArea = CalculateCircleArea(radias);
                Circumference = CalculateCircumference(radias);
                label10.Text = circleArea.ToString("F2");
                label16.Text = Circumference.ToString("F2");
            }
            else
            {
                MessageBox.Show("กรุณาป้อนค่าตัวเลขที่ถูกต้องสำหรับรัศมี");
            }
        }

        private double CalculateCircumference(double radias)
        {
            return 2 * Math.PI * radias;
        }

        private double CalculateCircleArea(double radias)
        {
            return Math.PI * radias * radias;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox3.Text, out i))
            {
                label21.Text = i.ToString();
                label22.Text = RandomNextNumber(ref i).ToString();
                textBox3.Text = i.ToString();
            }
        }

        private int RandomNextNumber(ref int x)
        {
            Random rnd = new Random();
            x += rnd.Next(1, 100);
            return x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double summary = 0.0;
            string[] intput = textBox5.Lines;
            double[] number = new double[intput.Length];

            for(int i = 0; i < intput.Length; i++)
            {
                if (double.TryParse(intput[i], out number[i]))
                {
                    number[i] = 0.0;
                }
                
            }
            summary = CalculateSummary(number);
            MessageBox.Show("ผลรวมคือ " + summary.ToString("F2"));
        }

        private double CalculateSummary(double[] number)
        {   
            double summary = 0.0;
            for (int i = 0; i < number.Length; i++)
            {
                summary += number[i];
            }
            return summary;
        }
    }
}
