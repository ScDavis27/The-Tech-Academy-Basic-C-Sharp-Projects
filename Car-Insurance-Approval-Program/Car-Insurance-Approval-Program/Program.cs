using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);

            Console.WriteLine("True or False: You have had a DUI");
            string duiAnswer = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiAnswer);
            

            Console.WriteLine("How many speeding tickets do you have?");
            string speed = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(speed);

            Console.WriteLine("Qualified?");


            bool isQualified = (age > 15 && dui == false && speedingTickets <= 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
