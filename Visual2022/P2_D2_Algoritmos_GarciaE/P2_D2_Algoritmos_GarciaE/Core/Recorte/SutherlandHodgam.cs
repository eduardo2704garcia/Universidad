using System;
using System.Collections.Generic;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Core.Recorte
{
    public static class SutherlandHodgman
    {
        public static List<Point> ClipPolygon(List<Point> subjectPolygon, Rectangle clipRect)
        {
            List<Point> outputList = new List<Point>(subjectPolygon);

            outputList = ClipAgainstEdge(outputList, clipRect, "Left");
            outputList = ClipAgainstEdge(outputList, clipRect, "Right");
            outputList = ClipAgainstEdge(outputList, clipRect, "Top");
            outputList = ClipAgainstEdge(outputList, clipRect, "Bottom");

            return outputList;
        }

        private static List<Point> ClipAgainstEdge(List<Point> input, Rectangle clipRect, string edge)
        {
            List<Point> output = new List<Point>();

            for (int i = 0; i < input.Count; i++)
            {
                Point current = input[i];
                Point previous = input[(i - 1 + input.Count) % input.Count];

                bool currInside = IsInside(current, clipRect, edge);
                bool prevInside = IsInside(previous, clipRect, edge);

                if (currInside)
                {
                    if (!prevInside)
                        output.Add(ComputeIntersection(previous, current, clipRect, edge));
                    output.Add(current);
                }
                else if (prevInside)
                {
                    output.Add(ComputeIntersection(previous, current, clipRect, edge));
                }
            }

            return output;
        }

        private static bool IsInside(Point p, Rectangle r, string edge)
        {
            switch (edge)
            {
                case "Left": return p.X >= r.Left;
                case "Right": return p.X <= r.Right;
                case "Top": return p.Y >= r.Top;
                case "Bottom": return p.Y <= r.Bottom;
                default: return true;
            }
        }

        private static Point ComputeIntersection(Point p1, Point p2, Rectangle rect, string edge)
        {
            float x = 0, y = 0;
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;

            switch (edge)
            {
                case "Left":
                    x = rect.Left;
                    y = p1.Y + dy * (rect.Left - p1.X) / dx;
                    break;
                case "Right":
                    x = rect.Right;
                    y = p1.Y + dy * (rect.Right - p1.X) / dx;
                    break;
                case "Top":
                    y = rect.Top;
                    x = p1.X + dx * (rect.Top - p1.Y) / dy;
                    break;
                case "Bottom":
                    y = rect.Bottom;
                    x = p1.X + dx * (rect.Bottom - p1.Y) / dy;
                    break;
            }

            return new Point((int)x, (int)y);
        }
    }
}
