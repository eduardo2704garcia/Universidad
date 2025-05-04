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
    public partial class FrmOperaciones2 : Form
    {
        public FrmOperaciones2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                double resultado = 0;

                if (rbtnSuma.Checked)
                    resultado = num1 + num2;
                else if (rbtnResta.Checked)
                    resultado = num1 - num2;
                else if (rbtnMultiplicacion.Checked)
                    resultado = num1 * num2;
                else if (rbtnDivision.Checked)
                {
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        lblResultado.Text = "No se puede dividir entre 0";
                        return;
                    }
                }
                else
                {
                    lblResultado.Text = "Seleccione una operación";
                    return;
                }

                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "Ingrese números válidos";
            }
        }
    }
}
