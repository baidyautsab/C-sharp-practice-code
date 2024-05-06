using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class TwoDArray
    {
        static void Main()
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            // Get the dimensions of the array
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Iterate through the array and print each element
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); // Move to the next line after printing each row
            }

            // using foreach loop
            foreach(int ele in matrix)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
