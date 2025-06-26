using System;
using System.Collections.Generic;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Models
{
    public class Figura
    {
        public List<Point> Puntos { get; private set; }

        public Figura(int lados, int centroX, int centroY, int radio)
        {
            Puntos = new List<Point>();
            double angulo = 2 * Math.PI / lados;

            for (int i = 0; i < lados; i++)
            {
                int x = centroX + (int)(radio * Math.Cos(i * angulo));
                int y = centroY + (int)(radio * Math.Sin(i * angulo));
                Puntos.Add(new Point(x, y));
            }
        }
    }
}
