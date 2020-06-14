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
                DateTime current = DateTime.Now;
                Console.WriteLine("What is your current age?");
                string userAge = Console.ReadLine();
                int age = Convert.ToInt32(userAge);
                DateTime yearBorn = current.AddYears(-age);
                int year = yearBorn.Year;
                Console.WriteLine(year);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter just the year in digits only.");
                Console.ReadLine();
            }

            
            
        }
    }
}

