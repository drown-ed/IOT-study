using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_accessmodifier
{
    class WaterHeater
    {
        protected int temp;

        public void SetTemp(int temp)
        {
            if (temp <-5 || temp > 40)
            {
                Console.WriteLine("범위 이탈");
                return;
            }
            this.temp = temp;
        }

        public int GetTemp() { return this.temp;}

        internal void TurnOnHeater()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterHeater boiler = new WaterHeater();
            boiler.TurnOnHeater();
        }
    }
}
