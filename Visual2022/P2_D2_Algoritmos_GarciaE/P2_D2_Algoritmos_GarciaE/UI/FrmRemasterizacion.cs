using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Core.Remasterizacion;
using P2_D2_Algoritmos_GarciaE.Interfaces;

namespace P2_D2_Algoritmos_GarciaE.UI
{
    public partial class FrmRemasterizacion : Form
    {
        private List<Point> puntos = new List<Point>();

        public FrmRemasterizacion()
        {
            InitializeComponent();
            this.Load += FrmRemasterizacion_Load;
        }

        private void FrmRemasterizacion_Load(object sender, EventArgs e)
        {
            cbAlgoritmo.Items.Add("DDA");
            cbAlgoritmo.Items.Add("Bresenham Línea");
            cbAlgoritmo.Items.Add("Bresenham Círculo");
            cbAlgoritmo.Items.Add("Bresenham Elipse");
            cbAlgoritmo.SelectedIndex = -1;
            cbAlgoritmo.Text = "Seleccione un algoritmo";
            DibujarPlanoCartesiano();

            //Estilo Visual
            Color colorNormal = Color.FromArgb(234, 221, 186);
            btnDibujar.BackColor = colorNormal;
            btnLimpiar.BackColor = colorNormal;
            btnVolver.BackColor = colorNormal;

            btnDibujar.ForeColor = Color.FromArgb(87, 70, 46);
            btnLimpiar.ForeColor = Color.FromArgb(87, 70, 46);
            btnVolver.ForeColor = Color.FromArgb(87, 70, 46);

            btnDibujar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatStyle = FlatStyle.Flat;

            btnDibujar.Cursor = Cursors.Hand;
            btnLimpiar.Cursor = Cursors.Hand;
            btnVolver.Cursor = Cursors.Hand;

            //Hover Boton
            btnDibujar.MouseEnter += btn_MouseEnter;
            btnDibujar.MouseLeave += btn_MouseLeave;
            btnLimpiar.MouseEnter += btn_MouseEnter;
            btnLimpiar.MouseLeave += btn_MouseLeave;
            btnVolver.MouseEnter += btn_MouseEnter;
            btnVolver.MouseLeave += btn_MouseLeave;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(214, 201, 160);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(234, 221, 186);
        }

        private void DibujarPlanoCartesiano()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.WhiteSmoke);

                Pen eje = new Pen(Color.LightGray, 1);
                for (int i = 0; i < picCanvas.Width; i += 20)
                    g.DrawLine(eje, i, 0, i, picCanvas.Height);
                for (int i = 0; i < picCanvas.Height; i += 20)
                    g.DrawLine(eje, 0, i, picCanvas.Width, i);

                Pen ejeXY = new Pen(Color.Gray, 2);
                g.DrawLine(ejeXY, 0, picCanvas.Height / 2, picCanvas.Width, picCanvas.Height / 2);
                g.DrawLine(ejeXY, picCanvas.Width / 2, 0, picCanvas.Width / 2, picCanvas.Height);
            }

            picCanvas.Image = bmp;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            if (puntos.Count >= 2) return;

            MouseEventArgs me = (MouseEventArgs)e;
            Point punto = me.Location;
            puntos.Add(punto);

            using (Graphics g = Graphics.FromImage(picCanvas.Image))
            {
                int size = 6;
                Brush brush = Brushes.Red;
                g.FillEllipse(brush, punto.X - size / 2, punto.Y - size / 2, size, size);
            }
            picCanvas.Invalidate();

            lblPuntos.Text = $"Puntos: {string.Join(" | ", puntos.Select(p => $"({p.X},{p.Y})"))}";
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            if (cbAlgoritmo.SelectedIndex == -1 || puntos.Count < 2)
            {
                MessageBox.Show("Seleccione un algoritmo y dos puntos primero.");
                return;
            }

            string algoritmo = cbAlgoritmo.SelectedItem.ToString();
            IAnimable animable = null;

            switch (algoritmo)
            {
                case "DDA":
                    animable = new DDA();
                    break;
                case "Bresenham Línea":
                    animable = new BresenhamLinea();
                    break;
                case "Bresenham Círculo":
                    animable = new BresenhamCirculo();
                    break;
                case "Bresenham Elipse":
                    animable = new BresenhamElipse();
                    break;
            }

            if (animable != null)
            {
                using (Graphics g = Graphics.FromImage(picCanvas.Image))
                {
                    await animable.Animar(g, puntos, picCanvas, 10);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            puntos.Clear();
            lblPuntos.Text = "Puntos: ";
            DibujarPlanoCartesiano();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
