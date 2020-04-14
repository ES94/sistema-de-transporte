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
    public partial class frmSeleccionarVehiculo : Form
    {
        public frmSeleccionarVehiculo()
        {
            InitializeComponent();
            Aviones = new List<Avion>();
            Autos = new List<Auto>();
            Colectivos = new List<Colectivo>();
            ViajesAviones = new List<Viaje>();
            ViajesAutos = new List<Viaje>();
            ViajesColectivos = new List<Viaje>();
            IdVehiculo = 0;
            cantPasajeros = 0;
            cantKm = 0;
            tipoElegido = -1;
            estado = false;
            fecha = DateTime.Today;
        }

        public List<Avion> Aviones { get; set; }

        public List<Auto> Autos { get; set; }

        public List<Colectivo> Colectivos { get; set; }

        public List<Viaje> ViajesAviones { get; set; }

        public List<Viaje> ViajesAutos { get; set; }

        public List<Viaje> ViajesColectivos { get; set; }

        public DateTime fecha;

        public int cantPasajeros;

        public int cantKm;

        public int tipoElegido;

        public bool estado;

        public int IdVehiculo { get; set; }

        private void frmSeleccionarVehiculo_Load(object sender, EventArgs e)
        { 
            if (tipoElegido == 0)
                srcSeleccionarVehiculo.DataSource = Aviones;

            if (tipoElegido == 1)
                srcSeleccionarVehiculo.DataSource = Autos;

            if (tipoElegido == 2)
                srcSeleccionarVehiculo.DataSource = Colectivos;
            
            srcSeleccionarVehiculo.Sort = "Numero";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (srcSeleccionarVehiculo.Count != 0)
            {
                Vehiculo v = (Vehiculo)dgvSeleccionarVehiculo.CurrentRow.DataBoundItem;
                bool valido = false;

                if (tipoElegido == 0)
                    valido = ComprobarVehiculo(ViajesAviones, v.Numero);
                else if (tipoElegido == 1)
                    valido = ComprobarVehiculo(ViajesAutos, v.Numero);
                else
                    valido = ComprobarVehiculo(ViajesColectivos, v.Numero);

                if (valido)
                {
                    estado = true;
                    IdVehiculo = v.Numero;
                    ActiveForm.Close();
                }
                else
                    MessageBox.Show("Vehículo seleccionado no disponible o no soporta la cantidad de pasajeros solicitada.", "Advertencia", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("No hay vehículos que seleccionar.", "Advertencia", MessageBoxButtons.OK);
        }

        private bool ComprobarVehiculo(List<Viaje> list, int id)
        {
            bool vehiculoDisponible = !list.Exists(x => x.IdVehiculo == id && x.FechaViaje.Date == fecha.Date);
            
            if (vehiculoDisponible)
            {
                if (tipoElegido == 0)
                    return (Aviones.Find(x => x.Numero == id).CantidadButacas >= cantPasajeros) ? true : false;
                else if (tipoElegido == 1)
                    return (Autos.Find(x => x.Numero == id).CantidadButacas >= cantPasajeros) ? true : false;
                else
                    return (Colectivos.Find(x => x.Numero == id).CantidadButacas >= cantPasajeros) ? true : false;
            }
            else
                return false;
        }
    }
}
