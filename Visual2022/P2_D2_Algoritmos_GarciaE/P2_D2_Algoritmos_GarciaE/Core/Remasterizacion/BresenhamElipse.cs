using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Interfaces;
using P2_D2_Algoritmos_GarciaE.Services;

namespace P2_D2_Algoritmos_GarciaE.Core.Remasterizacion
{
    public class BresenhamElipse : IDibujable, IAnimable
    {
        public void Dibujar(Graphics g, List<Point> puntos)
        {
            _ = Animar(g, puntos, null, 0);
        }

        public async Task Animar(Graphics g, List<Point> puntos, PictureBox canvas, int velocidad)
        {
            Point centro = puntos[0];
            Point extremo = puntos[1];
            int rx = Math.Abs(extremo.X - centro.X);
            int ry = Math.Abs(extremo.Y - centro.Y);
            int x = 0, y = ry;
            float dx = 2 * ry * ry * x;
            float dy = 2 * rx * rx * y;
            float p1 = ry * ry - rx * rx * ry + 0.25f * rx * rx;
            List<Point> lista = new List<Point>();

            void Agregar(int cx, int cy, int px, int py)
            {
                lista.Add(new Point(cx + px, cy + py));
                lista.Add(new Point(cx - px, cy + py));
                lista.Add(new Point(cx + px, cy - py));
                lista.Add(new Point(cx - px, cy - py));
            }

            while (dx < dy)
            {
                Agregar(centro.X, centro.Y, x, y);
                x++;
                dx = 2 * ry * ry * x;
                if (p1 < 0)
                {
                    p1 += dx + ry * ry;
                }
                else
                {
                    y--;
                    dy = 2 * rx * rx * y;
                    p1 += dx - dy + ry * ry;
                }
            }

            float p2 = (ry * ry) * (x + 0.5f) * (x + 0.5f) + (rx * rx) * (y - 1) * (y - 1) - (rx * rx * ry * ry);
            while (y >= 0)
            {
                Agregar(centro.X, centro.Y, x, y);
                y--;
                dy = 2 * rx * rx * y;
                if (p2 > 0)
                {
                    p2 += rx * rx - dy;
                }
                else
                {
                    x++;
                    dx = 2 * ry * ry * x;
                    p2 += dx - dy + rx * rx;
                }
            }

            await new PixelAnimator().AnimarPuntos(lista, canvas, Color.Black, velocidad);
        }
    }
}