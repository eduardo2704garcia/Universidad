using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura1
{
    public partial class FrmRectangle : Form
    {
        private Rectangle rectangle = new Rectangle();
        public FrmRectangle()
        {
            InitializeComponent();
        }
        
        private void frmRectangle_Load(object sender, EventArgs e)
        {
            rectangle.InitData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            rectangle.ReadData(txtWidth, txtHeight);
            rectangle.PerimeterRectangle();
            rectangle.AreaRectangle();
            rectangle.PrintData(txtPerimeter, txtArea);
            rectangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rectangle.InitData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            rectangle.CloseForm(this);
        }
    }
}
