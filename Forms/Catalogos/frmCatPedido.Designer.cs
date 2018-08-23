namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatPedido));
            this.lueTerminal = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lueVehiculo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPedidoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEjercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIEPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueColEstacion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colConfiguracionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueColConfiguracion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueColUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueColStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.pnlDatos = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtcDescuento = new DevExpress.XtraEditors.TextEdit();
            this.spDetallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidoDS1 = new RedCoForm.DataSets.DetallePedidoDS();
            this.lueCatVehiculo = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCatTerminal = new DevExpress.XtraEditors.LookUpEdit();
            this.dgcDetallePedido = new DevExpress.XtraGrid.GridControl();
            this.gvDetallePedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetallePedidoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueProducto = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTerminalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehiculoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolumen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDetalleVolumen = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblFactura = new System.Windows.Forms.Label();
            this.memObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.spCatPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spPedidoDS1 = new RedCoForm.DataSets.spPedidoDS();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.dateFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lueStatusPedido = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtFolio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lueUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.lueEstacion = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.txtIEPS = new DevExpress.XtraEditors.TextEdit();
            this.txtIVA = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.xtpPedido = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).BeginInit();
            this.tcCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).BeginInit();
            this.gcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).BeginInit();
            this.tpBuscar.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatos)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetallePedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCatVehiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCatTerminal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalleVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPedidoDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatusPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.Size = new System.Drawing.Size(1057, 452);
            this.tcCatalogo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpPedido});
            this.tcCatalogo.Controls.SetChildIndex(this.xtpPedido, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpDatos, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpBuscar, 0);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(1055, 100);
            this.gcBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.gcBusqueda_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            // 
            // txtDatosBusqueda
            // 
            // 
            // tpBuscar
            // 
            this.tpBuscar.Size = new System.Drawing.Size(1055, 427);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.pnlDatos);
            this.tpDatos.Size = new System.Drawing.Size(1055, 427);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatPedidoBindingSource;
            this.dgcCatalogo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueColEstacion,
            this.lueColConfiguracion,
            this.lueColUsuario,
            this.lueColStatus});
            this.dgcCatalogo.Size = new System.Drawing.Size(1055, 327);
            this.dgcCatalogo.Click += new System.EventHandler(this.dgcCatalogo_Click);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPedidoID,
            this.colSerie,
            this.colFolio,
            this.colFecha,
            this.colFechaModificacion,
            this.colEjercicio,
            this.colPeriodo,
            this.colDia,
            this.colSubtotal,
            this.colIVA,
            this.colIEPS,
            this.colTotal,
            this.colDescuento,
            this.colStatus,
            this.colObservacion,
            this.colEstacionID,
            this.colConfiguracionID,
            this.colUsuarioID,
            this.colStatusID});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            this.gvCatalogo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCatalogo_FocusedRowChanged);
            // 
            // lueTerminal
            // 
            this.lueTerminal.AutoHeight = false;
            this.lueTerminal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTerminal.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.lueTerminal.Name = "lueTerminal";
            this.lueTerminal.ShowFooter = false;
            this.lueTerminal.ShowHeader = false;
            // 
            // lueVehiculo
            // 
            this.lueVehiculo.AutoHeight = false;
            this.lueVehiculo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVehiculo.Name = "lueVehiculo";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            // 
            // colPedidoID
            // 
            this.colPedidoID.FieldName = "PedidoID";
            this.colPedidoID.Name = "colPedidoID";
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 0;
            // 
            // colFolio
            // 
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 3;
            // 
            // colEjercicio
            // 
            this.colEjercicio.FieldName = "Ejercicio";
            this.colEjercicio.Name = "colEjercicio";
            this.colEjercicio.Visible = true;
            this.colEjercicio.VisibleIndex = 4;
            // 
            // colPeriodo
            // 
            this.colPeriodo.FieldName = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.Visible = true;
            this.colPeriodo.VisibleIndex = 5;
            // 
            // colDia
            // 
            this.colDia.FieldName = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.Visible = true;
            this.colDia.VisibleIndex = 6;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 7;
            // 
            // colIVA
            // 
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 8;
            // 
            // colIEPS
            // 
            this.colIEPS.FieldName = "IEPS";
            this.colIEPS.Name = "colIEPS";
            this.colIEPS.Visible = true;
            this.colIEPS.VisibleIndex = 9;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 10;
            // 
            // colDescuento
            // 
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 11;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 12;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 13;
            // 
            // colEstacionID
            // 
            this.colEstacionID.ColumnEdit = this.lueColEstacion;
            this.colEstacionID.FieldName = "EstacionID";
            this.colEstacionID.Name = "colEstacionID";
            this.colEstacionID.Visible = true;
            this.colEstacionID.VisibleIndex = 14;
            // 
            // lueColEstacion
            // 
            this.lueColEstacion.AutoHeight = false;
            this.lueColEstacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueColEstacion.Name = "lueColEstacion";
            // 
            // colConfiguracionID
            // 
            this.colConfiguracionID.ColumnEdit = this.lueColConfiguracion;
            this.colConfiguracionID.FieldName = "ConfiguracionID";
            this.colConfiguracionID.Name = "colConfiguracionID";
            this.colConfiguracionID.Visible = true;
            this.colConfiguracionID.VisibleIndex = 15;
            // 
            // lueColConfiguracion
            // 
            this.lueColConfiguracion.AutoHeight = false;
            this.lueColConfiguracion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueColConfiguracion.Name = "lueColConfiguracion";
            // 
            // colUsuarioID
            // 
            this.colUsuarioID.ColumnEdit = this.lueColUsuario;
            this.colUsuarioID.FieldName = "UsuarioID";
            this.colUsuarioID.Name = "colUsuarioID";
            this.colUsuarioID.Visible = true;
            this.colUsuarioID.VisibleIndex = 16;
            // 
            // lueColUsuario
            // 
            this.lueColUsuario.AutoHeight = false;
            this.lueColUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueColUsuario.Name = "lueColUsuario";
            // 
            // colStatusID
            // 
            this.colStatusID.ColumnEdit = this.lueColStatus;
            this.colStatusID.FieldName = "StatusID";
            this.colStatusID.Name = "colStatusID";
            this.colStatusID.Visible = true;
            this.colStatusID.VisibleIndex = 17;
            // 
            // lueColStatus
            // 
            this.lueColStatus.AutoHeight = false;
            this.lueColStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueColStatus.Name = "lueColStatus";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.groupControl2);
            this.pnlDatos.Controls.Add(this.groupControl1);
            this.pnlDatos.Controls.Add(this.txtTotal);
            this.pnlDatos.Controls.Add(this.txtDescuento);
            this.pnlDatos.Controls.Add(this.txtIEPS);
            this.pnlDatos.Controls.Add(this.txtIVA);
            this.pnlDatos.Controls.Add(this.txtSubtotal);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1055, 427);
            this.pnlDatos.TabIndex = 32;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl4);
            this.groupControl2.Location = new System.Drawing.Point(22, 151);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1022, 264);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Detalle";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.txtcDescuento);
            this.panelControl4.Controls.Add(this.lueCatVehiculo);
            this.panelControl4.Controls.Add(this.lueCatTerminal);
            this.panelControl4.Controls.Add(this.dgcDetallePedido);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 21);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1018, 241);
            this.panelControl4.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(927, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Descuento";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(927, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Vehiculo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(927, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Terminal";
            // 
            // txtcDescuento
            // 
            this.txtcDescuento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spDetallePedidoBindingSource, "Descuento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtcDescuento.Location = new System.Drawing.Point(903, 172);
            this.txtcDescuento.Name = "txtcDescuento";
            this.txtcDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtcDescuento.TabIndex = 31;
            // 
            // spDetallePedidoBindingSource
            // 
            this.spDetallePedidoBindingSource.DataMember = "spDetallePedido";
            this.spDetallePedidoBindingSource.DataSource = this.detallePedidoDS1;
            this.spDetallePedidoBindingSource.Sort = "";
            // 
            // detallePedidoDS1
            // 
            this.detallePedidoDS1.DataSetName = "DetallePedidoDS";
            this.detallePedidoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueCatVehiculo
            // 
            this.lueCatVehiculo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spDetallePedidoBindingSource, "VehiculoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueCatVehiculo.Location = new System.Drawing.Point(903, 118);
            this.lueCatVehiculo.Name = "lueCatVehiculo";
            this.lueCatVehiculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCatVehiculo.Size = new System.Drawing.Size(100, 20);
            this.lueCatVehiculo.TabIndex = 30;
            // 
            // lueCatTerminal
            // 
            this.lueCatTerminal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spDetallePedidoBindingSource, "TerminalID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueCatTerminal.Location = new System.Drawing.Point(903, 63);
            this.lueCatTerminal.Name = "lueCatTerminal";
            this.lueCatTerminal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCatTerminal.Size = new System.Drawing.Size(100, 20);
            this.lueCatTerminal.TabIndex = 29;
            // 
            // dgcDetallePedido
            // 
            this.dgcDetallePedido.DataSource = this.spDetallePedidoBindingSource;
            this.dgcDetallePedido.Location = new System.Drawing.Point(2, 2);
            this.dgcDetallePedido.MainView = this.gvDetallePedido;
            this.dgcDetallePedido.Name = "dgcDetallePedido";
            this.dgcDetallePedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueProducto,
            this.txtDetalleVolumen});
            this.dgcDetallePedido.Size = new System.Drawing.Size(886, 243);
            this.dgcDetallePedido.TabIndex = 28;
            this.dgcDetallePedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetallePedido});
            this.dgcDetallePedido.Click += new System.EventHandler(this.dgcDetallePedido_Click);
            // 
            // gvDetallePedido
            // 
            this.gvDetallePedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetallePedidoID,
            this.colProductoID,
            this.colTerminalID,
            this.colVehiculoID,
            this.colVolumen,
            this.colPrecio,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colNoItems,
            this.colChoferID});
            this.gvDetallePedido.GridControl = this.dgcDetallePedido;
            this.gvDetallePedido.Name = "gvDetallePedido";
            this.gvDetallePedido.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDetallePedido.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvDetallePedido.OptionsView.ShowFooter = true;
            // 
            // colDetallePedidoID
            // 
            this.colDetallePedidoID.FieldName = "DetallePedidoID";
            this.colDetallePedidoID.Name = "colDetallePedidoID";
            this.colDetallePedidoID.Width = 77;
            // 
            // colProductoID
            // 
            this.colProductoID.Caption = "Producto";
            this.colProductoID.ColumnEdit = this.lueProducto;
            this.colProductoID.FieldName = "ProductoID";
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.Visible = true;
            this.colProductoID.VisibleIndex = 0;
            this.colProductoID.Width = 132;
            // 
            // lueProducto
            // 
            this.lueProducto.AutoHeight = false;
            this.lueProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProducto.Name = "lueProducto";
            // 
            // colTerminalID
            // 
            this.colTerminalID.Caption = "Terminal";
            this.colTerminalID.ColumnEdit = this.lueTerminal;
            this.colTerminalID.FieldName = "TerminalID";
            this.colTerminalID.Name = "colTerminalID";
            this.colTerminalID.Width = 70;
            // 
            // colVehiculoID
            // 
            this.colVehiculoID.Caption = "Vehiculo";
            this.colVehiculoID.ColumnEdit = this.lueVehiculo;
            this.colVehiculoID.FieldName = "VehiculoID";
            this.colVehiculoID.Name = "colVehiculoID";
            this.colVehiculoID.Width = 72;
            // 
            // colVolumen
            // 
            this.colVolumen.ColumnEdit = this.txtDetalleVolumen;
            this.colVolumen.FieldName = "Volumen";
            this.colVolumen.Name = "colVolumen";
            this.colVolumen.Visible = true;
            this.colVolumen.VisibleIndex = 1;
            this.colVolumen.Width = 101;
            // 
            // txtDetalleVolumen
            // 
            this.txtDetalleVolumen.AutoHeight = false;
            this.txtDetalleVolumen.Name = "txtDetalleVolumen";
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            this.colPrecio.Width = 53;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Subtotal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 122;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IVA";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 125;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IEPS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 128;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Total";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Descuento";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 39;
            // 
            // colNoItems
            // 
            this.colNoItems.Caption = "Numero Items";
            this.colNoItems.FieldName = "NoItems";
            this.colNoItems.Name = "colNoItems";
            this.colNoItems.Visible = true;
            this.colNoItems.VisibleIndex = 7;
            this.colNoItems.Width = 61;
            // 
            // colChoferID
            // 
            this.colChoferID.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colChoferID.FieldName = "ChoferID";
            this.colChoferID.Name = "colChoferID";
            this.colChoferID.Width = 68;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lblFactura);
            this.groupControl1.Controls.Add(this.memObservacion);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnGenerarRecibo);
            this.groupControl1.Controls.Add(this.dateFecha);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.lueStatusPedido);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtFolio);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.lueUsuario);
            this.groupControl1.Controls.Add(this.txtSerie);
            this.groupControl1.Controls.Add(this.lueEstacion);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(22, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(783, 140);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Encabezado";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(506, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(133, 97);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(0, 13);
            this.lblFactura.TabIndex = 33;
            // 
            // memObservacion
            // 
            this.memObservacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "Observacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memObservacion.Location = new System.Drawing.Point(255, 95);
            this.memObservacion.Name = "memObservacion";
            this.memObservacion.Size = new System.Drawing.Size(225, 34);
            this.memObservacion.TabIndex = 14;
            // 
            // spCatPedidoBindingSource
            // 
            this.spCatPedidoBindingSource.DataMember = "spPedido";
            this.spCatPedidoBindingSource.DataSource = this.spPedidoDS1;
            // 
            // spPedidoDS1
            // 
            this.spPedidoDS1.DataSetName = "spPedidoDS";
            this.spPedidoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Factura";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(380, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Estacion";
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.Location = new System.Drawing.Point(635, 32);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(110, 97);
            this.btnGenerarRecibo.TabIndex = 31;
            this.btnGenerarRecibo.Text = "Facturar";
            this.btnGenerarRecibo.UseVisualStyleBackColor = true;
            this.btnGenerarRecibo.Visible = false;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // dateFecha
            // 
            this.dateFecha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "Fecha", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateFecha.EditValue = null;
            this.dateFecha.Location = new System.Drawing.Point(506, 43);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Size = new System.Drawing.Size(100, 20);
            this.dateFecha.TabIndex = 13;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(14, 76);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(66, 13);
            this.labelControl13.TabIndex = 2;
            this.labelControl13.Text = "Status Pedido";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(255, 75);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 13);
            this.labelControl12.TabIndex = 12;
            this.labelControl12.Text = "Observacion";
            // 
            // lueStatusPedido
            // 
            this.lueStatusPedido.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "StatusID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueStatusPedido.Location = new System.Drawing.Point(14, 95);
            this.lueStatusPedido.Name = "lueStatusPedido";
            this.lueStatusPedido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatusPedido.Size = new System.Drawing.Size(100, 20);
            this.lueStatusPedido.TabIndex = 3;
            this.lueStatusPedido.EditValueChanged += new System.EventHandler(this.lueStatusPedido_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(255, 24);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Usuario";
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "Folio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFolio.Location = new System.Drawing.Point(134, 43);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(134, 23);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(22, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Folio";
            // 
            // lueUsuario
            // 
            this.lueUsuario.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "UsuarioID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueUsuario.Location = new System.Drawing.Point(255, 43);
            this.lueUsuario.Name = "lueUsuario";
            this.lueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsuario.Size = new System.Drawing.Size(100, 20);
            this.lueUsuario.TabIndex = 22;
            // 
            // txtSerie
            // 
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "Serie", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSerie.Location = new System.Drawing.Point(14, 43);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 15;
            // 
            // lueEstacion
            // 
            this.lueEstacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatPedidoBindingSource, "EstacionID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueEstacion.Location = new System.Drawing.Point(380, 43);
            this.lueEstacion.Name = "lueEstacion";
            this.lueEstacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstacion.Size = new System.Drawing.Size(100, 20);
            this.lueEstacion.TabIndex = 23;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 23);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Serie";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(1065, 80);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 21;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.Location = new System.Drawing.Point(1065, 61);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 20;
            // 
            // txtIEPS
            // 
            this.txtIEPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIEPS.Location = new System.Drawing.Point(1065, 42);
            this.txtIEPS.Name = "txtIEPS";
            this.txtIEPS.Size = new System.Drawing.Size(100, 20);
            this.txtIEPS.TabIndex = 19;
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIVA.Location = new System.Drawing.Point(1065, 23);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 18;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.Location = new System.Drawing.Point(1065, 4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 17;
            // 
            // xtpPedido
            // 
            this.xtpPedido.Name = "xtpPedido";
            this.xtpPedido.Size = new System.Drawing.Size(678, 282);
            this.xtpPedido.Text = "Pedidos";
            // 
            // frmCatPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1057, 452);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatPedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            this.tpBuscar.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueColStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatos)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetallePedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCatVehiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCatTerminal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalleVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPedidoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatusPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colPedidoID;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEjercicio;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colDia;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colIEPS;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionID;
        private DevExpress.XtraGrid.Columns.GridColumn colConfiguracionID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusID;
        private DevExpress.XtraEditors.PanelControl pnlDatos;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl dgcDetallePedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetallePedido;
        private DevExpress.XtraGrid.Columns.GridColumn colDetallePedidoID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminalID;
        private DevExpress.XtraGrid.Columns.GridColumn colVehiculoID;
        private DevExpress.XtraGrid.Columns.GridColumn colVolumen;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colNoItems;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferID;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LookUpEdit lueEstacion;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private DevExpress.XtraEditors.TextEdit txtIEPS;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIVA;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraEditors.LookUpEdit lueUsuario;
        private DevExpress.XtraEditors.TextEdit txtFolio;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit dateFecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memObservacion;
        private System.Windows.Forms.BindingSource spDetallePedidoBindingSource;
        private DataSets.DetallePedidoDS detallePedidoDS1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LookUpEdit lueStatusPedido;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtcDescuento;
        private DevExpress.XtraEditors.LookUpEdit lueCatVehiculo;
        private DevExpress.XtraEditors.LookUpEdit lueCatTerminal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueColEstacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueColConfiguracion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueColUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueColStatus;
        private DevExpress.XtraTab.XtraTabPage xtpPedido;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource spCatPedidoBindingSource;
        private DataSets.spPedidoDS spPedidoDS1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTerminal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueVehiculo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDetalleVolumen;
    }
}
