using System;
using System.Drawing;
using P2_PC2_Paint_GarciaE.DrawingCore;

namespace P2_PC2_Paint_GarciaE.Tools
{
    public class LineTool
    {
        public static void DrawLine(Canvas canvas, int x0, int y0, int x1, int y1, Color color)
        {
            int dx = Math.Abs(x1 - x0), dy = -Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx + dy;

            while (true)
            {
                canvas.SetPixel(x0, y0, color);
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 >= dy) { err += dy; x0 += sx; }
                if (e2 <= dx) { err += dx; y0 += sy; }
            }
        }
    }
}
