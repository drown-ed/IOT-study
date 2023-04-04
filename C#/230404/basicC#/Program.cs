using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


// 네임 스페이스 ConsoleApp
namespace basicC_
{
    /// <summary>
    /// 프로그램 클래스
    /// </summary>    
    internal class Program
    {
        /// <summary>
        ///  메인 엔트리 포인트
        /// </summary>
        /// <param name="args">콘솔 매개변수</param>
        static void Main(string[] args)
        {
            byte bdata = byte.MaxValue;
            Console.WriteLine(bdata);

            bdata = byte.MinValue;
            Console.WriteLine(bdata);  

            long ldata = long.MaxValue;
            Console.WriteLine(ldata);
            ldata = long.MinValue;
            Console.WriteLine(ldata);

            ldata--;
            Console.WriteLine(ldata);

            int binVal = 0b11111111;
            Console.WriteLine(binVal);

            int hexVal = 0xFF;
            Console.WriteLine(hexVal);

            float fdata = float.MaxValue;
            Console.WriteLine(fdata);
            fdata = float.MinValue;
            Console.WriteLine(fdata);

            double ddata = double.MaxValue;
            Console.WriteLine(ddata);   
        }
    }
}
