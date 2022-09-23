using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shape Program!\n");

            while (true)
            {
                Console.WriteLine("\nPlease choose an operation ");
                Console.WriteLine("1- Rectangular operations");
                Console.WriteLine("2- Triangle operations");
                Console.WriteLine("3- Square operations");
                Console.WriteLine("4- Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                if(choice == "4")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else if(choice == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("\n1- Calculate the area of the rectangular");
                        Console.WriteLine("2- Show the information of rectangular");
                        Console.WriteLine("3- Exit");
                        Console.Write("Your choice: ");
                        string choice2 = Console.ReadLine();

                        

                        if (choice2 == "3")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else if (choice2 == "1")
                        {
                            Console.Write("Please enter the long side of the rectangular: ");
                            int longSide = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter the short side of the rectangular: ");
                            int shortSide = Convert.ToInt32(Console.ReadLine());
                            Rectangular rec = new Rectangular("Rectangular", longSide, shortSide);

                            Console.WriteLine();
                            rec.CalculateShape();
                        }
                        else if (choice2 == "2")
                        {
                            Console.Write("Please enter the long side of the rectangular: ");
                            int longSide = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter the short side of the rectangular: ");
                            int shortSide = Convert.ToInt32(Console.ReadLine());
                            Rectangular rec = new Rectangular("Rectangular", longSide, shortSide); 

                            Console.WriteLine();
                            rec.ShowInfo();
                        }
                            
                        else
                            Console.WriteLine("Incorrect input!");
                    }
                }

                else if(choice == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("\n1- Calculate the area of the triangle");
                        Console.WriteLine("2- Show the information of triangle");
                        Console.WriteLine("3- Exit");
                        Console.Write("Your choice: ");
                        string choice3 = Console.ReadLine();

                        if (choice3 == "3")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else if (choice3 == "1")
                        {

                            Console.Write("Please enter the base of the triangle: ");
                            int baseSide = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter the height of the triangle: ");
                            int height = Convert.ToInt32(Console.ReadLine());

                            Triangle tri = new Triangle("Triangle", baseSide, height);

                            Console.WriteLine();
                            tri.CalculateShape();
                        }
                            
                        else if (choice3 == "2")
                        {

                            Console.Write("Please enter the base of the triangle: ");
                            int baseSide = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter the height of the triangle: ");
                            int height = Convert.ToInt32(Console.ReadLine());

                            Triangle tri = new Triangle("Triangle", baseSide, height);

                            Console.WriteLine();
                            tri.ShowInfo();
                        }
                        else
                            Console.WriteLine("Incorrect input!");
                    }
                }
                else if(choice == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("\n1- Calculate the area of the square");
                        Console.WriteLine("2- Show the information of square");
                        Console.WriteLine("3- Exit");
                        Console.Write("Your choice: ");
                        string choice4 = Console.ReadLine();

                        if (choice4 == "3")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else if (choice4 == "1")
                        {
                            Console.Write("Please enter the base of the square: ");
                            int side = Convert.ToInt32(Console.ReadLine());

                            Square sqr = new Square("Square", side); 

                            Console.WriteLine();
                            sqr.CalculateShape();
                        }
                            
                        else if (choice4 == "2")
                        {
                            Console.Write("Please enter the base of the square: ");
                            int side = Convert.ToInt32(Console.ReadLine());

                            Square sqr = new Square("Square", side); 

                            Console.WriteLine();
                            sqr.ShowInfo();
                        }
                        else
                            Console.WriteLine("Incorrect input!");
                    }
                }
                else
                    Console.WriteLine("Incorrect input!");

                Console.ReadKey();
            }
        }
    }
}
