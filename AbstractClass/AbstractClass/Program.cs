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
            Employee<string> employee = new Employee<string>();
            employee.Things.Add("desk");
            employee.Things.Add("table");
            employee.Things.Add("book");

            Employee<int> employee1 = new Employee<int>();
            employee1.Things.Add(4);
            employee1.Things.Add(416);
            employee1.Things.Add(7);

            employee.Print();
            employee1.Print();
            Console.ReadLine();


            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };
            //Employee employee1 = new Employee() { firstName = "Ronald", lastName = "Barron", Id = 3 };

            //IQuittable quittable = new Employee() { firstName = "Scott", lastName = "Davis", Id = 2 };

            //employee.SayName();
            //quittable.Quit();
            //Console.ReadLine();

            //string result = Convert.ToString(employee == employee1);

            //Console.WriteLine(result);
            //Console.ReadLine();






        }


    }
}
