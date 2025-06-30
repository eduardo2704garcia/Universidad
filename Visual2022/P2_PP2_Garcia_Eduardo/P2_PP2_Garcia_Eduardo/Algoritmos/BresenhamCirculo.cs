using System;
using System.Drawing;

namespace P2_PP2_Garcia_Eduardo.Algoritmos
{
    internal class BresenhamCirculo
    {
        public static void Dibujar(Bitmap bmp, int xc, int yc, int r, Color color)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;

            while (x <= y)
            {
                Pinta8Puntos(bmp, xc, yc, x, y, color);
                if (d < 0)
                    d += 4 * x + 6;
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }
        }

        private static void Pinta8Puntos(Bitmap bmp, int xc, int yc, int x, int y, Color color)
        {
            Action<int, int> pintar = (px, py) =>
            {
                if (px >= 0 && py >= 0 && px < bmp.Width && py < bmp.Height)
                    bmp.SetPixel(px, py, color);
            };

            pintar(xc + x, yc + y);
            pintar(xc - x, yc + y);
            pintar(xc + x, yc - y);
            pintar(xc - x, yc - y);
            pintar(xc + y, yc + x);
            pintar(xc - y, yc + x);
            pintar(xc + y, yc - x);
            pintar(xc - y, yc - x);
        }
    }
}
