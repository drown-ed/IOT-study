using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_filereadwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            StreamReader reader = new StreamReader(@".\python.py");
            try
            {                
                line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                                
            } catch (Exception e)
            {
                Console.WriteLine($"예외! {e.Message}");
                throw;
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
