using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Developer : Employee
    {
        private string languages;
        public Developer(int id, string name, string surname, string languages) : base(id, name, surname)
        {
            this.languages = languages;
        }

        public void operation(string operating_system)
        {
            Console.WriteLine(getName()+" works on "+operating_system+" rigth now!");
        }
    }
}
