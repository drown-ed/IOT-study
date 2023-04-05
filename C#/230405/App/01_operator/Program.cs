using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트 연산
            int firstval = 0x1111; // 15
            int secondval = firstval << 1;
            Console.WriteLine(secondval);
        }
    }
}
