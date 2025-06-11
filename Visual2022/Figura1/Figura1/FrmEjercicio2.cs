using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmEjercicio2 : Form
    {
        Ejercicio2 figura;

        public FrmEjercicio2()
        {
            InitializeComponent();
            figura = new Ejercicio2();
        }

        private void FrmEjercicio2_Load(object sender, EventArgs e)
        {
            Dibujar();
        }

        private void tkProgres_Scroll(object sender, EventArgs e)
        {
            Dibujar();
        }

        private void Dibujar()
        {
            int n = tkProgres.Value;

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            figura.DibujarRomboide(g, picCanvas.Width, picCanvas.Height, n);

            picCanvas.Image = bmp;
        }
    }
}
