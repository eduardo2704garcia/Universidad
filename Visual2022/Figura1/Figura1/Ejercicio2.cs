using System;
using System.Drawing;

namespace Figura1
{
    internal class Ejercicio2
    {
        public void DibujarRomboide(Graphics g, int width, int height, int n)
        {
            int margin = 50;

            Point puntoA = new Point(margin, margin);                       // Arriba izquierda
            Point puntoB = new Point(width - margin, margin);              // Arriba derecha
            Point puntoC = new Point(width - margin, height - margin);     // Abajo derecha
            Point puntoD = new Point(margin, height - margin);             // Abajo izquierda

            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n; //iterpolar linear 0 y 1

                // izquierda aarriba
                Point p1 = Lerp(puntoD, puntoA, t);
                Point p2 = Lerp(puntoA, puntoB, t);
                g.DrawLine(new Pen(Color.Blue), p1, p2);

                // derecha arriba
                Point p3 = Lerp(puntoA, puntoB, t);
                Point p4 = Lerp(puntoB, puntoC, t);
                g.DrawLine(new Pen(Color.Green), p3, p4);

                // derecha abajp
                Point p5 = Lerp(puntoB, puntoC, t);
                Point p6 = Lerp(puntoC, puntoD, t);
                g.DrawLine(new Pen(Color.Gold), p5, p6);

                // izquierda abjo
                Point p7 = Lerp(puntoC, puntoD, t);
                Point p8 = Lerp(puntoD, puntoA, t);
                g.DrawLine(new Pen(Color.Red), p7, p8);
            }
        }
        private Point Lerp(Point p1, Point p2, float t)
        {
            return new Point(
                (int)(p1.X + (p2.X - p1.X) * t), // t = 0 p1
                (int)(p1.Y + (p2.Y - p1.Y) * t)  // t = 1 p2 t = 0.5 medio
            );
        }
    }
}
