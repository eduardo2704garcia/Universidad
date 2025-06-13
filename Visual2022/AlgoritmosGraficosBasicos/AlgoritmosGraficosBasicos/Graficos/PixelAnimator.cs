using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.Graficos
{
    internal class PixelAnimator
    {
        public async Task RellenarDeArribaAbajo(Bitmap bmp, int x, int y, Color colorObjetivo, Color colorRelleno, PictureBox canvas, DataGridView grid)
        {
            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));

            while (cola.Count > 0)
            {
                Point punto = cola.Dequeue();

                if (punto.X < 0 || punto.Y < 0 || punto.X >= bmp.Width || punto.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(punto.X, punto.Y).ToArgb() != colorObjetivo.ToArgb())
                    continue;

                bmp.SetPixel(punto.X, punto.Y, colorRelleno);
                canvas.Refresh();

                grid.Rows.Add(punto.X, punto.Y);

                // Agrega prioridad a ir hacia abajo primero (animación vertical)
                cola.Enqueue(new Point(punto.X, punto.Y + 1));
                cola.Enqueue(new Point(punto.X + 1, punto.Y));
                cola.Enqueue(new Point(punto.X - 1, punto.Y));
                cola.Enqueue(new Point(punto.X, punto.Y - 1));

                await Task.Delay(1); // Animación pixel a pixel
            }
        }
    }
}
