using System;
using System.Collections.Generic;
using System.Drawing;

namespace Parcial2.Algoritmos
{
    internal class AlgoritmoPuntoMedio
    {
        public static List<Point> Calcular(int x0, int y0, int x1, int y1)
        {
            List<Point> puntos = new List<Point>();

            int dx = x1 - x0;
            int dy = y1 - y0;
            int d = dy - (dx / 2);
            int x = x0, y = y0;

            puntos.Add(new Point(x, y));
            while (x < x1)
            {
                x++;
                if (d < 0)
                {
                    d = d + dy;
                }
                else
                {
                    d += dy - dx;
                    y++;
                }
                puntos.Add(new Point(x, y));
            }

            return puntos;
        }
    }
}
