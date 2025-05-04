using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura1
{
    internal class Square
    {
        private float mWidth;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Square()
        {
            this.mWidth = 0.0f;
            this.mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtWidth)
        {
            try
            {
                this.mWidth = float.Parse(txtWidth.Text);
            }
            catch 
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }
        }

        public void PerimeterSquare()
        {
            this.mPerimeter = 4 * mWidth;
        }

        public void AreaSquare()
        {
            this.mArea = mWidth * mWidth;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
        }

        public void InitData(TextBox txtWidth, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mWidth = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtWidth.Text = ""; txtArea.Text = "";
            txtPerimeter.Text = "";

            txtWidth.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mWidth * SF);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
