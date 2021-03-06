﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point ()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.RIGHT:
                    x = x + offset;
                    break;
                case Direction.UP:
                    y = y - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
            }
        }

        public void Draw()
        {
            int currx, curry;
            currx = Console.CursorLeft;
            curry = Console.CursorTop;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
//            Console.SetCursorPosition(currx, curry);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool isHit(Point point)
        {
            if (x == point.x && y == point.y)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

    }
}
