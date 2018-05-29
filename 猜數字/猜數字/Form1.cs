using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字
{
    public partial class Form1 : Form
    {
      
        string ans;
        public Form1()
        {
            InitializeComponent();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> _list = new List<string>();
            int i;
            Random rnd = new Random();  //產生亂數初始值

            while (_list.Count<4)
            {
                i = rnd.Next(1, 10);
                if (_list.Any((x) => x == i.ToString()) == false)
                {
                    _list.Add(i.ToString());
                }
            }

            ans = _list[0].ToString() + _list[1].ToString() + _list[2].ToString() + _list[3].ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {            
            label3.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = 0;
            int a = 0;
            string input = textBox1.Text;
            var Inter = ans.Intersect(input);
            b = Inter.Count();
            foreach (var i in Inter)
            {
                var Inte =ans.IndexOf(i.ToString());
                if(ans[Inte] == input[Inte])
                {
                    a++;
                }
            }
            b = b - a;
            textBox2.Text += input + "--" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
            if (a == 4)
            {
                MessageBox.Show("恭喜過關 !!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
