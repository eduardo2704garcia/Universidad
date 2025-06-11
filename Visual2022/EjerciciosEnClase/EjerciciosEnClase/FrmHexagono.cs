using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosEnClase
{
    public partial class FrmHexagono : Form
    {
        public FrmHexagono()
        {
            InitializeComponent();
        }

        private void FrmHexagono_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validar entrada
            if (!float.TryParse(txtRadius.Text, out float radio) || radio <= 0)
            {
                MessageBox.Show("Ingresa un valor correcto.");
                return;
            }

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            Point centro = new Point(centerX, centerY);

            PointF[] vertices = Hexagono.CalcularVertices(centro, radio);

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                Pen penTriangulos = new Pen(Color.Yellow, 2);

                for (int i = 0; i < 6; i++)
                {
                    PointF punto1 = vertices[i];
                    PointF punto2 = vertices[(i + 1) % 6];

                    g.DrawLine(penTriangulos, centro, punto1);

                    g.DrawLine(penTriangulos, centro, punto2);

                    g.DrawLine(penTriangulos, punto1, punto2);
                }

                Pen penHexagono = new Pen(Color.Red, 6);
                g.DrawPolygon(penHexagono, vertices);
            }

            picCanvas.Image = bmp;
        }
    }
}
