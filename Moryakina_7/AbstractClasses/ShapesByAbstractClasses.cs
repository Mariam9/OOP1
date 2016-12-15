using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public string name;
        public string GetName()
        {
            return name;
        }
    }

    public class Circle : Shape
    {
        public double r = 0;
        public double p = 3.14;
        public override double GetArea()
        {
            return p * (r * r);
        }

    }

    public class Rectangle : Shape
    {
        public double width;
        public double length;
        public override double GetArea()
        {
            return width * length;
        }
    }

    public class Square : Rectangle
    {
        public double side;
        public override double GetArea()
        {
            return side * side;
        }
    }

    public class Triangle : Shape
    {
        public double baseOfTriangle = 0;
        public double height = 0;

        public override double GetArea()
        {
            return (baseOfTriangle / 2) * height;
        }
    }

    public class IsoscelesTriangle : Triangle
    {
        public double m = 0;
        public double n = 0;
        public double h = 0;
        public override double GetArea()
        {

            h = (m * m - (n / 2 * n / 2)) / 2;
            return (h * n) / 2;
        }
    }
}

