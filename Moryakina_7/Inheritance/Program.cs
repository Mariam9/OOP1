using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var round = new AbstractClasses.Circle();
            var round1 = new Interfaces.Circle();
            round.name = "Circle";
            Console.WriteLine("The name of figure is " + round.GetName());
            round.r = 9;
            Console.WriteLine("The area is " + round.GetArea());
            round1.name = "Circle";
            Console.WriteLine("The name of figure is " + round1.GetName());
            round1.r = 6;
            Console.WriteLine("The area is " + round1.GetArea());

            var rectangle = new AbstractClasses.Rectangle();
            var rectangle1 = new Interfaces.Rectangle();
            rectangle.name = "Rectangle";
            Console.WriteLine("The name of figure is " + rectangle.GetName());
            rectangle.width = 2;
            rectangle.length = 3;
            Console.WriteLine("The area is " + rectangle.GetArea());
            rectangle1.name = "Rectangle";
            Console.WriteLine("The name of figure is " + rectangle1.GetName());
            rectangle1.width = 8;
            rectangle1.lenght = 3;
            Console.WriteLine("The area is " + rectangle1.GetArea());

            var box = new AbstractClasses.Square();
            var box1 = new Interfaces.Square();
            box.name = "Square";
            Console.WriteLine("The name of figure is " + box.GetName());
            box.side = 5;
            Console.WriteLine("The area is " + box.GetArea());
            box1.name = "Square";
            Console.WriteLine("The name of figure is " + box1.GetName());
            box1.side = 9;
            Console.WriteLine("The area is " + box1.GetArea());

            var triangle = new AbstractClasses.Triangle();
            var triangle1 = new Interfaces.Triangle();
            triangle.name = "Triangle";
            Console.WriteLine("The name of figure is " + triangle.GetName());
            triangle.baseOfTriangle = 7;
            triangle.height = 1;
            Console.WriteLine("The area is " + triangle.GetArea());
            triangle1.name = "Triangle";
            Console.WriteLine("The name of figure is " + triangle1.GetName());
            triangle1.baseOfTriangle = 6;
            triangle1.height = 3;
            Console.WriteLine("The area is " + triangle1.GetArea());

            var isosceles = new AbstractClasses.IsoscelesTriangle();
            var isosceles1 = new Interfaces.IsoscelesTriangle();
            isosceles.name = "Isosceles triangle";
            Console.WriteLine("The name of figure is " + isosceles.GetName());
            isosceles.m = 8;
            isosceles.n = 4;
            isosceles.h = 9;
            Console.WriteLine("The area is " + isosceles.GetArea());
            isosceles1.name = "Isosceles triangle";
            Console.WriteLine("The name of figure is " + isosceles1.GetName());
            isosceles1.m = 10;
            isosceles1.n = 7;
            isosceles1.h = 6;
            Console.WriteLine("The area is " + isosceles1.GetArea());


        }
    }
}
