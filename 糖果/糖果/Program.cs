using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 糖果
{
    class Program
    {
        static void Main(string[] args)
        {

            int candy =0;
            int candyp=0;
            Console.Write("你想要吃的糖果數 : ");
            string input = Console.ReadLine();
            var number = int.Parse(input);


            while (number >= 0)
            {
                candyp++;
                if(candyp == 3)
                {
                    candyp = 0;                    
                }
                else
                {
                    candy++;
                }
                number--;
            }

            Console.WriteLine("需要買 : " + candy + "個糖果");
            Console.ReadLine();

        }
    }
}
