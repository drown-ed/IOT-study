using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            // int a = null;                    // int a에 null 값을 담을 수 없는데...
            int? b = null;                      // ?를 넣으니 됨 (nullable = 어떤 값도 가지지 않는 변수가 필요할 때)
            Console.WriteLine(a == null);       // output >> false
            Console.WriteLine(b == null);
            // Console.WriteLine(b.GetType());     // output >> 예외발생

            // 값형식 byte, short, int, long, float, double, char 등은 null 할당 x
            float? c = null;
            Console.WriteLine(c.HasValue);      // output >> false
            Console.WriteLine(c);               // output >> ' '

            c = 3.14f;
            Console.WriteLine(c.HasValue);      // output >> true
            Console.WriteLine(c.Value);         // output >> 3.14
            Console.WriteLine(c);               // output >> 3.14
        }
    }
}
