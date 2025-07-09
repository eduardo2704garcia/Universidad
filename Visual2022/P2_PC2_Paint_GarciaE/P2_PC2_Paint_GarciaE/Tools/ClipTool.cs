using System.Drawing;
using P2_PC2_Paint_GarciaE.DrawingCore;

namespace P2_PC2_Paint_GarciaE.Tools
{
    public class ClipTool
    {
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1;   // 0001
        private const int RIGHT = 2;  // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8;    // 1000

        private static int ComputeOutCode(int x, int y, int xmin, int ymin, int xmax, int ymax)
        {
            int code = INSIDE;
            if (x < xmin) code |= LEFT;
            else if (x > xmax) code |= RIGHT;
            if (y < ymin) code |= BOTTOM;
            else if (y > ymax) code |= TOP;
            return code;
        }

        public static void CohenSutherland(Canvas canvas, int x0, int y0, int x1, int y1,
                                           int xmin, int ymin, int xmax, int ymax, Color color)
        {
            int outcode0 = ComputeOutCode(x0, y0, xmin, ymin, xmax, ymax);
            int outcode1 = ComputeOutCode(x1, y1, xmin, ymin, xmax, ymax);
            bool accept = false;

            while (true)
            {
                if ((outcode0 | outcode1) == 0)
                {
                    accept = true;
                    break;
                }
                else if ((outcode0 & outcode1) != 0)
                {
                    break;
                }
                else
                {
                    int x = 0, y = 0;
                    int outcodeOut = outcode0 != 0 ? outcode0 : outcode1;

                    if ((outcodeOut & TOP) != 0)
                    {
                        x = x0 + (x1 - x0) * (ymax - y0) / (y1 - y0);
                        y = ymax;
                    }
                    else if ((outcodeOut & BOTTOM) != 0)
                    {
                        x = x0 + (x1 - x0) * (ymin - y0) / (y1 - y0);
                        y = ymin;
                    }
                    else if ((outcodeOut & RIGHT) != 0)
                    {
                        y = y0 + (y1 - y0) * (xmax - x0) / (x1 - x0);
                        x = xmax;
                    }
                    else if ((outcodeOut & LEFT) != 0)
                    {
                        y = y0 + (y1 - y0) * (xmin - x0) / (x1 - x0);
                        x = xmin;
                    }

                    if (outcodeOut == outcode0)
                    {
                        x0 = x;
                        y0 = y;
                        outcode0 = ComputeOutCode(x0, y0, xmin, ymin, xmax, ymax);
                    }
                    else
                    {
                        x1 = x;
                        y1 = y;
                        outcode1 = ComputeOutCode(x1, y1, xmin, ymin, xmax, ymax);
                    }
                }
            }

            if (accept)
            {
                LineTool.DrawLine(canvas, x0, y0, x1, y1, color);
            }
        }
    }
}
