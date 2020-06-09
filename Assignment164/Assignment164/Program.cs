using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment164
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to multiply by 7:");
            string myInt = Console.ReadLine();
            int y = Convert.ToInt32(myInt);
            Console.WriteLine(Class1.Multiply(7, y));
            Console.ReadLine();


            Console.WriteLine("Please enter a decimal number: ");
            string userInput = Console.ReadLine();
            decimal userDec = Convert.ToDecimal(userInput);
            Console.WriteLine(Class1.Multiply(userDec, 7));
            Console.ReadKey();

            Console.WriteLine("Please enter a number to multiply by 17: ");
            string userString = Console.ReadLine();
            double userDouble = Convert.ToDouble(userString);
            Console.WriteLine(Class1.Multiply(userDouble, 17));
            Console.ReadLine();
        }
    }
}
