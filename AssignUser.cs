using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class AssignUser
    {
        static void Main()
        {
            User user = new User(); 
            // user.Name = "Utsab";
            Console.WriteLine(user.Name);
        }
    }
}
