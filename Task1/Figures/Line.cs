using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Line : Figure
    {
        public Line(Point start, Point end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public override void Draw()
        {
            Console.WriteLine(string.Format(" Это линия. Начинается на координате ({0},{1}), заканчивается на ({2},{3})", StartPoint.XCoord, StartPoint.YCoord, EndPoint.XCoord, EndPoint.YCoord));
        }
    }
}
