using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);
            Console.WriteLine("(Optional)Please enter another number: ");
            string userInput2 = Console.ReadLine();
            
            if (userInput2 != "")
            {
                int y = Convert.ToInt32(userInput2);
                Console.WriteLine(Class1.MyMethod(x, y));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Class1.MyMethod(x));
                Console.ReadLine();
            }
            
        }
    }
}
