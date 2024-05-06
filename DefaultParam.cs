using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class DefaultParam
    {
        static void MyCountry(string country = "India")
        {
            Console.WriteLine(country);
        }

        static string IsGreater(int a, int b)
        {
            return (a > b) ? a + " is greater" : b + " is greater";
        }
        static void Main()
        {
            MyCountry("Japan");
            MyCountry();
            Console.WriteLine(IsGreater(1, 3));
        }
    }
}
