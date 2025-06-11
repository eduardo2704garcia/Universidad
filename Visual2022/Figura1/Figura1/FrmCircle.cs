using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmCircle : Form
    {
        private Circle circle = new Circle();
        private static FrmCircle formulario;

        public FrmCircle()
        {
            InitializeComponent();
        }

        public static FrmCircle callForm
        {
            get
            {
                if (formulario == null || formulario.IsDisposed)
                {
                    formulario = new FrmCircle();
                }
                return formulario;
            }
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            circle.InitData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            circle.ReadData(txtRadius);
            circle.PerimeterCircle();
            circle.AreaCircle();
            circle.PrintData(txtPerimeter, txtArea);
            circle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            circle.InitData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            circle.CloseForm(this);
        }
    }
}
