using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object 형식
            // int == System.Int32
            // long == System.Int64
            int idata = 1024;               // Int32
            long idata1 = 1024;             // Int64
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());
            Console.WriteLine(idata1);
            Console.WriteLine(idata1.GetType());

            object iobj = (object)idata1;            // 박싱 : 데이터타입을 object로 바꾸는 것
            Console.WriteLine(iobj);
            Console.WriteLine(iobj.GetType());  

            long udata = (long)iobj;                // // 언박싱 : object를 원래 데이터타입으로 바꾸는 것
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double ddata = 3.141592;
            object pobj = (object)ddata;
            double pdata = (double)pobj;             

            Console.WriteLine(pobj);
            Console.WriteLine(pobj.GetType());
            Console.WriteLine(pdata);
            Console.WriteLine(pdata.GetType());

            short sdata = 32000;
            int indata = sdata;
            Console.WriteLine(idata);

            long lndata = long.MaxValue;
            Console.WriteLine(lndata);
            indata = (int)lndata;
            Console.WriteLine(indata);

            float fval = 3.141592f;
            Console.WriteLine(fval);

            double dval = 3.14159202575684;
            Console.WriteLine("dval = " + dval);
            Console.WriteLine(fval == dval);
            Console.WriteLine(dval == 3.141592);

            // very important!!
            int numival = 1024;
            string strival = numival.ToString();
            Console.WriteLine(strival);
            Console.WriteLine(numival);
            Console.WriteLine(strival.GetType());

            double numdval = 3.14159265358979;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            // string to num
            string originstr = "34567890";
            int convval = Convert.ToInt32(originstr);
            Console.WriteLine(convval);

            originstr = "1.2345";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);

            // 예외 발생하지 않도록 형변환
            originstr = "123.0f";
            float ffval;
            float.TryParse(originstr, out ffval);   // 예외 발생하지 않게 숫자 변환 (형 변환할 수 없으면 0으로)
            Console.WriteLine(ffval);

            const double pi = 3.14159265358979;
            Console.WriteLine(pi);
            // Console.WriteLine(pi.ToString()); 상수는 못 바꿈
        }
    }
}
