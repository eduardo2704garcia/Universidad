using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmRhombus : Form
    {
        private Rhombus rhombus = new Rhombus();

        public FrmRhombus()
        {
            InitializeComponent();
        }

        private void FrmRhombus_Load(object sender, EventArgs e)
        {
            rhombus.InitData(txtDiagonal1, txtDiagonal2, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rhombus.ReadData(txtDiagonal1, txtDiagonal2, txtSide);
            rhombus.PerimeterRhombus();
            rhombus.AreaRhombus();
            rhombus.PrintData(txtPerimeter, txtArea);
            rhombus.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rhombus.InitData(txtDiagonal1, txtDiagonal2, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            rhombus.CloseForm(this);
        }
    }
}
