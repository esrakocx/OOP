using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Program
{
    public class Student
    {
        private int studentID;
        private string name;
        private string surname;
        private double midterm1;
        private double midterm2;
        private double final;
        private string schoolName;

        public Student(int _studentID, string _name, string _surname, double _midterm1, double _midterm2, double _final, string _schoolName)
        {
            studentID = _studentID;
            name = _name;
            surname = _surname;
            midterm1 = _midterm1;
            midterm2 = _midterm2;
            final = _final;
            schoolName = _schoolName;
        }

        public void printInfo(int studentID, string name, string surname, double midterm1, double midterm2, double final, string schoolName)
        {
            Console.WriteLine("Student's ID: {0}", studentID);
            Console.WriteLine("Student's name: {0}", name);
            Console.WriteLine("Student's surname: {0}", surname);
            Console.WriteLine("Student's midterm 1: {0}", midterm1);
            Console.WriteLine("Student's midterm 2: {0}", midterm2);
            Console.WriteLine("Student's final: {0}", final);
        }

        public double calculateGANO(int studentID, double midterm1, double midterm2, double final)
        {
            double gano = midterm1 * 0.2 + midterm2 * 0.2 + final * 0.6;
            return gano;
        }

        public void showSchool(int studentID)
        {
            
            Console.WriteLine("ID {0} - School Name: {1}", studentID, schoolName);
        }
    }
}
