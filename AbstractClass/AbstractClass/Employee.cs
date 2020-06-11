using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " Do you want to quit now?");
        }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.Id == employee1.Id)
            {
                Console.WriteLine(employee + " and " + employee1 + " is the employee .");
                return true;
            }
            else
            {
                Console.WriteLine("These employees do not have the same Employee ID.");
                return false;
            }
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.Id != employee1.Id)
            {
                Console.WriteLine("These employees do not have the same Employee ID.");
                return false;
            }
            else
            {
                Console.WriteLine("These employees have the same Employee ID.");
                return true;
            }
        }

    }
}
