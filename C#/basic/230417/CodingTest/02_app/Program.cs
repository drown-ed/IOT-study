using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_app
{
    internal class Program
    {
        class Boiler
        {
            string brand;
            byte voltage;
            int temperature;

            public string Brand
            {
                get => brand;
                set => brand = value;
            }
            public byte Voltage
            {
                get => voltage;
                set
                {
                    if ((value == 110) || (value == 220))
                    {
                        voltage = value;
                    }
                    else
                    {
                        Console.WriteLine("110v, 220v만 등록할 수 있습니다.");
                    };
                }
                    
            }

            public int Temperature
            {
                get => temperature;
                set
                {
                    if (value <= 5)
                    {
                        temperature = 5;
                    }
                    else if (value >= 70)
                    {
                        temperature = 70;
                    }
                    else temperature = value;
                }
            }

            public void PrintAll()
            {
                Console.WriteLine("브랜드 : {0} \n전압 : {1} \n온도 : {2}", this.Brand, this.Voltage, this.Temperature);
            }

        }
        static void Main(string[] args)
        {

            Boiler kitturami = new Boiler
            {
                Brand = "귀뚜라미",
                Voltage = 250,
                Temperature = 1
            };

            kitturami.PrintAll();
        }
    }
}
