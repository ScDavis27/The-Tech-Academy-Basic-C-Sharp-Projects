using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatementAndDoWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed = number == 27;

            do
            {
                switch (number)
                {
                    case 14:
                        Console.WriteLine("You guessed 14. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 26:
                        Console.WriteLine("You guessed 26. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 19:
                        Console.WriteLine("You guessed 19. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 88:
                        Console.WriteLine("You guessed 88. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 27:
                        Console.WriteLine("You guessed the number 27. Congratulations, that is correct!");
                        numberGuessed = true;
                        break;
                    default:
                        Console.WriteLine("That's incorrect, please try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!numberGuessed);

            Console.Read();


            //Console.WriteLine("Guess a color:");
            //string color = Console.ReadLine();
            //bool colorGuessed = color == "blue";


            //while (!colorGuessed)
            //{
            //    switch (color)
            //    {
            //        case "red":
            //            Console.WriteLine("You guessed red, that's incorrect. Please try again.");
            //            Console.WriteLine("Guess a color:");
            //            color = Console.ReadLine();
            //            break;
            //        case "orange":
            //            Console.WriteLine("You guessed orange, that's incorrect. Please try again.");
            //            Console.WriteLine("Guess a color:");
            //            color = Console.ReadLine();
            //            break;
            //        case "yellow":
            //            Console.WriteLine("You guessed yellow, that's incorrect. Please try again.");
            //            Console.WriteLine("Guess a color:");
            //            color = Console.ReadLine();
            //            break;
            //        case "green":
            //            Console.WriteLine("You guessed green, that's incorrect. Please try again.");
            //            Console.WriteLine("Guess a color:");
            //            color = Console.ReadLine();
            //            break;
            //        case "blue":
            //            Console.WriteLine("You guessed the blue. Congratulations, That's correct!");
            //            colorGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("I'm sorry that's incorrect, please try again.");
            //            Console.WriteLine("Guess a color:");
            //            color = Console.ReadLine();
            //            break;
            //    }

            //}
            //Console.Read();
        }
    }
}
