using System;
using Newtonsoft.Json;
using System.IO;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
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

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            frmVehiculos form = new frmVehiculos();
            form.Owner = this;
            form.Aviones = Aviones;
            form.Autos = Autos;
            form.Colectivos = Colectivos;
            form.ShowDialog();
            Aviones = form.Aviones;
            Autos = form.Autos;
            Colectivos = form.Colectivos;
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            frmViajes form = new frmViajes();
            form.Owner = this;
            form.Aviones = Aviones;
            form.Autos = Autos;
            form.Colectivos = Colectivos;
            form.ViajesAviones = ViajesAviones;
            form.ViajesAutos = ViajesAutos;
            form.ViajesColectivos = ViajesColectivos;
            form.ShowDialog();
            ViajesAviones = form.ViajesAviones;
            ViajesAutos = form.ViajesAutos;
            ViajesColectivos = form.ViajesColectivos;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes form = new frmReportes();
            form.Owner = this;
            form.ViajesAviones = ViajesAviones;
            form.ViajesAutos = ViajesAutos;
            form.ViajesColectivos = ViajesColectivos;
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Realmente desea salir?", "Información", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                ActiveForm.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string pathAviones = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\Aviones.json";
            string pathAutos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\Autos.json";
            string pathColectivos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\Colectivos.json";
            string pathViajesAviones = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\ViajesAviones.json";
            string pathViajesAutos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\ViajesAutos.json";
            string pathViajesColectivos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\ViajesColectivos.json";

            if (!File.Exists(pathAviones))
                File.Create(pathAviones);
            else
            {
                using (StreamReader archivo = new StreamReader(pathAviones))
                {
                    string contenido = archivo.ReadToEnd();

                    if (contenido != "null")
                        Aviones = JsonConvert.DeserializeObject<List<Avion>>(contenido);
                }
            }

            if (!File.Exists(pathAutos))
                File.Create(pathAutos);
            else
            {
                using (StreamReader archivo = new StreamReader(pathAutos))
                {
                    string contenido = archivo.ReadToEnd();

                    if (contenido != "null")
                        Autos = JsonConvert.DeserializeObject<List<Auto>>(contenido);
                }
            }

            if (!File.Exists(pathColectivos))
                File.Create(pathColectivos);
            else
            {
                using (StreamReader archivo = new StreamReader(pathColectivos))
                {
                    string contenido = archivo.ReadToEnd();

                    if (contenido != "null")
                        Colectivos = JsonConvert.DeserializeObject<List<Colectivo>>(contenido);
                }
            }

            ViajesAviones = AbrirCrearArchivosViajes(pathViajesAviones, ViajesAviones);
            ViajesAutos = AbrirCrearArchivosViajes(pathViajesAutos, ViajesAutos);
            ViajesColectivos = AbrirCrearArchivosViajes(pathViajesColectivos, ViajesColectivos);
        }

        private List<Viaje> AbrirCrearArchivosViajes(string path, List<Viaje> list)
        {
            if (!File.Exists(path))
                File.Create(path);
            else
            {
                using (StreamReader archivo = new StreamReader(path))
                {
                    string contenido = archivo.ReadToEnd();

                    if (contenido != "null")
                        list = JsonConvert.DeserializeObject<List<Viaje>>(contenido);
                }
            }

            return list;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string pathAviones = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\Aviones.json";
            string pathAutos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\Autos.json";
            string pathColectivos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\Colectivos.json";
            string pathViajesAviones = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\ViajesAviones.json";
            string pathViajesAutos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\ViajesAutos.json";
            string pathViajesColectivos = "D:\\UCSE\\2° Año\\Anuales\\Programación I\\Trabajo WinForm\\ViajesColectivos.json";

            using (StreamWriter archivo = new StreamWriter(pathAviones, false))
            {
                string contenido = JsonConvert.SerializeObject(Aviones);
                archivo.Write(contenido);
            }

            using (StreamWriter archivo = new StreamWriter(pathAutos, false))
            {
                string contenido = JsonConvert.SerializeObject(Autos);
                archivo.Write(contenido);
            }

            using (StreamWriter archivo = new StreamWriter(pathColectivos, false))
            {
                string contenido = JsonConvert.SerializeObject(Colectivos);
                archivo.Write(contenido);
            }

            GrabarArchivosViajes(pathViajesAviones, ViajesAviones);
            GrabarArchivosViajes(pathViajesAutos, ViajesAutos);
            GrabarArchivosViajes(pathViajesColectivos, ViajesColectivos);
        }

        private void GrabarArchivosViajes(string path, List<Viaje> list)
        {
            using (StreamWriter archivo = new StreamWriter(path, false))
            {
                string contenido = JsonConvert.SerializeObject(list);
                archivo.Write(contenido);
            }
        }
    }
}
