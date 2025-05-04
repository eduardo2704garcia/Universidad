using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmTriangle : Form
    {
        private Triangle triangle = new Triangle();

        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            triangle.InitData(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            triangle.ReadData(txtBase, txtHeight);
            triangle.PerimeterTriangle();
            triangle.AreaTriangle();
            triangle.PrintData(txtPerimeter, txtArea);
            triangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            triangle.InitData(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            triangle.CloseForm(this);
        }
    }
}
