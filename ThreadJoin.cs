using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class ThreadJoin
    {
        static void m1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("m1 " + i);
                if (i == 50)
                {
                    Console.WriteLine("m1 going to sleep!");
                    Thread.Sleep(5000);
                    Console.WriteLine("m1 woke up.");
                }
            }
        }
        static void m2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("m2 " + i);
            }
        }
        static void m3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("m3 " + i);
            }
        }

        static void Main()
        {
            Console.WriteLine("Main Thread started");
            Thread t1 = new Thread(m1);
            Thread t2 = new Thread(m2);
            Thread t3 = new Thread(m3);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();  
            t3.Join();

            Console.WriteLine("Main Thread executed");
        }
    }
}
