using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    public class Deltoid
    {
        private double dMajor, dMinor, sideA, sideB;
        private double area, perimeter;

        public void InitData(TextBox txtDmajor, TextBox txtDminor, TextBox txtSideA, TextBox txtSideB,
                             TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtDmajor.Clear();
            txtDminor.Clear();
            txtSideA.Clear();
            txtSideB.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            picCanvas.Refresh();
        }

        public void ReadData(TextBox txtDmajor, TextBox txtDminor, TextBox txtSideA, TextBox txtSideB)
        {
            dMajor = Convert.ToDouble(txtDmajor.Text);
            dMinor = Convert.ToDouble(txtDminor.Text);
            sideA = Convert.ToDouble(txtSideA.Text);
            sideB = Convert.ToDouble(txtSideB.Text);
        }

        public void PerimeterDeltoid()
        {
            perimeter = 2 * (sideA + sideB);
        }

        public void AreaDeltoid()
        {
            area = (dMajor * dMinor) / 2;
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

            Pen pen = new Pen(Color.DarkGreen, 2);

            // Dibujamos un deltoide idealizado (cometa)
            Point[] points = {
                new Point(120, 30),  // Punto superior (vértice de lado A)
                new Point(60, 100),  // Izquierda (lado B)
                new Point(120, 170), // Inferior (vértice opuesto)
                new Point(180, 100), // Derecha (lado B)
            };

            g.DrawPolygon(pen, points);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
