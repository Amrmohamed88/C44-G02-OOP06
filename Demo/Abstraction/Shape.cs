using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    public abstract class Shape
    {
        public decimal Dem01 { get; set; }
        public decimal Dem02 { get; set; }


        public abstract decimal Calculate();   // Abstract method 


        public abstract decimal Parameter { get; }   // abstract prop 

    }
}
