using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal class Utility
    {
        public Utility(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }


        // object member method - non static 
        public double MeterToCm(double value)
        { return value * 100; }

        private static double pi = 3.14;   // static attrbuites , class member method 

        // class member method - static 
        public static double cacuCircle (double radius)
        {
            return pi * radius * radius;
        }





    }
}
