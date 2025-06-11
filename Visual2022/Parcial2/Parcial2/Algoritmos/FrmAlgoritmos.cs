using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial2.Algoritmos
{
    public partial class FrmAlgoritmos : Form
    {
        private Bitmap canvasBitmap;
        private Graphics g;

        public FrmAlgoritmos()
        {
            InitializeComponent();

            // Inicializamos el bitmap y graphics para el canvas
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(canvasBitmap);
            g.Clear(Color.White);
            picCanvas.Image = canvasBitmap;
        }

        private void btncalculate_click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(Color.White);

                // Dibujar ejes X y Y
                Pen axisPen = new Pen(Color.Gray, 1);

                // Origen en la esquina inferior izquierda
                int origenX = 40; // margen para eje Y
                int origenY = picCanvas.Height - 40; // margen para eje X

                // Dibujar eje X
                g.DrawLine(axisPen, origenX, origenY, picCanvas.Width - 10, origenY);
                // Dibujar eje Y
                g.DrawLine(axisPen, origenX, origenY, origenX, 10);

                // Dibujar marcas y números (por ejemplo, de 0 a 10)
                for (int i = 0; i <= 10; i++)
                {
                    int xMarca = origenX + i * 40;
                    int yMarca = origenY - i * 40;

                    // Marcas eje X
                    g.DrawLine(axisPen, xMarca, origenY - 5, xMarca, origenY + 5);
                    g.DrawString(i.ToString(), this.Font, Brushes.Black, xMarca - 5, origenY + 5);

                    // Marcas eje Y
                    g.DrawLine(axisPen, origenX - 5, yMarca, origenX + 5, yMarca);
                    g.DrawString(i.ToString(), this.Font, Brushes.Black, origenX - 25, yMarca - 7);
                }

                // Leer puntos
                string[] inicial = txtInitialPoint.Text.Split(',');
                string[] final = txtFinalPoint.Text.Split(',');

                int escala = 40;

                int x0 = int.Parse(inicial[0]);
                int y0 = int.Parse(inicial[1]);
                int x1 = int.Parse(final[0]);
                int y1 = int.Parse(final[1]);

                // Transformar puntos al sistema de dibujo (origen abajo a la izquierda)
                Point p0 = new Point(origenX + x0 * escala, origenY - y0 * escala);
                Point p1 = new Point(origenX + x1 * escala, origenY - y1 * escala);

                List<Point> puntos = new List<Point>();

                if (DDA.Checked)
                    puntos = AlgoritmoDDA.Calcular(p0.X, p0.Y, p1.X, p1.Y);
                else if (Breseham.Checked)
                    puntos = AlgoritmoBreseham.Calcular(p0.X, p0.Y, p1.X, p1.Y);
                else if (PuntoMedio.Checked)
                    puntos = AlgoritmoPuntoMedio.Calcular(p0.X, p0.Y, p1.X, p1.Y);
                else
                {
                    MessageBox.Show("Seleccione un algoritmo");
                    return;
                }

                // Dibujar puntos (más visibles)
                foreach (var p in puntos)
                {
                    g.FillRectangle(Brushes.Red, p.X, p.Y, 5, 5);
                }

                picCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Error: Asegúrese de ingresar puntos válidos en formato x,y");
            }
        }

        private void btnclean_click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picCanvas.Refresh();

            txtInitialPoint.Clear();
            txtFinalPoint.Clear();
            DDA.Checked = false;
            Breseham.Checked = false;
            PuntoMedio.Checked = false;
        }
    }
}
