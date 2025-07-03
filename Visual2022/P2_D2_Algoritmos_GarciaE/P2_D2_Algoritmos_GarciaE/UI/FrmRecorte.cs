using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.Core.Recorte;

namespace P2_D2_Algoritmos_GarciaE.UI
{
    public partial class FrmRecorte : Form
    {
        private List<Point> puntosFigura = new List<Point>();
        private Rectangle ventanaRecorte;
        private bool dibujandoVentana = false;
        private Point puntoInicioVentana;
        private string tipoRecorte = "Línea";

        public FrmRecorte()
        {
            InitializeComponent();
            AplicarEstilos();
            InicializarCanvas();
        }

        private void AplicarEstilos()
        {
            this.BackColor = Color.FromArgb(255, 192, 255);
            Color colorNormal = Color.MediumOrchid;
            Color colorHover = Color.Orchid;
            Color textoBoton = Color.White;
            Color bordeBoton = Color.Purple;

            // Botones
            Button[] botones = { btnDibujarVentana, btnRecortar, btnLimpiar, btnVolver };
            foreach (Button btn in botones)
            {
                btn.BackColor = colorNormal;
                btn.ForeColor = textoBoton;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;
                btn.FlatAppearance.BorderColor = bordeBoton;
                btn.FlatAppearance.BorderSize = 2;

                btn.MouseEnter += (s, e) => ((Button)s).BackColor = colorHover;
                btn.MouseLeave += (s, e) => ((Button)s).BackColor = colorNormal;
            }

            cbAlgoritmo.Items.Clear();
            cbAlgoritmo.Items.Add("Seleccione un recorte");
            cbAlgoritmo.Items.Add("Línea");
            cbAlgoritmo.Items.Add("Polígono");
            cbAlgoritmo.SelectedIndex = 0;
            cbAlgoritmo.SelectedIndexChanged += (s, e) =>
            {
                if (cbAlgoritmo.SelectedIndex == 0)
                {
                    tipoRecorte = null;
                }
                else
                {
                    tipoRecorte = cbAlgoritmo.SelectedItem.ToString();
                }
            };
        }


        private void InicializarCanvas()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
                g.Clear(Color.Lavender);
            picCanvas.Image = bmp;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            if (dibujandoVentana) return;

            puntosFigura.Add(me.Location);
            using (Graphics g = Graphics.FromImage(picCanvas.Image))
            {
                g.FillEllipse(Brushes.DarkSlateBlue, me.X - 3, me.Y - 3, 6, 6);
                if (tipoRecorte == "Línea" && puntosFigura.Count == 2)
                {
                    g.DrawLine(new Pen(Color.DarkSlateBlue, 1.5f), puntosFigura[0], puntosFigura[1]);
                }
                else if (tipoRecorte == "Polígono" && puntosFigura.Count > 1)
                {
                    g.DrawLine(Pens.Blue, puntosFigura[puntosFigura.Count - 2], puntosFigura[puntosFigura.Count - 1]);
                }
            }
            picCanvas.Invalidate();
            lblPuntos.Text = $"Puntos: {puntosFigura.Count}";
        }

        private void btnDibujarVentana_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz clic y arrastra con el mouse sobre el canvas para dibujar la ventana.");
            dibujandoVentana = true;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseUp += picCanvas_MouseUp;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!dibujandoVentana) return;
            puntoInicioVentana = e.Location;
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!dibujandoVentana) return;

            int x = Math.Min(puntoInicioVentana.X, e.X);
            int y = Math.Min(puntoInicioVentana.Y, e.Y);
            int w = Math.Abs(puntoInicioVentana.X - e.X);
            int h = Math.Abs(puntoInicioVentana.Y - e.Y);

            ventanaRecorte = new Rectangle(x, y, w, h);

            using (Graphics g = Graphics.FromImage(picCanvas.Image))
                g.DrawRectangle(Pens.Red, ventanaRecorte);

            picCanvas.Invalidate();
            dibujandoVentana = false;
            picCanvas.MouseDown -= picCanvas_MouseDown;
            picCanvas.MouseUp -= picCanvas_MouseUp;
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            if (ventanaRecorte == Rectangle.Empty || puntosFigura.Count < 2)
            {
                MessageBox.Show("Dibuja la ventana y agrega al menos 2 puntos.");
                return;
            }

            using (Graphics g = Graphics.FromImage(picCanvas.Image))
            {
                Pen penRecorte = new Pen(Color.MidnightBlue, 2);

                if (tipoRecorte == "Línea")
                {
                    Point p1, p2;
                    if (CohenSutherland.RecortarLinea(puntosFigura[0], puntosFigura[1], ventanaRecorte, out p1, out p2))
                    {
                        g.DrawLine(penRecorte, p1, p2);
                    }
                }
                else if (tipoRecorte == "Polígono" && puntosFigura.Count >= 3)
                {
                    var poligonoRecortado = SutherlandHodgman.ClipPolygon(puntosFigura, ventanaRecorte);

                    if (poligonoRecortado.Count > 1)
                    {
                        for (int i = 0; i < poligonoRecortado.Count; i++)
                        {
                            Point p1 = poligonoRecortado[i];
                            Point p2 = poligonoRecortado[(i + 1) % poligonoRecortado.Count];
                            g.DrawLine(penRecorte, p1, p2);
                        }
                    }
                }
            }

            picCanvas.Invalidate();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            puntosFigura.Clear();
            ventanaRecorte = Rectangle.Empty;
            InicializarCanvas();
            lblPuntos.Text = "Puntos: 0";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
