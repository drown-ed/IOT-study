using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_property
{
    class Boiler
    {
        private int temp;
        public int Temp
        {
            get { return temp; } 
            set { 
                if (value <= 10 && value >= 70)
                {
                    temp = 10;
                } else
                {
                    temp = value;
                }
            }
        }
        
        public void SetTemp(int temp)
        {
            if (temp <= 10 || temp >= 70)
            {
                Console.WriteLine("수온 설정 값이 너무 낮거나 높습니다.");
                return;
            } else
            {
                this.temp = temp;
            }
            
        }

        public int GetTemp() { return this.temp; }
    }

    class Car
    {
        string name;
        string color;
        int year;
        string fuelType;
        int door;
        string tireType;
        string company;
        int price;
        string carIdNumber;
        string carPlateNumber;

        public string Name { get; set; } // 필터링이 필요 없으면 멤버변수 없이 프로퍼티로 대체
        public string Color { get => color; set => color = value; }
        public int Year
        {
            get => year;
            set
            {
                if (value <= 1990 || value >= 2023)
                {
                    value = 2023;
                }
                else
                {
                    year = value;
                }
            }
        }
        public string FuelType { get => fuelType; set => fuelType = value; }
        public int Door { get => door; set => door = value; }
        public string TireType { get => tireType; set => tireType = value; }
        public string Company { get => company; set => company = value; }
        public int Price { get => price; set => price = value; }
        public string CarIdNumber { get; set; }
        public string CarPlateNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            kitturami.SetTemp(60);

            Boiler navien = new Boiler();
            navien.Temp = 5000;
        }
    }
}
