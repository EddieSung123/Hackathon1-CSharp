using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 改變字串
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1; i<101; i++)
            {
                string input = i.ToString();
                input = input.Replace('3', 'A').Replace('5', 'B').Replace('9', 'C').Replace('0', 'D');

                Console.WriteLine(input);
            }
            Console.ReadLine();

        }
    }
}
