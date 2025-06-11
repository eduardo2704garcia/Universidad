using System;
using System.Windows.Forms;

namespace P1_PC1_Garcia_Eduardo_V2
{
    public partial class FrmSuperStar : Form
    {
        private GeometricFigure ObjFigure = new GeometricFigure();

        public FrmSuperStar()
        {
            InitializeComponent();
        }

        private void FrmSuperStar_Load(object sender, EventArgs e)
        {
            ObjFigure.InitializeData(txtSide, picCanvas);
        }

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            ObjFigure.ReadData(txtSide);
            ObjFigure.PlotShape(picCanvas);
        }
    }
}
