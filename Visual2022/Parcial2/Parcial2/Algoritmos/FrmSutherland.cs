using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2.Algoritmos
{
    public partial class FrmSutherland : Form
    {
        public FrmSutherland()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX1.Text, out int x1) ||
                !int.TryParse(txtY1.Text, out int y1) ||
                !int.TryParse(txtX2.Text, out int x2) ||
                !int.TryParse(txtY2.Text, out int y2))
            {
                MessageBox.Show("Coordenadas inválidas");
                return;
            }

            //Rectangulo 
            int xmin = 100, ymin = 100, xmax = 300, ymax = 200;

            
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                Pen recortePen = new Pen(Color.Red, 2);
                g.DrawRectangle(recortePen, xmin, ymin, xmax - xmin, ymax - ymin);

                AlgoritmoCohenSutherland algoritmo = new AlgoritmoCohenSutherland(xmin, ymin, xmax, ymax);
                if (algoritmo.RecortarLinea(ref x1, ref y1, ref x2, ref y2))
                {
                    Pen lineaPen = new Pen(Color.White, 2);
                    g.DrawLine(lineaPen, x1, y1, x2, y2);
                }
            }

            picCanvas.Image = bmp;
        }

    }
}
