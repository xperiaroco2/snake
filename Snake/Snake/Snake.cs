﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        

        public Snake(Point tile,int lenght, Direction direction )
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point( tile );
                p.Move(i, direction);
                pList.Add( p );
            }
        }
    }
}
