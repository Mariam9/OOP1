using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moryakina_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle round = new Circle();
            round.r = 5;
            Console.WriteLine("The area is " + round.GetArea());
            round.name = "circle";
            Console.WriteLine("The name of the figure is " + round.GetName());
            Rectangle box = new Rectangle();
            box.width = 2;
            box.height = 7;
            Console.WriteLine("The area is " + box.GetArea());
            round.name = "rectangle";
            Console.WriteLine("The name of the figure is " + round.GetName());
            Square box2 = new Square();
            box2.side = 3;
            Console.WriteLine("The area is " + box2.GetArea());
            box2.name = "square";
            Console.WriteLine("The name of the figure is " + box2.GetName());
            Triangle threeTops = new Triangle();
            threeTops.baseOfTriangle = 4;
            threeTops.height = 8;
            Console.WriteLine("The area is " + threeTops.GetArea());
            threeTops.name = "triangle";
            Console.WriteLine("The name of the figure is " + threeTops.GetName());

        }

        abstract class Shape
        {
            public abstract double GetArea();

            public string name;
            public string GetName()
            {
                return name;
            }
        }

        class Circle : Shape
        {
            public double r = 0;
            public double p = 3.14;
            public override double GetArea()
            {
                return p * (r * r);
            }

        }

        class Rectangle : Shape
        {
            public double width;
            public double height;
            public override double GetArea()
            {
                return width * height;
            }
        }

        class Square : Rectangle
        {
            public double side;
            public override double GetArea()
            {
                return side * side;
            }
        }

        class Triangle : Shape
        {
            public double baseOfTriangle = 0;
            public double height = 0;

            public override double GetArea()
            {
                return (baseOfTriangle / 2) * height;
            }
        }

        //class IsoscelesTriangle : Triangle
        //{

        //}
    }
}
