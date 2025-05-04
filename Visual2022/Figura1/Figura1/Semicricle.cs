using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    internal class Semicircle
    {
        private float r;
        private float area;
        private float perimeter;
        private Graphics mGraph;
        private const float SF = 20; // Escala
        private Pen mPen;

        public Semicircle()
        {
            r = 0.0f;
            area = 0.0f;
            perimeter = 0.0f;
        }

        public void ReadData(TextBox txtR)
        {
            try
            {
                r = float.Parse(txtR.Text);
            }
            catch
            {
                MessageBox.Show("Dato inválido...", "Mensaje de error");
            }
        }

        public void AreaSemicircle()
        {
            area = (float)(0.5 * Math.PI * r * r);
        }

        public void PerimeterSemicircle()
        {
            perimeter = (float)(Math.PI * r + 2 * r); // arco + diámetro
        }

        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = area.ToString("F2");
            txtPerimeter.Text = perimeter.ToString("F2");
        }

        public void InitData(TextBox txtR, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            r = 0.0f;
            area = 0.0f;
            perimeter = 0.0f;

            txtR.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

            txtR.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkGreen, 3);

            float centerX = (picCanvas.Width - 2 * r * SF) / 2;
            float centerY = (picCanvas.Height - r * SF) / 2 + r * SF;

            // Arco superior del semicírculo
            mGraph.DrawArc(mPen, centerX, centerY - r * SF, 2 * r * SF, 2 * r * SF, 0, 180);

            // Línea del diámetro
            mGraph.DrawLine(mPen, centerX, centerY, centerX + 2 * r * SF, centerY);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
