namespace Trabajo_WinForm
{
    partial class frmNuevoViaje
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
            this.txtCiudadOrigen = new System.Windows.Forms.TextBox();
            this.txtCiudadDestino = new System.Windows.Forms.TextBox();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.cbxCantidadPasajeros = new System.Windows.Forms.ComboBox();
            this.lblCiudadOrigen = new System.Windows.Forms.Label();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblFechaViaje = new System.Windows.Forms.Label();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.btnSeleccionarVehiculo = new System.Windows.Forms.Button();
            this.txtSeleccionarVehiculo = new System.Windows.Forms.TextBox();
            this.lblSeleccionarVehiculo = new System.Windows.Forms.Label();
            this.mskCantidadKm = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidadKm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCiudadOrigen
            // 
            this.txtCiudadOrigen.Location = new System.Drawing.Point(12, 45);
            this.txtCiudadOrigen.Name = "txtCiudadOrigen";
            this.txtCiudadOrigen.Size = new System.Drawing.Size(121, 20);
            this.txtCiudadOrigen.TabIndex = 0;
            // 
            // txtCiudadDestino
            // 
            this.txtCiudadDestino.Location = new System.Drawing.Point(158, 45);
            this.txtCiudadDestino.Name = "txtCiudadDestino";
            this.txtCiudadDestino.Size = new System.Drawing.Size(121, 20);
            this.txtCiudadDestino.TabIndex = 1;
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Location = new System.Drawing.Point(12, 105);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaViaje.TabIndex = 2;
            // 
            // cbxCantidadPasajeros
            // 
            this.cbxCantidadPasajeros.FormattingEnabled = true;
            this.cbxCantidadPasajeros.Location = new System.Drawing.Point(158, 166);
            this.cbxCantidadPasajeros.Name = "cbxCantidadPasajeros";
            this.cbxCantidadPasajeros.Size = new System.Drawing.Size(121, 21);
            this.cbxCantidadPasajeros.TabIndex = 3;
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(9, 29);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(90, 13);
            this.lblCiudadOrigen.TabIndex = 5;
            this.lblCiudadOrigen.Text = "Ciudad de origen:";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(155, 29);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(95, 13);
            this.lblCiudadDestino.TabIndex = 6;
            this.lblCiudadDestino.Text = "Ciudad de destino:";
            // 
            // lblFechaViaje
            // 
            this.lblFechaViaje.AutoSize = true;
            this.lblFechaViaje.Location = new System.Drawing.Point(12, 89);
            this.lblFechaViaje.Name = "lblFechaViaje";
            this.lblFechaViaje.Size = new System.Drawing.Size(82, 13);
            this.lblFechaViaje.TabIndex = 7;
            this.lblFechaViaje.Text = "Fecha del viaje:";
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(155, 150);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(115, 13);
            this.lblCantidadPasajeros.TabIndex = 8;
            this.lblCantidadPasajeros.Text = "Cantidad de pasajeros:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(166, 276);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(247, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Items.AddRange(new object[] {
            "Avión",
            "Auto",
            "Colectivo"});
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(12, 166);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoVehiculo.TabIndex = 12;
            this.cbxTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedIndexChanged);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(13, 150);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoVehiculo.TabIndex = 13;
            this.lblTipoVehiculo.Text = "Tipo de vehículo:";
            // 
            // btnSeleccionarVehiculo
            // 
            this.btnSeleccionarVehiculo.Location = new System.Drawing.Point(108, 225);
            this.btnSeleccionarVehiculo.Name = "btnSeleccionarVehiculo";
            this.btnSeleccionarVehiculo.Size = new System.Drawing.Size(25, 20);
            this.btnSeleccionarVehiculo.TabIndex = 14;
            this.btnSeleccionarVehiculo.Text = "...";
            this.btnSeleccionarVehiculo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVehiculo.Click += new System.EventHandler(this.btnSeleccionarVehiculo_Click);
            // 
            // txtSeleccionarVehiculo
            // 
            this.txtSeleccionarVehiculo.Location = new System.Drawing.Point(12, 226);
            this.txtSeleccionarVehiculo.Name = "txtSeleccionarVehiculo";
            this.txtSeleccionarVehiculo.Size = new System.Drawing.Size(96, 20);
            this.txtSeleccionarVehiculo.TabIndex = 15;
            // 
            // lblSeleccionarVehiculo
            // 
            this.lblSeleccionarVehiculo.AutoSize = true;
            this.lblSeleccionarVehiculo.Location = new System.Drawing.Point(9, 210);
            this.lblSeleccionarVehiculo.Name = "lblSeleccionarVehiculo";
            this.lblSeleccionarVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblSeleccionarVehiculo.TabIndex = 16;
            this.lblSeleccionarVehiculo.Text = "Vehículo:";
            // 
            // mskCantidadKm
            // 
            this.mskCantidadKm.Location = new System.Drawing.Point(158, 226);
            this.mskCantidadKm.Mask = "9999";
            this.mskCantidadKm.Name = "mskCantidadKm";
            this.mskCantidadKm.Size = new System.Drawing.Size(121, 20);
            this.mskCantidadKm.TabIndex = 17;
            this.mskCantidadKm.Visible = false;
            // 
            // lblCantidadKm
            // 
            this.lblCantidadKm.AutoSize = true;
            this.lblCantidadKm.Location = new System.Drawing.Point(158, 210);
            this.lblCantidadKm.Name = "lblCantidadKm";
            this.lblCantidadKm.Size = new System.Drawing.Size(85, 13);
            this.lblCantidadKm.TabIndex = 18;
            this.lblCantidadKm.Text = "Cantidad de Km:";
            this.lblCantidadKm.Visible = false;
            // 
            // frmNuevoViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.lblCantidadKm);
            this.Controls.Add(this.mskCantidadKm);
            this.Controls.Add(this.lblSeleccionarVehiculo);
            this.Controls.Add(this.txtSeleccionarVehiculo);
            this.Controls.Add(this.btnSeleccionarVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCantidadPasajeros);
            this.Controls.Add(this.lblFechaViaje);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.lblCiudadOrigen);
            this.Controls.Add(this.cbxCantidadPasajeros);
            this.Controls.Add(this.dtpFechaViaje);
            this.Controls.Add(this.txtCiudadDestino);
            this.Controls.Add(this.txtCiudadOrigen);
            this.Name = "frmNuevoViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo viaje";
            this.Load += new System.EventHandler(this.frmNuevoViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCiudadOrigen;
        private System.Windows.Forms.TextBox txtCiudadDestino;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.ComboBox cbxCantidadPasajeros;
        private System.Windows.Forms.Label lblCiudadOrigen;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblFechaViaje;
        private System.Windows.Forms.Label lblCantidadPasajeros;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Button btnSeleccionarVehiculo;
        private System.Windows.Forms.TextBox txtSeleccionarVehiculo;
        private System.Windows.Forms.Label lblSeleccionarVehiculo;
        private System.Windows.Forms.MaskedTextBox mskCantidadKm;
        private System.Windows.Forms.Label lblCantidadKm;
    }
}