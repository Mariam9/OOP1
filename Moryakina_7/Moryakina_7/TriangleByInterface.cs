using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moryakina_7
{
    class Triangle : IShape
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

    //class IsoscelesTriangle : Triangle
    //{

    //}
}
