using System;
using System.Collections.Generic;
using System.Drawing;

namespace Parcial2.Algoritmos
{
    internal class AlgoritmoDDA
    {
        public static List<Point> Calcular(int x0, int y0, int x1, int y1)
        {
            List<Point> puntos = new List<Point>();

            int dx = x1 - x0;
            int dy = y1 - y0;
            int pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xInc = dx / (float)pasos;
            float yInc = dy / (float)pasos;

            float x = x0, y = y0;
            for (int i = 0; i <= pasos; i++)
            {
                puntos.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                x += xInc;
                y += yInc;
            }

            return puntos;
        }
    }
}
