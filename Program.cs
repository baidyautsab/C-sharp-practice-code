using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Program
    {
        int i;
        string s;
        bool b;


        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.i);
            Console.WriteLine(p.s);
            Console.WriteLine(p.b);
        }
    }
}
