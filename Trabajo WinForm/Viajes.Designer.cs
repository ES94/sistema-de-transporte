namespace Trabajo_WinForm
{
    partial class frmViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViajes));
            this.mnuViajes = new System.Windows.Forms.MenuStrip();
            this.bmnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnNuevoViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnFiltrarPorFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.establecerFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnCalcularCosto = new System.Windows.Forms.ToolStripMenuItem();
            this.tabViajes = new System.Windows.Forms.TabControl();
            this.pagAviones = new System.Windows.Forms.TabPage();
            this.navAviones = new System.Windows.Forms.BindingNavigator(this.components);
            this.srcAviones = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.clmAvionesOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionesDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionesFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionesCantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionesIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionesTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvionesCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagAutos = new System.Windows.Forms.TabPage();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.clmAutosOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutosDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutosFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutosCantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutosIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutosTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutosCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcAutos = new System.Windows.Forms.BindingSource(this.components);
            this.navAutos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pagColectivos = new System.Windows.Forms.TabPage();
            this.dgvColectivos = new System.Windows.Forms.DataGridView();
            this.clmColeOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeCantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColeCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcColectivos = new System.Windows.Forms.BindingSource(this.components);
            this.navColectivos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bmnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViajes.SuspendLayout();
            this.tabViajes.SuspendLayout();
            this.pagAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navAviones)).BeginInit();
            this.navAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
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
            // mnuViajes
            // 
            this.mnuViajes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmnMenu});
            this.mnuViajes.Location = new System.Drawing.Point(0, 0);
            this.mnuViajes.Name = "mnuViajes";
            this.mnuViajes.Size = new System.Drawing.Size(624, 24);
            this.mnuViajes.TabIndex = 0;
            // 
            // bmnMenu
            // 
            this.bmnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmnNuevoViaje,
            this.bmnFiltrarPorFecha,
            this.bmnCalcularCosto,
            this.bmnSalir});
            this.bmnMenu.Name = "bmnMenu";
            this.bmnMenu.Size = new System.Drawing.Size(50, 20);
            this.bmnMenu.Text = "&Menú";
            // 
            // bmnNuevoViaje
            // 
            this.bmnNuevoViaje.Image = ((System.Drawing.Image)(resources.GetObject("bmnNuevoViaje.Image")));
            this.bmnNuevoViaje.Name = "bmnNuevoViaje";
            this.bmnNuevoViaje.Size = new System.Drawing.Size(233, 22);
            this.bmnNuevoViaje.Text = "&Nuevo viaje";
            this.bmnNuevoViaje.Click += new System.EventHandler(this.bmnNuevoViaje_Click);
            // 
            // bmnFiltrarPorFecha
            // 
            this.bmnFiltrarPorFecha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.establecerFiltroToolStripMenuItem,
            this.limpiarFiltroToolStripMenuItem});
            this.bmnFiltrarPorFecha.Image = ((System.Drawing.Image)(resources.GetObject("bmnFiltrarPorFecha.Image")));
            this.bmnFiltrarPorFecha.Name = "bmnFiltrarPorFecha";
            this.bmnFiltrarPorFecha.Size = new System.Drawing.Size(233, 22);
            this.bmnFiltrarPorFecha.Text = "&Filtrar lista por fecha de viaje...";
            // 
            // establecerFiltroToolStripMenuItem
            // 
            this.establecerFiltroToolStripMenuItem.Name = "establecerFiltroToolStripMenuItem";
            this.establecerFiltroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.establecerFiltroToolStripMenuItem.Text = "&Establecer filtro";
            this.establecerFiltroToolStripMenuItem.Click += new System.EventHandler(this.establecerFiltroToolStripMenuItem_Click);
            // 
            // limpiarFiltroToolStripMenuItem
            // 
            this.limpiarFiltroToolStripMenuItem.Name = "limpiarFiltroToolStripMenuItem";
            this.limpiarFiltroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.limpiarFiltroToolStripMenuItem.Text = "&Limpiar filtro";
            this.limpiarFiltroToolStripMenuItem.Click += new System.EventHandler(this.limpiarFiltroToolStripMenuItem_Click);
            // 
            // bmnCalcularCosto
            // 
            this.bmnCalcularCosto.Image = ((System.Drawing.Image)(resources.GetObject("bmnCalcularCosto.Image")));
            this.bmnCalcularCosto.Name = "bmnCalcularCosto";
            this.bmnCalcularCosto.Size = new System.Drawing.Size(233, 22);
            this.bmnCalcularCosto.Text = "&Calcular costo de viaje";
            this.bmnCalcularCosto.Click += new System.EventHandler(this.bmnCalcularCosto_Click);
            // 
            // tabViajes
            // 
            this.tabViajes.Controls.Add(this.pagAviones);
            this.tabViajes.Controls.Add(this.pagAutos);
            this.tabViajes.Controls.Add(this.pagColectivos);
            this.tabViajes.Location = new System.Drawing.Point(0, 27);
            this.tabViajes.Name = "tabViajes";
            this.tabViajes.SelectedIndex = 0;
            this.tabViajes.Size = new System.Drawing.Size(624, 413);
            this.tabViajes.TabIndex = 1;
            // 
            // pagAviones
            // 
            this.pagAviones.Controls.Add(this.navAviones);
            this.pagAviones.Controls.Add(this.dgvAviones);
            this.pagAviones.Location = new System.Drawing.Point(4, 22);
            this.pagAviones.Name = "pagAviones";
            this.pagAviones.Padding = new System.Windows.Forms.Padding(3);
            this.pagAviones.Size = new System.Drawing.Size(616, 387);
            this.pagAviones.TabIndex = 0;
            this.pagAviones.Text = "Aviones";
            this.pagAviones.UseVisualStyleBackColor = true;
            // 
            // navAviones
            // 
            this.navAviones.AddNewItem = null;
            this.navAviones.BindingSource = this.srcAviones;
            this.navAviones.CountItem = this.bindingNavigatorCountItem;
            this.navAviones.DeleteItem = null;
            this.navAviones.Dock = System.Windows.Forms.DockStyle.None;
            this.navAviones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.navAviones.Location = new System.Drawing.Point(0, 0);
            this.navAviones.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navAviones.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navAviones.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navAviones.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navAviones.Name = "navAviones";
            this.navAviones.PositionItem = this.bindingNavigatorPositionItem;
            this.navAviones.Size = new System.Drawing.Size(211, 25);
            this.navAviones.TabIndex = 1;
            this.navAviones.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // dgvAviones
            // 
            this.dgvAviones.AutoGenerateColumns = false;
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAvionesOrigen,
            this.clmAvionesDestino,
            this.clmAvionesFecha,
            this.clmAvionesCantidadPasajeros,
            this.clmAvionesIdVehiculo,
            this.clmAvionesTipoVehiculo,
            this.clmAvionesCosto});
            this.dgvAviones.DataSource = this.srcAviones;
            this.dgvAviones.Location = new System.Drawing.Point(0, 28);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.Size = new System.Drawing.Size(616, 356);
            this.dgvAviones.TabIndex = 0;
            // 
            // clmAvionesOrigen
            // 
            this.clmAvionesOrigen.DataPropertyName = "CiudadOrigen";
            this.clmAvionesOrigen.Frozen = true;
            this.clmAvionesOrigen.HeaderText = "Origen";
            this.clmAvionesOrigen.Name = "clmAvionesOrigen";
            this.clmAvionesOrigen.ReadOnly = true;
            this.clmAvionesOrigen.Width = 80;
            // 
            // clmAvionesDestino
            // 
            this.clmAvionesDestino.DataPropertyName = "CiudadDestino";
            this.clmAvionesDestino.Frozen = true;
            this.clmAvionesDestino.HeaderText = "Destino";
            this.clmAvionesDestino.Name = "clmAvionesDestino";
            this.clmAvionesDestino.ReadOnly = true;
            this.clmAvionesDestino.Width = 80;
            // 
            // clmAvionesFecha
            // 
            this.clmAvionesFecha.DataPropertyName = "FechaViaje";
            this.clmAvionesFecha.Frozen = true;
            this.clmAvionesFecha.HeaderText = "Fecha de viaje";
            this.clmAvionesFecha.Name = "clmAvionesFecha";
            this.clmAvionesFecha.ReadOnly = true;
            // 
            // clmAvionesCantidadPasajeros
            // 
            this.clmAvionesCantidadPasajeros.DataPropertyName = "CantidadPasajeros";
            this.clmAvionesCantidadPasajeros.Frozen = true;
            this.clmAvionesCantidadPasajeros.HeaderText = "Cantidad de pasajeros";
            this.clmAvionesCantidadPasajeros.Name = "clmAvionesCantidadPasajeros";
            this.clmAvionesCantidadPasajeros.ReadOnly = true;
            this.clmAvionesCantidadPasajeros.Width = 80;
            // 
            // clmAvionesIdVehiculo
            // 
            this.clmAvionesIdVehiculo.DataPropertyName = "IdVehiculo";
            this.clmAvionesIdVehiculo.Frozen = true;
            this.clmAvionesIdVehiculo.HeaderText = "ID de vehículo";
            this.clmAvionesIdVehiculo.Name = "clmAvionesIdVehiculo";
            this.clmAvionesIdVehiculo.ReadOnly = true;
            this.clmAvionesIdVehiculo.Width = 80;
            // 
            // clmAvionesTipoVehiculo
            // 
            this.clmAvionesTipoVehiculo.DataPropertyName = "TipoVehiculo";
            this.clmAvionesTipoVehiculo.Frozen = true;
            this.clmAvionesTipoVehiculo.HeaderText = "Tipo de vehículo";
            this.clmAvionesTipoVehiculo.Name = "clmAvionesTipoVehiculo";
            this.clmAvionesTipoVehiculo.ReadOnly = true;
            this.clmAvionesTipoVehiculo.Width = 80;
            // 
            // clmAvionesCosto
            // 
            this.clmAvionesCosto.DataPropertyName = "CostoTotal";
            this.clmAvionesCosto.Frozen = true;
            this.clmAvionesCosto.HeaderText = "Costo total";
            this.clmAvionesCosto.Name = "clmAvionesCosto";
            this.clmAvionesCosto.ReadOnly = true;
            this.clmAvionesCosto.Width = 80;
            // 
            // pagAutos
            // 
            this.pagAutos.Controls.Add(this.dgvAutos);
            this.pagAutos.Controls.Add(this.navAutos);
            this.pagAutos.Location = new System.Drawing.Point(4, 22);
            this.pagAutos.Name = "pagAutos";
            this.pagAutos.Padding = new System.Windows.Forms.Padding(3);
            this.pagAutos.Size = new System.Drawing.Size(616, 387);
            this.pagAutos.TabIndex = 1;
            this.pagAutos.Text = "Autos";
            this.pagAutos.UseVisualStyleBackColor = true;
            // 
            // dgvAutos
            // 
            this.dgvAutos.AutoGenerateColumns = false;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAutosOrigen,
            this.clmAutosDestino,
            this.clmAutosFecha,
            this.clmAutosCantidadPasajeros,
            this.clmAutosIdVehiculo,
            this.clmAutosTipoVehiculo,
            this.clmAutosCosto});
            this.dgvAutos.DataSource = this.srcAutos;
            this.dgvAutos.Location = new System.Drawing.Point(0, 28);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(616, 356);
            this.dgvAutos.TabIndex = 1;
            // 
            // clmAutosOrigen
            // 
            this.clmAutosOrigen.DataPropertyName = "CiudadOrigen";
            this.clmAutosOrigen.Frozen = true;
            this.clmAutosOrigen.HeaderText = "Origen";
            this.clmAutosOrigen.Name = "clmAutosOrigen";
            this.clmAutosOrigen.ReadOnly = true;
            this.clmAutosOrigen.Width = 80;
            // 
            // clmAutosDestino
            // 
            this.clmAutosDestino.DataPropertyName = "CiudadDestino";
            this.clmAutosDestino.Frozen = true;
            this.clmAutosDestino.HeaderText = "Destino";
            this.clmAutosDestino.Name = "clmAutosDestino";
            this.clmAutosDestino.ReadOnly = true;
            this.clmAutosDestino.Width = 80;
            // 
            // clmAutosFecha
            // 
            this.clmAutosFecha.DataPropertyName = "FechaViaje";
            this.clmAutosFecha.Frozen = true;
            this.clmAutosFecha.HeaderText = "Fecha de viaje";
            this.clmAutosFecha.Name = "clmAutosFecha";
            this.clmAutosFecha.ReadOnly = true;
            // 
            // clmAutosCantidadPasajeros
            // 
            this.clmAutosCantidadPasajeros.DataPropertyName = "CantidadPasajeros";
            this.clmAutosCantidadPasajeros.Frozen = true;
            this.clmAutosCantidadPasajeros.HeaderText = "Cantidad de pasajeros";
            this.clmAutosCantidadPasajeros.Name = "clmAutosCantidadPasajeros";
            this.clmAutosCantidadPasajeros.ReadOnly = true;
            this.clmAutosCantidadPasajeros.Width = 80;
            // 
            // clmAutosIdVehiculo
            // 
            this.clmAutosIdVehiculo.DataPropertyName = "IdVehiculo";
            this.clmAutosIdVehiculo.Frozen = true;
            this.clmAutosIdVehiculo.HeaderText = "ID de vehículo";
            this.clmAutosIdVehiculo.Name = "clmAutosIdVehiculo";
            this.clmAutosIdVehiculo.ReadOnly = true;
            this.clmAutosIdVehiculo.Width = 80;
            // 
            // clmAutosTipoVehiculo
            // 
            this.clmAutosTipoVehiculo.DataPropertyName = "TipoVehiculo";
            this.clmAutosTipoVehiculo.Frozen = true;
            this.clmAutosTipoVehiculo.HeaderText = "Tipo de vehículo";
            this.clmAutosTipoVehiculo.Name = "clmAutosTipoVehiculo";
            this.clmAutosTipoVehiculo.ReadOnly = true;
            this.clmAutosTipoVehiculo.Width = 80;
            // 
            // clmAutosCosto
            // 
            this.clmAutosCosto.DataPropertyName = "CostoTotal";
            this.clmAutosCosto.Frozen = true;
            this.clmAutosCosto.HeaderText = "Costo total";
            this.clmAutosCosto.Name = "clmAutosCosto";
            this.clmAutosCosto.ReadOnly = true;
            this.clmAutosCosto.Width = 80;
            // 
            // navAutos
            // 
            this.navAutos.AddNewItem = null;
            this.navAutos.BindingSource = this.srcAutos;
            this.navAutos.CountItem = this.bindingNavigatorCountItem1;
            this.navAutos.DeleteItem = null;
            this.navAutos.Dock = System.Windows.Forms.DockStyle.None;
            this.navAutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.navAutos.Location = new System.Drawing.Point(0, 0);
            this.navAutos.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.navAutos.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.navAutos.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.navAutos.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.navAutos.Name = "navAutos";
            this.navAutos.PositionItem = this.bindingNavigatorPositionItem1;
            this.navAutos.Size = new System.Drawing.Size(211, 25);
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
            // pagColectivos
            // 
            this.pagColectivos.Controls.Add(this.dgvColectivos);
            this.pagColectivos.Controls.Add(this.navColectivos);
            this.pagColectivos.Location = new System.Drawing.Point(4, 22);
            this.pagColectivos.Name = "pagColectivos";
            this.pagColectivos.Padding = new System.Windows.Forms.Padding(3);
            this.pagColectivos.Size = new System.Drawing.Size(616, 387);
            this.pagColectivos.TabIndex = 2;
            this.pagColectivos.Text = "Colectivos";
            this.pagColectivos.UseVisualStyleBackColor = true;
            // 
            // dgvColectivos
            // 
            this.dgvColectivos.AutoGenerateColumns = false;
            this.dgvColectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColectivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmColeOrigen,
            this.clmColeDestino,
            this.clmColeFecha,
            this.clmColeCantidadPasajeros,
            this.clmColeIdVehiculo,
            this.clmColeTipoVehiculo,
            this.clmColeCosto});
            this.dgvColectivos.DataSource = this.srcColectivos;
            this.dgvColectivos.Location = new System.Drawing.Point(0, 28);
            this.dgvColectivos.Name = "dgvColectivos";
            this.dgvColectivos.Size = new System.Drawing.Size(616, 356);
            this.dgvColectivos.TabIndex = 1;
            // 
            // clmColeOrigen
            // 
            this.clmColeOrigen.DataPropertyName = "CiudadOrigen";
            this.clmColeOrigen.Frozen = true;
            this.clmColeOrigen.HeaderText = "Origen";
            this.clmColeOrigen.Name = "clmColeOrigen";
            this.clmColeOrigen.ReadOnly = true;
            this.clmColeOrigen.Width = 80;
            // 
            // clmColeDestino
            // 
            this.clmColeDestino.DataPropertyName = "CiudadDestino";
            this.clmColeDestino.Frozen = true;
            this.clmColeDestino.HeaderText = "Destino";
            this.clmColeDestino.Name = "clmColeDestino";
            this.clmColeDestino.ReadOnly = true;
            this.clmColeDestino.Width = 80;
            // 
            // clmColeFecha
            // 
            this.clmColeFecha.DataPropertyName = "FechaViaje";
            this.clmColeFecha.Frozen = true;
            this.clmColeFecha.HeaderText = "Fecha de viaje";
            this.clmColeFecha.Name = "clmColeFecha";
            this.clmColeFecha.ReadOnly = true;
            // 
            // clmColeCantidadPasajeros
            // 
            this.clmColeCantidadPasajeros.DataPropertyName = "CantidadPasajeros";
            this.clmColeCantidadPasajeros.Frozen = true;
            this.clmColeCantidadPasajeros.HeaderText = "Cantidad de pasajeros";
            this.clmColeCantidadPasajeros.Name = "clmColeCantidadPasajeros";
            this.clmColeCantidadPasajeros.ReadOnly = true;
            this.clmColeCantidadPasajeros.Width = 80;
            // 
            // clmColeIdVehiculo
            // 
            this.clmColeIdVehiculo.DataPropertyName = "IdVehiculo";
            this.clmColeIdVehiculo.Frozen = true;
            this.clmColeIdVehiculo.HeaderText = "ID de vehículo";
            this.clmColeIdVehiculo.Name = "clmColeIdVehiculo";
            this.clmColeIdVehiculo.ReadOnly = true;
            this.clmColeIdVehiculo.Width = 80;
            // 
            // clmColeTipoVehiculo
            // 
            this.clmColeTipoVehiculo.DataPropertyName = "TipoVehiculo";
            this.clmColeTipoVehiculo.Frozen = true;
            this.clmColeTipoVehiculo.HeaderText = "Tipo de vehículo";
            this.clmColeTipoVehiculo.Name = "clmColeTipoVehiculo";
            this.clmColeTipoVehiculo.ReadOnly = true;
            this.clmColeTipoVehiculo.Width = 80;
            // 
            // clmColeCosto
            // 
            this.clmColeCosto.DataPropertyName = "CostoTotal";
            this.clmColeCosto.Frozen = true;
            this.clmColeCosto.HeaderText = "Costo total";
            this.clmColeCosto.Name = "clmColeCosto";
            this.clmColeCosto.ReadOnly = true;
            this.clmColeCosto.Width = 80;
            // 
            // navColectivos
            // 
            this.navColectivos.AddNewItem = null;
            this.navColectivos.BindingSource = this.srcColectivos;
            this.navColectivos.CountItem = this.bindingNavigatorCountItem2;
            this.navColectivos.DeleteItem = null;
            this.navColectivos.Dock = System.Windows.Forms.DockStyle.None;
            this.navColectivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8});
            this.navColectivos.Location = new System.Drawing.Point(0, 0);
            this.navColectivos.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.navColectivos.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.navColectivos.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.navColectivos.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.navColectivos.Name = "navColectivos";
            this.navColectivos.PositionItem = this.bindingNavigatorPositionItem2;
            this.navColectivos.Size = new System.Drawing.Size(211, 25);
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
            // bmnSalir
            // 
            this.bmnSalir.Image = ((System.Drawing.Image)(resources.GetObject("bmnSalir.Image")));
            this.bmnSalir.Name = "bmnSalir";
            this.bmnSalir.Size = new System.Drawing.Size(233, 22);
            this.bmnSalir.Text = "&Salir";
            this.bmnSalir.Click += new System.EventHandler(this.bmnSalir_Click);
            // 
            // frmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabViajes);
            this.Controls.Add(this.mnuViajes);
            this.MainMenuStrip = this.mnuViajes;
            this.Name = "frmViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.frmViajes_Load);
            this.mnuViajes.ResumeLayout(false);
            this.mnuViajes.PerformLayout();
            this.tabViajes.ResumeLayout(false);
            this.pagAviones.ResumeLayout(false);
            this.pagAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navAviones)).EndInit();
            this.navAviones.ResumeLayout(false);
            this.navAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
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

        private System.Windows.Forms.MenuStrip mnuViajes;
        private System.Windows.Forms.ToolStripMenuItem bmnMenu;
        private System.Windows.Forms.ToolStripMenuItem bmnNuevoViaje;
        private System.Windows.Forms.ToolStripMenuItem bmnFiltrarPorFecha;
        private System.Windows.Forms.ToolStripMenuItem bmnCalcularCosto;
        private System.Windows.Forms.TabControl tabViajes;
        private System.Windows.Forms.TabPage pagAviones;
        private System.Windows.Forms.TabPage pagAutos;
        private System.Windows.Forms.TabPage pagColectivos;
        private System.Windows.Forms.BindingNavigator navAviones;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.BindingNavigator navAutos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView dgvColectivos;
        private System.Windows.Forms.BindingNavigator navColectivos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.BindingSource srcAviones;
        private System.Windows.Forms.BindingSource srcAutos;
        private System.Windows.Forms.BindingSource srcColectivos;
        private System.Windows.Forms.ToolStripMenuItem establecerFiltroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarFiltroToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesCantidadPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvionesCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosCantidadPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutosCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeCantidadPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColeCosto;
        private System.Windows.Forms.ToolStripMenuItem bmnSalir;
    }
}