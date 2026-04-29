using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzziSP2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(txtDistancia.Text != "" && txtDias.Text != "" && int.Parse(txtDistancia.Text) >= 0 && int.Parse(txtDias.Text) >= 0 && int.Parse(txtDias.Text) <= 31)
            {
                Double price = Double.Parse(txtDistancia.Text) * 5;
                if (int.Parse(txtDias.Text) >= 7 || int.Parse(txtDias.Text) == 7)
                {
                    price = price * 0.5;
                }
                MessageBox.Show("Calculo completado. Costo total del boleto: $" + price, "Calculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDias.Text = String.Empty;
                txtDistancia.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Datos ingresados inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
