using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_event
{
    // 이벤트를 사용하려면 
    // 1. delegate 생성
    delegate void EventHandler(string message);

   
    class Sample
    {
        private int valueA; // member val
        public int valueB   // property
        {
            //get { return valueB; }
            //set { valueB = value; }

            get => valueA;
            set => valueB = value;
        }
    }
    class CustomNotifier
    {
        // 2. 이벤트 준비 (대리자로부터 시작)
        public event EventHandler SomethingChanged;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                // 3. 특별한 이벤트가 발생할 상황에서 이벤트 수행
                SomethingChanged(string.Format("{0} : even", number));
            }
        }

    }

    internal class Program
    {
        // 4. 이벤트 대신 호출할 메서드
        static void CustomHandler(string message)
        {
            Console.WriteLine(message);
        }

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
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingChanged += new EventHandler(CustomHandler);

            for (int i = 0; i <= 30; i++)
            {
                notifier.DoSomething(i);
            }

            
        }
    }
}
