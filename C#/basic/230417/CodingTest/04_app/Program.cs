using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rainbow = new Dictionary<string, string>();
            rainbow.Add("Red", "빨간색");
            rainbow.Add("Orange", "주황색");
            rainbow.Add("Yellow", "노란색");
            rainbow.Add("Green", "초록색");
            rainbow.Add("Blue", "파란색");
            rainbow.Add("Navy", "남색");
            rainbow.Add("Purple", "보라색");

            Console.Write("무지개 색은 ");
            foreach (KeyValuePair<string, string> item in rainbow)
            {
                Console.Write("{0}, ", item.Value);
            }
            Console.Write("입니다.\n\n");

            Console.WriteLine("Key와 Value 확인");
            Console.WriteLine("Purple은 " + rainbow["Purple"]+"입니다.");

        }
    }
}
