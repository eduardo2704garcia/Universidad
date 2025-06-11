using System;
using System.Drawing;
using System.Windows.Forms;

namespace PI_PC1_Garcia_Eduardo
{
    internal class Honey
    {
        private Graphics g;
        private float side; // Lado del hexágono
        private float h;    // Altura del triángulo (h = lado * √3 / 2)
        private float r;    // Apotema (distancia desde el centro al lado)
        private Pen pen;
        private Brush brush;

        public Honey(Graphics g, float side)
        {
            this.g = g;
            this.side = side;
            this.h = (float)(Math.Sqrt(3) / 2 * side);
            this.r = side / 2;
            pen = new Pen(Color.Orange, 1);
            brush = new SolidBrush(Color.Gold);
        }
        public void DrawHexagon(float centerX, float centerY)
        {
            PointF[] points = new PointF[6];

            for (int i = 0; i < 6; i++)
            {
                float angle_deg = 60 * i - 30;
                float angle_rad = (float)(Math.PI / 180 * angle_deg);
                points[i] = new PointF(
                    centerX + side * (float)Math.Cos(angle_rad),
                    centerY + side * (float)Math.Sin(angle_rad));
            }

            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }
        public void DrawHexagonGrid(int n, float canvasWidth, float canvasHeight)
        {
            float dx = side * 1.7f;
            float dy = side * (float)Math.Sqrt(8);

            int totalRows = 2 * n - 1;

            // Calcula dimensiones del panal completo
            float totalHeight = dy * totalRows / 2;
            float totalWidth = dx * (n + n - 1);

            float startX = (canvasWidth - totalWidth) / 2;
            float startY = (canvasHeight - totalHeight) / 2;

            for (int row = 0; row < totalRows; row++)
            {
                int colsInRow = n + Math.Min(row, totalRows - row - 1);
                float y = startY + row * (dy / 2);

                for (int col = 0; col < colsInRow; col++)
                {
                    float x = startX + col * dx + ((n - 1 - Math.Min(row, totalRows - row - 1)) * dx / 2);
                    DrawHexagon(x, y);
                }
            }
        }

    }
}
