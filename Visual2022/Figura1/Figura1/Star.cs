using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Star
    {
        private float mBase, mAltura, mLado;
        private float mArea, mPerimeter;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 5;

        public Star()
        {
            mBase = mAltura = mLado = 0;
            mArea = mPerimeter = 0;
        }

        public void ReadData(TextBox txtBase, TextBox txtAltura, TextBox txtLado)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mAltura = float.Parse(txtAltura.Text);
                mLado = float.Parse(txtLado.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

        public void AreaStar()
        {
            mArea = 5 * (mBase * mAltura) / 2;
        }

        public void PerimeterStar()
        {
            mPerimeter = 10 * mLado;
        }

        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
        }

        public void InitData(TextBox txtBase, TextBox txtAltura, TextBox txtLado, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            mBase = mAltura = mLado = 0;
            mArea = mPerimeter = 0;

            txtBase.Text = "";
            txtAltura.Text = "";
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 2);

            PointF[] points = new PointF[10];

            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;
            float outerRadius = mAltura * SF;
            float innerRadius = (mAltura / 2) * SF;

            for (int i = 0; i < 10; i++)
            {
                double angle = Math.PI / 5 * i;
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;

                points[i] = new PointF(
                    cx + (float)(radius * Math.Sin(angle)),
                    cy - (float)(radius * Math.Cos(angle))
                );
            }

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
