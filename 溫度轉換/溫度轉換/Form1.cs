using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 溫度轉換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string f = textBox1.Text;
                int ff = int.Parse(f);
                label2.Text = ff+ "℃ " +" = "+ ConvertCelsiusToFarhenheit(ff).ToString() + "℉ ";
            }
            if (radioButton2.Checked)
            {
                string c = textBox1.Text;
                int cc = int.Parse(c);
                label2.Text = cc + "℉ " + " = " + ConvertFarhenheitToCelsius(cc).ToString() + "℃ ";
            }


        }

        public static double ConvertFarhenheitToCelsius(double F)
        {
            return (F - 32.0) * (5.0 / 9.0);
        }
        public static double ConvertCelsiusToFarhenheit(double C)
        {
            return C*9.0 / 5.0   + 32;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
