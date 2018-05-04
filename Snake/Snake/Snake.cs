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
        public int speed;

        public Snake(Point _tail, int _length, Direction _direction):this(_tail, _length, _direction, 300)
        {
        }

        public Snake(Point _tail, int _length, Direction _direction, int _speed)
        {
            speed = _speed;
            for (int i = 0; i < _length; i++)
            {
                direction = _direction;
                Point p = new Point(_tail);
                p.Move(i, direction);
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

        public bool HandleKey(ConsoleKey key)
        {
            bool Exit = false;
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
                case ConsoleKey.Escape:
                    Exit = true;
                    break;
            }
            return Exit;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                points.Add(food);
                speed = (int) (speed * 0.95);
                return true;
            }
            else
                return false;
        }
    }
}
