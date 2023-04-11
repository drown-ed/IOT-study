using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_generic
{
    class MyArray<T> where T : class 
    {
        T[] array;
    }
    internal class Program
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        #region <위 코드 휘뚜루마뚜루>
        static void CopyArray(int[] source, int[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];                      // copy
            }
        }
        static void CopyArray(long[] source, long[] target)
        {
            for (var i = 0;i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void CopyArray(float[] source, float[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        #endregion


        static void Main(string[] args)
        {
            int[] source = { 2, 4, 6, 8, 10 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            long[] source2 = { 2100000, 2300000, 3300000, 5600000, 7800000 };
            long[] target2 = new long[source2.Length];

            CopyArray<long>(source2, target2);

            float[] source3 = { 3.14f, 3.15f, 3.16f, 3.17f, 3.18f };
            float[] target3 = new float[source3.Length];

            CopyArray<float>(source3, target3);
        }
    }
}
