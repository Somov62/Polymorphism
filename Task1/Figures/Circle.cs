using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Circle : Figure
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
        public double Radius { get; set; }
        public Point Center { get; set; }
        public override void Draw()
        {
            Console.WriteLine(string.Format(" Это окружность с центром в точке ({0},{1}) и радиусом - {2}", Center.XCoord, Center.YCoord, Radius));
        }
    }
}
