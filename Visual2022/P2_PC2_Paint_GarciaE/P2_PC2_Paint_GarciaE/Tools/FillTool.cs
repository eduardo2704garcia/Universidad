using System;
using System.Drawing;
using P2_PC2_Paint_GarciaE.DrawingCore;

namespace P2_PC2_Paint_GarciaE.Tools
{
    public class FillTool
    {
        public static void DrawAndFillPolygon(Canvas canvas, int cx, int cy, int radius, int sides, Color borderColor, Color fillColor)
        {
            if (sides < 3) return;

            Point[] points = new Point[sides];
            double angleStep = 2 * Math.PI / sides;

            for (int i = 0; i < sides; i++)
            {
                int x = cx + (int)(radius * Math.Cos(i * angleStep));
                int y = cy + (int)(radius * Math.Sin(i * angleStep));
                points[i] = new Point(x, y);
            }

            for (int i = 0; i < sides; i++)
            {
                Point p1 = points[i];
                Point p2 = points[(i + 1) % sides];
                LineTool.DrawLine(canvas, p1.X, p1.Y, p2.X, p2.Y, borderColor);
            }
            Color target = canvas.GetPixel(cx, cy);
            FloodFill(canvas, cx, cy, target, fillColor);
        }
        //Frecursivo
        public static void FloodFill(Canvas canvas, int x, int y, Color targetColor, Color fillColor)
        {
            if (x < 0 || y < 0 || x >= canvas.Bitmap.Width || y >= canvas.Bitmap.Height) return;
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;
            if (canvas.GetPixel(x, y).ToArgb() != targetColor.ToArgb()) return;

            canvas.SetPixel(x, y, fillColor);

            FloodFill(canvas, x + 1, y, targetColor, fillColor);
            FloodFill(canvas, x - 1, y, targetColor, fillColor);
            FloodFill(canvas, x, y + 1, targetColor, fillColor);
            FloodFill(canvas, x, y - 1, targetColor, fillColor);
        }
    }
}
