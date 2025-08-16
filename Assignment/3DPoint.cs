using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class _3DPoint : ICloneable ,IComparable < _3DPoint > 
    {
        public _3DPoint(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public _3DPoint () : this (0,0,0)
        { }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string ToString()
        {
            return $"A = {A}, B = {B} , C = {C}"; 
        }

        public int CompareTo(_3DPoint? point)
        {
            return this.A.CompareTo(point?.A);
            return this.B.CompareTo(point?.B);
        }

        public object Clone()
        {
            return new _3DPoint
            {
                A = this.A, B = this.B, C = this.C
            };
        }
    }
}
