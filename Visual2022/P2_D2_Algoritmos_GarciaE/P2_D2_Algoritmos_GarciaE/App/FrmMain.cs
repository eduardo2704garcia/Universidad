using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2_D2_Algoritmos_GarciaE.UI;


namespace P2_D2_Algoritmos_GarciaE.App
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnRecorte_Click(object sender, EventArgs e)
        {
            FrmRecorte frm = new FrmRecorte();
            this.Hide();//Oculta la caratula
            frm.FormClosed += (s, args) => this.Show();//Muestro
            frm.Show();
        }

        private void btnCurvas_Click(object sender, EventArgs e)
        {
            FrmCurvas frm = new FrmCurvas();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            FrmRelleno frm = new FrmRelleno();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnRemasterizacion_Click(object sender, EventArgs e)
        {
            FrmRemasterizacion frm = new FrmRemasterizacion();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
