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
                int months = age * 12;
                DateTime current = DateTime.Now;
                DateTime yearBorn = current.AddMonths(-months);
                int year = yearBorn.Year;
                Console.WriteLine("You were born in the year " + year);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
                Console.ReadLine();
            }
        }
    }
}

