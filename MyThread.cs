using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class MyThread
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine("Current executing thread is : " + t.Name);
        }
    }
}
