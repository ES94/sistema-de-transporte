namespace Trabajo_WinForm
{
    partial class frmCalcularCostoViaje
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
            this.mskCostoPersonaKm = new System.Windows.Forms.MaskedTextBox();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblCantPersonasKm = new System.Windows.Forms.Label();
            this.lblCostoPersonaKm = new System.Windows.Forms.Label();
            this.chkLowCostCocheCama = new System.Windows.Forms.CheckBox();
            this.chkAlmuerzoCena = new System.Windows.Forms.CheckBox();
            this.cbxCantPersonas = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.mskCantidadKm = new System.Windows.Forms.MaskedTextBox();
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
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(12, 40);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoVehiculo.TabIndex = 0;
            this.cbxTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedIndexChanged);
            // 
            // mskCostoPersonaKm
            // 
            this.mskCostoPersonaKm.Location = new System.Drawing.Point(150, 40);
            this.mskCostoPersonaKm.Mask = "9999";
            this.mskCostoPersonaKm.Name = "mskCostoPersonaKm";
            this.mskCostoPersonaKm.Size = new System.Drawing.Size(121, 20);
            this.mskCostoPersonaKm.TabIndex = 1;
            this.mskCostoPersonaKm.Visible = false;
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.lblResultado);
            this.gbxResultado.Location = new System.Drawing.Point(47, 133);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(183, 71);
            this.gbxResultado.TabIndex = 3;
            this.gbxResultado.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(116, 226);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(197, 226);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(12, 21);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoVehiculo.TabIndex = 6;
            this.lblTipoVehiculo.Text = "Tipo de vehículo:";
            // 
            // lblCantPersonasKm
            // 
            this.lblCantPersonasKm.AutoSize = true;
            this.lblCantPersonasKm.Location = new System.Drawing.Point(12, 76);
            this.lblCantPersonasKm.Name = "lblCantPersonasKm";
            this.lblCantPersonasKm.Size = new System.Drawing.Size(0, 13);
            this.lblCantPersonasKm.TabIndex = 7;
            this.lblCantPersonasKm.Visible = false;
            // 
            // lblCostoPersonaKm
            // 
            this.lblCostoPersonaKm.AutoSize = true;
            this.lblCostoPersonaKm.Location = new System.Drawing.Point(150, 21);
            this.lblCostoPersonaKm.Name = "lblCostoPersonaKm";
            this.lblCostoPersonaKm.Size = new System.Drawing.Size(0, 13);
            this.lblCostoPersonaKm.TabIndex = 8;
            this.lblCostoPersonaKm.Visible = false;
            // 
            // chkLowCostCocheCama
            // 
            this.chkLowCostCocheCama.AutoSize = true;
            this.chkLowCostCocheCama.Location = new System.Drawing.Point(150, 75);
            this.chkLowCostCocheCama.Name = "chkLowCostCocheCama";
            this.chkLowCostCocheCama.Size = new System.Drawing.Size(15, 14);
            this.chkLowCostCocheCama.TabIndex = 9;
            this.chkLowCostCocheCama.UseVisualStyleBackColor = true;
            this.chkLowCostCocheCama.Visible = false;
            // 
            // chkAlmuerzoCena
            // 
            this.chkAlmuerzoCena.AutoSize = true;
            this.chkAlmuerzoCena.Location = new System.Drawing.Point(150, 95);
            this.chkAlmuerzoCena.Name = "chkAlmuerzoCena";
            this.chkAlmuerzoCena.Size = new System.Drawing.Size(97, 17);
            this.chkAlmuerzoCena.TabIndex = 10;
            this.chkAlmuerzoCena.Text = "Amuerzo/Cena";
            this.chkAlmuerzoCena.UseVisualStyleBackColor = true;
            this.chkAlmuerzoCena.Visible = false;
            // 
            // cbxCantPersonas
            // 
            this.cbxCantPersonas.FormattingEnabled = true;
            this.cbxCantPersonas.Location = new System.Drawing.Point(12, 93);
            this.cbxCantPersonas.Name = "cbxCantPersonas";
            this.cbxCantPersonas.Size = new System.Drawing.Size(121, 21);
            this.cbxCantPersonas.TabIndex = 11;
            this.cbxCantPersonas.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 0;
            // 
            // mskCantidadKm
            // 
            this.mskCantidadKm.Location = new System.Drawing.Point(12, 93);
            this.mskCantidadKm.Mask = "9999";
            this.mskCantidadKm.Name = "mskCantidadKm";
            this.mskCantidadKm.Size = new System.Drawing.Size(121, 20);
            this.mskCantidadKm.TabIndex = 12;
            this.mskCantidadKm.Visible = false;
            // 
            // frmCalcularCostoViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mskCantidadKm);
            this.Controls.Add(this.cbxCantPersonas);
            this.Controls.Add(this.chkAlmuerzoCena);
            this.Controls.Add(this.chkLowCostCocheCama);
            this.Controls.Add(this.lblCostoPersonaKm);
            this.Controls.Add(this.lblCantPersonasKm);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.mskCostoPersonaKm);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Name = "frmCalcularCostoViaje";
            this.Text = "Calcular costo de viaje";
            this.Load += new System.EventHandler(this.frmCalcularCostoViaje_Load);
            this.gbxResultado.ResumeLayout(false);
            this.gbxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.MaskedTextBox mskCostoPersonaKm;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblCantPersonasKm;
        private System.Windows.Forms.Label lblCostoPersonaKm;
        private System.Windows.Forms.CheckBox chkLowCostCocheCama;
        private System.Windows.Forms.CheckBox chkAlmuerzoCena;
        private System.Windows.Forms.ComboBox cbxCantPersonas;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.MaskedTextBox mskCantidadKm;
    }
}