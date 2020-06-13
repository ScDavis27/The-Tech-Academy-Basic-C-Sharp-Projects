using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var newPlayer = Console.ReadLine();
            const string myName = "Scott";
            Console.WriteLine("Hello, {0}, my name is {1}, welcome to my program!", newPlayer, myName);
            Console.ReadLine();

            Employee employee = new Employee("Johnny Jones", 7);
            
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Id);
            Console.ReadLine();

            
        }
    }
}
