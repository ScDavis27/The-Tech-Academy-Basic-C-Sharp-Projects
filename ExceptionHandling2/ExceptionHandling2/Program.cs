using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("What is your current age?");
                string userAge = Console.ReadLine();
                int age = Convert.ToInt32(userAge);
                if (age > 0)
                {
                    DateTime current = DateTime.Now;
                    DateTime yearBorn = current.AddYears(-age);
                    int year = yearBorn.Year;
                    Console.WriteLine(year);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter just the year in digits only.");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
                Console.ReadLine();
            }



        }
    }
}

