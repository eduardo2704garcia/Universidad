using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figura1
{
    public partial class FrmSquare : Form
    {
        private Square square = new Square();
        public FrmSquare()
        {
            InitializeComponent();
        }

        private void frmSquare_Load(object sender, EventArgs e)
        {
            square.InitData(txtWidth, txtPerimeter, txtArea, picCanvas);

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            square.ReadData(txtWidth);
            square.PerimeterSquare();
            square.AreaSquare();
            square.PrintData(txtPerimeter, txtArea);
            square.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            square.InitData(txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            square.CloseForm(this);
        }

    }
}
