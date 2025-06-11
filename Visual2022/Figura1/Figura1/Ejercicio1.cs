using System;
using System.Drawing;

namespace Figura1
{
    internal class Ejercicio1
    {
        public void DibujarRombo(Graphics g, int width, int height, int n)
        {
            Point puntoA = new Point(0, 0); //arriba izquierda
            Point puntoB = new Point(width, 0);//arriba derecha
            Point puntoC = new Point(0, height);//abajo izquierda
            Point puntoD = new Point(width, height);

            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;

                // abajo izqueirda
                Point p1 = new Point((int)(puntoA.X), (int)(puntoA.Y + t * height));
                Point p2 = new Point((int)(puntoA.X + t * width), (int)(puntoC.Y));
                g.DrawLine(new Pen(Color.Red), p1, p2);

                // abajo derecha
                Point p3 = new Point((int)(puntoC.X + t * width), puntoC.Y);
                Point p4 = new Point(puntoD.X, (int)(puntoD.Y - t * height));
                g.DrawLine(new Pen(Color.Blue), p3, p4);

                // arriba derecja
                Point p5 = new Point(puntoD.X, (int)(puntoD.Y - t * height));
                Point p6 = new Point((int)(puntoD.X - t * width), puntoB.Y);
                g.DrawLine(new Pen(Color.Green), p5, p6);

                // arriba izquierda
                Point p7 = new Point((int)(puntoA.X + t * width), puntoA.Y);
                Point p8 = new Point(puntoA.X, (int)(puntoA.Y + t * height));
                g.DrawLine(new Pen(Color.Yellow), p7, p8);

            }
        }
    }
}
