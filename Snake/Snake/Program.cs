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

            List<char> Charlist = new List<char>();

            Charlist.Add('a');
            Charlist.Add('d');
            Charlist.Add('b');
            Charlist.Add('g');

            Charlist.Sort();

            Charlist.RemoveAt(2);

            List<Point> PointList = new List<Point>();

            PointList.Add(p1);
            PointList.Add(p2);

//            PointList.Sort();  


            Console.ReadKey();
        }

    }
}
