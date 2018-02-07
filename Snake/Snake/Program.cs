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
            Draw(1, 4, '*');
            Console.ReadKey();
            Draw(8, 2, '#');
            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            int currx, curry;
            currx = Console.CursorLeft;
            curry = Console.CursorTop;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.SetCursorPosition(currx, curry);
            return;
        }
    }
}
