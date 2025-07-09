using System;
using System.Drawing;
using P2_PC2_Paint_GarciaE.DrawingCore;

namespace P2_PC2_Paint_GarciaE.Tools
{
    public class BezierTool
    {
        public static void DrawCubicBezier(Canvas canvas, Point p0, Point p1, Point p2, Point p3, Color color)
        {
            for (float t = 0; t <= 1; t += 0.001f)
            {
                float x = (float)(Math.Pow(1 - t, 3) * p0.X +
                                  3 * Math.Pow(1 - t, 2) * t * p1.X +
                                  3 * (1 - t) * Math.Pow(t, 2) * p2.X +
                                  Math.Pow(t, 3) * p3.X);
                float y = (float)(Math.Pow(1 - t, 3) * p0.Y +
                                  3 * Math.Pow(1 - t, 2) * t * p1.Y +
                                  3 * (1 - t) * Math.Pow(t, 2) * p2.Y +
                                  Math.Pow(t, 3) * p3.Y);
                canvas.SetPixel((int)x, (int)y, color);
            }
        }
    }
}
