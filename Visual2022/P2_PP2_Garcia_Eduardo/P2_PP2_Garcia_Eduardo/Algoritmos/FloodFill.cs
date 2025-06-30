using System.Collections.Generic;
using System.Drawing;

namespace P2_PP2_Garcia_Eduardo.Algoritmos
{
    internal class FloodFill
    {
        public static void Rellenar(Bitmap bmp, int x, int y, Color target, Color replacement)
        {
            if (target.ToArgb() == replacement.ToArgb()) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();
                if (p.X < 0 || p.Y < 0 || p.X >= bmp.Width || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() == target.ToArgb())
                {
                    bmp.SetPixel(p.X, p.Y, replacement);
                    pixels.Push(new Point(p.X + 1, p.Y));
                    pixels.Push(new Point(p.X - 1, p.Y));
                    pixels.Push(new Point(p.X, p.Y + 1));
                    pixels.Push(new Point(p.X, p.Y - 1));
                }
            }
        }
    }
}
