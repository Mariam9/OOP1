using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShape
    {
        double GetArea();
        string GetName();
    }

    public class Circle : IShape
    {
        public double r = 0;
        public double p = 3.14;
        public double GetArea()
        {
            return p * (r * r);
        }

        public string name;
        public string GetName()
        {
            return name;
        }
    }

    public class Rectangle : IShape
    {
        public double width = 0;
        public double lenght = 0;
        public virtual double GetArea()
        {
            return width * lenght;
        }

        public string name;
        public string GetName()
        {
            return name;
        }
    }

    public class Square : Rectangle
    {
        public double side = 0;
        public override double GetArea()
        {
            return side * side;
        }
    }

    public class Triangle : IShape
    {
        public double baseOfTriangle = 0;
        public double height = 0;

        public virtual double GetArea()
        {
            return (baseOfTriangle / 2) * height;
        }

        public string name;
        public string GetName()
        {
            return name;
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
