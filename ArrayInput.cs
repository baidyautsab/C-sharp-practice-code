using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class ArrayInput
    {
        static void Main()
        {
            Console.WriteLine("Enter the array size ");
            string size = Console.ReadLine();
            string[] names = new string[int.Parse(size)];
            // Console.WriteLine(names.Length);
            Console.WriteLine("Enter the name: ");
            
            for(int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            
            Console.WriteLine("--------------------");
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("-----------Foreach--------------");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
