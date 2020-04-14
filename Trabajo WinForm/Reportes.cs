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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            ViajesAviones = new List<Viaje>();
            ViajesAutos = new List<Viaje>();
            ViajesColectivos = new List<Viaje>();
        }

        public List<Viaje> ViajesAviones { get; set; }

        public List<Viaje> ViajesAutos { get; set; }

        public List<Viaje> ViajesColectivos { get; set; }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
                cbxMes.Items.Add(i);

            for (int i = 2000; i < 2100; i++)
                cbxAño.Items.Add(i);

            //int cantViajesAviones = ViajesAviones.Count;
            //int cantViajesAutos = ViajesAutos.Count;
            //int cantViajesColes = ViajesColectivos.Count;

            //if ((cantViajesAviones > cantViajesAutos) && (cantViajesAviones > cantViajesColes))
            //{
            //    txtPromPersonas.Text = (ViajesAviones.Average(x => x.CantidadPasajeros)).ToString();
            //    txtMasUsado.Text = "Avión";
            //}
            //else if ((cantViajesAutos > cantViajesAviones) && (cantViajesAutos > cantViajesColes))
            //{
            //    txtPromPersonas.Text = (ViajesAutos.Average(x => x.CantidadPasajeros)).ToString();
            //    txtMasUsado.Text = "Auto";
            //}
            //else if ((cantViajesColes > cantViajesAviones) && (cantViajesColes > cantViajesAutos))
            //{
            //    txtPromPersonas.Text = (ViajesColectivos.Average(x => x.CantidadPasajeros)).ToString();
            //    txtMasUsado.Text = "Colectivo";
            //}
            //else
            //{
            //    txtMasUsado.Text = "Indefinido";
            //    txtPromPersonas.Text = "Indefinido";
            //}

            TransporteMasUsadoYPromPersonas();
        }

        private void TransporteMasUsadoYPromPersonas()
        {
            List<int> masUsados = new List<int>();

            int id = 0;
            int idAvionMasUsado = 0;
            int masUsado = 0;

            while (true)
            {
                id++;

                if (ViajesAviones.Exists(x => x.IdVehiculo == id))
                {
                    if (ViajesAviones.Count(x => x.IdVehiculo == id) > masUsado)
                    {
                        masUsado = ViajesAviones.Count(x => x.IdVehiculo == id);
                        idAvionMasUsado = id;
                    }
                }
                else
                    break;
            }

            int idAutoMasUsado = 0;
            masUsados.Add(masUsado);
            masUsado = 0;
            id = 0;

            while (true)
            {
                id++;

                if (ViajesAutos.Exists(x => x.IdVehiculo == id))
                {
                    if (ViajesAutos.Count(x => x.IdVehiculo == id) > masUsado)
                    {
                        masUsado = ViajesAutos.Count(x => x.IdVehiculo == id);
                        idAutoMasUsado = id;
                    }
                }
                else
                    break;
            }

            int idColeMasUsado = 0;
            masUsados.Add(masUsado);
            masUsado = 0;
            id = 0;

            while (true)
            {
                id++;

                if (ViajesColectivos.Exists(x => x.IdVehiculo == id))
                {
                    if (ViajesColectivos.Count(x => x.IdVehiculo == id) > masUsado)
                    {
                        masUsado = ViajesColectivos.Count(x => x.IdVehiculo == id);
                        idColeMasUsado = id;
                    }
                }
                else
                    break;
            }

            masUsados.Add(masUsado);
            int tipoMasUsado = masUsados.FindIndex(x => x == masUsados.Max());

            if (tipoMasUsado == 0)
            {
                txtMasUsado.Text = string.Format("ID: {0}, tipo: avión", idAvionMasUsado);
                txtPromPersonas.Text = (ViajesAviones.Average(x => x.CantidadPasajeros)).ToString();
            }
            else if (tipoMasUsado == 1)
            {
                txtMasUsado.Text = string.Format("ID: {0}, tipo: auto", idAutoMasUsado);
                txtPromPersonas.Text = (ViajesAutos.Average(x => x.CantidadPasajeros)).ToString();
            }
            else
            {
                txtMasUsado.Text = string.Format("ID: {0}, tipo: colectivo", idColeMasUsado);
                txtPromPersonas.Text = (ViajesColectivos.Average(x => x.CantidadPasajeros)).ToString();
            }
        }

        private int CantidadViajes(int año, int mes)
        {
            int cantViajes = 0;

            foreach (Viaje v in ViajesAviones)
                if ((v.FechaViaje.Year == año) && (v.FechaViaje.Month == mes))
                    cantViajes++;

            foreach (Viaje v in ViajesAutos)
                if ((v.FechaViaje.Year == año) && (v.FechaViaje.Month) == mes)
                    cantViajes++;

            foreach (Viaje v in ViajesColectivos)
                if ((v.FechaViaje.Year == año) && (v.FechaViaje.Month == mes))
                    cantViajes++;

            return cantViajes;
        }

        private void btnCalcularCantViajes_Click(object sender, EventArgs e)
        {
            if ((cbxAño.SelectedIndex == -1) && (cbxMes.SelectedIndex == -1))
                MessageBox.Show("Debe un mes y un año.", "Advertencia", MessageBoxButtons.OK);
            else
            {
                int año = Convert.ToInt16(cbxAño.Text);
                int mes = Convert.ToInt16(cbxMes.Text);

                txtCantViajes.Text = CantidadViajes(año, mes).ToString();
            }
        }

        private float GananciasTotales(int tipoTransporte)
        {
            if (tipoTransporte == 0)
                return ViajesAviones.Sum(x => x.CostoTotal);
            else if (tipoTransporte == 1)
                return ViajesAutos.Sum(x => x.CostoTotal);
            else
                return ViajesColectivos.Sum(x => x.CostoTotal);
        }

        private void btnCalcularGanancias_Click(object sender, EventArgs e)
        {
            if (cbxTipoVehiculo.SelectedIndex == -1)
                MessageBox.Show("Debe elegir un tipo de vehículo.", "Advertencia", MessageBoxButtons.OK);
            else
                txtGananciasTotales.Text = GananciasTotales(cbxTipoVehiculo.SelectedIndex).ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
