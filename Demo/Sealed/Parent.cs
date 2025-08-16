using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    public class Parent
    {
        public int X { get; set; }
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void myfun()
        {
            Console.WriteLine("iam parent");
        }
    }

     class child : Parent
     {
        public sealed override void myfun()  // sealed method
        {
            Console.WriteLine("iam child");
        }
        public sealed override int Salary   // sealed property
        {
            get { return base.Salary; }
            set { base.Salary = value + 2000; }
        }
     }

    class grand : child
    {
        public new void myfun()
        {
            Console.WriteLine("iam grand");
        }

        public new int Salary 
        {
            get { return base.Salary; }
            set { base.Salary = value + 3000 ; }
        }

    }



}
