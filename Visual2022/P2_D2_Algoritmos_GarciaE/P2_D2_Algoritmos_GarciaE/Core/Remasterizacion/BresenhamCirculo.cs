using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Interfaces;
using P2_D2_Algoritmos_GarciaE.Services;

namespace P2_D2_Algoritmos_GarciaE.Core.Remasterizacion
{
    public class BresenhamCirculo : IDibujable, IAnimable
    {
        public void Dibujar(Graphics g, List<Point> puntos)
        {
            _ = Animar(g, puntos, null, 0); // O usa implementación sin animación
        }

        public async Task Animar(Graphics g, List<Point> puntos, PictureBox canvas, int velocidad)
        {
            Point centro = puntos[0];
            Point borde = puntos[1];
            int radio = (int)Math.Sqrt(Math.Pow(borde.X - centro.X, 2) + Math.Pow(borde.Y - centro.Y, 2));
            int x = 0, y = radio;
            int d = 3 - 2 * radio;
            List<Point> lista = new List<Point>();

            void AgregarPuntos(int cx, int cy, int px, int py)
            {
                lista.Add(new Point(cx + px, cy + py));
                lista.Add(new Point(cx - px, cy + py));
                lista.Add(new Point(cx + px, cy - py));
                lista.Add(new Point(cx - px, cy - py));
                lista.Add(new Point(cx + py, cy + px));
                lista.Add(new Point(cx - py, cy + px));
                lista.Add(new Point(cx + py, cy - px));
                lista.Add(new Point(cx - py, cy - px));
            }

            while (x <= y)
            {
                AgregarPuntos(centro.X, centro.Y, x, y);
                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            await new PixelAnimator().AnimarPuntos(lista, canvas, Color.Black, velocidad);
        }
    }
}