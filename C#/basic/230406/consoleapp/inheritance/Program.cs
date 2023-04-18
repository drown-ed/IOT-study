using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Base
    {   // 상속받기 위해선 private 쓰면 안 됨
        protected string Name;
        private string Color;   // 상속하고 싶으면 protected로 변경
        public int Age;

        public Base(string Name, string Color, int Age)
        {
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;

            Console.WriteLine("{0}.Base()", Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", Name);
        }

        public string GetColor() { return Color; }
    }

    class Child : Base
    {
        public Child(string Name, string Color, int Age): base(Name, Color, Age)
        {
            Console.WriteLine("{0}.Base()", Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0}.ChildMethod()", Name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
