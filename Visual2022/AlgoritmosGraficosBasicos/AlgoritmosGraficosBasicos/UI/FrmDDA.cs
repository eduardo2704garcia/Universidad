using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlgoritmosGraficosBasicos.Algoritmos;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmDDA : Form
    {
        public FrmDDA()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //Leo mis cordenadas
            if (!int.TryParse(txtX1.Text, out int x1) ||
                !int.TryParse(txtY1.Text, out int y1) ||
                !int.TryParse(txtX2.Text, out int x2) ||
                !int.TryParse(txtY2.Text, out int y2))
            {
                MessageBox.Show("Por favor ingresa coordenadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Aqui creo puntos
            Punto inicio = new Punto(x1, y1);
            Punto fin = new Punto(x2, y2);

            AlgoritmoDDA dda = new AlgoritmoDDA();
            List<Punto> puntosLinea = dda.CalcularLinea(inicio, fin);

            picCanvas.BackColor = Color.DarkOrchid;

            //Bitmap
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.DarkOrchid);

                int escala = 20;
                int offsetX = 50;
                int offsetY = 50;

                //Cuadricula
                Pen gridPen = new Pen(Color.FromArgb(60, Color.Black), 1);
                for (int x = 0; x < bmp.Width; x += escala)
                {
                    g.DrawLine(gridPen, x, 0, x, bmp.Height);
                }
                for (int y = 0; y < bmp.Height; y += escala)
                {
                    g.DrawLine(gridPen, 0, y, bmp.Width, y);
                }

                //Numero de coordenada
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

                foreach (var punto in puntosLinea)
                {
                    int x = punto.X * escala + offsetX;
                    int y = bmp.Height - (punto.Y * escala + offsetY); //linea

                    if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                    {
                        g.FillRectangle(Brushes.Black, x, y, escala, escala);
                    }
                }
            }

            picCanvas.Image = bmp;

            //Datos tabla
            dtaPixeles.Columns.Clear();
            dtaPixeles.Rows.Clear();
            dtaPixeles.ColumnCount = 2;
            dtaPixeles.Columns[0].Name = "X";
            dtaPixeles.Columns[1].Name = "Y";

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.DarkOrchid,
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

            foreach (var punto in puntosLinea)
            {
                dtaPixeles.Rows.Add(punto.X, punto.Y);
            }

            dtaPixeles.AutoResizeColumns();
        }
    }
}
