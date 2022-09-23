

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Company System!");
            Console.WriteLine("Please choose the operation: \n");
            while (true)
            {
                Console.WriteLine("1- Developer Operations");
                Console.WriteLine("2- Manager Operations");
                Console.WriteLine("3- Exit");
                string opr = Console.ReadLine();

                if(opr == "3") 
                {
                    Console.WriteLine("Exiting....");
                    break;
                }
                else if(opr == "1")
                {
                    while (true)
                    {
                        Developer dev = new Developer(23, "Esra", "Koc", "C, C#, Python");
                        Console.WriteLine("1- Developer Info");
                        Console.WriteLine("2- See the work");
                        Console.WriteLine("3- Exit");
                        string opr2 = Console.ReadLine();

                        if (opr2 == "3")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else if (opr2 == "1")
                        {
                            Console.WriteLine();
                            dev.showInfo();
                        }
                            

                        else if (opr2 == "2")
                        {
                            Console.Write("Please enter the operating system: ");
                            string oprSys = Console.ReadLine();
                            Console.WriteLine();
                            dev.operation(oprSys);
                        }
                        else
                            Console.WriteLine("Incorrect input!");
                    }
                }
                else if(opr == "2")
                {
                    while (true)
                    {
                        Manager man = new Manager(1, "Mark", "Zuckerberg", 250000);
                        Console.WriteLine("1- Manager Info");
                        Console.WriteLine("2- See the raise amount");
                        Console.WriteLine("3- Exit");
                        string opr3 = Console.ReadLine();

                        if(opr3 == "3")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else if(opr3 == "1")
                        {
                            man.showInfo();
                            Console.WriteLine();
                        }
                        else if(opr3 == "2")
                        {
                            Console.Write("Please enter the amount of the raise: ");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            man.makeRaise(amount);
                        }
                        else
                            Console.WriteLine("Incorrect input!");
                    }
                }
                else
                    Console.WriteLine("Incorect input!");
            }
            Console.ReadKey();
        }
    }
}
