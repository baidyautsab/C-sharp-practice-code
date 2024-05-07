using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class SingleThreadVsMultiThread
    {
        static void IncreamentCount1()
        {
            long count = 0;
            for (long i = 0; i <= 1000000000; i++)
            {
                count += 1;
            }
            Console.WriteLine(count);
        }
        static void IncreamentCount2()
        {
            long count = 0;
            for (long i = 0; i <= 1000000000; i++)
            {
                count += 1;
            }
            Console.WriteLine(count);
        }
        static void Main()
        {
            Stopwatch sp1 = new Stopwatch();
            Stopwatch sp2 = new Stopwatch();    

            // single threaded
            sp1.Start();
            IncreamentCount1();
            IncreamentCount2();
            sp1.Stop();

            // multithreaded
            Thread t1 = new Thread(IncreamentCount1);
            Thread t2 = new Thread(IncreamentCount2);

            sp2.Start();
            t1.Start();
            t2.Start();
            sp2.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("Time taken to complete the task in single thread: " + sp1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete the task in multi thread: " + sp2.ElapsedMilliseconds);
        }
    }
}
