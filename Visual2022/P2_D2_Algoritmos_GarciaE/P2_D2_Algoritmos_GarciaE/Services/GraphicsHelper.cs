using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace P2_D2_Algoritmos_GarciaE.Services
{
    public static class GraphicsHelper
    {
        public static void DibujarLinea(Graphics g, Point p1, Point p2, Pen lapiz)
        {
            g.DrawLine(lapiz, p1, p2);
        }

        public static void DibujarPuntos(Graphics g, List<Point> puntos, Brush color, int size = 4)
        {
            foreach (var p in puntos)
            {
                g.FillEllipse(color, p.X - size / 2, p.Y - size / 2, size, size);
            }
        }

        public static void DibujarTexto(Graphics g, string texto, Point ubicacion, Font fuente, Brush color)
        {
            g.DrawString(texto, fuente, color, ubicacion);
        }
    }
}
