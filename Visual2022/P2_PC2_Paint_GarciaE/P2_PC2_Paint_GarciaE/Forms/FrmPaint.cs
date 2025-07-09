using System;
using System.Drawing;
using System.Windows.Forms;
using P2_PC2_Paint_GarciaE.DrawingCore;
using P2_PC2_Paint_GarciaE.Tools;

namespace P2_PC2_Paint_GarciaE
{
    public partial class FrmPaint : Form
    {
        private Canvas canvas;
        private Color currentColor = Color.Black;
        private string figuraActiva = null;
        private Point mouseOffset;
        private bool dragging = false;

        private Rectangle? recorteRect = null;
        private Point lineaStart = new Point(30, 30);
        private Point lineaEnd = new Point(300, 300);
        private Point clipStart = new Point(100, 100);
        private Point clipEnd = new Point(250, 250);

        public FrmPaint()
        {
            InitializeComponent();
            this.Load += FrmPaint_Load;
        }

        private void FrmPaint_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            canvas.RenderToPictureBox(picCanvas);

            cbAlgoritmos.Items.AddRange(new string[]
            {
                "Línea",
                "Circunferencia",
                "Curva Bézier",
                "Relleno",
                "Recorte"
            });
            cbAlgoritmos.SelectedIndex = 0;

            cbAlgoritmos.SelectedIndexChanged += CbAlgoritmos_SelectedIndexChanged;

            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
        }

        private void CbAlgoritmos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlgoritmos.SelectedItem.ToString() == "Recorte")
            {
                recorteRect = new Rectangle(clipStart.X, clipStart.Y, clipEnd.X - clipStart.X, clipEnd.Y - clipStart.Y);
                canvas.Clear(Color.White);

                //dlineaycuadro
                DrawGrid();
                LineTool.DrawLine(canvas, lineaStart.X, lineaStart.Y, lineaEnd.X, lineaEnd.Y, currentColor);

                canvas.RenderToPictureBox(picCanvas);
                figuraActiva = null;
            }
            else
            {
                recorteRect = null;
                canvas.Clear(Color.White);
                canvas.RenderToPictureBox(picCanvas);
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (cbAlgoritmos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un algoritmo antes de dibujar.");
                return;
            }

            string algoritmo = cbAlgoritmos.SelectedItem.ToString();

            canvas.Clear(Color.White);

            switch (algoritmo)
            {
                case "Línea":
                    LineTool.DrawLine(canvas, 50, 50, 200, 200, currentColor);
                    figuraActiva = "Linea";
                    break;

                case "Circunferencia":
                    CircleTool.DrawCircle(canvas, 150, 150, 80, currentColor);
                    figuraActiva = null;
                    break;

                case "Curva Bézier":
                    BezierTool.DrawCubicBezier(canvas,
                        new Point(20, 200),
                        new Point(80, 50),
                        new Point(200, 300),
                        new Point(250, 100),
                        currentColor);
                    figuraActiva = "Bezier";
                    break;

                case "Relleno":
                    int cx = canvas.Bitmap.Width / 2;
                    int cy = canvas.Bitmap.Height / 2;
                    int r = 60;
                    int lados = 4;
                    FillTool.DrawAndFillPolygon(canvas, cx, cy, r, lados, Color.Black, currentColor);
                    figuraActiva = null;
                    break;

                case "Recorte":
                    //cuadricula
                    if (recorteRect != null)
                        DrawGrid();

                    //dlinea
                    LineTool.DrawLine(canvas, lineaStart.X, lineaStart.Y, lineaEnd.X, lineaEnd.Y, currentColor);
                    figuraActiva = null;
                    break;

                default:
                    MessageBox.Show("Algoritmo no reconocido.");
                    figuraActiva = null;
                    break;
            }

            canvas.RenderToPictureBox(picCanvas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);
            canvas.RenderToPictureBox(picCanvas);
            figuraActiva = null;
            recorteRect = null;
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            if (recorteRect == null)
            {
                MessageBox.Show("No hay un área de recorte definida.");
                return;
            }

            canvas.Clear(Color.White);

            DrawGrid();

            ClipTool.CohenSutherland(canvas,
                lineaStart.X, lineaStart.Y,
                lineaEnd.X, lineaEnd.Y,
                recorteRect.Value.Left, recorteRect.Value.Top,
                recorteRect.Value.Right, recorteRect.Value.Bottom,
                currentColor);

            canvas.RenderToPictureBox(picCanvas);
        }

        private void DrawGrid()
        {
            if (recorteRect == null) return;

            Color gridColor = Color.Gray;

            LineTool.DrawLine(canvas, recorteRect.Value.Left, recorteRect.Value.Top, recorteRect.Value.Right, recorteRect.Value.Top, gridColor);
            LineTool.DrawLine(canvas, recorteRect.Value.Right, recorteRect.Value.Top, recorteRect.Value.Right, recorteRect.Value.Bottom, gridColor);
            LineTool.DrawLine(canvas, recorteRect.Value.Right, recorteRect.Value.Bottom, recorteRect.Value.Left, recorteRect.Value.Bottom, gridColor);
            LineTool.DrawLine(canvas, recorteRect.Value.Left, recorteRect.Value.Bottom, recorteRect.Value.Left, recorteRect.Value.Top, gridColor);

            //lineasdetro
            //int step = 10;
            //for (int x = recorteRect.Value.Left + step; x < recorteRect.Value.Right; x += step)
            //{
                //LineTool.DrawLine(canvas, x, recorteRect.Value.Top, x, recorteRect.Value.Bottom, gridColor);
            //}
            //for (int y = recorteRect.Value.Top + step; y < recorteRect.Value.Bottom; y += step)
            //{
                //LineTool.DrawLine(canvas, recorteRect.Value.Left, y, recorteRect.Value.Right, y, gridColor);
            //}
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (figuraActiva != null)
            {
                dragging = true;
                mouseOffset = e.Location;
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging && figuraActiva != null)
            {
                canvas.Clear(Color.White);

                int dx = e.X - mouseOffset.X;
                int dy = e.Y - mouseOffset.Y;

                switch (figuraActiva)
                {
                    case "Linea":
                        LineTool.DrawLine(canvas, 50 + dx, 50 + dy, 200 + dx, 200 + dy, currentColor);
                        break;

                    case "Bezier":
                        BezierTool.DrawCubicBezier(canvas,
                            new Point(20 + dx, 200 + dy),
                            new Point(80 + dx, 50 + dy),
                            new Point(200 + dx, 300 + dy),
                            new Point(250 + dx, 100 + dy),
                            currentColor);
                        break;
                }

                canvas.RenderToPictureBox(picCanvas);
            }
        }
    }
}
