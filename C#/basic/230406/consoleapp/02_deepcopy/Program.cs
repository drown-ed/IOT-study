using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_deepcopy
{
    internal class Program
    {
        class SomeClass
        {
            public int SomeField1;
            public int SomeField2;

            public SomeClass DeepCopy()
            {
                SomeClass newCopy = new SomeClass();   
                newCopy.SomeField1 = this.SomeField1;
                newCopy.SomeField2 = this.SomeField2;

                return newCopy;
            }
        }

        // this 사용법
        class Employee
        {
            private string Name;

            public void SetName(string Name) 
            {
                this.Name = Name;   // 멤버변수(속성)과 메서드 매개변수 이름이 대소문자까지 완전 똑같을 때 this 사용
            }
        }

        class ThisClass
        {
            int a, b, c;

            public ThisClass()
            {
                this.a = 1; 
            }

            public ThisClass(int b) : this()
            {
                this.b = b;
            }

            public ThisClass(int b, int c) : this(b)
            {
                this.c = c;
            }
(bool)        }

        static void Main(string[] args)
        {
            Console.WriteLine("얕은 복사 시작");

            SomeClass source = new SomeClass();
            source.SomeField1 = 1;
            source.SomeField2 = 2;

            SomeClass target = source;
            target.SomeField2 = 3;

            Console.WriteLine("s.SomeField1 = {0}, s.SomeField2 = {1}", source.SomeField1, source.SomeField2);
        }
    }
}
