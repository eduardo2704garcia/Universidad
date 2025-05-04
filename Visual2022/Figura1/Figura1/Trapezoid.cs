using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Trapezoid
    {
        private float b1, b2, h, l1, l2;
        private float area, perimeter;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Trapezoid()
        {
            b1 = b2 = h = l1 = l2 = 0.0f;
            area = perimeter = 0.0f;
        }

        public void ReadData(TextBox txtB1, TextBox txtB2, TextBox txtH, TextBox txtL1, TextBox txtL2)
        {
            try
            {
                b1 = float.Parse(txtB1.Text);
                b2 = float.Parse(txtB2.Text);
                h = float.Parse(txtH.Text);
                l1 = float.Parse(txtL1.Text);
                l2 = float.Parse(txtL2.Text);
            }
            catch
            {
                MessageBox.Show("Dato inválido...", "Mensaje de error");
            }
        }

        public void AreaTrapezoid()
        {
            area = ((b1 + b2) * h) / 2.0f;
        }

        public void PerimeterTrapezoid()
        {
            perimeter = b1 + b2 + l1 + l2;
        }

        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = area.ToString("F2");
            txtPerimeter.Text = perimeter.ToString("F2");
        }

        public void InitData(TextBox txtB1, TextBox txtB2, TextBox txtH, TextBox txtL1, TextBox txtL2, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            b1 = b2 = h = l1 = l2 = 0.0f;
            area = perimeter = 0.0f;

            txtB1.Text = "";
            txtB2.Text = "";
            txtH.Text = "";
            txtL1.Text = "";
            txtL2.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

            txtB1.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas, bool isTrapecio)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkMagenta, 3);
            picCanvas.Refresh();

            float centerX = (picCanvas.Width - Math.Max(b1, b2) * SF) / 2;
            float baseY = (picCanvas.Height + h * SF) / 2;

            PointF[] points;

            if (isTrapecio)
            {
                // Trapecio: un par de lados paralelos
                float x1 = centerX;
                float x2 = x1 + b1 * SF;
                float x3 = centerX + ((b1 - b2) / 2.0f) * SF;
                float x4 = x3 + b2 * SF;

                float y1 = baseY;
                float y2 = baseY;
                float y3 = baseY - h * SF;
                float y4 = baseY - h * SF;

                points = new PointF[] {
            new PointF(x1, y1),
            new PointF(x2, y2),
            new PointF(x4, y4),
            new PointF(x3, y3)
        };
            }
            else
            {
                // Trapezoide: sin lados paralelos (forma general asimétrica)
                float x1 = centerX;
                float x2 = x1 + b1 * SF;
                float x3 = x2 - l2 * SF * 0.4f;
                float x4 = x1 + l1 * SF * 0.4f;

                float y1 = baseY;
                float y2 = baseY;
                float y3 = baseY - h * SF;
                float y4 = baseY - h * SF;

                points = new PointF[] {
            new PointF(x1, y1),
            new PointF(x2, y2),
            new PointF(x3, y3),
            new PointF(x4, y4)
        };
            }

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
