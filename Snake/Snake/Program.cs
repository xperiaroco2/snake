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
            List<char> charList = new List<char>();
            charList.Add('@');
            charList.Add('#');
            charList.Add('$');
            charList.Add('%');
            charList.Add('&');
            charList.Add('*');

            foreach (char c in charList)
            {
                Console.WriteLine(c);
            }

            Point p1 = new Point(5, 5, '*');
            Point p2 = new Point(6, 6, '#');
            Point p3 = new Point(7, 7, '&');
            Point p4 = new Point(8, 8, '%');
            Point p5 = new Point(10, 10, '$');
            Point p6 = new Point(10, 10, '@');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            foreach (Point p in pList)
            {
                p.Draw();
            }

            Console.ReadLine();
        }
    }
}