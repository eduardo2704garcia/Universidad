using System;
using System.Drawing;

namespace Examen_Garcia_Eduardo
{
    internal class SuperStar
    {
        public void Draw(Graphics g, int side, int width, int height)
        {
            PointF center = new PointF(width / 2f, height / 2f);
            Pen pen = Pens.Black;

            float rotationAngle = side * 1f;

            // Estrella grande rotada
            PointF[] outerPoints = GetStarPoints(center, side, rotationAngle);
            DrawStar(g, outerPoints, pen);

            // Estrella pequeña fija
            PointF[] fixedInnerPoints = GetStarPoints(center, side * 0.5f, 0); 
            DrawStar(g, fixedInnerPoints, pen);

            // Pentágono encima
            DrawFlower(g, center, side * 0.6f, 9, 10, 20);
        }


        private PointF[] GetStarPoints(PointF center, float side, float rotationDegrees)
        {
            PointF[] points = new PointF[5];
            float rotationRad = (float)(Math.PI * rotationDegrees / 180.0);
            float radius = (float)(side / (2 * Math.Sin(Math.PI / 5)));

            for (int i = 0; i < 5; i++)
            {
                double angle = 2 * Math.PI * i / 5 - Math.PI / 2 + rotationRad;
                float x = center.X + radius * (float)Math.Cos(angle);
                float y = center.Y + radius * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }

            return points;
        }

        private void DrawStar(Graphics g, PointF[] points, Pen pen)
        {
            g.DrawLine(pen, points[0], points[2]);
            g.DrawLine(pen, points[2], points[4]);
            g.DrawLine(pen, points[4], points[1]);
            g.DrawLine(pen, points[1], points[3]);
            g.DrawLine(pen, points[3], points[0]);
        }

        private PointF[] ConnectStarTips(PointF[] tips)
        {
            PointF[] newTips = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                int next = (i + 2) % 5;
                float midX = (tips[i].X + tips[next].X) / 2;
                float midY = (tips[i].Y + tips[next].Y) / 2;
                newTips[i] = new PointF(midX, midY);
            }

            return newTips;
        }

        private void DrawFlower(Graphics g, PointF center, float initialRadius, int steps, float growth, float rotationStep)
        {
            for (int i = 0; i < steps; i++)
            {
                float radius = initialRadius + i * growth;
                float rotation = i * rotationStep;
                PointF[] pentagon = GetStarPoints(center, radius, rotation);

                g.DrawPolygon(Pens.Black, pentagon);
            }
        }

    }
}
