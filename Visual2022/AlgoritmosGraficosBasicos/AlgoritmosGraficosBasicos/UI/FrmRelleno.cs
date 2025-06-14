using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlgoritmosGraficosBasicos.Graficos;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmRelleno : Form
    {
        private Bitmap bmp;
        private int escala = 20;

        public FrmRelleno()
        {
            InitializeComponent();
            picCanvas.MouseClick += picCanvas_MouseClick;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLado.Text, out int lados) || lados < 3)
            {
                MessageBox.Show("Ingresa un número válido de lados (mínimo 3).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = null;
            dtaPixeles.Rows.Clear();
            dtaPixeles.Columns.Clear();

            //CentroRadio
            float centerX = picCanvas.Width / 2f;
            float centerY = picCanvas.Height / 2f;
            float radio = Math.Min(picCanvas.Width, picCanvas.Height) * 0.25f;

            //Vertices 
            PointF[] puntos = new PointF[lados];
            double angulo = 2 * Math.PI / lados;

            for (int i = 0; i < lados; i++)
            {
                float x = centerX + (float)(radio * Math.Cos(i * angulo - Math.PI / 2));
                float y = centerY + (float)(radio * Math.Sin(i * angulo - Math.PI / 2));
                puntos[i] = new PointF(x, y);
            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(255, 255, 128));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.Black, 2);
                g.DrawPolygon(pen, puntos);
            }

            picCanvas.Image = bmp;
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (bmp == null)
                return;

            int px = e.X;
            int py = e.Y;

            if (px < 0 || py < 0 || px >= bmp.Width || py >= bmp.Height)
                return;

            Color colorObjetivo = bmp.GetPixel(px, py);
            Color colorRelleno = Color.Red;

            //Tabla
            dtaPixeles.Columns.Clear();
            dtaPixeles.Rows.Clear();
            dtaPixeles.Columns.Add("X", "X");
            dtaPixeles.Columns.Add("Y", "Y");

            dtaPixeles.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128);
            dtaPixeles.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtaPixeles.DefaultCellStyle.ForeColor = Color.Black;
            dtaPixeles.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dtaPixeles.GridColor = Color.Black;
            dtaPixeles.BorderStyle = BorderStyle.Fixed3D;
            dtaPixeles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtaPixeles.EnableHeadersVisualStyles = false;

            PixelAnimator animador = new PixelAnimator();
            await animador.RellenarLineaPorLinea(bmp, px, py, colorObjetivo, colorRelleno, picCanvas, dtaPixeles);

            dtaPixeles.Refresh();
        }
    }
}
