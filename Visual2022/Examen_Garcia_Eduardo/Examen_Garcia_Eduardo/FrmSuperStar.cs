using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Garcia_Eduardo
{
    public partial class FrmSuperStar : Form
    {
        public FrmSuperStar()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSide.Text, out int side))
            {
                Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    SuperStar star = new SuperStar();
                    star.Draw(g, side, picCanvas.Width, picCanvas.Height);
                }
                picCanvas.Image = bmp;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido en el campo de lado.");
            }
        }

    }
}
