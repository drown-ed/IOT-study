using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_abstractClass
{
    abstract class AbstractParent
    {
        protected void MethodA()
        {
            Console.WriteLine("AbstractPrent.methodA()");
        }
        public void MethodB()            // 클래스랑 동일
        {
            Console.WriteLine("AbstractPrent.methodB()");
        }

        public abstract void MethodC();     // 인터페이스랑 동일

    }


    class Child : AbstractParent
    {
        public override void MethodC()
        {
            Console.WriteLine("Child.Method() - 추상클래스 구현!");
            MethodA();
        }
    }

    abstract class Mammal
    {
        public void Nurse()
        {
            Console.Write("포유한다");
        }
        public abstract void Sound();
    }

    class Dogs : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("Bark!!");
        }
    }

    class Cats : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow!!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractParent parent = new Child();
            parent.MethodC();
            parent.MethodB();
            // parent.MethodA(); // protected는 자기자신과 자식클래스 내에서만 사용 가능
        }
    }
}
