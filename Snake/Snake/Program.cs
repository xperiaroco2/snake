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
            //Размер экрана
            Console.SetBufferSize(80, 25);
           
            //Горизонт. линия
            Linesx linex1 = new Linesx(0, 78, 0, '+');
            linex1.DrawLine();
            Linesx linex2 = new Linesx(0, 78, 24, '+');
            linex2.DrawLine();
            
            //Вертикал. линия
            Linesy liney1 = new Linesy(0, 24, 0, '+');
            liney1.DrawLine();
            Linesy liney2 = new Linesy(0, 24, 78, '+');
            liney2.DrawLine();

            //Создание змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT );
            snake.DrawLine();
                  

            Console.ReadLine();
        }
    }
}