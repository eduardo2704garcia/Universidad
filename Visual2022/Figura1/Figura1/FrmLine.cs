using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmLine : Form
    {
        private List<Line> lineas = new List<Line>();
        private Point? puntoAnterior = null;

        public FrmLine()
        {
            InitializeComponent();
            this.Text = "Dibujar lineas continuas con el ratón";
            this.BackColor = Color.White;
            this.DoubleBuffered = true; // parpadeo

            this.MouseClick += FrmLine_MouseClick;
            this.Paint += FrmLine_Paint;
        }

        private void FrmLine_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (puntoAnterior == null)
                {
                    // Primera linea parte desde el origen
                    puntoAnterior = new Point(0, 0);
                }

                Line nuevaLinea = new Line(puntoAnterior.Value, e.Location);
                lineas.Add(nuevaLinea);
                puntoAnterior = e.Location;

                Invalidate(); // Redibuja
            }
        }

        private void FrmLine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen lapiz = new Pen(Color.Black, 2);
            Brush marcador = Brushes.Red;

            foreach (var linea in lineas)
            {
                g.DrawLine(lapiz, linea.Start, linea.End);

                // punto de linea circulo pequeño
                g.FillEllipse(marcador, linea.Start.X - 3, linea.Start.Y - 3, 6, 6);
                g.FillEllipse(marcador, linea.End.X - 3, linea.End.Y - 3, 6, 6);
            }
        }

        private void FrmLine_Load(object sender, EventArgs e)
        {
        }
    }
}
