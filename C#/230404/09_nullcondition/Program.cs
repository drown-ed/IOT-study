using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo myfoo = null;   // new Foo();
            // myfoo.member = 30;

            //int? bar;
            //if(myfoo != null)
            //{
            //    bar = myfoo.member;
            //}
            //else
            //{
            //    bar = null;
            //}

            int? var = myfoo?.member;  // myfoo가 null이 아니면 member 변수 값을 var에 집어넣어라
        }
    }
}


class Foo
{
    public int member;
}