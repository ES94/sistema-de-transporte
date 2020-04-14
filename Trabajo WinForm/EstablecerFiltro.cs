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
    public partial class frmEstablecerFiltro : Form
    {
        public frmEstablecerFiltro()
        {
            InitializeComponent();
            FechaInicial = new DateTime();
            FechaFinal = new DateTime();
            estado = false;
        }

        public DateTime FechaInicial { get; set; }

        public DateTime FechaFinal { get; set; }

        public bool estado;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                MessageBox.Show("La fecha final del rango no puede ser menor a la fecha inicial.", "Advertencia", MessageBoxButtons.OK);
            else
            {
                FechaInicial = dtpFechaDesde.Value;
                FechaFinal = dtpFechaHasta.Value;
                estado = true;
                ActiveForm.Close();
            }
        }
    }
}
