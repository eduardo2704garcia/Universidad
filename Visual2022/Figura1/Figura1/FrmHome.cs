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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare FrmSquare = new FrmSquare();
            FrmSquare.MdiParent = this;
            FrmSquare.Show();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle FrmRectangle = new FrmRectangle();
            FrmRectangle.MdiParent = this;
            FrmRectangle.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle FrmTriangle = new FrmTriangle();
            FrmTriangle.MdiParent = this;
            FrmTriangle.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle FrmCircle = new FrmCircle();
            FrmCircle.MdiParent = this;
            FrmCircle.Show();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEllipse FrmEllipse = new FrmEllipse();
            FrmEllipse.MdiParent = this;
            FrmEllipse.Show();
        }

        private void semicirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemicircle FrmSemicircle = new FrmSemicircle();
            FrmSemicircle.MdiParent = this;
            FrmSemicircle.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoid FrmTrapezoid = new FrmTrapezoid();
            FrmTrapezoid.MdiParent = this;
            FrmTrapezoid.Show();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoid FrmTrapezoid = new FrmTrapezoid();
            FrmTrapezoid.MdiParent = this;
            FrmTrapezoid.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhombus FrmRhombus = new FrmRhombus();
            FrmRhombus.MdiParent = this;
            FrmRhombus.Show();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhombusoid FrmRhombusoid = new FrmRhombusoid();
            FrmRhombusoid.MdiParent = this;
            FrmRhombusoid.Show();
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoid FrmDeltoid = new FrmDeltoid();
            FrmDeltoid.MdiParent = this;
            FrmDeltoid.Show();
        }

        private void estrellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStar FrmStar = new FrmStar();
            FrmStar.MdiParent = this;
            FrmStar.Show();
        }
    }
}
