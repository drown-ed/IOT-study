using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_app
{
    internal class Program
    {
        class Car
        {
            string name;
            string maker;
            string color;
            int yearmodel;
            int maxspeed;
            string uniquenumber;

            public string Name
            {
                get => name; set => name = value;
            }

            public string Maker
            {
                get => maker; set => maker = value;
            }

            public string Color
            {
                get => color; set => color = value;
            }

            public int YearModel
            {
                get => yearmodel; set => yearmodel = value;
            }

            public int MaxSpeed
            {
                get => maxspeed; set => maxspeed = value;
            }

            public string UniqueNumber
            {
                get => uniquenumber; set => uniquenumber = value;
            }

            public void Start()
            {
                Console.WriteLine("{0}의 시동을 겁니다.", this.name);
            }

            public void Accelerate()
            {
                Console.WriteLine("최대 시속 {0}km/h로 가속합니다.", this.maxspeed);
            }

            

            public void TurnRight()
            {
                Console.WriteLine("{0}을 우회전합니다.", this.name);
            }

            public void Brake()
            {
                Console.WriteLine("{0}의 브레이크를 밟습니다.", this.name);
            }
        }

        class ElectricCar : Car
        {
            public virtual void Recharge()
            {
                Console.WriteLine("배터리를 충전합니다.");
            }
            
        }

        class HybridCar : ElectricCar
        {
            public override void Recharge()
            {
                Console.WriteLine("달리면서 배터리를 충전합니다.");
            }
        }

        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();
        }
    }
}
