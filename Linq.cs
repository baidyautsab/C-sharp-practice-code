using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Linq
    {
        static void display2(int[] arr)
        {
            // using linq
            var brr = from i in arr where i > 40 select i;
            foreach (int i in brr)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void display1(int[] arr)
        {
            // longest logic to store the element >40 in another array
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                    count++;
            }
            int[] brr = new int[count];
            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    brr[index++] = arr[i];
                }
            }
            foreach(int i in brr)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 23, 45, 5, 67, 23, 42, 9, 57, 29, 79, 60, 0, 13, 81 };

            display1(arr);

            display2(arr);
        }
    }
}
