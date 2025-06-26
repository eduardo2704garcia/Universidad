using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Interfaces;
using P2_D2_Algoritmos_GarciaE.Core.Curvas;

namespace P2_D2_Algoritmos_GarciaE.UI
{
    public partial class FrmCurvas : Form
    {
        private List<PointF> puntosControl = new List<PointF>();
        private bool arrastrando = false;
        private int puntoSeleccionado = -1;

        public FrmCurvas()
        {
            InitializeComponent();
            this.Load += FrmCurvas_Load;
        }

        private void FrmCurvas_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 52, 64);
            picCanvas.BackColor = Color.FromArgb(236, 239, 244);
            btnDibujar.BackColor = btnLimpiar.BackColor = btnVolver.BackColor = Color.FromArgb(94, 129, 172);
            btnDibujar.ForeColor = btnLimpiar.ForeColor = btnVolver.ForeColor = Color.FromArgb(236, 239, 244);
            lblPuntos.ForeColor = Color.FromArgb(216, 222, 233);

            btnDibujar.MouseEnter += (s, ev) => btnDibujar.BackColor = Color.FromArgb(129, 161, 193);
            btnDibujar.MouseLeave += (s, ev) => btnDibujar.BackColor = Color.FromArgb(94, 129, 172);
            btnLimpiar.MouseEnter += (s, ev) => btnLimpiar.BackColor = Color.FromArgb(129, 161, 193);
            btnLimpiar.MouseLeave += (s, ev) => btnLimpiar.BackColor = Color.FromArgb(94, 129, 172);
            btnVolver.MouseEnter += (s, ev) => btnVolver.BackColor = Color.FromArgb(129, 161, 193);
            btnVolver.MouseLeave += (s, ev) => btnVolver.BackColor = Color.FromArgb(94, 129, 172);

            cbCurva.Items.Add("Bezier Lineal");
            cbCurva.Items.Add("Bezier Cuadrática");
            cbCurva.Items.Add("Bezier Cúbica");
            cbCurva.Items.Add("B-Spline");
            cbCurva.SelectedIndex = -1;
            cbCurva.Text = "Seleccione una curva";
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            if (cbCurva.SelectedIndex == -1) return;

            IFiguraCurva curva = ObtenerCurvaSeleccionada();
            if (curva == null) return;

            if (puntosControl.Count >= curva.MinimoPuntos)
            {
                MessageBox.Show($"Esta curva requiere solo {curva.MinimoPuntos} puntos.");
                return;
            }

            Point punto = ((MouseEventArgs)e).Location;
            puntosControl.Add(punto);
            Redibujar();
        }


        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < puntosControl.Count; i++)
            {
                if (Distance(puntosControl[i], e.Location) < 10)
                {
                    arrastrando = true;
                    puntoSeleccionado = i;
                    break;
                }
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando && puntoSeleccionado != -1)
            {
                puntosControl[puntoSeleccionado] = e.Location;
                Redibujar();
            }
        }

        private void picCanvas_MouseUp(object sender, EventArgs e)
        {
            arrastrando = false;
            puntoSeleccionado = -1;
        }

        private float Distance(PointF a, PointF b)
        {
            return (float)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        private void Redibujar()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(236, 239, 244));

                foreach (var p in puntosControl)
                    g.FillEllipse(Brushes.IndianRed, p.X - 4, p.Y - 4, 8, 8);

                if (cbCurva.SelectedIndex != -1)
                {
                    IFiguraCurva curva = ObtenerCurvaSeleccionada();
                    if (curva != null && puntosControl.Count >= curva.MinimoPuntos)
                    {
                        List<PointF> puntos = curva.CalcularPuntos(puntosControl);
                        curva.Dibujar(g, puntos, new Pen(Color.FromArgb(136, 192, 208), 2));
                    }
                }
            }

            picCanvas.Image = bmp;
            lblPuntos.Text = "Puntos: " + string.Join(" | ", puntosControl.Select(p => $"({p.X:F0},{p.Y:F0})"));
        }

        private IFiguraCurva ObtenerCurvaSeleccionada()
        {
            string seleccion = cbCurva.SelectedItem.ToString();
            if (seleccion == "Bezier Lineal")
                return new BezierLineal();
            else if (seleccion == "Bezier Cuadrática")
                return new BezierCuadratica();
            else if (seleccion == "Bezier Cúbica")
                return new BezierCubica();
            else if (seleccion == "B-Spline")
                return new BSpline();
            else
                return null;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (cbCurva.SelectedIndex == -1 || puntosControl.Count < 2)
            {
                MessageBox.Show("Seleccione una curva y defina al menos 2 puntos.");
                return;
            }

            Redibujar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            puntosControl.Clear();
            picCanvas.Image = null;
            lblPuntos.Text = "Puntos: ";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
