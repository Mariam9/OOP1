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
            round.r = 9;
            Console.WriteLine("The area is " + round.GetArea());
            round.name = "circle";
            Console.WriteLine("The name of the figure is " + round.GetName());
            Rectangle box = new Rectangle();
            box.width = 4;
            box.lenght = 9;
            Console.WriteLine("The area is " + box.GetArea());
            box.name = "rectangle";
            Console.WriteLine("The name of the figure is " + box.GetName());
            Square box2 = new Square();
            box2.side = 8;
            Console.WriteLine("The area is " + box2.GetArea());
            box2.name = "square";
            Console.WriteLine("The name of the figure " + box2.GetName());
            Triangle three = new Triangle();
            three.baseOfTriangle = 4;
            three.height = 9;
            Console.WriteLine("The area is " + three.GetArea());
            box2.name = "triangle";
            Console.WriteLine("The name of the figure " + three.GetName());

        }

        
    }
}
