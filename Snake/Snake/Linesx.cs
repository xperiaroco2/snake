using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Linesx : Figure
    {

        //Конструктор Горизонт. линий
        public Linesx(int xLeft, int xRight, int y, char sym)
        {   
            //Создаем лист точек
            pList = new List<Point>();

            //Добавляем точки в массив
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }              
        }
        
       
    }
}

