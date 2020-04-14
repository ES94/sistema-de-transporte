namespace Trabajo_WinForm
{
    partial class frmNuevoVehiculo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxCantButacas = new System.Windows.Forms.ComboBox();
            this.chkLowCostCocheCama = new System.Windows.Forms.CheckBox();
            this.chkPermiteMascotasAlmuerzoCena = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblCantButacas = new System.Windows.Forms.Label();
            this.lblCostoPersona = new System.Windows.Forms.Label();
            this.lblCostoKm = new System.Windows.Forms.Label();
            this.mskCostoPersona = new System.Windows.Forms.MaskedTextBox();
            this.mskCostoKm = new System.Windows.Forms.MaskedTextBox();
            this.lblEmbarqueMarcaDarsena = new System.Windows.Forms.Label();
            this.cbxEmbarqueDarsena = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.mskAutonomia = new System.Windows.Forms.MaskedTextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 276);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Items.AddRange(new object[] {
            "Avión",
            "Auto",
            "Colectivo"});
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(187, 40);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoVehiculo.TabIndex = 3;
            this.cbxTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedIndexChanged);
            // 
            // cbxCantButacas
            // 
            this.cbxCantButacas.FormattingEnabled = true;
            this.cbxCantButacas.Location = new System.Drawing.Point(12, 98);
            this.cbxCantButacas.Name = "cbxCantButacas";
            this.cbxCantButacas.Size = new System.Drawing.Size(121, 21);
            this.cbxCantButacas.TabIndex = 4;
            // 
            // chkLowCostCocheCama
            // 
            this.chkLowCostCocheCama.AutoSize = true;
            this.chkLowCostCocheCama.Location = new System.Drawing.Point(187, 144);
            this.chkLowCostCocheCama.Name = "chkLowCostCocheCama";
            this.chkLowCostCocheCama.Size = new System.Drawing.Size(15, 14);
            this.chkLowCostCocheCama.TabIndex = 6;
            this.chkLowCostCocheCama.UseVisualStyleBackColor = true;
            this.chkLowCostCocheCama.Visible = false;
            // 
            // chkPermiteMascotasAlmuerzoCena
            // 
            this.chkPermiteMascotasAlmuerzoCena.AutoSize = true;
            this.chkPermiteMascotasAlmuerzoCena.Location = new System.Drawing.Point(187, 164);
            this.chkPermiteMascotasAlmuerzoCena.Name = "chkPermiteMascotasAlmuerzoCena";
            this.chkPermiteMascotasAlmuerzoCena.Size = new System.Drawing.Size(15, 14);
            this.chkPermiteMascotasAlmuerzoCena.TabIndex = 7;
            this.chkPermiteMascotasAlmuerzoCena.UseVisualStyleBackColor = true;
            this.chkPermiteMascotasAlmuerzoCena.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(184, 24);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoVehiculo.TabIndex = 9;
            this.lblTipoVehiculo.Text = "Tipo de vehículo:";
            // 
            // lblCantButacas
            // 
            this.lblCantButacas.AutoSize = true;
            this.lblCantButacas.Location = new System.Drawing.Point(12, 82);
            this.lblCantButacas.Name = "lblCantButacas";
            this.lblCantButacas.Size = new System.Drawing.Size(108, 13);
            this.lblCantButacas.TabIndex = 10;
            this.lblCantButacas.Text = "Cantidad de butacas:";
            // 
            // lblCostoPersona
            // 
            this.lblCostoPersona.AutoSize = true;
            this.lblCostoPersona.Location = new System.Drawing.Point(9, 145);
            this.lblCostoPersona.Name = "lblCostoPersona";
            this.lblCostoPersona.Size = new System.Drawing.Size(96, 13);
            this.lblCostoPersona.TabIndex = 11;
            this.lblCostoPersona.Text = "Costo por persona:";
            // 
            // lblCostoKm
            // 
            this.lblCostoKm.AutoSize = true;
            this.lblCostoKm.Location = new System.Drawing.Point(9, 202);
            this.lblCostoKm.Name = "lblCostoKm";
            this.lblCostoKm.Size = new System.Drawing.Size(73, 13);
            this.lblCostoKm.TabIndex = 12;
            this.lblCostoKm.Text = "Costo por Km:";
            // 
            // mskCostoPersona
            // 
            this.mskCostoPersona.Location = new System.Drawing.Point(12, 161);
            this.mskCostoPersona.Mask = "99999";
            this.mskCostoPersona.Name = "mskCostoPersona";
            this.mskCostoPersona.Size = new System.Drawing.Size(121, 20);
            this.mskCostoPersona.TabIndex = 13;
            this.mskCostoPersona.ValidatingType = typeof(int);
            // 
            // mskCostoKm
            // 
            this.mskCostoKm.Location = new System.Drawing.Point(12, 218);
            this.mskCostoKm.Mask = "99999";
            this.mskCostoKm.Name = "mskCostoKm";
            this.mskCostoKm.Size = new System.Drawing.Size(121, 20);
            this.mskCostoKm.TabIndex = 14;
            this.mskCostoKm.ValidatingType = typeof(int);
            // 
            // lblEmbarqueMarcaDarsena
            // 
            this.lblEmbarqueMarcaDarsena.AutoSize = true;
            this.lblEmbarqueMarcaDarsena.Location = new System.Drawing.Point(184, 82);
            this.lblEmbarqueMarcaDarsena.Name = "lblEmbarqueMarcaDarsena";
            this.lblEmbarqueMarcaDarsena.Size = new System.Drawing.Size(0, 13);
            this.lblEmbarqueMarcaDarsena.TabIndex = 15;
            // 
            // cbxEmbarqueDarsena
            // 
            this.cbxEmbarqueDarsena.FormattingEnabled = true;
            this.cbxEmbarqueDarsena.Location = new System.Drawing.Point(187, 98);
            this.cbxEmbarqueDarsena.Name = "cbxEmbarqueDarsena";
            this.cbxEmbarqueDarsena.Size = new System.Drawing.Size(121, 21);
            this.cbxEmbarqueDarsena.TabIndex = 18;
            this.cbxEmbarqueDarsena.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(187, 98);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 19;
            this.txtMarca.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(187, 161);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 20;
            this.txtModelo.Visible = false;
            // 
            // mskAutonomia
            // 
            this.mskAutonomia.Location = new System.Drawing.Point(187, 218);
            this.mskAutonomia.Mask = "99999";
            this.mskAutonomia.Name = "mskAutonomia";
            this.mskAutonomia.Size = new System.Drawing.Size(121, 20);
            this.mskAutonomia.TabIndex = 21;
            this.mskAutonomia.ValidatingType = typeof(int);
            this.mskAutonomia.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(184, 145);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 22;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Visible = false;
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.Location = new System.Drawing.Point(184, 202);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(94, 13);
            this.lblAutonomia.TabIndex = 23;
            this.lblAutonomia.Text = "Km de autonomía:";
            this.lblAutonomia.Visible = false;
            // 
            // frmNuevoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.lblAutonomia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.mskAutonomia);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cbxEmbarqueDarsena);
            this.Controls.Add(this.lblEmbarqueMarcaDarsena);
            this.Controls.Add(this.mskCostoKm);
            this.Controls.Add(this.mskCostoPersona);
            this.Controls.Add(this.lblCostoKm);
            this.Controls.Add(this.lblCostoPersona);
            this.Controls.Add(this.lblCantButacas);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.chkPermiteMascotasAlmuerzoCena);
            this.Controls.Add(this.chkLowCostCocheCama);
            this.Controls.Add(this.cbxCantButacas);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmNuevoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo vehículo";
            this.Load += new System.EventHandler(this.frmNuevoEditarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ComboBox cbxCantButacas;
        private System.Windows.Forms.CheckBox chkLowCostCocheCama;
        private System.Windows.Forms.CheckBox chkPermiteMascotasAlmuerzoCena;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblCantButacas;
        private System.Windows.Forms.Label lblCostoPersona;
        private System.Windows.Forms.Label lblCostoKm;
        private System.Windows.Forms.MaskedTextBox mskCostoPersona;
        private System.Windows.Forms.MaskedTextBox mskCostoKm;
        private System.Windows.Forms.Label lblEmbarqueMarcaDarsena;
        private System.Windows.Forms.ComboBox cbxEmbarqueDarsena;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.MaskedTextBox mskAutonomia;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAutonomia;
    }
}