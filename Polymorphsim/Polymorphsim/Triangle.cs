using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Triangle : Shape
    {
        public int baseSide { get; set; }
        public int height { get; set; }

        public Triangle(string name, int baseSide, int height) : base(name)
        {
            this.baseSide = baseSide;
            this.height = height;
        }

        public override void CalculateShape()
        {
            base.CalculateShape();
            Console.WriteLine("The area of the " + getName() + ": " + (baseSide * height)/2);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("The name of the shape: " + getName());
            Console.WriteLine("The base side of the " + getName() + ": " + baseSide);
            Console.WriteLine("The height of the " + getName() + ": " + height);
            Console.WriteLine("The area of the " + getName() + ": " + (baseSide * height) / 2);
        }
    }
}
