using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Services;

namespace P2_D2_Algoritmos_GarciaE.Core.Relleno
{
    public class SkilineFill
    {
        private PixelAnimator animador = new PixelAnimator();

        public async Task Rellenar(Bitmap bmp, List<Point> vertices, Color colorRelleno, PictureBox canvas, int velocidad)
        {
            int minY = int.MaxValue, maxY = int.MinValue;

            foreach (var p in vertices)
            {
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            List<Point> puntosRelleno = new List<Point>();

            for (int y = minY; y <= maxY; y++)
            {
                List<int> intersecciones = new List<int>();

                for (int i = 0; i < vertices.Count; i++)
                {
                    Point p1 = vertices[i];
                    Point p2 = vertices[(i + 1) % vertices.Count];

                    if (p1.Y == p2.Y)
                        continue;

                    if (y >= Math.Min(p1.Y, p2.Y) && y < Math.Max(p1.Y, p2.Y))
                    {
                        int x = p1.X + (y - p1.Y) * (p2.X - p1.X) / (p2.Y - p1.Y);
                        intersecciones.Add(x);
                    }
                }

                intersecciones.Sort();

                for (int i = 0; i < intersecciones.Count - 1; i += 2)
                {
                    for (int x = intersecciones[i]; x <= intersecciones[i + 1]; x++)
                    {
                        bmp.SetPixel(x, y, colorRelleno);
                        puntosRelleno.Add(new Point(x, y));
                    }
                }
            }

            await animador.AnimarPuntos(puntosRelleno, canvas, colorRelleno, velocidad);
        }
    }
}
