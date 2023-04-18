using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_interface
{
    interface ILogger       // 클래스랑 똑같아서 앞에 I를 넣어주는 게 기본
    {
        void WriteLog(string log);
    }

    interface IFormattableLogger : ILogger  // 상속이랑 비슷
    {
        void WriteLog(string  format, params object[] args); // args 다중 파라미터
    }

    class ConsoleLogger : ILogger        // 인터페이스는 implemant(구현)이라고 함
    {
        public void WriteLog(string log)
        {
            Console.WriteLine(log);
        }
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string log)
        {
            Console.WriteLine(log);
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Stop()
        {
            Console.WriteLine("정지!");
        }
    }

    interface IHoverable
    {
        void Hover();   // 물에서 달림
    }

    interface IFlyable
    {
        void Fly();
    }

    // C# 다중상속 불가
    class FlyHoverCar : Car, IFlyable, IHoverable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Hover()
        {
            throw new NotImplementedException();
        }
    }

    class WashCar : Car, IHoverable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Hover()
        {
            Console.WriteLine("Hover");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ILogger logger = new ILogger();  불가
            // ConsoleLogger logger = new ConsoleLogger();  가능
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("안녕");

            IFormattableLogger logger2 = new ConsoleLogger2();
            logger2.WriteLog("{0} x {1} = {2}", 6, 5, 6 * 5);
        }
    }
}
