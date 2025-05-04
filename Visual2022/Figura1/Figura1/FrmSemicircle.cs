using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figura1
{
    public partial class FrmSemicircle : Form
    {
        private Semicircle semicircle = new Semicircle();

        public FrmSemicircle()
        {
            InitializeComponent();
        }

        private void FrmSemicircle_Load(object sender, EventArgs e)
        {
            semicircle.InitData(txtR, txtArea, txtPerimeter, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            semicircle.ReadData(txtR);
            semicircle.AreaSemicircle();
            semicircle.PerimeterSemicircle();
            semicircle.PrintData(txtArea, txtPerimeter);
            semicircle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            semicircle.InitData(txtR, txtArea, txtPerimeter, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            semicircle.CloseForm(this);
        }
    }
}
