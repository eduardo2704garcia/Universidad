using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Ellipse
    {
        private float a; // Eje mayor
        private float b; // Eje menor
        private float area;
        private float perimeter;
        private Graphics mGraph;
        private const float SF = 20; // Escala
        private Pen mPen;

        public Ellipse()
        {
            a = 0.0f;
            b = 0.0f;
            area = 0.0f;
            perimeter = 0.0f;
        }

        public void ReadData(TextBox txtA, TextBox txtB)
        {
            try
            {
                a = float.Parse(txtA.Text);
                b = float.Parse(txtB.Text);
            }
            catch
            {
                MessageBox.Show("Datos inválidos...", "Mensaje de error");
            }
        }

        public void AreaEllipse()
        {
            area = (float)(Math.PI * a * b);
        }

        public void PerimeterEllipse()
        {
            // Fórmula aproximada de Ramanujan
            perimeter = (float)(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))));
        }

        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = area.ToString("F2");
            txtPerimeter.Text = perimeter.ToString("F2");
        }

        public void InitData(TextBox txtA, TextBox txtB, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            a = 0.0f;
            b = 0.0f;
            area = 0.0f;
            perimeter = 0.0f;

            txtA.Text = "";
            txtB.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

            txtA.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            float centerX = (picCanvas.Width - 2 * a * SF) / 2;
            float centerY = (picCanvas.Height - 2 * b * SF) / 2;

            mGraph.DrawEllipse(mPen, centerX, centerY, 2 * a * SF, 2 * b * SF);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
