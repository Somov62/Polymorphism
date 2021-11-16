using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Point
    {
        public Point(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
        }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
    }
}
