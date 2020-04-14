namespace Trabajo_WinForm
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViajes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxPrincipal = new System.Windows.Forms.PictureBox();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVehiculos,
            this.btnViajes,
            this.btnReportes,
            this.btnSalir});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(624, 24);
            this.mnuPrincipal.TabIndex = 0;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(69, 20);
            this.btnVehiculos.Text = "&Vehículos";
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(49, 20);
            this.btnViajes.Text = "V&iajes";
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(65, 20);
            this.btnReportes.Text = "&Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 20);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbxPrincipal
            // 
            this.pbxPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrincipal.Image")));
            this.pbxPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pbxPrincipal.Name = "pbxPrincipal";
            this.pbxPrincipal.Size = new System.Drawing.Size(624, 417);
            this.pbxPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPrincipal.TabIndex = 1;
            this.pbxPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pbxPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Sauces";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnVehiculos;
        private System.Windows.Forms.ToolStripMenuItem btnViajes;
        private System.Windows.Forms.ToolStripMenuItem btnReportes;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.PictureBox pbxPrincipal;
    }
}

