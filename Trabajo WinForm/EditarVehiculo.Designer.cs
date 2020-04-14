namespace Trabajo_WinForm
{
    partial class frmEditarVehiculo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidadButacas = new System.Windows.Forms.Label();
            this.lblCostoPersona = new System.Windows.Forms.Label();
            this.lblCostoKm = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblEmbarqueMarcaDarsena = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskCostoPersona = new System.Windows.Forms.MaskedTextBox();
            this.mskCostoKm = new System.Windows.Forms.MaskedTextBox();
            this.mskAutonomia = new System.Windows.Forms.MaskedTextBox();
            this.cbxCantidadButacas = new System.Windows.Forms.ComboBox();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.cbxEmbarqueDarsena = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.chkLowCostCocheCama = new System.Windows.Forms.CheckBox();
            this.chkPermiteMascotasAlmuerzoCena = new System.Windows.Forms.CheckBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCantidadButacas
            // 
            this.lblCantidadButacas.AutoSize = true;
            this.lblCantidadButacas.Location = new System.Drawing.Point(9, 92);
            this.lblCantidadButacas.Name = "lblCantidadButacas";
            this.lblCantidadButacas.Size = new System.Drawing.Size(108, 13);
            this.lblCantidadButacas.TabIndex = 1;
            this.lblCantidadButacas.Text = "Cantidad de butacas:";
            // 
            // lblCostoPersona
            // 
            this.lblCostoPersona.AutoSize = true;
            this.lblCostoPersona.Location = new System.Drawing.Point(9, 150);
            this.lblCostoPersona.Name = "lblCostoPersona";
            this.lblCostoPersona.Size = new System.Drawing.Size(96, 13);
            this.lblCostoPersona.TabIndex = 2;
            this.lblCostoPersona.Text = "Costo por persona:";
            // 
            // lblCostoKm
            // 
            this.lblCostoKm.AutoSize = true;
            this.lblCostoKm.Location = new System.Drawing.Point(9, 206);
            this.lblCostoKm.Name = "lblCostoKm";
            this.lblCostoKm.Size = new System.Drawing.Size(73, 13);
            this.lblCostoKm.TabIndex = 3;
            this.lblCostoKm.Text = "Costo por Km:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(198, 31);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Tipo de vehículo:";
            // 
            // lblEmbarqueMarcaDarsena
            // 
            this.lblEmbarqueMarcaDarsena.AutoSize = true;
            this.lblEmbarqueMarcaDarsena.Location = new System.Drawing.Point(198, 92);
            this.lblEmbarqueMarcaDarsena.Name = "lblEmbarqueMarcaDarsena";
            this.lblEmbarqueMarcaDarsena.Size = new System.Drawing.Size(0, 13);
            this.lblEmbarqueMarcaDarsena.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(198, 150);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Visible = false;
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.Location = new System.Drawing.Point(198, 206);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(62, 13);
            this.lblAutonomia.TabIndex = 7;
            this.lblAutonomia.Text = "Autonomía:";
            this.lblAutonomia.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(161, 276);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(247, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // mskCostoPersona
            // 
            this.mskCostoPersona.Location = new System.Drawing.Point(12, 166);
            this.mskCostoPersona.Mask = "99999";
            this.mskCostoPersona.Name = "mskCostoPersona";
            this.mskCostoPersona.Size = new System.Drawing.Size(121, 20);
            this.mskCostoPersona.TabIndex = 11;
            this.mskCostoPersona.ValidatingType = typeof(int);
            // 
            // mskCostoKm
            // 
            this.mskCostoKm.Location = new System.Drawing.Point(12, 222);
            this.mskCostoKm.Mask = "99999";
            this.mskCostoKm.Name = "mskCostoKm";
            this.mskCostoKm.Size = new System.Drawing.Size(121, 20);
            this.mskCostoKm.TabIndex = 12;
            this.mskCostoKm.ValidatingType = typeof(int);
            // 
            // mskAutonomia
            // 
            this.mskAutonomia.Location = new System.Drawing.Point(201, 222);
            this.mskAutonomia.Mask = "99999";
            this.mskAutonomia.Name = "mskAutonomia";
            this.mskAutonomia.Size = new System.Drawing.Size(121, 20);
            this.mskAutonomia.TabIndex = 13;
            this.mskAutonomia.ValidatingType = typeof(int);
            this.mskAutonomia.Visible = false;
            // 
            // cbxCantidadButacas
            // 
            this.cbxCantidadButacas.FormattingEnabled = true;
            this.cbxCantidadButacas.Location = new System.Drawing.Point(12, 108);
            this.cbxCantidadButacas.Name = "cbxCantidadButacas";
            this.cbxCantidadButacas.Size = new System.Drawing.Size(121, 21);
            this.cbxCantidadButacas.TabIndex = 14;
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTipoVehiculo.Location = new System.Drawing.Point(201, 47);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.ReadOnly = true;
            this.txtTipoVehiculo.Size = new System.Drawing.Size(121, 20);
            this.txtTipoVehiculo.TabIndex = 15;
            // 
            // cbxEmbarqueDarsena
            // 
            this.cbxEmbarqueDarsena.FormattingEnabled = true;
            this.cbxEmbarqueDarsena.Location = new System.Drawing.Point(201, 108);
            this.cbxEmbarqueDarsena.Name = "cbxEmbarqueDarsena";
            this.cbxEmbarqueDarsena.Size = new System.Drawing.Size(121, 21);
            this.cbxEmbarqueDarsena.TabIndex = 16;
            this.cbxEmbarqueDarsena.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(201, 166);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 17;
            this.txtModelo.Visible = false;
            // 
            // chkLowCostCocheCama
            // 
            this.chkLowCostCocheCama.AutoSize = true;
            this.chkLowCostCocheCama.Location = new System.Drawing.Point(201, 150);
            this.chkLowCostCocheCama.Name = "chkLowCostCocheCama";
            this.chkLowCostCocheCama.Size = new System.Drawing.Size(15, 14);
            this.chkLowCostCocheCama.TabIndex = 18;
            this.chkLowCostCocheCama.UseVisualStyleBackColor = true;
            this.chkLowCostCocheCama.Visible = false;
            // 
            // chkPermiteMascotasAlmuerzoCena
            // 
            this.chkPermiteMascotasAlmuerzoCena.AutoSize = true;
            this.chkPermiteMascotasAlmuerzoCena.Location = new System.Drawing.Point(201, 166);
            this.chkPermiteMascotasAlmuerzoCena.Name = "chkPermiteMascotasAlmuerzoCena";
            this.chkPermiteMascotasAlmuerzoCena.Size = new System.Drawing.Size(15, 14);
            this.chkPermiteMascotasAlmuerzoCena.TabIndex = 19;
            this.chkPermiteMascotasAlmuerzoCena.UseVisualStyleBackColor = true;
            this.chkPermiteMascotasAlmuerzoCena.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(201, 108);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.Visible = false;
            // 
            // frmEditarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.chkPermiteMascotasAlmuerzoCena);
            this.Controls.Add(this.chkLowCostCocheCama);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cbxEmbarqueDarsena);
            this.Controls.Add(this.txtTipoVehiculo);
            this.Controls.Add(this.cbxCantidadButacas);
            this.Controls.Add(this.mskAutonomia);
            this.Controls.Add(this.mskCostoKm);
            this.Controls.Add(this.mskCostoPersona);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAutonomia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblEmbarqueMarcaDarsena);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblCostoKm);
            this.Controls.Add(this.lblCostoPersona);
            this.Controls.Add(this.lblCantidadButacas);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmEditarVehiculo";
            this.Text = "Editar vehículo";
            this.Load += new System.EventHandler(this.EditarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidadButacas;
        private System.Windows.Forms.Label lblCostoPersona;
        private System.Windows.Forms.Label lblCostoKm;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblEmbarqueMarcaDarsena;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskCostoPersona;
        private System.Windows.Forms.MaskedTextBox mskCostoKm;
        private System.Windows.Forms.MaskedTextBox mskAutonomia;
        private System.Windows.Forms.ComboBox cbxCantidadButacas;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.ComboBox cbxEmbarqueDarsena;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.CheckBox chkLowCostCocheCama;
        private System.Windows.Forms.CheckBox chkPermiteMascotasAlmuerzoCena;
        private System.Windows.Forms.TextBox txtMarca;
    }
}