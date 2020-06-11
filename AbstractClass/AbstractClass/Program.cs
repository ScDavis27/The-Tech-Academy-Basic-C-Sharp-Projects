using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            IQuittable quittable = new Employee() { firstName = "Scott", lastName = "Davis" };

            employee.SayName();
            quittable.Quit();
            Console.ReadLine();  
        }

    }
}
