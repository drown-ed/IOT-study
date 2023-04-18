using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_delegatechain
{

    delegate void ThereIsAFire(string location); // 화재 시 대신 해주는 대리자

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);

    class Calcc
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        // static이 붙으면 무조건 실행될 때 최초 메모리에 올라감
        // 프로그램 실행 중에는 언제든지 접근 가능
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {

        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? 여기 {0}에 불났어요!", location);
        }
        static void ShoutOut(string location)
        {
            Console.WriteLine("여기 {0}에 불났어요!", location);
        }
        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다.", location);
        }
        static void Main(string[] args)
        {
            var loc = "우리 집";

            Call119(loc);
            ShoutOut(loc);  
            Escape(loc);

            var otherloc = "경찰서";
            ThereIsAFire fire = new ThereIsAFire(Call119);
            fire += new ThereIsAFire(ShoutOut);
            fire += new ThereIsAFire(Escape);

            fire(otherloc);

            Calc plus = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(plus(6, 7));

            Calc minus = (a, b) => { return a - b; };

            Console.WriteLine(minus(6, 7));

            Calc simpleMinus = (a, b) => a - b;
        }
    }
}
