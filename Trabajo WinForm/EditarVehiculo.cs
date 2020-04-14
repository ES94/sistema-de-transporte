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
    public partial class frmEditarVehiculo : Form
    {
        public frmEditarVehiculo()
        {
            InitializeComponent();
            tipoElegido = -1;
            estado = false;
        }

        public Avion Avion { get; set; }

        public Auto Auto { get; set; }

        public Colectivo Colectivo { get; set; }

        public int tipoElegido;

        public bool estado;

        private void EditarVehiculo_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 201; i++)
                cbxCantidadButacas.Items.Add(i);

            if ((tipoElegido == 0) || (tipoElegido == 2))
            {
                for (int i = 1; i < 16; i++)
                    cbxEmbarqueDarsena.Items.Add(i);

                cbxEmbarqueDarsena.Visible = true;
                chkLowCostCocheCama.Visible = true;
                chkPermiteMascotasAlmuerzoCena.Visible = true;
                txtMarca.Visible = false;
                txtModelo.Visible = false;
                mskAutonomia.Visible = false;
                lblModelo.Visible = false;
                lblAutonomia.Visible = false;

                if (tipoElegido == 0)
                {
                    lblEmbarqueMarcaDarsena.Text = "Puerta de embarque:";
                    chkLowCostCocheCama.Text = "Low Cost";
                    chkPermiteMascotasAlmuerzoCena.Text = "Permite mascotas";

                    txtNombre.Text = Avion.Nombre;
                    txtTipoVehiculo.Text = "Avión";
                    cbxCantidadButacas.Text = Avion.CantidadButacas.ToString();
                    mskCostoPersona.Text = Avion.CostoPorPersona.ToString();
                    mskCostoKm.Text = Avion.CostoPorKm.ToString();
                    cbxEmbarqueDarsena.Text = Avion.PuertaEmbarque.ToString();
                    chkLowCostCocheCama.Checked = Avion.LowCost;
                    chkPermiteMascotasAlmuerzoCena.Checked = Avion.PermiteMascotas;
                }
                else
                {
                    lblEmbarqueMarcaDarsena.Text = "Número de dársena:";
                    chkLowCostCocheCama.Text = "Coche cama";
                    chkPermiteMascotasAlmuerzoCena.Text = "Almuerzo/Cena";

                    txtNombre.Text = Colectivo.Nombre;
                    txtTipoVehiculo.Text = "Colectivo";
                    cbxCantidadButacas.Text = Colectivo.CantidadButacas.ToString();
                    mskCostoPersona.Text = Colectivo.CostoPorPersona.ToString();
                    mskCostoKm.Text = Colectivo.CostoPorKm.ToString();
                    cbxEmbarqueDarsena.Text = Colectivo.NumeroDarsena.ToString();
                    chkLowCostCocheCama.Checked = Colectivo.CocheCama;
                    chkPermiteMascotasAlmuerzoCena.Checked = Colectivo.AlmuerzoCena;
                }
            }
            else
            {
                cbxEmbarqueDarsena.Visible = false;
                chkLowCostCocheCama.Visible = false;
                chkPermiteMascotasAlmuerzoCena.Visible = false;
                txtMarca.Visible = true;
                txtModelo.Visible = true;
                mskAutonomia.Visible = true;
                lblModelo.Visible = true;
                lblAutonomia.Visible = true;
                lblEmbarqueMarcaDarsena.Text = "Marca:";

                txtNombre.Text = Auto.Nombre;
                txtTipoVehiculo.Text = "Auto";
                cbxCantidadButacas.Text = Auto.CantidadButacas.ToString();
                mskCostoPersona.Text = Auto.CostoPorPersona.ToString();
                mskCostoKm.Text = Auto.CostoPorKm.ToString();
                txtMarca.Text = Auto.Marca;
                txtModelo.Text = Auto.Modelo;
                mskAutonomia.Text = Auto.Autonomia.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            int i = 0;

            if (txtNombre.Text == "")
                error = true;

            if (mskCostoPersona.Text == "")
                error = true;

            if (mskCostoKm.Text == "")
                error = true;

            if (cbxCantidadButacas.SelectedIndex == -1)
                error = true;
            else
                i = Convert.ToInt16(cbxCantidadButacas.Text);

            if ((tipoElegido == 0) || (tipoElegido == 2))
            {
                if (cbxEmbarqueDarsena.SelectedIndex == -1)
                    error = true;

                if ((tipoElegido == 0) && (i < 10))
                    error = true;
                else if ((tipoElegido == 2) && ((i > 50) || (i < 30)))
                    error = true;
            }
            else
            {
                if (txtMarca.Text == "")
                    error = true;

                if (txtModelo.Text == "")
                    error = true;

                if (mskAutonomia.Text == "")
                    error = true;

                if ((i > 5) || (i < 2))
                    error = true;
            }

            // Si hay algún campo inválido.
            if (error)
                MessageBox.Show("Hay campos incorrectos o sin completar.", "Advertencia", MessageBoxButtons.OK);
            // Si todo lo ingresado es válido.
            else
            {
                string nom = txtNombre.Text;
                int but = Convert.ToInt16(cbxCantidadButacas.Text);
                float costPer = Convert.ToSingle(mskCostoPersona.Text);
                float costKm = Convert.ToSingle(mskCostoKm.Text);

                if ((tipoElegido == 0) || (tipoElegido == 2))
                {
                    int embDar = Convert.ToInt16(cbxEmbarqueDarsena.Text);
                    bool lowCama = chkLowCostCocheCama.Checked;
                    bool mascAlm = chkPermiteMascotasAlmuerzoCena.Checked;

                    if (tipoElegido == 0)
                    {
                        Avion = new Avion(Avion.Numero, nom, but, costPer, costKm, embDar, lowCama, mascAlm);
                    }
                    else
                    {
                        Colectivo = new Colectivo(Colectivo.Numero, nom, but, costPer, costKm, embDar, lowCama, mascAlm);
                    }
                }
                else
                {
                    int auto = Convert.ToInt16(mskAutonomia.Text);

                    Auto = new Auto(Auto.Numero, nom, but, costPer, costKm, txtMarca.Text, txtModelo.Text, auto);
                }

                estado = true;
                ActiveForm.Close();
            }
        }
    }
}
