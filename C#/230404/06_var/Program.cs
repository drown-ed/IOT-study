using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.141592;
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = 3.141592f;
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

            var d = "Basic C#";
            Console.WriteLine("Type : {0}, Value : {1}", d.GetType(), d);
        }
    }
}
