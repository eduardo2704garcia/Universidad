using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_PP2_Garcia_Eduardo.Algoritmos;
using P2_PP2_Garcia_Eduardo.Services;

namespace P2_PP2_Garcia_Eduardo.UI
{
    public partial class FrmReloj : Form
    {
        public FrmReloj()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = Reloj.GenerarReloj(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.X;
            int y = me.Y;

            if (picCanvas.Image == null) return;

            Bitmap bmp = new Bitmap(picCanvas.Image);
            Color target = bmp.GetPixel(x, y);

            
            if (target.ToArgb() != Color.LightYellow.ToArgb() && target.ToArgb() != Color.Black.ToArgb())
            {
                FloodFill.Rellenar(bmp, x, y, target, Color.Gray);
                picCanvas.Image = bmp;
            }
        }

    }
}
