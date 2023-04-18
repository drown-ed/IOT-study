using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ga = '가';
            string greeting = "Hello";
            String hello = "Hello";             // 모든 타입 대문자도 있음
            Console.WriteLine(ga + greeting);
            Console.WriteLine(hello);

            bool isTrue = false;
            Console.WriteLine(isTrue == true);
        }
    }
}
