namespace Trabajo_WinForm
{
    partial class frmReportes
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
            this.gbxMasUsadoPromPersonas = new System.Windows.Forms.GroupBox();
            this.gbxCantViajesRealizados = new System.Windows.Forms.GroupBox();
            this.gbxTotalGanancias = new System.Windows.Forms.GroupBox();
            this.lblMasUsado = new System.Windows.Forms.Label();
            this.lblPromPersonas = new System.Windows.Forms.Label();
            this.txtMasUsado = new System.Windows.Forms.TextBox();
            this.txtPromPersonas = new System.Windows.Forms.TextBox();
            this.cbxAño = new System.Windows.Forms.ComboBox();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblCantViajes = new System.Windows.Forms.Label();
            this.txtCantViajes = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.lblGananciasTotales = new System.Windows.Forms.Label();
            this.txtGananciasTotales = new System.Windows.Forms.TextBox();
            this.btnCalcularCantViajes = new System.Windows.Forms.Button();
            this.btnCalcularGanancias = new System.Windows.Forms.Button();
            this.gbxMasUsadoPromPersonas.SuspendLayout();
            this.gbxCantViajesRealizados.SuspendLayout();
            this.gbxTotalGanancias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMasUsadoPromPersonas
            // 
            this.gbxMasUsadoPromPersonas.Controls.Add(this.txtPromPersonas);
            this.gbxMasUsadoPromPersonas.Controls.Add(this.txtMasUsado);
            this.gbxMasUsadoPromPersonas.Controls.Add(this.lblPromPersonas);
            this.gbxMasUsadoPromPersonas.Controls.Add(this.lblMasUsado);
            this.gbxMasUsadoPromPersonas.Location = new System.Drawing.Point(12, 12);
            this.gbxMasUsadoPromPersonas.Name = "gbxMasUsadoPromPersonas";
            this.gbxMasUsadoPromPersonas.Size = new System.Drawing.Size(600, 113);
            this.gbxMasUsadoPromPersonas.TabIndex = 0;
            this.gbxMasUsadoPromPersonas.TabStop = false;
            this.gbxMasUsadoPromPersonas.Text = "Tipo de transporte más usado y promedio de pasajeros";
            // 
            // gbxCantViajesRealizados
            // 
            this.gbxCantViajesRealizados.Controls.Add(this.btnCalcularCantViajes);
            this.gbxCantViajesRealizados.Controls.Add(this.txtCantViajes);
            this.gbxCantViajesRealizados.Controls.Add(this.lblCantViajes);
            this.gbxCantViajesRealizados.Controls.Add(this.lblMes);
            this.gbxCantViajesRealizados.Controls.Add(this.lblAño);
            this.gbxCantViajesRealizados.Controls.Add(this.cbxMes);
            this.gbxCantViajesRealizados.Controls.Add(this.cbxAño);
            this.gbxCantViajesRealizados.Location = new System.Drawing.Point(12, 131);
            this.gbxCantViajesRealizados.Name = "gbxCantViajesRealizados";
            this.gbxCantViajesRealizados.Size = new System.Drawing.Size(600, 73);
            this.gbxCantViajesRealizados.TabIndex = 1;
            this.gbxCantViajesRealizados.TabStop = false;
            this.gbxCantViajesRealizados.Text = "Cantidad de viajes realizados en un determinado año y mes";
            // 
            // gbxTotalGanancias
            // 
            this.gbxTotalGanancias.Controls.Add(this.btnCalcularGanancias);
            this.gbxTotalGanancias.Controls.Add(this.txtGananciasTotales);
            this.gbxTotalGanancias.Controls.Add(this.lblGananciasTotales);
            this.gbxTotalGanancias.Controls.Add(this.lblTipoTransporte);
            this.gbxTotalGanancias.Controls.Add(this.cbxTipoVehiculo);
            this.gbxTotalGanancias.Location = new System.Drawing.Point(12, 210);
            this.gbxTotalGanancias.Name = "gbxTotalGanancias";
            this.gbxTotalGanancias.Size = new System.Drawing.Size(600, 104);
            this.gbxTotalGanancias.TabIndex = 2;
            this.gbxTotalGanancias.TabStop = false;
            this.gbxTotalGanancias.Text = "Totalidad de ganancias por tipo de transporte";
            // 
            // lblMasUsado
            // 
            this.lblMasUsado.AutoSize = true;
            this.lblMasUsado.Location = new System.Drawing.Point(6, 37);
            this.lblMasUsado.Name = "lblMasUsado";
            this.lblMasUsado.Size = new System.Drawing.Size(150, 13);
            this.lblMasUsado.TabIndex = 0;
            this.lblMasUsado.Text = "Tipo de transporte más usado:";
            // 
            // lblPromPersonas
            // 
            this.lblPromPersonas.AutoSize = true;
            this.lblPromPersonas.Location = new System.Drawing.Point(6, 75);
            this.lblPromPersonas.Name = "lblPromPersonas";
            this.lblPromPersonas.Size = new System.Drawing.Size(299, 13);
            this.lblPromPersonas.TabIndex = 1;
            this.lblPromPersonas.Text = "Promedio de personas que más usaron este tipo de vehículo: ";
            // 
            // txtMasUsado
            // 
            this.txtMasUsado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMasUsado.Location = new System.Drawing.Point(162, 34);
            this.txtMasUsado.Name = "txtMasUsado";
            this.txtMasUsado.ReadOnly = true;
            this.txtMasUsado.Size = new System.Drawing.Size(141, 20);
            this.txtMasUsado.TabIndex = 2;
            // 
            // txtPromPersonas
            // 
            this.txtPromPersonas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPromPersonas.Location = new System.Drawing.Point(311, 72);
            this.txtPromPersonas.Name = "txtPromPersonas";
            this.txtPromPersonas.ReadOnly = true;
            this.txtPromPersonas.Size = new System.Drawing.Size(100, 20);
            this.txtPromPersonas.TabIndex = 3;
            // 
            // cbxAño
            // 
            this.cbxAño.FormattingEnabled = true;
            this.cbxAño.Location = new System.Drawing.Point(41, 33);
            this.cbxAño.Name = "cbxAño";
            this.cbxAño.Size = new System.Drawing.Size(59, 21);
            this.cbxAño.TabIndex = 0;
            // 
            // cbxMes
            // 
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Location = new System.Drawing.Point(162, 33);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(44, 21);
            this.cbxMes.TabIndex = 1;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(6, 36);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(126, 36);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Mes:";
            // 
            // lblCantViajes
            // 
            this.lblCantViajes.AutoSize = true;
            this.lblCantViajes.Location = new System.Drawing.Point(227, 36);
            this.lblCantViajes.Name = "lblCantViajes";
            this.lblCantViajes.Size = new System.Drawing.Size(147, 13);
            this.lblCantViajes.TabIndex = 4;
            this.lblCantViajes.Text = "Cantidad de viajes realizados:";
            // 
            // txtCantViajes
            // 
            this.txtCantViajes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCantViajes.Location = new System.Drawing.Point(380, 33);
            this.txtCantViajes.Name = "txtCantViajes";
            this.txtCantViajes.ReadOnly = true;
            this.txtCantViajes.Size = new System.Drawing.Size(100, 20);
            this.txtCantViajes.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(537, 406);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Items.AddRange(new object[] {
            "Avión",
            "Auto",
            "Colectivo"});
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(163, 33);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoVehiculo.TabIndex = 0;
            // 
            // lblTipoTransporte
            // 
            this.lblTipoTransporte.AutoSize = true;
            this.lblTipoTransporte.Location = new System.Drawing.Point(6, 36);
            this.lblTipoTransporte.Name = "lblTipoTransporte";
            this.lblTipoTransporte.Size = new System.Drawing.Size(151, 13);
            this.lblTipoTransporte.TabIndex = 1;
            this.lblTipoTransporte.Text = "Seleccionar tipo de transporte:";
            // 
            // lblGananciasTotales
            // 
            this.lblGananciasTotales.AutoSize = true;
            this.lblGananciasTotales.Location = new System.Drawing.Point(308, 36);
            this.lblGananciasTotales.Name = "lblGananciasTotales";
            this.lblGananciasTotales.Size = new System.Drawing.Size(95, 13);
            this.lblGananciasTotales.TabIndex = 2;
            this.lblGananciasTotales.Text = "Ganancias totales:";
            // 
            // txtGananciasTotales
            // 
            this.txtGananciasTotales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGananciasTotales.Location = new System.Drawing.Point(409, 33);
            this.txtGananciasTotales.Name = "txtGananciasTotales";
            this.txtGananciasTotales.ReadOnly = true;
            this.txtGananciasTotales.Size = new System.Drawing.Size(100, 20);
            this.txtGananciasTotales.TabIndex = 3;
            // 
            // btnCalcularCantViajes
            // 
            this.btnCalcularCantViajes.Location = new System.Drawing.Point(519, 31);
            this.btnCalcularCantViajes.Name = "btnCalcularCantViajes";
            this.btnCalcularCantViajes.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularCantViajes.TabIndex = 6;
            this.btnCalcularCantViajes.Text = "Calcular";
            this.btnCalcularCantViajes.UseVisualStyleBackColor = true;
            this.btnCalcularCantViajes.Click += new System.EventHandler(this.btnCalcularCantViajes_Click);
            // 
            // btnCalcularGanancias
            // 
            this.btnCalcularGanancias.Location = new System.Drawing.Point(519, 64);
            this.btnCalcularGanancias.Name = "btnCalcularGanancias";
            this.btnCalcularGanancias.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularGanancias.TabIndex = 4;
            this.btnCalcularGanancias.Text = "Calcular";
            this.btnCalcularGanancias.UseVisualStyleBackColor = true;
            this.btnCalcularGanancias.Click += new System.EventHandler(this.btnCalcularGanancias_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxTotalGanancias);
            this.Controls.Add(this.gbxCantViajesRealizados);
            this.Controls.Add(this.gbxMasUsadoPromPersonas);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.gbxMasUsadoPromPersonas.ResumeLayout(false);
            this.gbxMasUsadoPromPersonas.PerformLayout();
            this.gbxCantViajesRealizados.ResumeLayout(false);
            this.gbxCantViajesRealizados.PerformLayout();
            this.gbxTotalGanancias.ResumeLayout(false);
            this.gbxTotalGanancias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMasUsadoPromPersonas;
        private System.Windows.Forms.GroupBox gbxCantViajesRealizados;
        private System.Windows.Forms.GroupBox gbxTotalGanancias;
        private System.Windows.Forms.TextBox txtPromPersonas;
        private System.Windows.Forms.TextBox txtMasUsado;
        private System.Windows.Forms.Label lblPromPersonas;
        private System.Windows.Forms.Label lblMasUsado;
        private System.Windows.Forms.TextBox txtCantViajes;
        private System.Windows.Forms.Label lblCantViajes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.ComboBox cbxAño;
        private System.Windows.Forms.TextBox txtGananciasTotales;
        private System.Windows.Forms.Label lblGananciasTotales;
        private System.Windows.Forms.Label lblTipoTransporte;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCalcularCantViajes;
        private System.Windows.Forms.Button btnCalcularGanancias;
    }
}