using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal abstract class MyAbstarctClass
    {
        public abstract void myAbstarctMethod();
    }

    class MyImplClass : MyAbstarctClass { 
        public override void myAbstarctMethod()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(String[] args)
        {
            MyImplClass obj = new MyImplClass();
            obj.myAbstarctMethod();
        }
    }
}
