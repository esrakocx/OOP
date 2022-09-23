using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Shape
    {
        public string name { get; set; }

        public Shape(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public virtual void CalculateShape()
        {
            Console.WriteLine("The area of the shape is calculating...");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine(getName() + "'s informations...");
        }
    }
}
