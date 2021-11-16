using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Ring : Round
    {
        public Ring(Point center, double radius, Color fill, double thickness) : base(center, radius, fill)
        {
            Thickness = thickness;
            Hole = new(base.Center, base.Radius, Color.Tranparment);
        }
        public Ring(double thickness, Round figure) : base(figure.Center, figure.Radius, figure.Fill)
        {
            Thickness = thickness;
            Hole = new(base.Center, base.Radius, Color.Tranparment);
        }
        public double Thickness  { get; set; }
        public Round Hole { get; }
        public override void Draw()
        {
            Console.WriteLine(string.Format(" Я колечко толщиной {0} и цветом {1}", Thickness, base.Fill));
        }
    }
}
