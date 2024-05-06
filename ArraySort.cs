using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class ArraySort
    {
        static void Main()
        {
            int[] arr = {3, 4, 2, 44, 34, 1, 0, 20};
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Sort(arr);
            foreach (int ele in arr)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.Max());
        }
    }
}
