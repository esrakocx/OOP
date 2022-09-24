using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            January jan = new January();
            Console.WriteLine("January is the {0}st month.", jan.whichMonth());
            Console.WriteLine("January has the {0} days.", jan.howManyDays());
            Console.WriteLine("One day has {0} hours.\n", jan.DayHours());

            February feb = new February();
            Console.WriteLine("February is the {0}nd month.", feb.whichMonth());
            Console.WriteLine("Febraury has the {0} days.", feb.howManyDays());
            Console.WriteLine("One day has {0} hours.\n", feb.DayHours());

            March march = new March();
            Console.WriteLine("March is the {0}rd month.", march.whichMonth());
            Console.WriteLine("March has the {0} days.", march.howManyDays());
            Console.WriteLine("One day has {0} hours.", march.DayHours());

            Console.ReadKey();
        }
    }
}
