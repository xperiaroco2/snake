using System;
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

        //Конструктор создания точек
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

        public void Move(int offcet, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x = x + offcet;
            else if (direction == Direction.LEFT)
                x = x - offcet;
            else if (direction == Direction.DOWN)
                y = y + offcet;
            else
                y = y - offcet;
        }

        //Метод внесение точки на экран
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool Hit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
