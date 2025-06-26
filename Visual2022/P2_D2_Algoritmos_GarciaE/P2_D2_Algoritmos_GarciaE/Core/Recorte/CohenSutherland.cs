using System;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Core.Recorte
{
    public static class CohenSutherland
    {
        private const int INSIDE = 0;
        private const int LEFT = 1;
        private const int RIGHT = 2;
        private const int BOTTOM = 4;
        private const int TOP = 8;

        private static int ComputeCode(Point p, Rectangle rect)
        {
            int code = INSIDE;
            if (p.X < rect.Left) code |= LEFT;
            else if (p.X > rect.Right) code |= RIGHT;
            if (p.Y < rect.Top) code |= TOP;
            else if (p.Y > rect.Bottom) code |= BOTTOM;
            return code;
        }

        public static bool ClipLine(ref Point p1, ref Point p2, Rectangle rect)
        {
            int code1 = ComputeCode(p1, rect);
            int code2 = ComputeCode(p2, rect);
            bool accept = false;

            while (true)
            {
                if ((code1 | code2) == 0)
                {
                    accept = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    break;
                }
                else
                {
                    int codeOut = code1 != 0 ? code1 : code2;
                    int x = 0, y = 0;

                    if ((codeOut & TOP) != 0)
                    {
                        x = p1.X + (p2.X - p1.X) * (rect.Top - p1.Y) / (p2.Y - p1.Y);
                        y = rect.Top;
                    }
                    else if ((codeOut & BOTTOM) != 0)
                    {
                        x = p1.X + (p2.X - p1.X) * (rect.Bottom - p1.Y) / (p2.Y - p1.Y);
                        y = rect.Bottom;
                    }
                    else if ((codeOut & RIGHT) != 0)
                    {
                        y = p1.Y + (p2.Y - p1.Y) * (rect.Right - p1.X) / (p2.X - p1.X);
                        x = rect.Right;
                    }
                    else if ((codeOut & LEFT) != 0)
                    {
                        y = p1.Y + (p2.Y - p1.Y) * (rect.Left - p1.X) / (p2.X - p1.X);
                        x = rect.Left;
                    }

                    if (codeOut == code1)
                    {
                        p1 = new Point(x, y);
                        code1 = ComputeCode(p1, rect);
                    }
                    else
                    {
                        p2 = new Point(x, y);
                        code2 = ComputeCode(p2, rect);
                    }
                }
            }

            return accept;
        }

        public static bool RecortarLinea(Point p1, Point p2, Rectangle rect, out Point recortado1, out Point recortado2)
        {
            recortado1 = p1;
            recortado2 = p2;
            return ClipLine(ref recortado1, ref recortado2, rect);
        }
    }
}
