using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    public class MyRectangle : Shape    // concreate class : Fully implemented class 
    {

        public override decimal Parameter
        {

            get { return Dem01 * Dem02 * 2; }
        }

        public override decimal Calculate()
        {
            return Dem01 * Dem02;
        }
    }


    public class Square : Shape
    {
        public Square(decimal side)
        {
             Dem01 = Dem02 = side;
        }

        public override decimal Parameter 
        { get { return Dem01 * 4; } 
        }

        public override decimal Calculate()
        {
            return Dem01* Dem02;    
        }
    }

    public class Circle : Shape
    {
        public Circle(decimal radius)
        {
            Dem01 = Dem02 = radius;
        }
        public override decimal Parameter 
        { get { return 2 * Dem01 * 3.14M; }             /// or  return 2 *(decimal) Math.PI * Dem01; 

        }

        public override decimal Calculate()
        {
            return 3.14M * Dem01 * Dem02;   
        }
    }
}
