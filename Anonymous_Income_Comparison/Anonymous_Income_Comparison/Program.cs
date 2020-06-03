using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string p1HourlyRate = Console.ReadLine();
            int p1Hourly = Convert.ToInt32(p1HourlyRate);

            Console.WriteLine("How many hours per week?");
            string p1HoursPerWeek = Console.ReadLine();
            int p1Hours = Convert.ToInt32(p1HoursPerWeek);
            int p1TotalSalary = p1Hourly * p1Hours * 52;

            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate?");
            string p2HourlyRate = Console.ReadLine();
            int p2Hourly = Convert.ToInt32(p2HourlyRate);

            Console.WriteLine("How many hours per week?");
            string p2HoursPerWeek = Console.ReadLine();
            int p2Hours = Convert.ToInt32(p2HoursPerWeek);
            int p2TotalSalary = p2Hourly * p2Hours * 52;

            Console.WriteLine("Annual salary of Person 1: " + p1TotalSalary);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2: " + p2TotalSalary);
            Console.ReadLine();

            bool moreMoney = p1TotalSalary > p2TotalSalary;

            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(moreMoney);
            Console.ReadLine();



        }
    }
}
