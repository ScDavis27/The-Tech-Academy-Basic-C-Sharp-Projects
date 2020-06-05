using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Scott.";
            //string age = " I am 32 years old";
            //string location = " and living in Upstate New York.";

            //name = name.ToUpper();

            //Console.WriteLine("Hello, my name is " + name + age + location);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("I was born and raised in Gainesville, Florida for 21 years.");
            sb.Append(" I was immediately born into the SEC football culture.");
            sb.Append(" \nSo naturally I have supported the Florida Gators my entire life.");
            sb.Append(" I now live in Monticello, New York and still watch \nevery Gators sporting event.");
            sb.Append("\n\tI have a beautiful 6 year old daughter that I am also now having to play kindergarten teach to for another \nmonth until school ends up here.");


            Console.WriteLine(sb);
            Console.ReadLine();



            
        }
    }
}
