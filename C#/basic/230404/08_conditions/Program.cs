using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            string result = "";
            if (a == 30)
            {
                result = "30";
            } else
            {
                result = "not 30";
            }
            Console.WriteLine(result);

            // 삼항 연산자
            int b = 40;
            string result2 = b == 40 ? "40" : "not 40";
            Console.WriteLine(result2);
        }
    }
}
