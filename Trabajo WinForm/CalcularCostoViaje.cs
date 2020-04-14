using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_WinForm
{
    public partial class frmCalcularCostoViaje : Form
    {
        public frmCalcularCostoViaje()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCostoPersonaKm.Visible = true;
            lblCantPersonasKm.Visible = true;
            mskCostoPersonaKm.Visible = true;

            if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
            {
                lblCostoPersonaKm.Text = "Costo por persona:";
                lblCantPersonasKm.Text = "Cantidad de personas:";
                mskCantidadKm.Visible = false;
                cbxCantPersonas.Visible = true;
                chkLowCostCocheCama.Visible = true;

                if (cbxTipoVehiculo.SelectedIndex == 0)
                {
                    chkLowCostCocheCama.Text = "LowCost";
                    chkAlmuerzoCena.Visible = false;
                }
                else
                {
                    chkLowCostCocheCama.Text = "Coche cama";
                    chkAlmuerzoCena.Visible = true;
                }
            }
            else
            {
                lblCostoPersonaKm.Text = "Costo por Km:";
                lblCantPersonasKm.Text = "Cantidad de Km:";
                mskCantidadKm.Visible = true;
                cbxCantPersonas.Visible = false;
                chkLowCostCocheCama.Visible = false;
                chkAlmuerzoCena.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool error = false;
            int i = 0;

            if (cbxTipoVehiculo.SelectedIndex == -1)
                error = true;
            else
            {
                if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
                {
                    if (cbxCantPersonas.SelectedIndex == -1)
                        error = true;
                    else
                        i = Convert.ToInt16(cbxCantPersonas.Text);

                    if ((cbxTipoVehiculo.SelectedIndex == 2) && (i > 50))
                        error = true;
                }
            }

            if (mskCostoPersonaKm.Text == "")
                error = true;

            if (error)
                MessageBox.Show("Hay campos inválidos o incompletos.", "Advertencia", MessageBoxButtons.OK);
            else
            {
                int cantPasKm = 0;
                float costoPersonaKm = Convert.ToSingle(mskCostoPersonaKm.Text);
                lblResultado.Text = "Resultado: $";

                if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
                {
                    cantPasKm = Convert.ToInt16(cbxCantPersonas.Text);

                    if (cbxTipoVehiculo.SelectedIndex == 0)
                        lblResultado.Text += (cantPasKm * costoPersonaKm + ((chkLowCostCocheCama.Checked) ? 1200 : 2700)).ToString();
                    else
                        lblResultado.Text += (cantPasKm * costoPersonaKm + ((chkAlmuerzoCena.Checked) ? 100 : 0) + ((chkLowCostCocheCama.Checked) ? 30 : 0)).ToString();
                }
                else
                {
                    cantPasKm = Convert.ToInt16(mskCantidadKm.Text);
                    lblResultado.Text += (cantPasKm * costoPersonaKm).ToString();
                }  
            }
        }

        private void frmCalcularCostoViaje_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 201; i++)
                cbxCantPersonas.Items.Add(i);
        }
    }
}
