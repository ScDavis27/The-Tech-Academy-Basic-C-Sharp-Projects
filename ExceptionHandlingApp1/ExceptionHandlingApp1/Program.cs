using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(70);
            numbers.Add(270);
            numbers.Add(208);
            numbers.Add(888);
            numbers.Add(129);

            
            try
            {
                Console.WriteLine("Please choose a number to divide the integers by: ");
                int userInt = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int answer = number / userInt;
                    Console.WriteLine(number + " divided by " + userInt + " equals " + answer);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
                Console.WriteLine("Thank you. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
