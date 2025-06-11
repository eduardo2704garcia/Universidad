using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EjerciciosEnClase
{
    public partial class FrmMargarita : Form
    {
        private float rotacion = 0f;
        private float escala = 1f;
        private PointF desplazamiento = new PointF(0, 0);
        private float lado = 0f;

        public FrmMargarita()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FrmMargarita_Load(object sender, EventArgs e)
        {
            this.KeyDown += FrmMargarita_KeyDown;
        }

        private void FrmMargarita_KeyDown(object sender, KeyEventArgs e)
        {
            float paso = 10f;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    desplazamiento.Y -= paso;
                    break;
                case Keys.Down:
                    desplazamiento.Y += paso;
                    break;
                case Keys.Left:
                    desplazamiento.X -= paso;
                    break;
                case Keys.Right:
                    desplazamiento.X += paso;
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    escala *= 1.1f;
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    escala *= 0.9f;
                    break;
                case Keys.R:
                    rotacion += 0.1f;
                    break;
                case Keys.T:
                    rotacion -= 0.1f;
                    break;
            }

            btnCalculate.PerformClick(); // Redibuja
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtLado.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor que 0.");
                return;
            }

            Margarita margarita = new Margarita(lado);
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                g.TranslateTransform(picCanvas.Width / 2f + desplazamiento.X, picCanvas.Height / 2f + desplazamiento.Y);
                g.ScaleTransform(escala, escala);
                g.RotateTransform(rotacion * 180f / (float)Math.PI); // de radianes a grados

                List<PointF[]> figuras = margarita.ObtenerPentagonosFlor(new PointF(0, 0));

                foreach (PointF[] pentagono in figuras)
                {
                    g.FillPolygon(Brushes.IndianRed, pentagono);
                    g.DrawPolygon(Pens.Red, pentagono);
                }

                g.ResetTransform();
            }

            picCanvas.Image = bmp;
        }
    }
}
