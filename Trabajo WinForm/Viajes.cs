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
    public partial class frmViajes : Form
    {
        public frmViajes()
        {
            InitializeComponent();
            Aviones = new List<Avion>();
            Autos = new List<Auto>();
            Colectivos = new List<Colectivo>();
            ViajesAviones = new List<Viaje>();
            ViajesAutos = new List<Viaje>();
            ViajesColectivos = new List<Viaje>();
        }

        public List<Avion> Aviones { get; set; }

        public List<Auto> Autos { get; set; }

        public List<Colectivo> Colectivos { get; set; }

        public List<Viaje> ViajesAviones { get; set; }

        public List<Viaje> ViajesAutos { get; set; }

        public List<Viaje> ViajesColectivos { get; set; }

        private void bmnSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            srcAviones.DataSource = ViajesAviones;
            srcAutos.DataSource = ViajesAutos;
            srcColectivos.DataSource = ViajesColectivos;
        }

        private void bmnNuevoViaje_Click(object sender, EventArgs e)
        {
            frmNuevoViaje form = new frmNuevoViaje();
            form.Owner = this;
            form.Aviones = Aviones;
            form.Autos = Autos;
            form.Colectivos = Colectivos;
            form.ViajesAviones = ViajesAviones;
            form.ViajesAutos = ViajesAutos;
            form.ViajesColectivos = ViajesColectivos;
            form.ShowDialog();

            if (form.estado)
                if (form.tipo == 0)
                {
                    ViajesAviones.Add(form.Viaje);
                    srcAviones.ResetBindings(true);
                    dgvAviones.Refresh();
                }
                else if (form.tipo == 1)
                {
                    ViajesAutos.Add(form.Viaje);
                    srcAutos.ResetBindings(true);
                    dgvAutos.Refresh();
                }
                else
                {
                    ViajesColectivos.Add(form.Viaje);
                    srcColectivos.ResetBindings(true);
                    dgvColectivos.Refresh();
                }
        }

        private void establecerFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstablecerFiltro form = new frmEstablecerFiltro();
            form.ShowDialog();

            if (form.estado)
            {
                srcAviones.Filter = string.Format("Fecha de viaje >= '{0}' AND Fecha de viaje <= '{1}'", form.FechaInicial.ToString(), form.FechaFinal.ToString());
                srcAutos.Filter = string.Format("Fecha de viaje >= '{0}' AND Fecha de viaje <= '{1}'", form.FechaInicial.ToString(), form.FechaFinal.ToString());
                srcColectivos.Filter = string.Format("Fecha de viaje >= '{0}' AND Fecha de viaje <= '{1}'", form.FechaInicial.ToString(), form.FechaFinal.ToString());

                /*
                DateTime fechaInicial = form.FechaInicial.Date;
                DateTime fechaFinal = form.FechaFinal.Date;

                dgvAviones.Rows.Clear();
                dgvAutos.Rows.Clear();
                dgvColectivos.Rows.Clear();

                int index = 0;

                foreach (Viaje v in ViajesAviones)
                {
                    DateTime fechaViaje = v.FechaViaje.Date;

                    if ((fechaViaje >= fechaInicial) && (fechaViaje <= fechaFinal))
                    {
                        index = dgvAviones.Rows.Add();

                        dgvAviones.Rows[index].Cells[0].Value = v.CiudadOrigen;
                        dgvAviones.Rows[index].Cells[1].Value = v.CiudadDestino;
                        dgvAviones.Rows[index].Cells[2].Value = v.FechaViaje;
                        dgvAviones.Rows[index].Cells[3].Value = v.CantidadPasajeros;
                        dgvAviones.Rows[index].Cells[4].Value = v.IdVehiculo;
                        dgvAviones.Rows[index].Cells[5].Value = v.TipoVehiculo;
                        dgvAviones.Rows[index].Cells[6].Value = v.CostoTotal;
                    }
                }

                foreach (Viaje v in ViajesAutos)
                {
                    DateTime fechaViaje = v.FechaViaje.Date;

                    if ((fechaViaje >= fechaInicial) && (fechaViaje <= fechaFinal))
                    {
                        index = dgvAutos.Rows.Add();

                        dgvAutos.Rows[index].Cells[0].Value = v.CiudadOrigen;
                        dgvAutos.Rows[index].Cells[1].Value = v.CiudadDestino;
                        dgvAutos.Rows[index].Cells[2].Value = v.FechaViaje;
                        dgvAutos.Rows[index].Cells[3].Value = v.CantidadPasajeros;
                        dgvAutos.Rows[index].Cells[4].Value = v.IdVehiculo;
                        dgvAutos.Rows[index].Cells[5].Value = v.TipoVehiculo;
                        dgvAutos.Rows[index].Cells[6].Value = v.CostoTotal;
                    }
                }

                foreach (Viaje v in ViajesColectivos)
                {
                    DateTime fechaViaje = v.FechaViaje.Date;

                    if ((fechaViaje >= fechaInicial) && (fechaViaje <= fechaFinal))
                    {
                        index = dgvColectivos.Rows.Add();

                        dgvColectivos.Rows[index].Cells[0].Value = v.CiudadOrigen;
                        dgvColectivos.Rows[index].Cells[1].Value = v.CiudadDestino;
                        dgvColectivos.Rows[index].Cells[2].Value = v.FechaViaje;
                        dgvColectivos.Rows[index].Cells[3].Value = v.CantidadPasajeros;
                        dgvColectivos.Rows[index].Cells[4].Value = v.IdVehiculo;
                        dgvColectivos.Rows[index].Cells[5].Value = v.TipoVehiculo;
                        dgvColectivos.Rows[index].Cells[6].Value = v.CostoTotal;
                    }
                }
                */
            }
        }

        private void limpiarFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srcAviones.RemoveFilter();
            srcAutos.RemoveFilter();
            srcColectivos.RemoveFilter();

            /*
            dgvAviones.Rows.Clear();
            dgvAutos.Rows.Clear();
            dgvColectivos.Rows.Clear();

            dgvAviones.DataSource = ViajesAviones;
            dgvAutos.DataSource = ViajesAutos;
            dgvColectivos.DataSource = ViajesColectivos;

            dgvAviones.Refresh();
            dgvAutos.Refresh();
            dgvColectivos.Refresh();
            */
        }

        private void bmnCalcularCosto_Click(object sender, EventArgs e)
        {
            frmCalcularCostoViaje form = new frmCalcularCostoViaje();
            form.Owner = this;
            form.ShowDialog();
        }
    }

    public class Viaje
    {
        public Viaje() { }

        public Viaje(string origen, string destino, DateTime fecha, int pasajeros, int id, string tipoVh, float costo)
        {
            CiudadOrigen = origen;
            CiudadDestino = destino;
            FechaViaje = fecha;
            CantidadPasajeros = pasajeros;
            IdVehiculo = id;
            TipoVehiculo = tipoVh;
            CostoTotal = costo;
        }

        public string CiudadOrigen { get; set; } 

        public string CiudadDestino { get; set; }

        public DateTime FechaViaje { get; set; }

        public int CantidadPasajeros { get; set; }

        public float CostoTotal { get; set; }

        public int IdVehiculo { get; set; }

        public string TipoVehiculo { get; set; }
    }
}
