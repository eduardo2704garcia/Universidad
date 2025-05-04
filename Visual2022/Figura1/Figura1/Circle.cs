using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Circle
    {
        private float mRadius;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Circle()
        {
            this.mRadius = 0.0f;
            this.mPerimeter = 0.0f;
            this.mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                this.mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterCircle()
        {
            this.mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        public void AreaCircle()
        {
            this.mArea = (float)Math.PI * mRadius * mRadius;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString("F2");
            txtPerimeter.Text = mPerimeter.ToString("F2");
        }

        public void InitData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mRadius = 0.0f;
            this.mPerimeter = 0.0f;
            this.mArea = 0.0f;

            txtRadius.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Red, 3);
            float diameter = mRadius * 2 * SF;
            mGraph.DrawEllipse(mPen, 0, 0, diameter, diameter);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
