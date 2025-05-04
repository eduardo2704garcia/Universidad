using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                double resultado = num1 + num2;
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "Entrada inválida";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                double resultado = num1 - num2;
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "Entrada inválida";
            }
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                double resultado = num1 * num2;
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "Entrada inválida";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                if (num2 != 0)
                {
                    double resultado = num1 / num2;
                    lblResultado.Text = resultado.ToString();
                }
                else
                {
                    lblResultado.Text = "No se puede dividir entre 0";
                }
            }
            else
            {
                lblResultado.Text = "Entrada inválida";
            }
        }
    }
}
