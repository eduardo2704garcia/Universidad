using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Triangle
    {
        private float mBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; // Escala de dibujo
        private Pen mPen;

        public Triangle()
        {
            this.mBase = 0.0f;
            this.mHeight = 0.0f;
            this.mPerimeter = 0.0f;
            this.mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtHeight)
        {
            try
            {
                this.mBase = float.Parse(txtBase.Text);
                this.mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterTriangle()
        {
            // Suponemos triángulo isósceles
            float lado = (float)Math.Sqrt(Math.Pow(mBase / 2, 2) + Math.Pow(mHeight, 2));
            this.mPerimeter = 2 * lado + mBase;
        }

        public void AreaTriangle()
        {
            this.mArea = (mBase * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString("F2");
            txtPerimeter.Text = mPerimeter.ToString("F2");
        }

        public void InitData(TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mBase = 0.0f;
            this.mHeight = 0.0f;
            this.mPerimeter = 0.0f;
            this.mArea = 0.0f;

            txtBase.Text = "";
            txtHeight.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);

            // Coordenadas de los 3 vértices (isósceles centrado)
            PointF A = new PointF((mBase / 2) * SF, 0);
            PointF B = new PointF(0, mHeight * SF);
            PointF C = new PointF(mBase * SF, mHeight * SF);

            mGraph.DrawPolygon(mPen, new PointF[] { A, B, C });
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
