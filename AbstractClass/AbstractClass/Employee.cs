using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " Do you want to quit now?");
        }
        
    }
}
