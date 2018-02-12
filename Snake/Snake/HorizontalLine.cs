using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> hLine = new List<Point>();

        public HorizontalLine(int xLeft, int xRight, int y, char sym )
        {
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                hLine.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in hLine)
            {
                p.Draw();
            }
        }
    }
}
