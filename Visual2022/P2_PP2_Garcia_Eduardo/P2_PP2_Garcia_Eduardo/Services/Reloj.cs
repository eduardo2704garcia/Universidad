using System;
using System.Drawing;
using P2_PP2_Garcia_Eduardo.Algoritmos;

namespace P2_PP2_Garcia_Eduardo.Services
{
    internal class Reloj
    {
        public static Bitmap GenerarReloj(int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            int xc = width / 2;
            int yc = height / 2;
            int r = Math.Min(xc, yc) - 10;

            BresenhamCirculo.Dibujar(bmp, xc, yc, r, Color.Black);

            DibujarMarcas(bmp, xc, yc, r);

            DibujarManecillas(bmp, xc, yc, r);

            return bmp;
        }

        private static void DibujarMarcas(Bitmap bmp, int xc, int yc, int r)
        {
            for (int i = 0; i < 60; i++)
            {
                int len = (i % 5 == 0) ? 15 : 7;
                Point p1 = Rotar(xc, yc - (r - len), xc, yc, i * 6);
                Point p2 = Rotar(xc, yc - r, xc, yc, i * 6);
                DDA.Dibujar(bmp, p1.X, p1.Y, p2.X, p2.Y, Color.Black);
            }
        }

        private static void DibujarManecillas(Bitmap bmp, int xc, int yc, int r)
        {
            DateTime ahora = DateTime.Now;

            double angSeg = ahora.Second * 6;
            double angMin = ahora.Minute * 6 + ahora.Second * 0.1;
            double angHor = (ahora.Hour % 12) * 30 + ahora.Minute * 0.5;

            Point seg = Rotar(xc, yc - (r - 15), xc, yc, angSeg);
            Point min = Rotar(xc, yc - (r - 30), xc, yc, angMin);
            Point hor = Rotar(xc, yc - (r - 50), xc, yc, angHor);

            DDA.Dibujar(bmp, xc, yc, seg.X, seg.Y, Color.Red);
            DDA.Dibujar(bmp, xc, yc, min.X, min.Y, Color.Green);
            DDA.Dibujar(bmp, xc, yc, hor.X, hor.Y, Color.Blue);
        }

        private static Point Rotar(int x, int y, int cx, int cy, double ang)
        {
            double rad = ang * Math.PI / 180.0;
            int dx = x - cx;
            int dy = y - cy;

            int xr = (int)(Math.Cos(rad) * dx - Math.Sin(rad) * dy + cx);
            int yr = (int)(Math.Sin(rad) * dx + Math.Cos(rad) * dy + cy);

            return new Point(xr, yr);
        }
    }
}
