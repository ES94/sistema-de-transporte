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
    public partial class frmNuevoVehiculo : Form
    {
        public frmNuevoVehiculo()
        {
            InitializeComponent();
            Aviones = new List<Avion>();
            Autos = new List<Auto>();
            Colectivos = new List<Colectivo>();
            estado = false;
            tipo = -1;
        }

        public List<Avion> Aviones { get; set; }

        public List<Auto> Autos { get; set; }

        public List<Colectivo> Colectivos { get; set; }

        public Avion Avion { get; set; }

        public Auto Auto { get; set; }

        public Colectivo Colectivo { get; set; }

        public bool estado;

        public int tipo;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
            {
                cbxEmbarqueDarsena.Visible = true;
                chkLowCostCocheCama.Visible = true;
                chkPermiteMascotasAlmuerzoCena.Visible = true;
                txtMarca.Visible = false;
                txtModelo.Visible = false;
                mskAutonomia.Visible = false;
                lblModelo.Visible = false;
                lblAutonomia.Visible = false;

                if (cbxTipoVehiculo.SelectedIndex == 0)
                {
                    lblEmbarqueMarcaDarsena.Text = "Puerta de embarque:";
                    chkLowCostCocheCama.Text = "Low Cost";
                    chkPermiteMascotasAlmuerzoCena.Text = "Permite mascotas";
                }
                else
                {
                    lblEmbarqueMarcaDarsena.Text = "Número de dársena:";
                    chkLowCostCocheCama.Text = "Coche cama";
                    chkPermiteMascotasAlmuerzoCena.Text = "Almuerzo/Cena";
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
            }
        }

        private void frmNuevoEditarVehiculo_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i++)
                cbxEmbarqueDarsena.Items.Add(i);

            for (int i = 2; i < 201; i++)
                cbxCantButacas.Items.Add(i);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (txtNombre.Text == "")
                error = true;

            if (mskCostoPersona.Text == "")
                error = true;

            if (mskCostoKm.Text == "")
                error = true;

            // Si no se eligió ningún tipo de vehículo.
            if (cbxTipoVehiculo.SelectedIndex == -1)
                error = true;
            // Si se eligió un avión o colectivo como tipo de vehículo.
            else if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
            {
                // Si no se eligió puerta de embarque o número de dársena.
                if (cbxEmbarqueDarsena.SelectedIndex == -1)
                    error = true;
                
                // Si no se eligió cantidad de butacas.
                if (cbxCantButacas.SelectedIndex == -1)
                    error = true;
                else
                {
                    int i = Convert.ToInt16(cbxCantButacas.Text);

                    // Si se eligió un colectivo como tipo de vehículo y cantidad de butacas inválida.
                    if ((cbxTipoVehiculo.SelectedIndex == 2) && ((i > 50) || (i < 30)))
                        error = true;

                    // Si se eligió un avión como tipo de vehículo y cantidad de butacas inválida.
                    if ((cbxTipoVehiculo.SelectedIndex == 0) && (i < 10))
                        error = true;
                }
            }
            // Si se eligió un auto como tipo de vehículo.
            else
            {
                if (txtMarca.Text == "")
                    error = true;

                if (txtModelo.Text == "")
                    error = true;

                if (mskAutonomia.Text == "")
                    error = true;

                // Si no se eligió cantidad de butacas.
                if (cbxCantButacas.SelectedIndex == -1)
                    error = true;
                // Si se eligió una cantidad de butacas inválida.
                else if (Convert.ToInt16(cbxCantButacas.Text) > 5)
                        error = true;
            }

            // Si hay algún campo inválido.
            if (error)
                MessageBox.Show("Hay campos incorrectos o sin completar.", "Advertencia", MessageBoxButtons.OK);
            // Si todo lo ingresado es válido.
            else
            {
                int num = AsignarNumeroVehiculo();
                string nom = txtNombre.Text;
                int but = Convert.ToInt16(cbxCantButacas.Text);
                float costPer = Convert.ToSingle(mskCostoPersona.Text);
                float costKm = Convert.ToSingle(mskCostoKm.Text);

                if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
                {
                    int embDar = Convert.ToInt16(cbxEmbarqueDarsena.Text);
                    bool lowCama = chkLowCostCocheCama.Checked;
                    bool mascAlm = chkPermiteMascotasAlmuerzoCena.Checked;

                    if (cbxTipoVehiculo.SelectedIndex == 0)
                    {
                        Avion = new Avion(num, nom, but, costPer, costKm, embDar, lowCama, mascAlm);
                    }
                    else
                    {
                        Colectivo = new Colectivo(num, nom, but, costPer, costKm, embDar, lowCama, mascAlm);
                    }
                }
                else
                {
                    int auto = Convert.ToInt16(mskAutonomia.Text);

                    Auto = new Auto(num, nom, but, costPer, costKm, txtMarca.Text, txtModelo.Text, auto);
                }

                estado = true;
                tipo = cbxTipoVehiculo.SelectedIndex;
                ActiveForm.Close();
            }
        }

        private int AsignarNumeroVehiculo()
        {
            int numero = 0;

            while (true)
            {
                numero++;

                if (cbxTipoVehiculo.SelectedIndex == 0)
                    if (!Aviones.Exists(x => x.Numero == numero))
                        break;

                if (cbxTipoVehiculo.SelectedIndex == 1)
                    if (!Autos.Exists(x => x.Numero == numero))
                        break;

                if (cbxTipoVehiculo.SelectedIndex == 2)
                    if (!Colectivos.Exists(x => x.Numero == numero))
                        break;
            }

            return numero;
        }
    }
}
