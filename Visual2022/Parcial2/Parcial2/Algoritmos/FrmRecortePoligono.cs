using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial2.Algoritmos
{
    public partial class FrmRecortePoligono : Form
    {
        private List<Point> vertices = new List<Point>();
        private Bitmap bmp;
        private Graphics g;
        private Rectangle rectRecorte = new Rectangle(100, 100, 200, 150); // xmin, ymin, width, height

        public FrmRecortePoligono()
        {
            InitializeComponent();
            picCanvas.Click += picCanvas_Click;
            this.DoubleBuffered = true;

            btnRecortar.Click += btnRecortar_Click;
            this.Controls.Add(btnRecortar);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            vertices.Add(me.Location);

            RedibujarTodo();
        }


        private void RedibujarTodo()
        {
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            //Rectangulo
            g.DrawRectangle(new Pen(Color.Red, 2), rectRecorte);

            //Original
            if (vertices.Count >= 2)
            {
                g.DrawPolygon(Pens.White, vertices.ToArray());
            }
            else if (vertices.Count == 1)
            {
                g.FillEllipse(Brushes.Yellow, vertices[0].X - 2, vertices[0].Y - 2, 4, 4);
            }

            picCanvas.Image = bmp;
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            if (vertices.Count < 3)
            {
                MessageBox.Show("Dibuja al menos un polígono con 3 vértices.");
                return;
            }

            AlgoritmoRecortePoligono recorte = new AlgoritmoRecortePoligono();
            List<Point> poligonoRecortado = recorte.RecortarPoligono(vertices, rectRecorte);

            RedibujarTodo(); 
            if (poligonoRecortado.Count >= 3)
            {
                g.DrawPolygon(new Pen(Color.Orange, 2), poligonoRecortado.ToArray());
                picCanvas.Image = bmp;
            }
            else
            {
                MessageBox.Show("El polígono quedó totalmente fuera del área de recorte.");
            }
        }
    }
}
