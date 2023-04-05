using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_methods
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region <static method>
            int result =Calculator.Plus(1, 2);
            // static은 최초 실행 시 메모리에 올라가기 때문에
            // 클래스 객체를 만들 필요 없음 -> new Calculator();
            // Minus는 static이 아니어서 접근 불가 (객체 생성 시 접근 가능)
            result = new Calculator().Minus(1, 2);
            Console.WriteLine(result);

            #endregion

            #region <call by ref, call by value>

            int x = 5; int y = 4;
            Swap(x, y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            #endregion

            #region <out 매개변수>

            int divid = 30;
            int divor = 2;

            int rem = 0; 
            Divide(divid, divor, out result, out rem);  // ref, out (권장) 차이 없음
            Console.WriteLine("result = {0}, rem = {1}", result, rem);

            #endregion
        }

        //static int Divide(int x, int y)
        //{
        //    return x / y;
        //}

        //static int Reminder(int x, int y)
        //{
        //    return x % y;
        //}

        static void Divide(int x, int y, out int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        public static void Swap(int x, int y)
        {
            int temp = 0;
            temp = x; x = y; y = temp;
        }

        static int val = 100;
        public static void Swap(ref int x, ref int y)
        {
            int temp = 0;
            temp = x; x = y; y = temp;
        }
    }
}
