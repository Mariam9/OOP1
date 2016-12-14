using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moryakina_7
{
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
}
