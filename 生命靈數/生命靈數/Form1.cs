using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 生命靈數
{
    public partial class Form1 : Form
    {
        string s;
        string lifesoul;
        public Form1()
        {
            InitializeComponent();
        }
        
        private string aaa()
        {
            int year = dateTimePicker1.Value.Year;
            DateTime First_Aquarius = new DateTime(year, 1, 21);
            DateTime end_Aquarius = new DateTime(year, 2, 20);
            DateTime First_Pieces = new DateTime(year, 2, 21);
            DateTime end_Pieces = new DateTime(year, 3, 20);
            DateTime First_Aries = new DateTime(year, 3, 21);
            DateTime end_Aries = new DateTime(year, 4, 20);
            DateTime First_Taurus = new DateTime(year, 4, 21);
            DateTime end_Taurus = new DateTime(year, 5, 20);
            DateTime First_Gemini = new DateTime(year, 5, 21);
            DateTime end_Gemini = new DateTime(year, 6, 20);
            DateTime First_Cancer = new DateTime(year, 6, 21);
            DateTime end_Cancer = new DateTime(year, 7, 20);
            DateTime First_Leo = new DateTime(year, 7, 21);
            DateTime end_Leo = new DateTime(year, 8, 20);
            DateTime First_Virgo = new DateTime(year, 8, 21);
            DateTime end_Virgo = new DateTime(year, 9, 20);
            DateTime First_Libra = new DateTime(year, 9, 21);
            DateTime end_Libra = new DateTime(year, 10, 20);
            DateTime First_Scorpio = new DateTime(year, 10, 21);
            DateTime end_Scorpio = new DateTime(year, 11, 20);
            DateTime First_Sagittarius = new DateTime(year, 11, 21);
            DateTime end_Sagittarius = new DateTime(year, 12, 20);
            DateTime First_Capricorn = new DateTime(year, 12, 21);
            DateTime end_Capricorn = new DateTime(year, 1, 20);

            var date = dateTimePicker1.Value.Date;
            if (First_Aquarius <= date && date <= end_Aquarius)
            {
                return "水瓶座";
            }
            else if (First_Pieces <= date && date <= end_Pieces)
            {
                return "雙魚座";
            }
            else if (First_Aries <= date && date <= end_Aries)
            {
                return "牡羊座";
            }
            else if (First_Taurus <= date && date <= end_Taurus)
            {
                return "金牛座";
            }
            else if (First_Gemini <= date && date <= end_Gemini)
            {
                return "雙子座";
            }
            else if (First_Cancer <= date && date <= end_Cancer)
            {
                return "巨蟹座";
            }
            else if (First_Leo <= date && date <= end_Leo)
            {
                return "獅子座";
            }
            else if (First_Virgo <= date && date <= end_Virgo)
            {
                return "處女座";
            }
            else if (First_Libra <= date && date <= end_Libra)
            {
                return "天秤座";
            }
            else if (First_Scorpio <= date && date <= end_Scorpio)
            {
                return "天蠍座";
            }
            else if (First_Sagittarius <= date && date <= end_Sagittarius)
            {
                return "射手座";
            }
            else if (First_Capricorn <= date && date <= end_Capricorn)
            {
                return "摩羯座";
            }
            else
            {
                return "";
            }


        }


        private void GetSoul()
        {int soso = 0;
            int soul = 0;
            
            DateTime birth = new DateTime();
            birth = dateTimePicker1.Value;
            string life = birth.Year.ToString() + birth.Month.ToString() + birth.Day.ToString();
            foreach (var d in life)
            {
                soul += int.Parse(d.ToString());
            }
            if (soul > 9)
            {foreach(var x in soul.ToString())
                {
                     soso += int.Parse(x.ToString());
                }
                lifesoul = soso.ToString();
              
            }
            soul = soso;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSoul();
            var dtDate = aaa();
            Dictionary<int, string> a = new Dictionary<int, string>();
            switch (dtDate)
            {
                case "水瓶座":
                   a = Class1.CreateAquarius();
                    break;

                case "雙魚座":
                    a = Class1.CreatePieces();
                    break;
                case "牡羊座":
                    a = Class1.CreateAries();
                    break;
                case "金牛座":
                    a = Class1.CreateTaurus();
                    break;
                case "雙子座":
                    a = Class1.CreateGemini();
                    break;
                case "巨蟹座":
                    a = Class1.CreateCancer();
                    break;
                case "獅子座":
                    a = Class1.CreateLeo();
                    break;
                case "處女座":
                    a = Class1.CreateVirgo();
                    break;
                case "天秤座":
                    a = Class1.CreateLibra();
                    break;
                case "天蠍座":
                    a = Class1.CreateScorpio();
                    break;
                case "射手座":
                    a = Class1.CreateSagittarius();
                    break;
                case "摩羯座":
                    a = Class1.CreateCapricorn();
                    break;

            }

            var v = a.Where((x) => x.Key == int.Parse(lifesoul));
            string vi = "";
            foreach(var item in v)
            {
                vi = item.Value;
            }
            label3.Text = dtDate + "\r\n" + "生命靈數 : " + lifesoul + "\r\n" + vi;


        }


       
    }
}
