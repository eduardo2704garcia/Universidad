using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Interfaces;
using P2_D2_Algoritmos_GarciaE.Services;

namespace P2_D2_Algoritmos_GarciaE.Core.Remasterizacion
{
    public class BresenhamLinea : IDibujable, IAnimable
    {
        public void Dibujar(Graphics g, List<Point> puntos)
        {
            int x0 = puntos[0].X, y0 = puntos[0].Y;
            int x1 = puntos[1].X, y1 = puntos[1].Y;
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                g.FillRectangle(Brushes.Black, x0, y0, 1, 1);
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }

        public async Task Animar(Graphics g, List<Point> puntos, PictureBox canvas, int velocidad)
        {
            int x0 = puntos[0].X, y0 = puntos[0].Y;
            int x1 = puntos[1].X, y1 = puntos[1].Y;
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            List<Point> lista = new List<Point>();
            while (true)
            {
                lista.Add(new Point(x0, y0));
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }

            await new PixelAnimator().AnimarPuntos(lista, canvas, Color.Black, velocidad);
        }
    }
}
