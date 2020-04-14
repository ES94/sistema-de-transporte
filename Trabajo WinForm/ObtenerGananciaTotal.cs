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
    public partial class frmObtenerGananciaTotal : Form
    {
        public frmObtenerGananciaTotal()
        {
            InitializeComponent();
        }

        private void frmObtenerGananciaMaxima_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 201; i++)
                cbxCantidadButacas.Items.Add(i);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (cbxCantidadButacas.SelectedIndex == -1)
                error = true;

            if (cbxTipoVehiculo.SelectedIndex == -1)
                error = true;
            else if (cbxCantidadButacas.SelectedIndex != -1)
            {
                int cantBut = Convert.ToInt16(cbxCantidadButacas.Text);

                if ((cbxTipoVehiculo.SelectedIndex == 0) && (cantBut < 10))
                    error = true;

                if ((cbxTipoVehiculo.SelectedIndex == 1) && (cantBut > 5))
                    error = true;

                if ((cbxTipoVehiculo.SelectedIndex == 2) && (cantBut > 50))
                    error = true;
            }

            if (mskCostoPersona.Text == "")
                error = true;

            if (error)
                MessageBox.Show("Hay campos incorrectos o sin completar.", "Advertencia", MessageBoxButtons.OK);
            else
            {
                int cantBut = Convert.ToInt16(cbxCantidadButacas.Text);
                float costoPer = Convert.ToSingle(mskCostoPersona.Text);

                lblResultado.Text = "Resultado: " + (costoPer * cantBut).ToString();
            }
        }
    }
}
