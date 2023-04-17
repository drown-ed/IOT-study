using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_app
{
    internal class Program
    {
        interface IAnimal
        {
            int Age { get; set; }
            string Name { get; set; }

            void Eat();
            void Sleep();
            void Sound();
        }

        class Dog : IAnimal
        {
            private int age;
            private string name;
            public int Age { get => age; set => age = value; }
            public string Name { get => name; set => name = value; }
            public void Eat() { Console.WriteLine("강아지 먹는다.");  }
            public void Sleep() { Console.WriteLine("강아지 잔다.");  }
            public void Sound() { Console.WriteLine("멍멍."); }
        }

        class Cat : IAnimal
        {
            private int age;
            private string name;
            public int Age { get => age; set => age = value; }
            public string Name { get => name; set => name = value; }
            public void Eat() { Console.WriteLine("고양이 먹는다."); }
            public void Sleep() { Console.WriteLine("고양이 잔다."); }
            public void Sound() { Console.WriteLine("냐옹."); }
        }

        class Horse : IAnimal
        {
            private int age;
            private string name;
            public int Age { get => age; set => age = value; }
            public string Name { get => name; set => name = value; }
            public void Eat() { Console.WriteLine("말 먹는다."); }
            public void Sleep() { Console.WriteLine("말 잔다."); }
            public void Sound() { Console.WriteLine("히잉."); }
        }

        static void Main(string[] args)
        {
            Cat c = new Cat()
            {
                Name = "냐옹이",
                Age = 2
            };
            c.Eat();
            c.Sleep();
            c.Sound();

            Dog d = new Dog()
            {
                Name = "멍멍이",
                Age = 5
            };
            d.Eat();
            d.Sleep();
            d.Sound();

            Horse h = new Horse()
            {
                Name = "얼룩이",
                Age = 10
            };
            h.Eat();
            h.Sleep();
            h.Sound();
        }
    }
}
