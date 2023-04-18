using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string curDirectory = ".";

            Console.WriteLine("현재 디렉토리 정보");

            var dirs = Directory.GetDirectories(curDirectory);
            foreach (var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);

                Console.WriteLine(dirInfo.Name);
                Console.WriteLine(" {0}]", dirInfo.Attributes);
            }

            Console.WriteLine("현재 디렉토리 파일정보");

            var files = Directory.GetFiles(curDirectory);  
            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.Write(fileInfo.Name);
                Console.WriteLine(" {0}]", fileInfo.Attributes);
            }

            string path = @"C:\\Temp-Csharp_Bank";
            string sfile = "Test.log";

            if (Directory.Exists(path))
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);
            } else
            {
                Console.WriteLine($"해당 경로가 없습니다. {path}를 만듭니다.");
                Directory.CreateDirectory(path);

                Console.WriteLine("경로가 존재하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);
            }
        }
    }
}
