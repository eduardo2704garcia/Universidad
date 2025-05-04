using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmDeltoid : Form
    {
        private Deltoid deltoid = new Deltoid();

        public FrmDeltoid()
        {
            InitializeComponent();
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
            deltoid.InitData(txtDmajor, txtDminor, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            deltoid.ReadData(txtDmajor, txtDminor, txtSideA, txtSideB);
            deltoid.PerimeterDeltoid();
            deltoid.AreaDeltoid();
            deltoid.PrintData(txtPerimeter, txtArea);
            deltoid.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deltoid.InitData(txtDmajor, txtDminor, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            deltoid.CloseForm(this);
        }
    }
}
