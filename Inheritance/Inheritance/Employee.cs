using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        private int id;
        private string name;
        private string surname;

        public Employee(int _id, string _name, string _surname)
        {
            this.id = _id;
            this.name = _name;
            this.surname = _surname;
        }

        public int getID()
        {
            return this.id;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.name;
        }
        public void setID(string name)
        {
            this.name = name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void showInfo()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
        }
    }
}
