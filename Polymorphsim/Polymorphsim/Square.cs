using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    class Square : Shape
    {
        public int side { get; set; }
        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }

        public override void CalculateShape()
        {
            base.CalculateShape();
            Console.WriteLine("The area of the " + getName() + ": " + side * side);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("The name of the shape: " + getName());
            Console.WriteLine("The side of the " + getName() + ": " + side);
            Console.WriteLine("The area of the " + getName() + ": " + side * side);
        }
    }
}
