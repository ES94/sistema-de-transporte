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
    public partial class frmNuevoViaje : Form
    {
        public frmNuevoViaje()
        {
            InitializeComponent();
            ViajesAviones = new List<Viaje>();
            ViajesAutos = new List<Viaje>();
            ViajesColectivos = new List<Viaje>();
            Viaje = new Viaje();
            estado = false;
            tipo = -1;
        }

        public List<Avion> Aviones { get; set; }

        public List<Auto> Autos { get; set; }

        public List<Colectivo> Colectivos { get; set; }

        public List<Viaje> ViajesAviones { get; set; }

        public List<Viaje> ViajesAutos { get; set; }

        public List<Viaje> ViajesColectivos { get; set; }

        public Viaje Viaje { get; set; }

        public bool estado;

        public int tipo;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (txtCiudadOrigen.Text == "")
                error = true;

            if (txtCiudadDestino.Text == "")
                error = true;

            if (txtSeleccionarVehiculo.Text == "")
                error = true;

            if (dtpFechaViaje.Value <= DateTime.Today)
                error = true;

            if (cbxCantidadPasajeros.SelectedIndex == -1)
                error = true;

            if (cbxTipoVehiculo.SelectedIndex == -1)
                error = true;
            else if (cbxCantidadPasajeros.SelectedIndex != -1)
            {
                int cantPas = Convert.ToInt16(cbxCantidadPasajeros.Text);

                if ((cbxTipoVehiculo.SelectedIndex == 0) && (cantPas < 10))
                    error = true;

                if (cbxTipoVehiculo.SelectedIndex == 1)
                {
                    if (cantPas > 5)
                        error = true;

                    if (mskCantidadKm.Text == "")
                        error = true;
                }
                if ((cbxTipoVehiculo.SelectedIndex == 2) && (cantPas > 50))
                    error = true;
            }

            if (error)
                MessageBox.Show("Hay campos incerrectos o sin completar.", "Advertencia", MessageBoxButtons.OK);
            else
            {
                string origen = txtCiudadOrigen.Text;
                string detino = txtCiudadDestino.Text;
                DateTime fecha = dtpFechaViaje.Value;
                int cantPas = Convert.ToInt16(cbxCantidadPasajeros.Text);
                int id = Convert.ToInt16(txtSeleccionarVehiculo.Text);
                tipo = cbxTipoVehiculo.SelectedIndex;
                string tipoVh = ((tipo == 0) ? "Avión" : (tipo == 1) ? "Auto" : "Colectivo");
                int cantPasKm = cantPas;

                if (tipo == 1)
                    cantPasKm = Convert.ToInt16(mskCantidadKm.Text);

                float costo = CalcularCostoTotal(tipo, id, cantPasKm);
                Viaje = new Viaje(origen, detino, fecha, cantPas, id, tipoVh, costo);
                MessageBox.Show("Viaje registrado correctamente: el costo total es $" + costo, "Información", MessageBoxButtons.OK);

                estado = true;
                ActiveForm.Close();
            }
        }

        private void btnSeleccionarVehiculo_Click(object sender, EventArgs e)
        {
            if ((cbxTipoVehiculo.SelectedIndex != -1) && (dtpFechaViaje.Value > DateTime.Today) && (cbxCantidadPasajeros.SelectedIndex != -1))
            {
                frmSeleccionarVehiculo form = new frmSeleccionarVehiculo();
                form.tipoElegido = cbxTipoVehiculo.SelectedIndex;
                form.fecha = dtpFechaViaje.Value;
                form.cantPasajeros = Convert.ToInt16(cbxCantidadPasajeros.Text);
                form.Aviones = Aviones;
                form.Autos = Autos;
                form.Colectivos = Colectivos;

                if (cbxTipoVehiculo.SelectedIndex == 0)
                    form.ViajesAviones = ViajesAviones;
                else if (cbxTipoVehiculo.SelectedIndex == 1)
                    form.ViajesAutos = ViajesAutos;
                else
                    form.ViajesColectivos = ViajesColectivos;

                form.Owner = this;
                form.ShowDialog();

                if (form.estado)
                    txtSeleccionarVehiculo.Text = form.IdVehiculo.ToString();
            }
            else
            {
                string errorTipoVehiculo = "Debe elegir un tipo de vehículo.";
                string errorFechaViaje = "Establezca una fecha de viaje válida.";
                string errorCantKm = "Establezca una cantidad de Km.";
                string errorCantPasajeros = "Debe elegir una cantidad de pasajeros.";
                string mensaje = "";
                int c = 0;

                if (cbxTipoVehiculo.SelectedIndex == -1)
                {
                    mensaje += errorTipoVehiculo;
                    c++;
                }

                if (dtpFechaViaje.Value <= DateTime.Now)
                {
                    if (c > 0)
                        mensaje += "\n";

                    mensaje += errorFechaViaje;
                    c++;
                }

                if (cbxTipoVehiculo.SelectedIndex == 1)
                {
                    if (mskCantidadKm.Text == "")
                    {
                        if (c > 0)
                            mensaje += "\n";

                        mensaje += errorCantKm;
                    }
                }
                else
                {
                    if (cbxCantidadPasajeros.SelectedIndex == -1)
                    {
                        if (c > 0)
                            mensaje += "\n";

                        mensaje += errorCantPasajeros;
                    }
                }

                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void frmNuevoViaje_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 201; i++)
                cbxCantidadPasajeros.Items.Add(i);
        }

        private float CalcularCostoTotal(int opcion, int id, int cantPasKm)
        {
            float costo = 0;

            if (opcion == 0)
            {
                Avion a = Aviones.Find(x => x.Numero == id);
                costo = cantPasKm * a.CostoPorPersona + ((a.LowCost) ? 1200 : 2700);
            }
            else if (opcion == 1)
            {
                Auto a = Autos.Find(x => x.Numero == id);
                costo = cantPasKm * a.CostoPorKm;
            }
            else
            {
                Colectivo c = Colectivos.Find(x => x.Numero == id);
                costo = cantPasKm * c.CostoPorPersona + ((c.AlmuerzoCena) ? 100 : 0) + ((c.CocheCama) ? 30 : 0);
            }

            return costo;
        }

        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbxTipoVehiculo.SelectedIndex == 0) || (cbxTipoVehiculo.SelectedIndex == 2))
            {
                lblCantidadKm.Visible = false;
                mskCantidadKm.Visible = false;
            }
            else
            {
                lblCantidadKm.Visible = true;
                mskCantidadKm.Visible = true;
            }
        }
    }
}
