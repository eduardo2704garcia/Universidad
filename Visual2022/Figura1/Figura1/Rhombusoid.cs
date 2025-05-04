using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    public class Rhombusoid
    {
        private double baseLength, height, side;
        private double area, perimeter;

        public void InitData(TextBox txtBase, TextBox txtHeight, TextBox txtSide,
                             TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtBase.Clear();
            txtHeight.Clear();
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            picCanvas.Refresh();
        }

        public void ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtSide)
        {
            baseLength = Convert.ToDouble(txtBase.Text);
            height = Convert.ToDouble(txtHeight.Text);
            side = Convert.ToDouble(txtSide.Text);
        }

        public void PerimeterRhombusoid()
        {
            perimeter = 2 * (baseLength + side);
        }

        public void AreaRhombusoid()
        {
            area = baseLength * height;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString("F2");
            txtArea.Text = area.ToString("F2");
        }

        public void PlotShape(PictureBox picCanvas)
        {
            Graphics g = picCanvas.CreateGraphics();
            g.Clear(picCanvas.BackColor);

            Pen pen = new Pen(Color.Blue, 2);

            // Dibujamos un paralelogramo con ángulo inclinado
            Point[] points = {
                new Point(40, 100),
                new Point(80, 40),
                new Point(180, 40),
                new Point(140, 100)
            };

            g.DrawPolygon(pen, points);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
