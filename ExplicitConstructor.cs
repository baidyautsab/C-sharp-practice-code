using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class ExplicitConstructor
    {
        public ExplicitConstructor() {
            Console.WriteLine("Contructor created by user");
        }
        static void Main()
        {
            ExplicitConstructor ex = new ExplicitConstructor();
            Console.WriteLine(ex);
        }
    }
}
