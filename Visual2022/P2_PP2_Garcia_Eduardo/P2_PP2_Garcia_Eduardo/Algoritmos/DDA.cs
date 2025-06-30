using System;
using System.Drawing;

namespace P2_PP2_Garcia_Eduardo.Algoritmos
{
    internal class DDA
    {
        public static void Dibujar(Bitmap bmp, int x1, int y1, int x2, int y2, Color color)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xInc = dx / (float)steps;
            float yInc = dy / (float)steps;
            float x = x1;
            float y = y1;

            for (int i = 0; i <= steps; i++)
            {
                if (x >= 0 && y >= 0 && x < bmp.Width && y < bmp.Height)
                    bmp.SetPixel((int)x, (int)y, color);
                x += xInc;
                y += yInc;
            }
        }
    }
}
