using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle : Figure
    {
        public Rectangle(Point first, Point second)
        {
            FirstCoord = first;
            SecondCoord = second;
            ThirdCoord = new(FirstCoord.XCoord, SecondCoord.YCoord);
            FourthCoord = new(SecondCoord.XCoord, FirstCoord.YCoord);
        }
        public Point FirstCoord { get; set; }
        public Point SecondCoord { get; set; }
        public Point ThirdCoord { get; set; }
        public Point FourthCoord { get; set; }

        public override void Draw()
        {
            Console.WriteLine(string.Format(" Это прямоугольник с диагональю - {0}", GetDiagonalLenght()));
        }

        public double GetDiagonalLenght()
        {
            return Math.Round(Math.Sqrt(Math.Pow(SecondCoord.XCoord - FirstCoord.XCoord, 2) + Math.Pow(SecondCoord.YCoord - FirstCoord.YCoord, 2)), 2);
        }

    }
}
