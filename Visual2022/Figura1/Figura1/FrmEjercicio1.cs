using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmEjercicio1 : Form
    {
        Ejercicio1 figura;

        public FrmEjercicio1()
        {
            InitializeComponent();
            figura = new Ejercicio1();
        }

        private void FrmEjercicio1_Load(object sender, EventArgs e)
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

            figura.DibujarRombo(g, picCanvas.Width, picCanvas.Height, n);

            picCanvas.Image = bmp;
        }
    }
}
