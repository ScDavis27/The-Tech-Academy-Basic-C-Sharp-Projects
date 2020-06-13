using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Guess a number:");
            string userNum = (Console.ReadLine());
            File.WriteAllText(@"C:\Users\Student\Logs\Logs.txt", userNum);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Student\Logs\Logs.txt"));
            Console.ReadLine();
        }
    }
}
