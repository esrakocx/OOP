using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Rectangular : Shape
    {
        public int longSide { get; set; }
        public int shortSide { get; set; }
        public Rectangular(string name, int longSide, int shortSide) : base(name)
        {
            this.longSide = longSide;
            this.shortSide = shortSide;
        }

        public override void CalculateShape()
        {
            base.CalculateShape();
            Console.WriteLine("The area of the "+getName()+": "+longSide*shortSide);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("The name of the shape: "+getName());
            Console.WriteLine("The long side of the "+getName()+ ": "+longSide);
            Console.WriteLine("The short side of the "+getName()+": " + shortSide);
            Console.WriteLine("The area of the " + getName() + ": " + longSide * shortSide);

        }
    }
}
