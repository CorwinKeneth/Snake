using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine topBorder = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomBorder = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftBorder = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightBorder = new VerticalLine(0, 24, 78, '+');
            topBorder.Draw();
            bottomBorder.Draw();
            leftBorder.Draw();
            rightBorder.Draw();

            Point p = new Point(8, 9, '*');
            Snake snake = new Snake(p, 4, Direction.DOWN);
            snake.Draw();

            Console.ReadKey();
        }

    }
}
