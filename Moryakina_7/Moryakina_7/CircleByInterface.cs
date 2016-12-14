using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moryakina_7
{
    interface IShape
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
}
