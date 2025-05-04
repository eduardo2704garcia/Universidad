using System;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmStar : Form
    {
        private Star star = new Star();

        public FrmStar()
        {
            InitializeComponent();
        }

        private void FrmStar_Load(object sender, EventArgs e)
        {
            star.InitData(txtBase, txtAltura, txtLado, txtArea, txtPerimeter, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            star.ReadData(txtBase, txtAltura, txtLado);
            star.AreaStar();
            star.PerimeterStar();
            star.PrintData(txtArea, txtPerimeter);
            star.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            star.InitData(txtBase, txtAltura, txtLado, txtArea, txtPerimeter, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            star.CloseForm(this);
        }
    }
}
