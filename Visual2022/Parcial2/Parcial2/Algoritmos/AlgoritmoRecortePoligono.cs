using System;
using System.Collections.Generic;
using System.Drawing;

namespace Parcial2.Algoritmos
{
    internal class AlgoritmoRecortePoligono
    {
        public List<Point> RecortarPoligono(List<Point> poligono, Rectangle recorte)
        {
            List<Point> resultado = new List<Point>(poligono);

            //Recortes
            resultado = RecortarContraBorde(resultado, new Point(recorte.Left, recorte.Top), new Point(recorte.Right, recorte.Top), "TOP");
            resultado = RecortarContraBorde(resultado, new Point(recorte.Right, recorte.Top), new Point(recorte.Right, recorte.Bottom), "RIGHT");
            resultado = RecortarContraBorde(resultado, new Point(recorte.Right, recorte.Bottom), new Point(recorte.Left, recorte.Bottom), "BOTTOM");
            resultado = RecortarContraBorde(resultado, new Point(recorte.Left, recorte.Bottom), new Point(recorte.Left, recorte.Top), "LEFT");

            return resultado;
        }

        private List<Point> RecortarContraBorde(List<Point> entrada, Point bordeInicio, Point bordeFin, string borde)
        {
            List<Point> salida = new List<Point>();

            for (int i = 0; i < entrada.Count; i++)
            {
                Point actual = entrada[i];
                Point anterior = entrada[(i - 1 + entrada.Count) % entrada.Count];

                bool actualDentro = EstaDentro(actual, borde, bordeInicio);
                bool anteriorDentro = EstaDentro(anterior, borde, bordeInicio);

                if (anteriorDentro && actualDentro)
                {
                    salida.Add(actual);
                }
                else if (anteriorDentro && !actualDentro)
                {
                    salida.Add(CalcularInterseccion(anterior, actual, borde, bordeInicio));
                }
                else if (!anteriorDentro && actualDentro)
                {
                    salida.Add(CalcularInterseccion(anterior, actual, borde, bordeInicio));
                    salida.Add(actual);
                }
            }

            return salida;
        }

        private bool EstaDentro(Point p, string borde, Point limite)
        {
            switch (borde)
            {
                case "LEFT": return p.X >= limite.X;
                case "RIGHT": return p.X <= limite.X;
                case "TOP": return p.Y >= limite.Y;
                case "BOTTOM": return p.Y <= limite.Y;
                default: return false;
            }
        }

        private Point CalcularInterseccion(Point p1, Point p2, string borde, Point limite)
        {
            float x1 = p1.X, y1 = p1.Y, x2 = p2.X, y2 = p2.Y;
            float dx = x2 - x1;
            float dy = y2 - y1;

            switch (borde)
            {
                case "LEFT":
                    return new Point((int)limite.X, (int)(y1 + dy * (limite.X - x1) / dx));
                case "RIGHT":
                    return new Point((int)limite.X, (int)(y1 + dy * (limite.X - x1) / dx));
                case "TOP":
                    return new Point((int)(x1 + dx * (limite.Y - y1) / dy), (int)limite.Y);
                case "BOTTOM":
                    return new Point((int)(x1 + dx * (limite.Y - y1) / dy), (int)limite.Y);
                default:
                    return Point.Empty;
            }
        }
    }
}
