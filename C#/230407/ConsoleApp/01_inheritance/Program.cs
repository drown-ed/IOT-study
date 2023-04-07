using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_inheritance
{
    class Parent
    {
        public string name;     // subclass doesn't inherit the private instance

        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine("{0} from parent creator", name);
        }

        public void ParentMethod()
        {
            Console.WriteLine("{0} from parent method", name);
        }
    }

    class Child : Parent
    {
        public Child(string name) : base(name)
        {
            this.name = name;
            Console.WriteLine("{0} from child creator", name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0} from child method", name);
        }
    }

    // class 간 형변환 DB처리
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("포유류 기르다");
        }
    }
    
    class Cats : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }
    class Dogs : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Elephants : Mammal
    {
        public void Poo()
        {
            Console.WriteLine("푸우우");
        }
    }

    class ZooKeeper
    {
        public void Wash(Mammal mammal)
        {
            if(mammal is Elephants)
            {
                var animal = mammal as Elephants;
                Console.WriteLine("코끼리를 씻깁니다.");
                animal.Poo();
            }
            else if (mammal is Dogs)
            {
                var animal = mammal as Dogs;
                Console.WriteLine("강아지를 씻깁니다.");
                animal.Bark();
            }
            else if (mammal is Cats)
            {
                var animal = mammal as Cats;
                Console.WriteLine("고양이를 씻깁니다.");
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region <basic inherit>
            Parent p = new Parent("p");
            p.ParentMethod();

            Console.WriteLine("자식 클래스");
            Child c = new Child("c");
            c.ParentMethod();
            c.ChildMethod();
            #endregion

            #region <클래스간 형식변환>

            // Mammal mammal = new Mammal();     << 기본
            Mammal mammal = new Dogs(); // 자식클래스가 부모클래스로 변환 가능
            // mammal.Bark(); 바로 안 됨
            if (mammal is Dogs)
            {
                // Dogs midDog = (Dogs)mammal;
                Dogs midDog = mammal as Dogs;
                midDog.Bark();
            }

            // Dogs dogs = new Mammal(); // 부모클래스가 자식클래스로 변환 불가
            Dogs dog2 = new Dogs();
            Cats cat2 = new Cats();
            Elephants el2 = new Elephants();

            ZooKeeper keeper = new ZooKeeper();
            keeper.Wash(dog2);
            keeper.Wash(cat2);
            keeper.Wash(el2);

            #endregion
        }
    }
}
