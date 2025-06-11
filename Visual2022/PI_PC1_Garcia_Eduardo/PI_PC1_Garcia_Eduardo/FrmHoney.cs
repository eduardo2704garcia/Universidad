using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_PC1_Garcia_Eduardo
{
    public partial class FrmHoney : Form
    {
        public FrmHoney()
        {
            InitializeComponent();
        }
        private void bntCalculate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtLado.Text, out float lado) && lado > 0)
            {
                Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Transparent);

                    Honey honey = new Honey(g, lado);
                    honey.DrawHexagonGrid(3, picCanvas.Width, picCanvas.Height); 

                    picCanvas.Image = bmp;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el lado del hexágono.");
            }
        }

    }
}
