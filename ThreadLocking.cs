using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class ThreadLocking
    {
        public void print()
        {
            lock (this)
            {
                Console.WriteLine("print method started");
                Console.Write("Utsab ");
                Thread.Sleep(5000);
                Console.WriteLine("Baidya");
                Console.WriteLine("print method ended");
            }
        }

        static void Main()
        {
            ThreadLocking tl = new ThreadLocking();

            Thread t1 = new Thread(tl.print);
            Thread t2 = new Thread(tl.print);
            Thread t3 = new Thread(tl.print); 

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
