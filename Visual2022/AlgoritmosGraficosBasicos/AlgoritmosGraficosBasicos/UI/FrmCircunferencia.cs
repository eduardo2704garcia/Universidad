using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmosGraficosBasicos.Algoritmos;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmCircunferencia : Form
    {
        public FrmCircunferencia()
        {
            InitializeComponent();
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            //Validaciones de ingreso
            if (!int.TryParse(txtCentroX.Text, out int cx) ||
                !int.TryParse(txtCentroY.Text, out int cy) ||
                !int.TryParse(txtRadio.Text, out int radio))
            {
                MessageBox.Show("Por favor ingresa coordenadas y radio válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Punto centro = new Punto(cx, cy);
            AlgoritmoCircunferencia algoritmo = new AlgoritmoCircunferencia();
            List<Punto> puntos = algoritmo.CalcularCircunferencia(centro, radio);

            int escala = 20;
            int offsetX = 50;
            int offsetY = 50;
            Color fondo = Color.FromArgb(255, 255, 128);

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(fondo);

                //Dinujo plano
                Pen gridPen = new Pen(Color.FromArgb(60, Color.Black), 1);
                for (int x = 0; x < bmp.Width; x += escala)
                    g.DrawLine(gridPen, x, 0, x, bmp.Height);
                for (int y = 0; y < bmp.Height; y += escala)
                    g.DrawLine(gridPen, 0, y, bmp.Width, y);

                //Numeros dle plano
                Font font = new Font("Consolas", 8);
                Brush brush = Brushes.Black;
                for (int x = 0; x < bmp.Width; x += escala)
                {
                    int valorX = (x - offsetX) / escala;
                    g.DrawString(valorX.ToString(), font, brush, x + 1, bmp.Height - offsetY + 2);
                }
                for (int y = 0; y < bmp.Height; y += escala)
                {
                    int valorY = (bmp.Height - y - offsetY) / escala;
                    g.DrawString(valorY.ToString(), font, brush, 1, y + 1);
                }
            }

            picCanvas.Image = bmp;

            //Animacion
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (var punto in puntos)
                {
                    int x = punto.X * escala + offsetX;
                    int y = bmp.Height - (punto.Y * escala + offsetY);

                    if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                    {
                        g.FillRectangle(Brushes.Black, x, y, escala, escala);
                        picCanvas.Image = (Bitmap)bmp.Clone();
                        await Task.Delay(400);
                    }
                }
            }

            //Mostrar numeros 
            dtaPixeles.Columns.Clear();
            dtaPixeles.Rows.Clear();
            dtaPixeles.ColumnCount = 2;
            dtaPixeles.Columns[0].Name = "X";
            dtaPixeles.Columns[1].Name = "Y";

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = fondo,
                ForeColor = Color.Black,
                Font = new Font("Times New Roman", 12, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            dtaPixeles.ColumnHeadersDefaultCellStyle = headerStyle;
            dtaPixeles.DefaultCellStyle.ForeColor = Color.Black;
            dtaPixeles.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dtaPixeles.GridColor = Color.Black;
            dtaPixeles.BorderStyle = BorderStyle.Fixed3D;
            dtaPixeles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtaPixeles.EnableHeadersVisualStyles = false;

            foreach (var punto in puntos)
            {
                dtaPixeles.Rows.Add(punto.X, punto.Y);
            }

            dtaPixeles.AutoResizeColumns();
        }
    }
}
