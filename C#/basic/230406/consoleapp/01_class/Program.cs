using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_class
{
    class Cat
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        #region <생성자>
        public Cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }
        #endregion

        /// <summary>
        /// 사용자 지정 생성자
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public Cat(string name, string color, sbyte age)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        // 접근지시자 안 쓰면 기본적으로 private
        #region <memberval - property>
        public string Name;
        public string Color;
        public sbyte Age;
        #endregion

        #region <membermethods - function>
        public void Meow()
        {
            Console.WriteLine("{0} - 야옹!", Name);
        }

        public void Run()
        {
            Console.WriteLine("{0} 달린다.", Name);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat hellokitty = new Cat();
            hellokitty.Name = "hello kitty";
            hellokitty.Color = "흰색";
            hellokitty.Age = 50;
            hellokitty.Meow();
            hellokitty.Run();

            Cat nero = new Cat()
            {
                Name = "검은 고양이 네로",
                Color = "red",
                Age = 20
            };

            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세입니다",
                hellokitty.Name, hellokitty.Color, hellokitty.Age);

            Cat yaongi = new Cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세입니다",
                yaongi.Name, yaongi.Color, yaongi.Age);
        }
    }
}
