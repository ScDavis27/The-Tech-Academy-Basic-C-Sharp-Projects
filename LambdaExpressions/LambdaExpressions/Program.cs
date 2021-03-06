﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Dirt", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Andrew", LastName = "Neidig", Id = 2 };
            Employee employee3 = new Employee() { FirstName = "Aaron", LastName = "Nosko", Id = 3 };
            Employee employee4 = new Employee() { FirstName = "Evelynn", LastName = "Davis", Id = 4 };
            Employee employee5 = new Employee() { FirstName = "Chloe", LastName = "Collins", Id = 5 };
            Employee employee6 = new Employee() { FirstName = "Yolanda", LastName = "Leonard", Id = 6 };
            Employee employee7 = new Employee() { FirstName = "Bernard", LastName = "Washington", Id = 7 };
            Employee employee8 = new Employee() { FirstName = "Jessica", LastName = "Robbins", Id = 8 };
            Employee employee9 = new Employee() { FirstName = "Chris", LastName = "Born", Id = 9 };
            Employee employee10 = new Employee() { FirstName = "Joe", LastName = "Roberts", Id = 10 };


            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
            employeeList.Add(employee6);
            employeeList.Add(employee7);
            employeeList.Add(employee8);
            employeeList.Add(employee9);
            employeeList.Add(employee10);


            List<Employee> nameIsJoe = new List<Employee>(); // New list that all the joes go into

            // loop that adds any employee who's first name is Joe
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    nameIsJoe.Add(employee);
                    //Console.WriteLine(nameIsJoe);
                }
            }
            
            // Lambda function to find Joe in a list
            List<Employee> theJoesFName = employeeList.Where(x => x.FirstName == "Joe").ToList();

            // Lambda function to find all employee ID's over 5
            List<Employee> employeeId = employeeList.Where(y => y.Id > 5).ToList();

            foreach (Employee joe in theJoesFName)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " Id: " + joe.Id);
            }
            Console.ReadLine();
        }
    }
}
