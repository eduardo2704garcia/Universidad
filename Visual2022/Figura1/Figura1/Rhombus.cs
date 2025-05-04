using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Rhombus
    {
        private float mDiagonalMajor;
        private float mDiagonalMinor;
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10;

        public Rhombus()
        {
            mDiagonalMajor = mDiagonalMinor = mSide = 0.0f;
            mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtD1, TextBox txtD2, TextBox txtSide)
        {
            try
            {
                mDiagonalMajor = float.Parse(txtD1.Text);
                mDiagonalMinor = float.Parse(txtD2.Text);
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Datos no válidos. Intente nuevamente.", "Error");
            }
        }

        public void PerimeterRhombus()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaRhombus()
        {
            mArea = (mDiagonalMajor * mDiagonalMinor) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitData(TextBox txtD1, TextBox txtD2, TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mDiagonalMajor = mDiagonalMinor = mSide = 0.0f;
            mPerimeter = mArea = 0.0f;

            txtD1.Text = ""; txtD2.Text = ""; txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtD1.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);

            float d1 = mDiagonalMajor * SF;
            float d2 = mDiagonalMinor * SF;

            PointF center = new PointF(picCanvas.Width / 2, picCanvas.Height / 2);

            PointF[] rhombus = new PointF[4];
            rhombus[0] = new PointF(center.X, center.Y - d2 / 2); // arriba
            rhombus[1] = new PointF(center.X + d1 / 2, center.Y); // derecha
            rhombus[2] = new PointF(center.X, center.Y + d2 / 2); // abajo
            rhombus[3] = new PointF(center.X - d1 / 2, center.Y); // izquierda

            mGraph.DrawPolygon(mPen, rhombus);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
