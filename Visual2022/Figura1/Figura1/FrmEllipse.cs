using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmEllipse : Form
    {
        private Ellipse ellipse = new Ellipse();

        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {
            ellipse.InitData(txtA, txtB, txtArea, txtPerimeter, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ellipse.ReadData(txtA, txtB);
            ellipse.AreaEllipse();
            ellipse.PerimeterEllipse();
            ellipse.PrintData(txtArea, txtPerimeter);
            ellipse.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ellipse.InitData(txtA, txtB, txtArea, txtPerimeter, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ellipse.CloseForm(this);
        }
    }
}
