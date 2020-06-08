using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment161
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number to do 3 seperate math operations on:");
            string userInt = Console.ReadLine();
            int x = Convert.ToInt32(userInt);

            int result = Class1.Sum(x,7);
            Console.WriteLine("The sum of " + x + " and 7 is " + result);
            Console.ReadLine();

            int result1 = Class1.Product(x, 7);
            Console.WriteLine(x + " mutiplied by 7 equals " + result1);
            Console.ReadLine();

            int result2 = Class1.Divide(x, 7);
            Console.WriteLine(x + " divided by 7 equals " + result2);
            Console.ReadLine();

        }

        
    }
}
