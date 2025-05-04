using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmRhombusoid : Form
    {
        private Rhombusoid rhombusoid = new Rhombusoid();

        public FrmRhombusoid()
        {
            InitializeComponent();
        }

        private void FrmRhombusoid_Load(object sender, EventArgs e)
        {
            rhombusoid.InitData(txtBase, txtHeight, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rhombusoid.ReadData(txtBase, txtHeight, txtSide);
            rhombusoid.PerimeterRhombusoid();
            rhombusoid.AreaRhombusoid();
            rhombusoid.PrintData(txtPerimeter, txtArea);
            rhombusoid.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rhombusoid.InitData(txtBase, txtHeight, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            rhombusoid.CloseForm(this);
        }
    }
}
