using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Student's ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student's name: ");
            string name = Console.ReadLine();
            Console.Write("Student's surname: ");
            string surname = Console.ReadLine();
            Console.Write("Student's Midterm 1: ");
            double midterm1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student's Midterm 2: ");
            double midterm2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student's Final exam: ");
            double final = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student's school name: ");
            string schoolName = Console.ReadLine();

            Student student1 = new Student(id, name, surname, midterm1, midterm2, final, schoolName);

            bool control = true;
           
            while(control)
            {
                showOperations();
                Console.Write("Please enter your choice: ");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == '1') 
                {
                    student1.printInfo(id, name, surname, midterm1, midterm2, final, schoolName);
                    Console.WriteLine("\n");
                    continue;
                }

                else if (choice == '2')
                {
                    double note = student1.calculateGANO(id, midterm1, midterm2, final);
                    Console.WriteLine("ID - {0} Note - {1}", id, note);
                    Console.WriteLine("\n");
                    continue;
                }

                else if (choice == '3')
                {
                    student1.showSchool(id);
                    Console.WriteLine("\n");
                    continue;
                }

                else if (choice == '4')
                {
                    control = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect input!");
                    continue;
                }
            }
            Console.ReadKey();
        }
        static void showOperations() 
        {
            Console.WriteLine("\n~MENU~\n");
            Console.WriteLine("1- Show student's info\n2- Show student's GANO\n3- Show student's school\n4- Exit\n");
        }
    }
}
