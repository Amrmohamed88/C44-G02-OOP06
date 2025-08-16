using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Trainning_abstract
{
    public abstract class Shape
    {
        public abstract double Area ();
        public abstract double perimeter();

        public void message ()
        {
            Console.WriteLine("iam shape");
        }
        
    }

    public class Rectangle : Shape

    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }


        public override double Area()
        {
            return Width * Height;
        }

        public override double perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}

