using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_lambdaproperty
{
    delegate string Concatenate(string[] args);
    internal class Program
    {
        static string ProcConcate(string[] args)
        {
            string result = string.Empty;
            foreach (string s in args)
            {
                result += s + "/";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);

            Console.WriteLine(result);

            Console.WriteLine();

            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty;
                foreach (string s in arr)
                {
                    res += s + "/";
                }
                return res;
            };

            Console.WriteLine(concat2(args));
        }
    }
}
