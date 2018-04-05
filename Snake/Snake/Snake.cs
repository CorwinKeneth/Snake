using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point _tail, int _length, Direction _direction)
        {
            for (int i = 0; i < _length; i++)
            {
                direction = _direction;
                Point p = new Point(_tail);
                p.Move (i, direction);
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal Point GetNextPoint()
        {
            Point head = new Point(points.Last());
            head.Move(1, direction);
            return (head);
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.RIGHT)
                        direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.LEFT)
                        direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != Direction.DOWN)
                        direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.UP)
                        direction = Direction.DOWN;
                    break;
            }
        }
    }
}
