using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Interfaces;
using P2_D2_Algoritmos_GarciaE.Services;

namespace P2_D2_Algoritmos_GarciaE.Core.Remasterizacion
{
    public class DDA : IDibujable, IAnimable
    {
        public void Dibujar(Graphics g, List<Point> puntos)
        {
            Point p0 = puntos[0], p1 = puntos[1];
            int dx = p1.X - p0.X;
            int dy = p1.Y - p0.Y;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xInc = dx / (float)steps;
            float yInc = dy / (float)steps;
            float x = p0.X, y = p0.Y;

            for (int i = 0; i <= steps; i++)
            {
                g.FillRectangle(Brushes.Black, (int)Math.Round(x) - 1, (int)Math.Round(y) - 1, 3, 3);
                x += xInc;
                y += yInc;
            }
        }

        public async Task Animar(Graphics g, List<Point> puntos, PictureBox canvas, int velocidad)
        {
            List<Point> lista = new List<Point>();
            Point p0 = puntos[0], p1 = puntos[1];
            int dx = p1.X - p0.X;
            int dy = p1.Y - p0.Y;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xInc = dx / (float)steps;
            float yInc = dy / (float)steps;
            float x = p0.X, y = p0.Y;

            for (int i = 0; i <= steps; i++)
            {
                lista.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                x += xInc;
                y += yInc;
            }

            await new PixelAnimator().AnimarPuntos(lista, canvas, Color.Black, velocidad);
        }
    }
}
