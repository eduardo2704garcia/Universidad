using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmTrapezoid : Form
    {
        private Trapezoid trapezoid = new Trapezoid();

        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            trapezoid.InitData(txtB1, txtB2, txtH, txtL1, txtL2, txtArea, txtPerimeter, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            trapezoid.ReadData(txtB1, txtB2, txtH, txtL1, txtL2);
            trapezoid.AreaTrapezoid();
            trapezoid.PerimeterTrapezoid();
            trapezoid.PrintData(txtArea, txtPerimeter);

            bool isTrapecio = rbtnTrapecio.Checked;
            trapezoid.PlotShape(picCanvas, isTrapecio);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapezoid.InitData(txtB1, txtB2, txtH, txtL1, txtL2, txtArea, txtPerimeter, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            trapezoid.CloseForm(this);
        }
    }
}
