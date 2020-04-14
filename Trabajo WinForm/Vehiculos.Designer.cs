namespace Trabajo_WinForm
{
    partial class frmVehiculos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            this.mnuVehiculos = new System.Windows.Forms.MenuStrip();
            this.bmnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnNuevoVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnEditarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnGananciaTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tabVehiculos = new System.Windows.Forms.TabControl();
            this.pagAviones = new System.Windows.Forms.TabPage();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.srcAviones = new System.Windows.Forms.BindingSource(this.components);
            this.navAviones = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnvEditarAvion = new System.Windows.Forms.ToolStripButton();
            this.pagAutos = new System.Windows.Forms.TabPage();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.srcAutos = new System.Windows.Forms.BindingSource(this.components);
            this.navAutos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bnvEditarAuto = new System.Windows.Forms.ToolStripButton();
            this.pagColectivos = new System.Windows.Forms.TabPage();
            this.dgvColectivos = new System.Windows.Forms.DataGridView();
            this.srcColectivos = new System.Windows.Forms.BindingSource(this.components);
            this.navColectivos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bnvEditarCole = new System.Windows.Forms.ToolStripButton();
            this.clmAvionNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionCantButacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionCostoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionCostoKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPuertaEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLowCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPermiteMasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutoCantButacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutoCostoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutoCostoKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutonomia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeCantButacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeCostoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeCostoKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumeroDarsena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCocheCama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlmuerzoCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuVehiculos.SuspendLayout();
            this.tabVehiculos.SuspendLayout();
            this.pagAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navAviones)).BeginInit();
            this.navAviones.SuspendLayout();
            this.pagAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navAutos)).BeginInit();
            this.navAutos.SuspendLayout();
            this.pagColectivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColectivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcColectivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navColectivos)).BeginInit();
            this.navColectivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuVehiculos
            // 
            this.mnuVehiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmnMenu});
            this.mnuVehiculos.Location = new System.Drawing.Point(0, 0);
            this.mnuVehiculos.Name = "mnuVehiculos";
            this.mnuVehiculos.Size = new System.Drawing.Size(624, 24);
            this.mnuVehiculos.TabIndex = 0;
            // 
            // bmnMenu
            // 
            this.bmnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmnNuevoVehiculo,
            this.bmnEditarVehiculo,
            this.bmnGananciaTotal,
            this.bmnSalir});
            this.bmnMenu.Name = "bmnMenu";
            this.bmnMenu.Size = new System.Drawing.Size(50, 20);
            this.bmnMenu.Text = "&Menú";
            // 
            // bmnNuevoVehiculo
            // 
            this.bmnNuevoVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("bmnNuevoVehiculo.Image")));
            this.bmnNuevoVehiculo.Name = "bmnNuevoVehiculo";
            this.bmnNuevoVehiculo.Size = new System.Drawing.Size(197, 22);
            this.bmnNuevoVehiculo.Text = "&Nuevo vehículo";
            this.bmnNuevoVehiculo.Click += new System.EventHandler(this.bmnNuevoVehiculo_Click);
            // 
            // bmnEditarVehiculo
            // 
            this.bmnEditarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("bmnEditarVehiculo.Image")));
            this.bmnEditarVehiculo.Name = "bmnEditarVehiculo";
            this.bmnEditarVehiculo.Size = new System.Drawing.Size(197, 22);
            this.bmnEditarVehiculo.Text = "&Editar vehículo";
            this.bmnEditarVehiculo.Click += new System.EventHandler(this.bmnEditarVehiculo_Click);
            // 
            // bmnGananciaTotal
            // 
            this.bmnGananciaTotal.Image = ((System.Drawing.Image)(resources.GetObject("bmnGananciaTotal.Image")));
            this.bmnGananciaTotal.Name = "bmnGananciaTotal";
            this.bmnGananciaTotal.Size = new System.Drawing.Size(197, 22);
            this.bmnGananciaTotal.Text = "&Obtener ganacia total...";
            this.bmnGananciaTotal.Click += new System.EventHandler(this.bmnGananciaTotal_Click);
            // 
            // bmnSalir
            // 
            this.bmnSalir.Image = ((System.Drawing.Image)(resources.GetObject("bmnSalir.Image")));
            this.bmnSalir.Name = "bmnSalir";
            this.bmnSalir.Size = new System.Drawing.Size(197, 22);
            this.bmnSalir.Text = "&Salir";
            this.bmnSalir.Click += new System.EventHandler(this.bmnSalir_Click);
            // 
            // tabVehiculos
            // 
            this.tabVehiculos.Controls.Add(this.pagAviones);
            this.tabVehiculos.Controls.Add(this.pagAutos);
            this.tabVehiculos.Controls.Add(this.pagColectivos);
            this.tabVehiculos.Location = new System.Drawing.Point(0, 27);
            this.tabVehiculos.Name = "tabVehiculos";
            this.tabVehiculos.SelectedIndex = 0;
            this.tabVehiculos.Size = new System.Drawing.Size(624, 415);
            this.tabVehiculos.TabIndex = 1;
            // 
            // pagAviones
            // 
            this.pagAviones.Controls.Add(this.dgvAviones);
            this.pagAviones.Controls.Add(this.navAviones);
            this.pagAviones.Location = new System.Drawing.Point(4, 22);
            this.pagAviones.Name = "pagAviones";
            this.pagAviones.Padding = new System.Windows.Forms.Padding(3);
            this.pagAviones.Size = new System.Drawing.Size(616, 389);
            this.pagAviones.TabIndex = 0;
            this.pagAviones.Text = "Aviones";
            this.pagAviones.UseVisualStyleBackColor = true;
            // 
            // dgvAviones
            // 
            this.dgvAviones.AutoGenerateColumns = false;
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAvionNumero,
            this.clmAvionNombre,
            this.clmAvionCantButacas,
            this.clmAvionCostoPersona,
            this.clmAvionCostoKm,
            this.clmPuertaEmbarque,
            this.clmLowCost,
            this.clmPermiteMasc});
            this.dgvAviones.DataSource = this.srcAviones;
            this.dgvAviones.Location = new System.Drawing.Point(0, 31);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.Size = new System.Drawing.Size(616, 358);
            this.dgvAviones.TabIndex = 1;
            // 
            // navAviones
            // 
            this.navAviones.AddNewItem = null;
            this.navAviones.BindingSource = this.srcAviones;
            this.navAviones.CountItem = this.bindingNavigatorCountItem;
            this.navAviones.DeleteItem = this.bindingNavigatorDeleteItem;
            this.navAviones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bnvEditarAvion});
            this.navAviones.Location = new System.Drawing.Point(3, 3);
            this.navAviones.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navAviones.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navAviones.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navAviones.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navAviones.Name = "navAviones";
            this.navAviones.PositionItem = this.bindingNavigatorPositionItem;
            this.navAviones.Size = new System.Drawing.Size(610, 25);
            this.navAviones.TabIndex = 0;
            this.navAviones.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnvEditarAvion
            // 
            this.bnvEditarAvion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvEditarAvion.Image = ((System.Drawing.Image)(resources.GetObject("bnvEditarAvion.Image")));
            this.bnvEditarAvion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvEditarAvion.Name = "bnvEditarAvion";
            this.bnvEditarAvion.Size = new System.Drawing.Size(23, 22);
            this.bnvEditarAvion.Text = "Editar vehículo";
            this.bnvEditarAvion.Click += new System.EventHandler(this.bnvEditarAvion_Click);
            // 
            // pagAutos
            // 
            this.pagAutos.Controls.Add(this.dgvAutos);
            this.pagAutos.Controls.Add(this.navAutos);
            this.pagAutos.Location = new System.Drawing.Point(4, 22);
            this.pagAutos.Name = "pagAutos";
            this.pagAutos.Padding = new System.Windows.Forms.Padding(3);
            this.pagAutos.Size = new System.Drawing.Size(616, 389);
            this.pagAutos.TabIndex = 1;
            this.pagAutos.Text = "Autos";
            this.pagAutos.UseVisualStyleBackColor = true;
            // 
            // dgvAutos
            // 
            this.dgvAutos.AutoGenerateColumns = false;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAutoNumero,
            this.clmAutoNombre,
            this.clmAutoCantButacas,
            this.clmAutoCostoPersona,
            this.clmAutoCostoKm,
            this.clmMarca,
            this.clmModelo,
            this.clmAutonomia});
            this.dgvAutos.DataSource = this.srcAutos;
            this.dgvAutos.Location = new System.Drawing.Point(0, 31);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(616, 358);
            this.dgvAutos.TabIndex = 1;
            // 
            // navAutos
            // 
            this.navAutos.AddNewItem = null;
            this.navAutos.BindingSource = this.srcAutos;
            this.navAutos.CountItem = this.bindingNavigatorCountItem1;
            this.navAutos.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.navAutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorDeleteItem1,
            this.bnvEditarAuto});
            this.navAutos.Location = new System.Drawing.Point(3, 3);
            this.navAutos.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.navAutos.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.navAutos.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.navAutos.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.navAutos.Name = "navAutos";
            this.navAutos.PositionItem = this.bindingNavigatorPositionItem1;
            this.navAutos.Size = new System.Drawing.Size(610, 25);
            this.navAutos.TabIndex = 0;
            this.navAutos.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bnvEditarAuto
            // 
            this.bnvEditarAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvEditarAuto.Image = ((System.Drawing.Image)(resources.GetObject("bnvEditarAuto.Image")));
            this.bnvEditarAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvEditarAuto.Name = "bnvEditarAuto";
            this.bnvEditarAuto.Size = new System.Drawing.Size(23, 22);
            this.bnvEditarAuto.Text = "Editar vehículo";
            this.bnvEditarAuto.Click += new System.EventHandler(this.bnvEditarAuto_Click);
            // 
            // pagColectivos
            // 
            this.pagColectivos.Controls.Add(this.dgvColectivos);
            this.pagColectivos.Controls.Add(this.navColectivos);
            this.pagColectivos.Location = new System.Drawing.Point(4, 22);
            this.pagColectivos.Name = "pagColectivos";
            this.pagColectivos.Padding = new System.Windows.Forms.Padding(3);
            this.pagColectivos.Size = new System.Drawing.Size(616, 389);
            this.pagColectivos.TabIndex = 2;
            this.pagColectivos.Text = "Colectivos";
            this.pagColectivos.UseVisualStyleBackColor = true;
            // 
            // dgvColectivos
            // 
            this.dgvColectivos.AutoGenerateColumns = false;
            this.dgvColectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColectivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmColeNumero,
            this.clmColeNombre,
            this.clmColeCantButacas,
            this.clmColeCostoPersona,
            this.clmColeCostoKm,
            this.clmNumeroDarsena,
            this.clmCocheCama,
            this.clmAlmuerzoCena});
            this.dgvColectivos.DataSource = this.srcColectivos;
            this.dgvColectivos.Location = new System.Drawing.Point(0, 31);
            this.dgvColectivos.Name = "dgvColectivos";
            this.dgvColectivos.Size = new System.Drawing.Size(616, 358);
            this.dgvColectivos.TabIndex = 1;
            // 
            // navColectivos
            // 
            this.navColectivos.AddNewItem = null;
            this.navColectivos.BindingSource = this.srcColectivos;
            this.navColectivos.CountItem = this.bindingNavigatorCountItem2;
            this.navColectivos.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.navColectivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorDeleteItem2,
            this.bnvEditarCole});
            this.navColectivos.Location = new System.Drawing.Point(3, 3);
            this.navColectivos.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.navColectivos.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.navColectivos.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.navColectivos.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.navColectivos.Name = "navColectivos";
            this.navColectivos.PositionItem = this.bindingNavigatorPositionItem2;
            this.navColectivos.Size = new System.Drawing.Size(610, 25);
            this.navColectivos.TabIndex = 0;
            this.navColectivos.Text = "bindingNavigator3";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem2.Text = "de {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Mover último";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // bnvEditarCole
            // 
            this.bnvEditarCole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvEditarCole.Image = ((System.Drawing.Image)(resources.GetObject("bnvEditarCole.Image")));
            this.bnvEditarCole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvEditarCole.Name = "bnvEditarCole";
            this.bnvEditarCole.Size = new System.Drawing.Size(23, 22);
            this.bnvEditarCole.Text = "Editar vehículo";
            this.bnvEditarCole.Click += new System.EventHandler(this.bnvEditarCole_Click);
            // 
            // clmAvionNumero
            // 
            this.clmAvionNumero.DataPropertyName = "Numero";
            this.clmAvionNumero.Frozen = true;
            this.clmAvionNumero.HeaderText = "ID";
            this.clmAvionNumero.Name = "clmAvionNumero";
            this.clmAvionNumero.ReadOnly = true;
            this.clmAvionNumero.Width = 50;
            // 
            // clmAvionNombre
            // 
            this.clmAvionNombre.DataPropertyName = "Nombre";
            this.clmAvionNombre.Frozen = true;
            this.clmAvionNombre.HeaderText = "Nombre";
            this.clmAvionNombre.Name = "clmAvionNombre";
            this.clmAvionNombre.ReadOnly = true;
            this.clmAvionNombre.Width = 80;
            // 
            // clmAvionCantButacas
            // 
            this.clmAvionCantButacas.DataPropertyName = "CantidadButacas";
            this.clmAvionCantButacas.Frozen = true;
            this.clmAvionCantButacas.HeaderText = "Cantidad de butacas";
            this.clmAvionCantButacas.Name = "clmAvionCantButacas";
            this.clmAvionCantButacas.ReadOnly = true;
            this.clmAvionCantButacas.Width = 50;
            // 
            // clmAvionCostoPersona
            // 
            this.clmAvionCostoPersona.DataPropertyName = "CostoPorPersona";
            this.clmAvionCostoPersona.Frozen = true;
            this.clmAvionCostoPersona.HeaderText = "Costo por persona";
            this.clmAvionCostoPersona.Name = "clmAvionCostoPersona";
            this.clmAvionCostoPersona.ReadOnly = true;
            this.clmAvionCostoPersona.Width = 80;
            // 
            // clmAvionCostoKm
            // 
            this.clmAvionCostoKm.DataPropertyName = "CostoPorKm";
            this.clmAvionCostoKm.Frozen = true;
            this.clmAvionCostoKm.HeaderText = "Costo por Km";
            this.clmAvionCostoKm.Name = "clmAvionCostoKm";
            this.clmAvionCostoKm.ReadOnly = true;
            this.clmAvionCostoKm.Width = 80;
            // 
            // clmPuertaEmbarque
            // 
            this.clmPuertaEmbarque.DataPropertyName = "PuertaEmbarque";
            this.clmPuertaEmbarque.Frozen = true;
            this.clmPuertaEmbarque.HeaderText = "Puerta de embarque";
            this.clmPuertaEmbarque.Name = "clmPuertaEmbarque";
            this.clmPuertaEmbarque.ReadOnly = true;
            this.clmPuertaEmbarque.Width = 80;
            // 
            // clmLowCost
            // 
            this.clmLowCost.DataPropertyName = "LowCost";
            this.clmLowCost.Frozen = true;
            this.clmLowCost.HeaderText = "LowCost";
            this.clmLowCost.Name = "clmLowCost";
            this.clmLowCost.ReadOnly = true;
            this.clmLowCost.Width = 80;
            // 
            // clmPermiteMasc
            // 
            this.clmPermiteMasc.DataPropertyName = "PermiteMascotas";
            this.clmPermiteMasc.Frozen = true;
            this.clmPermiteMasc.HeaderText = "Permite mascotas";
            this.clmPermiteMasc.Name = "clmPermiteMasc";
            this.clmPermiteMasc.ReadOnly = true;
            this.clmPermiteMasc.Width = 80;
            // 
            // clmAutoNumero
            // 
            this.clmAutoNumero.DataPropertyName = "Numero";
            this.clmAutoNumero.Frozen = true;
            this.clmAutoNumero.HeaderText = "ID";
            this.clmAutoNumero.Name = "clmAutoNumero";
            this.clmAutoNumero.ReadOnly = true;
            this.clmAutoNumero.Width = 50;
            // 
            // clmAutoNombre
            // 
            this.clmAutoNombre.DataPropertyName = "Nombre";
            this.clmAutoNombre.Frozen = true;
            this.clmAutoNombre.HeaderText = "Nombre";
            this.clmAutoNombre.Name = "clmAutoNombre";
            this.clmAutoNombre.ReadOnly = true;
            this.clmAutoNombre.Width = 80;
            // 
            // clmAutoCantButacas
            // 
            this.clmAutoCantButacas.DataPropertyName = "CantidadButacas";
            this.clmAutoCantButacas.Frozen = true;
            this.clmAutoCantButacas.HeaderText = "Cantidad de butacas";
            this.clmAutoCantButacas.Name = "clmAutoCantButacas";
            this.clmAutoCantButacas.ReadOnly = true;
            this.clmAutoCantButacas.Width = 50;
            // 
            // clmAutoCostoPersona
            // 
            this.clmAutoCostoPersona.DataPropertyName = "CostoPorPersona";
            this.clmAutoCostoPersona.Frozen = true;
            this.clmAutoCostoPersona.HeaderText = "Costo por persona";
            this.clmAutoCostoPersona.Name = "clmAutoCostoPersona";
            this.clmAutoCostoPersona.ReadOnly = true;
            this.clmAutoCostoPersona.Width = 80;
            // 
            // clmAutoCostoKm
            // 
            this.clmAutoCostoKm.DataPropertyName = "CostoPorKm";
            this.clmAutoCostoKm.Frozen = true;
            this.clmAutoCostoKm.HeaderText = "Costo por Km";
            this.clmAutoCostoKm.Name = "clmAutoCostoKm";
            this.clmAutoCostoKm.ReadOnly = true;
            this.clmAutoCostoKm.Width = 80;
            // 
            // clmMarca
            // 
            this.clmMarca.DataPropertyName = "Marca";
            this.clmMarca.Frozen = true;
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            this.clmMarca.Width = 80;
            // 
            // clmModelo
            // 
            this.clmModelo.DataPropertyName = "Modelo";
            this.clmModelo.Frozen = true;
            this.clmModelo.HeaderText = "Modelo";
            this.clmModelo.Name = "clmModelo";
            this.clmModelo.ReadOnly = true;
            this.clmModelo.Width = 80;
            // 
            // clmAutonomia
            // 
            this.clmAutonomia.DataPropertyName = "Autonomia";
            this.clmAutonomia.Frozen = true;
            this.clmAutonomia.HeaderText = "Autonomía (en Km)";
            this.clmAutonomia.Name = "clmAutonomia";
            this.clmAutonomia.ReadOnly = true;
            this.clmAutonomia.Width = 80;
            // 
            // clmColeNumero
            // 
            this.clmColeNumero.DataPropertyName = "Numero";
            this.clmColeNumero.Frozen = true;
            this.clmColeNumero.HeaderText = "ID";
            this.clmColeNumero.Name = "clmColeNumero";
            this.clmColeNumero.ReadOnly = true;
            this.clmColeNumero.Width = 50;
            // 
            // clmColeNombre
            // 
            this.clmColeNombre.DataPropertyName = "Nombre";
            this.clmColeNombre.Frozen = true;
            this.clmColeNombre.HeaderText = "Nombre";
            this.clmColeNombre.Name = "clmColeNombre";
            this.clmColeNombre.ReadOnly = true;
            this.clmColeNombre.Width = 80;
            // 
            // clmColeCantButacas
            // 
            this.clmColeCantButacas.DataPropertyName = "CantidadButacas";
            this.clmColeCantButacas.Frozen = true;
            this.clmColeCantButacas.HeaderText = "Cantidad de butacas";
            this.clmColeCantButacas.Name = "clmColeCantButacas";
            this.clmColeCantButacas.ReadOnly = true;
            this.clmColeCantButacas.Width = 50;
            // 
            // clmColeCostoPersona
            // 
            this.clmColeCostoPersona.DataPropertyName = "CostoPorPersona";
            this.clmColeCostoPersona.Frozen = true;
            this.clmColeCostoPersona.HeaderText = "Costo por persona";
            this.clmColeCostoPersona.Name = "clmColeCostoPersona";
            this.clmColeCostoPersona.ReadOnly = true;
            this.clmColeCostoPersona.Width = 80;
            // 
            // clmColeCostoKm
            // 
            this.clmColeCostoKm.DataPropertyName = "CostoPorKm";
            this.clmColeCostoKm.Frozen = true;
            this.clmColeCostoKm.HeaderText = "Costo por Km";
            this.clmColeCostoKm.Name = "clmColeCostoKm";
            this.clmColeCostoKm.ReadOnly = true;
            this.clmColeCostoKm.Width = 80;
            // 
            // clmNumeroDarsena
            // 
            this.clmNumeroDarsena.DataPropertyName = "NumeroDarsena";
            this.clmNumeroDarsena.Frozen = true;
            this.clmNumeroDarsena.HeaderText = "Número de dársena";
            this.clmNumeroDarsena.Name = "clmNumeroDarsena";
            this.clmNumeroDarsena.ReadOnly = true;
            this.clmNumeroDarsena.Width = 50;
            // 
            // clmCocheCama
            // 
            this.clmCocheCama.DataPropertyName = "CocheCama";
            this.clmCocheCama.Frozen = true;
            this.clmCocheCama.HeaderText = "Coche cama";
            this.clmCocheCama.Name = "clmCocheCama";
            this.clmCocheCama.ReadOnly = true;
            this.clmCocheCama.Width = 80;
            // 
            // clmAlmuerzoCena
            // 
            this.clmAlmuerzoCena.DataPropertyName = "AlmuerzoCena";
            this.clmAlmuerzoCena.Frozen = true;
            this.clmAlmuerzoCena.HeaderText = "Almuerzo/Cena";
            this.clmAlmuerzoCena.Name = "clmAlmuerzoCena";
            this.clmAlmuerzoCena.ReadOnly = true;
            this.clmAlmuerzoCena.Width = 90;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabVehiculos);
            this.Controls.Add(this.mnuVehiculos);
            this.MainMenuStrip = this.mnuVehiculos;
            this.Name = "frmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.mnuVehiculos.ResumeLayout(false);
            this.mnuVehiculos.PerformLayout();
            this.tabVehiculos.ResumeLayout(false);
            this.pagAviones.ResumeLayout(false);
            this.pagAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navAviones)).EndInit();
            this.navAviones.ResumeLayout(false);
            this.navAviones.PerformLayout();
            this.pagAutos.ResumeLayout(false);
            this.pagAutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navAutos)).EndInit();
            this.navAutos.ResumeLayout(false);
            this.navAutos.PerformLayout();
            this.pagColectivos.ResumeLayout(false);
            this.pagColectivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColectivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcColectivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navColectivos)).EndInit();
            this.navColectivos.ResumeLayout(false);
            this.navColectivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuVehiculos;
        private System.Windows.Forms.ToolStripMenuItem bmnMenu;
        private System.Windows.Forms.ToolStripMenuItem bmnNuevoVehiculo;
        private System.Windows.Forms.ToolStripMenuItem bmnEditarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem bmnGananciaTotal;
        private System.Windows.Forms.ToolStripMenuItem bmnSalir;
        private System.Windows.Forms.TabControl tabVehiculos;
        private System.Windows.Forms.TabPage pagAviones;
        private System.Windows.Forms.TabPage pagAutos;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.BindingSource srcAviones;
        private System.Windows.Forms.BindingNavigator navAviones;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.BindingSource srcAutos;
        private System.Windows.Forms.BindingNavigator navAutos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TabPage pagColectivos;
        private System.Windows.Forms.DataGridView dgvColectivos;
        private System.Windows.Forms.BindingSource srcColectivos;
        private System.Windows.Forms.BindingNavigator navColectivos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.ToolStripButton bnvEditarAvion;
        private System.Windows.Forms.ToolStripButton bnvEditarAuto;
        private System.Windows.Forms.ToolStripButton bnvEditarCole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionCantButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionCostoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionCostoKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPuertaEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLowCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPermiteMasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutoNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutoCantButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutoCostoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutoCostoKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeCantButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeCostoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeCostoKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroDarsena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCocheCama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlmuerzoCena;
    }
}