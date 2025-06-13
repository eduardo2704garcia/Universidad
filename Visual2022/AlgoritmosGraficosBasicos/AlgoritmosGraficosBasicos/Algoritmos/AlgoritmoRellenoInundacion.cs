using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRellenoInundacion
    {
        public async Task RellenarAnimado(Bitmap bmp, int x, int y, Color colorObjetivo, Color colorRelleno, PictureBox canvas)
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
                canvas.Refresh(); // actualiza visualmente

                cola.Enqueue(new Point(punto.X + 1, punto.Y));
                cola.Enqueue(new Point(punto.X - 1, punto.Y));
                cola.Enqueue(new Point(punto.X, punto.Y + 1));
                cola.Enqueue(new Point(punto.X, punto.Y - 1));

                await Task.Delay(1); // control de animación (ajustable)
            }
        }
    }
}
