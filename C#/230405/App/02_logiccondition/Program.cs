using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_logiccondition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region <if>
            int a = 20;

            if(a == 20)         // 처리 로직이 있으면 무조건 {}
            {
                Console.WriteLine("20");
            }

            if (a == 30) return; // 메서드 완전히 빠져나가는 구문은 한 줄로 ok

            object obj = null;

            string inputs = Console.ReadLine();
            if (int.TryParse(inputs, out int iouput))
            {
                obj = iouput;
            }
            else if (float.TryParse(inputs, out float foutput))
            {
                obj = foutput;
            }
            else
            {
                obj = inputs; 
            }
            Console.WriteLine(obj);
            #endregion

            #region <swtich-case>
            switch (obj)
            {
                case int i:
                    Console.WriteLine("{0} int 형식", i);
                    break;
                case float f:
                    Console.WriteLine("{0} float 형식", f);
                    break;
                case double d:
                    Console.WriteLine("{0} double 형식", d);
                    break;
                default:
                    Console.WriteLine("모름");
                    break;
            }
            #endregion

            #region <2중 for문>

            for (int x = 2; x <= 0; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    Console.WriteLine("{0} x {1} = {2}, x, y, x*y");
                }
            }

            #endregion

            #region <Foreach 문>

            int[] ary = { 2, 4, 6, 8, 10 };

            foreach (int i in ary)
            {
                Console.WriteLine("{0}*2 = {1}", i, i*2);
            }

            #endregion
        }
    }
}
