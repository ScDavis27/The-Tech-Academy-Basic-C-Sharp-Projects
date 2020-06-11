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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };
            Employee employee1 = new Employee() { firstName = "Ronald", lastName = "Barron", Id = 3 };

            IQuittable quittable = new Employee() { firstName = "Scott", lastName = "Davis", Id = 2 };




            employee1.SayName();
            employee.SayName();
            quittable.Quit();
            Console.ReadLine();  
        }

    }
}
