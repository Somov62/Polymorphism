using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] array = new Figure[5];
            array[0] = new Line(new Point(0, 0), new Point(1, 1));
            array[1] = new Circle(new Point(0, 0), 10.5);
            array[2] = new Rectangle(new Point(0, 0), new Point(1, 1));
            array[3] = new Round((Circle)array[1], Color.Black);
            array[4] = new Ring(3, (Round)array[3]);

            foreach (var item in array)
            {
                item.Draw();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
