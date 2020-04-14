namespace Trabajo_WinForm
{
    partial class frmObtenerGananciaTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblCantidadButacas = new System.Windows.Forms.Label();
            this.lblCostoPersona = new System.Windows.Forms.Label();
            this.cbxCantidadButacas = new System.Windows.Forms.ComboBox();
            this.mskCostoPersona = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Items.AddRange(new object[] {
            "Avión",
            "Auto",
            "Colectivo"});
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(12, 51);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoVehiculo.TabIndex = 0;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(9, 35);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoVehiculo.TabIndex = 1;
            this.lblTipoVehiculo.Text = "Tipo de vehículo:";
            // 
            // lblCantidadButacas
            // 
            this.lblCantidadButacas.AutoSize = true;
            this.lblCantidadButacas.Location = new System.Drawing.Point(148, 35);
            this.lblCantidadButacas.Name = "lblCantidadButacas";
            this.lblCantidadButacas.Size = new System.Drawing.Size(108, 13);
            this.lblCantidadButacas.TabIndex = 2;
            this.lblCantidadButacas.Text = "Cantidad de butacas:";
            // 
            // lblCostoPersona
            // 
            this.lblCostoPersona.AutoSize = true;
            this.lblCostoPersona.Location = new System.Drawing.Point(9, 103);
            this.lblCostoPersona.Name = "lblCostoPersona";
            this.lblCostoPersona.Size = new System.Drawing.Size(96, 13);
            this.lblCostoPersona.TabIndex = 3;
            this.lblCostoPersona.Text = "Costo por persona:";
            // 
            // cbxCantidadButacas
            // 
            this.cbxCantidadButacas.FormattingEnabled = true;
            this.cbxCantidadButacas.Location = new System.Drawing.Point(151, 51);
            this.cbxCantidadButacas.Name = "cbxCantidadButacas";
            this.cbxCantidadButacas.Size = new System.Drawing.Size(121, 21);
            this.cbxCantidadButacas.TabIndex = 5;
            // 
            // mskCostoPersona
            // 
            this.mskCostoPersona.Location = new System.Drawing.Point(12, 119);
            this.mskCostoPersona.Mask = "99999";
            this.mskCostoPersona.Name = "mskCostoPersona";
            this.mskCostoPersona.Size = new System.Drawing.Size(121, 20);
            this.mskCostoPersona.TabIndex = 6;
            this.mskCostoPersona.ValidatingType = typeof(int);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(116, 226);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.lblResultado);
            this.gbxResultado.Location = new System.Drawing.Point(50, 145);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(183, 75);
            this.gbxResultado.TabIndex = 9;
            this.gbxResultado.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 33);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 0;
            // 
            // frmObtenerGananciaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mskCostoPersona);
            this.Controls.Add(this.cbxCantidadButacas);
            this.Controls.Add(this.lblCostoPersona);
            this.Controls.Add(this.lblCantidadButacas);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Name = "frmObtenerGananciaTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener ganancia total";
            this.Load += new System.EventHandler(this.frmObtenerGananciaMaxima_Load);
            this.gbxResultado.ResumeLayout(false);
            this.gbxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblCantidadButacas;
        private System.Windows.Forms.Label lblCostoPersona;
        private System.Windows.Forms.ComboBox cbxCantidadButacas;
        private System.Windows.Forms.MaskedTextBox mskCostoPersona;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}