using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_delegate
{
    // 대리자 사용 선언
    delegate int CalcDelegate(int a, int b);

    // a, b 중 뭐가 크고 작은지 비교하는 대리자
    delegate int Compare(int a, int b); 

    #region <대리자 학습 기본>
    class Calc
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
    #endregion 


    internal class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        // 오름차순, 내림차순 정렬 하나의 메서드에서 다 실행
        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++) 
            { 
                for (j=0; j <DataSet.Length - (i+1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j+1]) > 0) // (DataSet[j] > DataSet[j + 1])
                    {
                        temp = DataSet[j + 1];
                        DataSet[j+1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            #region <대리자 기본 예>
            // 일반적인 클래스 사용 방식
            Calc normalCalc = new Calc();
            int x = 10, y = 15;
            int res1 = normalCalc.Plus(x, y);
            Console.WriteLine(res1);
            Console.WriteLine(normalCalc.Plus(x, y));

            // 대리자를 사용하는 방식 - 대리자 대신 실행
            Calc delCalc = new Calc();
            CalcDelegate Callback;
            Callback = new CalcDelegate(delCalc.Plus);
            int res2 = Callback(x, y); // Calc.Plus() 대신 호출
            Console.WriteLine(res2);

            Callback = new CalcDelegate(delCalc.Minus);
            res2 = Callback(x, y);
            Console.WriteLine(res2);
            #endregion

            int[] origin = { 4, 7, 8, 2, 9, 1 };

            Console.WriteLine("오름차순 버블 정렬");
            BubbleSort(origin, new Compare(AscendCompare));

            foreach(var item in origin)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("내림차순 버블 정렬");
            BubbleSort(origin, new Compare(DescendCompare));

            foreach (var item in origin)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
