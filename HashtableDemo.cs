using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class HashtableDemo
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("eid", 101);
            hashtable.Add("ename", "Utsab Baidya");
            hashtable.Add("phone", "8343838660");
            hashtable.Add("email", "utsab2047@gmail.com");
            hashtable.Add("salary", 10000);

            foreach(object key in hashtable.Keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }
        }
    }
}
