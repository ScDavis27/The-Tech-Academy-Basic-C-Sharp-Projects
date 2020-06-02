using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 5 > 12;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            Console.WriteLine("Please enter a number: ");
            string yourNumber = Console.ReadLine();
            int product = Convert.ToInt32(yourNumber);
            int total = product * 50;
            Console.WriteLine(product + " multiplied by 50 is: " + total );
            Console.ReadLine();


            Console.WriteLine("Please enter a number: ");
            string aNumber = Console.ReadLine();
            int answer = Convert.ToInt32(aNumber);
            int equals = answer + 25;
            Console.WriteLine(answer + " plus 25 is: " + equals);
            Console.ReadLine();


            Console.WriteLine("Please enter a number: ");
            string bNumber = Console.ReadLine();
            int theAnswer = Convert.ToInt32(bNumber);
            double itEquals = theAnswer / 12.5;
            Console.WriteLine(theAnswer + " divided by 12.5 is: " + itEquals);
            Console.ReadLine();


            Console.WriteLine("Please enter a number: ");
            string cNumber = Console.ReadLine();
            int anAnswer = Convert.ToInt32(cNumber);
            bool trueOrFalse = anAnswer > 50;
            Console.Write(anAnswer + " is greater than 50: " + trueOrFalse);
            Console.ReadLine();


            Console.WriteLine("Please enter a number: ");
            string hisNumber = Console.ReadLine();
            int remainder = Convert.ToInt32(hisNumber);
            int finalAnswer = remainder % 7;
            Console.WriteLine(remainder + " divided by 7 has a remainder of " + finalAnswer);
            Console.ReadLine();
        }
    }
}
