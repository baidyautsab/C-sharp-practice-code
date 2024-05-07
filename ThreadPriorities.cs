using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class ThreadPriorities
    {
        static long count1, count2;

        void IncreamentCount1()
        {
            while (true)
            {
                count1 += 1;
            }
        }

        void IncreamentCount2()
        {
            while (true)
            {
                count2 += 1;
            }
        }

        static void Main()
        {
            ThreadPriorities tp = new ThreadPriorities();
            Thread t1 = new Thread(tp.IncreamentCount1);
            Thread t2 = new Thread(tp.IncreamentCount2);

            t2.Priority = ThreadPriority.Lowest;
            t1.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine("Main Thread is going to sleep");
            Thread.Sleep(10000);
            Console.WriteLine("Main Thread wokes up");

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("Count1: " + count1);
            Console.WriteLine("Count2: " + count2);
        }
    }
}
