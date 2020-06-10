using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment169
{
    static class StaticClass 
    {
        static string f_Name = "Scott";
        static string l_Name = "Davis";

        public static void details()
        {
            Console.WriteLine("First name: " + f_Name);
            Console.WriteLine("Last name: " + l_Name);
            Console.ReadLine();
        }


    }
}
