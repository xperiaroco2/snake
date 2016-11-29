using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Linesy : Figure
    {
        

        //Конструктор Вертикал. линий
        public Linesy(int yUp, int yDown, int x,  char sym)
        {
            //Создаем лист точек
            pList = new List<Point>();

            //Добавляем точки в массив
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        }
        
        
    }
}
