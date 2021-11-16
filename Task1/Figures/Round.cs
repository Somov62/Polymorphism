using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Round : Circle
    {
        public Round(Point center, double radius, Color fill) : base(center, radius)
        {
            Fill = fill;
        }
        public Round(Circle circle, Color fill) : base(circle.Center, circle.Radius)
        {
            Fill = fill;
        }
        public Color Fill { get; set; }
        public override void Draw()
        {
            Console.WriteLine(string.Format(" Это окружность с центром в точке ({0},{1}), радиусом {2} и {3} цветом", base.Center.XCoord, base.Center.YCoord, Radius, Fill));
        }
    }
    internal enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
        Black,
        Tranparment
    }
}
