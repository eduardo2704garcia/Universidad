using System.Drawing;
using P2_PC2_Paint_GarciaE.DrawingCore;

namespace P2_PC2_Paint_GarciaE.Tools
{
    public class CircleTool
    {
        public static void DrawCircle(Canvas canvas, int xc, int yc, int r, Color color)
        {
            int x = 0, y = r;
            int d = 1 - r;

            while (x <= y)
            {
                PlotCirclePoints(canvas, xc, yc, x, y, color);
                x++;
                d += (d < 0) ? 2 * x + 1 : 2 * (x - y--) + 1;
            }
        }

        private static void PlotCirclePoints(Canvas canvas, int xc, int yc, int x, int y, Color color)
        {
            canvas.SetPixel(xc + x, yc + y, color);
            canvas.SetPixel(xc - x, yc + y, color);
            canvas.SetPixel(xc + x, yc - y, color);
            canvas.SetPixel(xc - x, yc - y, color);
            canvas.SetPixel(xc + y, yc + x, color);
            canvas.SetPixel(xc - y, yc + x, color);
            canvas.SetPixel(xc + y, yc - x, color);
            canvas.SetPixel(xc - y, yc - x, color);
        }
    }
}
