using Demo.Abstraction;
using Demo.partial;
using Demo.Sealed;
using Demo.Static;
using System.Drawing;
using System.Reflection;

namespace Demo
{
    internal class Program
    {
        //static void processshape (Shape shape)
        //{
        //    if (shape is not null)
        //    {
        //        Console.WriteLine(shape.Calculate());
        //        Console.WriteLine(shape.Parameter);
        //    }
        //}
        static void Main(string[] args)
        {
            #region Abstrcation
            //MyRectangle rectangle = new MyRectangle() { Dem01 = 10, Dem02 = 20 };
            //processshape(rectangle);
            //Console.WriteLine(rectangle.Calculate());
            //Console.WriteLine(rectangle.Parameter);



            //Circle circle = new Circle(10);
            //processshape(circle);
            //Console.WriteLine(circle.Parameter);
            //Console.WriteLine(circle.Calculate());

            #endregion
            #region  
            //Utility utility = new Utility(1 , 2);
            //Console.WriteLine(utility.MeterToCm (1.2)); // 120 
            //utility.X = 10;
            //utility.Y = 20;

            //Console.WriteLine( utility.MeterToCm(1.2));
            // the result of calling method [metertocm] doesnt chane by change object state [x-y] 

            //Utility u = new Utility(10, 20);
            //Console.WriteLine(u.MeterToCm(1.2));

            //Console.WriteLine(utility.cacuCircle(10));   // 314 
            //utility.X = 10;
            //utility.Y = 20;

            //Console.WriteLine(utility.cacuCircle(10));  // 314 

            //Console.WriteLine(Utility.cacuCircle(10));
            //Console.WriteLine(Utility.cacuCircle(20));    // static 

            #endregion
            #region Sealed
            //Parent parent = new Parent();
            //parent.myfun();
            //parent.Salary = 10000;
            //Console.WriteLine(parent.Salary);

            //child child = new child();
            //child.myfun();
            //child.Salary = 20000;
            //Console.WriteLine(child.Salary);

            //grand gra = new grand();
            //gra.myfun();
            //gra.Salary = 30000;
            //Console.WriteLine(gra.Salary);

            //Parent parent1 = new grand();
            //parent1.myfun();
            //parent1.Salary = 4000;
            //Console.WriteLine(parent1.Salary);

            #endregion
            #region partial 
            //Employee e = new Employee();
            //e.ID = 10;
            //e.Name = "amr";
            //e.Salary = 100000;
            //e.myfun();

            #endregion
        }
    }
}
