using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Son : Father
    {
        public override void Job()
        {
            Console.WriteLine("Private Job");
        }

        static void Main(string[] args)
        {
            Father f1 = new Son();
            f1.Job();

            Son son = new Son();
            Console.WriteLine(son.bike);
            son.Job();
        }
    }
}
