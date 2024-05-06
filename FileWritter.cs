using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class FileWritter
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write the text: ");
                string text = Console.ReadLine();
                File.WriteAllText("myText.txt", text);

                string readText = File.ReadAllText("myText.txt");
                Console.WriteLine("Text saved in myText.txt:");
                Console.WriteLine(readText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
