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
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
            Aviones = new List<Avion>();
            Autos = new List<Auto>();
            Colectivos = new List<Colectivo>();
        }

        public List<Avion> Aviones { get; set; }

        public List<Auto> Autos { get; set; }

        public List<Colectivo> Colectivos { get; set; }

        private void bmnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            frmNuevoVehiculo form = new frmNuevoVehiculo();
            form.Owner = this;
            form.Aviones = Aviones;
            form.Autos = Autos;
            form.Colectivos = Colectivos;
            form.ShowDialog();

            if (form.estado)
            {
                if (form.tipo == 0)
                {
                    Aviones.Add(form.Avion);
                    srcAviones.ResetBindings(true);
                    dgvAviones.Refresh();
                }
                else if (form.tipo == 1)
                {
                    Autos.Add(form.Auto);
                    srcAutos.ResetBindings(true);
                    dgvAutos.Refresh();
                }
                else
                {
                    Colectivos.Add(form.Colectivo);
                    srcColectivos.ResetBindings(true);
                    dgvColectivos.Refresh();
                }
            }
        }

        private void bmnEditarVehiculo_Click(object sender, EventArgs e)
        {
            
        }

        private void bmnSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            srcAviones.DataSource = Aviones;
            srcAviones.Sort = "Numero";
            srcAutos.DataSource = Autos;
            srcAutos.Sort = "Numero";
            srcColectivos.DataSource = Colectivos;
            srcColectivos.Sort = "Numero";
        }

        private void bmnGananciaTotal_Click(object sender, EventArgs e)
        {
            frmObtenerGananciaTotal form = new frmObtenerGananciaTotal();
            form.Owner = this;
            form.ShowDialog();
        }

        private void bnvEditarAvion_Click(object sender, EventArgs e)
        {
            if (dgvAviones.Rows.Count != 0)
            {
                frmEditarVehiculo form = new frmEditarVehiculo();
                form.Owner = this;
                int num = Convert.ToInt16(dgvAviones.CurrentRow.Cells[0].Value);
                form.Avion = Aviones.Find(x => x.Numero == num);
                form.tipoElegido = 0;
                form.ShowDialog();
                int pos = Aviones.FindIndex(x => x.Numero == form.Avion.Numero);
                Aviones[pos] = form.Avion;
                srcAviones.ResetBindings(true);
                dgvAviones.Refresh();
            }
        }

        private void bnvEditarAuto_Click(object sender, EventArgs e)
        {
            if (dgvAutos.Rows.Count != 0)
            {
                frmEditarVehiculo form = new frmEditarVehiculo();
                form.Owner = this;
                int num = Convert.ToInt16(dgvAutos.CurrentRow.Cells[0].Value);
                form.Auto = Autos.Find(x => x.Numero == num);
                form.tipoElegido = 1;
                form.ShowDialog();
                int pos = Autos.FindIndex(x => x.Numero == form.Auto.Numero);
                Autos[pos] = form.Auto;
                srcAutos.ResetBindings(true);
                dgvAutos.Refresh();
            }
        }

        private void bnvEditarCole_Click(object sender, EventArgs e)
        {
            if (dgvColectivos.Rows.Count != 0)
            {
                frmEditarVehiculo form = new frmEditarVehiculo();
                form.Owner = this;
                int num = Convert.ToInt16(dgvColectivos.CurrentRow.Cells[0].Value);
                form.Colectivo = Colectivos.Find(x => x.Numero == num);
                form.tipoElegido = 2;
                form.ShowDialog();
                int pos = Colectivos.FindIndex(x => x.Numero == form.Colectivo.Numero);
                Colectivos[pos] = form.Colectivo;
                srcColectivos.ResetBindings(true);
                dgvColectivos.Refresh();
            }
        }
    }

    public abstract class Vehiculo
    {
        public int Numero { get; set; }

        public string Nombre { get; set; }

        public int CantidadButacas { get; set; }

        public float CostoPorPersona { get; set; }

        public float CostoPorKm { get; set; }
    }

    public class Avion : Vehiculo
    {
        public Avion(int numero, string nombre, int cantButacas, float costoPersona, float costoKm, int pEmbarque, bool lowCost, bool permiteMascotas)
        {
            Numero = numero;
            Nombre = nombre;
            CantidadButacas = cantButacas;
            CostoPorPersona = costoPersona;
            CostoPorKm = costoKm;
            PuertaEmbarque = pEmbarque;
            LowCost = lowCost;
            PermiteMascotas = permiteMascotas;
        }

        public int PuertaEmbarque { get; set; }

        public bool LowCost { get; set; }

        public bool PermiteMascotas { get; set; }
    }

    public class Auto : Vehiculo
    {
        public Auto(int numero, string nombre, int cantButacas, float costoPersona, float costoKm, string marca, string modelo, int autonomia)
        {
            Numero = numero;
            Nombre = nombre;
            CantidadButacas = cantButacas;
            CostoPorPersona = costoPersona;
            CostoPorKm = costoKm;
            Marca = marca;
            Modelo = modelo;
            Autonomia = autonomia;
        }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Autonomia { get; set; }
    }

    public class Colectivo : Vehiculo
    {
        public Colectivo(int numero, string nombre, int cantButacas, float costoPersona, float costoKm, int numDarsena, bool cocheCama, bool almuerzoCena)
        {
            Numero = numero;
            Nombre = nombre;
            CantidadButacas = cantButacas;
            CostoPorPersona = costoPersona;
            CostoPorKm = costoKm;
            NumeroDarsena = numDarsena;
            CocheCama = cocheCama;
            AlmuerzoCena = almuerzoCena;
        }

        public int NumeroDarsena { get; set; }

        public bool CocheCama { get; set; }

        public bool AlmuerzoCena { get; set; }
    }
}
