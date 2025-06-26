using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Services;

namespace P2_D2_Algoritmos_GarciaE.Core.Relleno
{
    public class FloodFill
    {
        private PixelAnimator animador = new PixelAnimator();

        public async Task Rellenar(Bitmap bmp, Point inicio, Color colorRelleno, PictureBox canvas, int velocidad)
        {
            Color colorObjetivo = bmp.GetPixel(inicio.X, inicio.Y);
            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(inicio);

            List<Point> puntosAnimados = new List<Point>();

            while (cola.Count > 0)
            {
                Point p = cola.Dequeue();
                if (p.X < 0 || p.Y < 0 || p.X >= bmp.Width || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != colorObjetivo.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, colorRelleno);
                puntosAnimados.Add(p);

                cola.Enqueue(new Point(p.X + 1, p.Y));
                cola.Enqueue(new Point(p.X - 1, p.Y));
                cola.Enqueue(new Point(p.X, p.Y + 1));
                cola.Enqueue(new Point(p.X, p.Y - 1));
            }

            await animador.AnimarPuntos(puntosAnimados, canvas, colorRelleno, velocidad);
        }
    }
}
