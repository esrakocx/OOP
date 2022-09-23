using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Manager : Employee
    {
        private int people;
        public Manager(int id, string name, string surname, int people) : base(id,name,surname)
        {
            this.people = people;
        }

        public void makeRaise(int amount)
        {
            Console.WriteLine(getName()+" raises "+amount+" dollars.");
        }
    }
}
