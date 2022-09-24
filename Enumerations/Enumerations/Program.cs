using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Esra", "Koc", "Female", "eocesra@gmail.com");

            Status code = customer1.addCustomer(customer1);

            if (code == Status.successful)
                Console.WriteLine("Customer added successfuly! ");
            else if (code == Status.unsuccessful)
                Console.WriteLine("Customer could not be added!");
            else
                Console.WriteLine("Connection error!");

            Console.ReadKey();
        }
    }
}
