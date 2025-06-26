using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Models;
using P2_D2_Algoritmos_GarciaE.Services;
using P2_D2_Algoritmos_GarciaE.Core.Relleno;

namespace P2_D2_Algoritmos_GarciaE.UI
{
    public partial class FrmRelleno : Form
    {
        private Figura figura;
        private Bitmap bmp;
        private PixelAnimator animador = new PixelAnimator();

        public FrmRelleno()
        {
            InitializeComponent();
            AplicarEstilos();

            cbRelleno.Items.Add("Selecciona un algoritmo");
            cbRelleno.Items.Add("Flood Fill");
            cbRelleno.Items.Add("Scanline Fill");
            cbRelleno.SelectedIndex = 0;

            picCanvas.MouseClick += picCanvas_MouseClick;
        }

        private void AplicarEstilos()
        {
            Color colorNormal = Color.FromArgb(244, 208, 63);     
            Color colorHover = Color.FromArgb(212, 172, 13);       
            Color colorBorde = Color.FromArgb(255, 193, 7);        
            Color textoBoton = Color.White;

            Button[] botones = { btnDibujar, btnLimpiar, btnVolver };

            foreach (var btn in botones)
            {
                btn.BackColor = colorNormal;
                btn.ForeColor = textoBoton;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = colorBorde;
                btn.Cursor = Cursors.Hand;

                btn.MouseEnter += (s, e) => ((Button)s).BackColor = colorHover;
                btn.MouseLeave += (s, e) => ((Button)s).BackColor = colorNormal;
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPuntos.Text, out int lados) || lados < 3)
            {
                MessageBox.Show("Ingrese un número válido de lados (mínimo 3).");
                return;
            }

            int centroX = picCanvas.Width / 2;
            int centroY = picCanvas.Height / 2;
            int radio = Math.Min(picCanvas.Width, picCanvas.Height) / 5;

            figura = new Figura(lados, centroX, centroY, radio);

            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
            animador.DibujarPoligono(figura.Puntos, picCanvas, Color.Black);
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (bmp == null || figura == null)
                return;

            int x = e.X;
            int y = e.Y;

            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return;

            Color colorObjetivo = bmp.GetPixel(x, y);
            Color colorRelleno = Color.Red;
            int velocidad = 2;

            string algoritmo = cbRelleno.SelectedItem.ToString();

            if (algoritmo == "Flood Fill")
            {
                await animador.RellenarLineaPorLinea(bmp, x, y, colorObjetivo, colorRelleno, picCanvas, velocidad);
            }
            else if (algoritmo == "Scanline Fill")
            {
                SkilineFill scanline = new SkilineFill();
                await scanline.Rellenar(bmp, figura.Puntos, colorRelleno, picCanvas, velocidad);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            picCanvas.Image = null;
            bmp = null;
            figura = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
