using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal p1 = new Personal();
            p1.ID = "12345678910";

            Console.WriteLine("Your ID: " + p1.ID); 
            
            Console.ReadKey();
        }

       
    }
}
