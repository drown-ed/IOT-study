using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_collection
{
    class MyList
    {
        int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int Length       // property
        {
            get { return array.Length; }
        }

        // indexor
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length) // 3보다 커지면 ?
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("MyList Resize : {0}", array.Length);
                }
                array[index] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            char[] oldString = new char[5]; // 구닥다리
            string curString = "";

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);

            ArrayList list = new ArrayList();
            list.Add(8);
            list.Add(4);
            list.Add(15);
            list.Add(10);
            list.Add(7);
            list.Add(2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("10 삭제 후");
            list.Remove(10);
            Console.WriteLine("3번째 데이터 삭제");
            list.RemoveAt(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("0번째 위치 7 추가");
            list.Insert(0, 7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("정렬");
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // ArrayList
            // Add() : 추가
            // Insert(x, val) : x번째 val 추가
            // RemoveAt(x) : x번째 데이터 삭제
            // Sort() : 정렬
            // Reverse() : 반전

            MyList myList = new MyList();
            for (int i= -1; i <= 5; i++)
            {
                myList[i] = i * 5;
            }

        }
    }
}
