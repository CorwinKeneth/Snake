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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 4;
            p1.sym = '*';

            Point p2 = new Point(8, 2, '#');

            p1.Draw();
            p2.Draw();

            Console.ReadKey();
        }

    }
}
