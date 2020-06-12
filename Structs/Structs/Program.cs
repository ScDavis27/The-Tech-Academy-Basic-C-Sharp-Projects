using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number decNumber = new Number();
            decNumber.Amount = 17.7m;
            Console.WriteLine(decNumber.Amount);
            Console.ReadLine();
        }
    }
}
