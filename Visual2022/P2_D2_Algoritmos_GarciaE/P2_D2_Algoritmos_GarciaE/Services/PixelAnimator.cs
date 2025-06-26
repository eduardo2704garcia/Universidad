using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_D2_Algoritmos_GarciaE.Services
{
    public class PixelAnimator
    {
        public async Task AnimarPuntos(List<Point> puntos, PictureBox canvas, Color color, int velocidad)
        {
            if (canvas.Image == null)
                canvas.Image = new Bitmap(canvas.Width, canvas.Height);

            using (Graphics g = Graphics.FromImage(canvas.Image))
            {
                foreach (Point p in puntos)
                {
                    g.FillRectangle(new SolidBrush(color), p.X, p.Y, 1, 1);
                    canvas.Invalidate();
                    await Task.Delay(velocidad);
                }
            }
        }

        public void DibujarPoligono(List<Point> puntos, PictureBox canvas, Color color)
        {
            if (canvas.Image == null)
                canvas.Image = new Bitmap(canvas.Width, canvas.Height);

            using (Graphics g = Graphics.FromImage(canvas.Image))
            {
                g.DrawPolygon(new Pen(color), puntos.ToArray());
            }
            canvas.Invalidate();
        }

        public async Task RellenarLineaPorLinea(Bitmap bmp, int x, int y, Color colorObjetivo, Color colorRelleno, PictureBox canvas, int velocidad = 5)
        {
            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));

            while (cola.Count > 0)
            {
                Point punto = cola.Dequeue();
                int px = punto.X;
                int py = punto.Y;

                // Corre a la izquierda
                while (px >= 0 && bmp.GetPixel(px, py).ToArgb() == colorObjetivo.ToArgb())
                    px--;
                px++;

                bool arriba = false, abajo = false;

                // Corre a la derecha pintando
                while (px < bmp.Width && bmp.GetPixel(px, py).ToArgb() == colorObjetivo.ToArgb())
                {
                    bmp.SetPixel(px, py, colorRelleno);
                    canvas.Refresh();
                    await Task.Delay(velocidad);

                    // Pixel arriba
                    if (py > 0 && bmp.GetPixel(px, py - 1).ToArgb() == colorObjetivo.ToArgb())
                    {
                        if (!arriba)
                        {
                            cola.Enqueue(new Point(px, py - 1));
                            arriba = true;
                        }
                    }
                    else
                    {
                        arriba = false;
                    }

                    // Pixel abajo
                    if (py < bmp.Height - 1 && bmp.GetPixel(px, py + 1).ToArgb() == colorObjetivo.ToArgb())
                    {
                        if (!abajo)
                        {
                            cola.Enqueue(new Point(px, py + 1));
                            abajo = true;
                        }
                    }
                    else
                    {
                        abajo = false;
                    }

                    px++;
                }
            }
        }
    }
}
