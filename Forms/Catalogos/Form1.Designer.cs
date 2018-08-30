namespace RedCoForm
{
    partial class Form1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.dateFecha = new DevExpress.XtraEditors.DateEdit();
            this.spPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.txtSerie = new UserControls.CTextEdit();
            this.txtFolio = new UserControls.CTextEdit();
            this.txtSubtotal = new UserControls.CTextEdit();
            this.txtIVA = new UserControls.CTextEdit();
            this.txtIEPS = new UserControls.CTextEdit();
            this.txtDescuento = new UserControls.CTextEdit();
            this.txtTotal = new UserControls.CTextEdit();
            this.lueUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.spCatUsuarioDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatUsuarioDS = new RedCoForm.DataSets.spCatUsuarioDS();
            this.lueEstacion = new DevExpress.XtraEditors.LookUpEdit();
            this.spCatEstacionDS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatEstacionDS = new RedCoForm.DataSets.spCatEstacionDS();
            this.txtBuscar = new UserControls.CTextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.dgcDetallePedido = new DevExpress.XtraGrid.GridControl();
            this.spDetallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidoDS1 = new RedCoForm.DataSets.DetallePedidoDS();
            this.gvDetallePedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetallePedidoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueProducto = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTerminalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueTerminal = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colVehiculoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueVehiculo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colVolumen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIEPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spCatProductoDS = new RedCoForm.DataSets.spCatProductoDS();
            this.spCatProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPedidoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spCatTerminalDS = new RedCoForm.DataSets.spCatTerminalDS();
            this.spCatVehiculoDS = new RedCoForm.DataSets.spCatVehiculoDS();
            this.spCatTerminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkStatus = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgcPedido = new DevExpress.XtraGrid.GridControl();
            this.gvPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPedidoID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEjercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIEPS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfiguracionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlDatos = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetallePedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatos)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Estacion";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(456, 374);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Subtotal";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(456, 393);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "IVA";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(456, 412);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "IEPS";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(456, 450);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Total";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(456, 431);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Descuento";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(132, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Usuario";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(389, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Serie";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(499, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(22, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Folio";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(24, 54);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(31, 13);
            this.labelControl11.TabIndex = 11;
            this.labelControl11.Text = "Status";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(132, 54);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 13);
            this.labelControl12.TabIndex = 12;
            this.labelControl12.Text = "Observacion";
            // 
            // dateFecha
            // 
            this.dateFecha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "Fecha", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateFecha.EditValue = null;
            this.dateFecha.Location = new System.Drawing.Point(24, 22);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Size = new System.Drawing.Size(100, 20);
            this.dateFecha.TabIndex = 13;
            // 
            // memObservacion
            // 
            this.memObservacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "Observacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memObservacion.Location = new System.Drawing.Point(132, 73);
            this.memObservacion.Name = "memObservacion";
            this.memObservacion.Size = new System.Drawing.Size(200, 34);
            this.memObservacion.TabIndex = 14;
            // 
            // txtSerie
            // 
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "Serie", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSerie.Location = new System.Drawing.Point(389, 22);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 15;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "Folio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFolio.Location = new System.Drawing.Point(499, 22);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 16;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(542, 371);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 17;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(542, 390);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 18;
            // 
            // txtIEPS
            // 
            this.txtIEPS.Location = new System.Drawing.Point(542, 409);
            this.txtIEPS.Name = "txtIEPS";
            this.txtIEPS.Size = new System.Drawing.Size(100, 20);
            this.txtIEPS.TabIndex = 19;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(542, 428);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 20;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(542, 447);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 21;
            // 
            // lueUsuario
            // 
            this.lueUsuario.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "UsuarioID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueUsuario.Location = new System.Drawing.Point(132, 22);
            this.lueUsuario.Name = "lueUsuario";
            this.lueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsuario.Properties.DataSource = this.spCatUsuarioDSBindingSource;
            this.lueUsuario.Size = new System.Drawing.Size(100, 20);
            this.lueUsuario.TabIndex = 22;
            // 
            // spCatUsuarioDSBindingSource
            // 
            this.spCatUsuarioDSBindingSource.DataMember = "spCatUsuario";
            this.spCatUsuarioDSBindingSource.DataSource = this.spCatUsuarioDS;
            // 
            // spCatUsuarioDS
            // 
            this.spCatUsuarioDS.DataSetName = "spCatUsuarioDS";
            this.spCatUsuarioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueEstacion
            // 
            this.lueEstacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "EstacionID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueEstacion.Location = new System.Drawing.Point(249, 22);
            this.lueEstacion.Name = "lueEstacion";
            this.lueEstacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstacion.Properties.DataSource = this.spCatEstacionDS1BindingSource;
            this.lueEstacion.Size = new System.Drawing.Size(100, 20);
            this.lueEstacion.TabIndex = 23;
            // 
            // spCatEstacionDS1BindingSource
            // 
            this.spCatEstacionDS1BindingSource.DataMember = "spCatEstacion";
            this.spCatEstacionDS1BindingSource.DataSource = this.spCatEstacionDS;
            // 
            // spCatEstacionDS
            // 
            this.spCatEstacionDS.DataSetName = "spCatEstacionDS";
            this.spCatEstacionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(5, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(111, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgcDetallePedido
            // 
            this.dgcDetallePedido.DataSource = this.spDetallePedidoBindingSource;
            this.dgcDetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcDetallePedido.Location = new System.Drawing.Point(2, 2);
            this.dgcDetallePedido.MainView = this.gvDetallePedido;
            this.dgcDetallePedido.Name = "dgcDetallePedido";
            this.dgcDetallePedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueProducto,
            this.lueTerminal,
            this.lueVehiculo,
            this.repositoryItemLookUpEdit4});
            this.dgcDetallePedido.Size = new System.Drawing.Size(616, 243);
            this.dgcDetallePedido.TabIndex = 28;
            this.dgcDetallePedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetallePedido});
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
            // gvDetallePedido
            // 
            this.gvDetallePedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetallePedidoID,
            this.colProductoID,
            this.colTerminalID,
            this.colVehiculoID,
            this.colVolumen,
            this.colPrecio,
            this.colSubtotal,
            this.colIVA,
            this.colIEPS,
            this.colTotal,
            this.colDescuento,
            this.colNoItems,
            this.colChoferID});
            this.gvDetallePedido.GridControl = this.dgcDetallePedido;
            this.gvDetallePedido.Name = "gvDetallePedido";
            this.gvDetallePedido.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDetallePedido_CellValueChanged);
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
            this.colProductoID.Width = 51;
            // 
            // lueProducto
            // 
            this.lueProducto.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueProducto.AutoHeight = false;
            this.lueProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProducto.Name = "lueProducto";
            this.lueProducto.ShowFooter = false;
            this.lueProducto.ShowHeader = false;
            // 
            // colTerminalID
            // 
            this.colTerminalID.Caption = "Terminal";
            this.colTerminalID.ColumnEdit = this.lueTerminal;
            this.colTerminalID.FieldName = "TerminalID";
            this.colTerminalID.Name = "colTerminalID";
            this.colTerminalID.Visible = true;
            this.colTerminalID.VisibleIndex = 1;
            this.colTerminalID.Width = 70;
            // 
            // lueTerminal
            // 
            this.lueTerminal.AutoHeight = false;
            this.lueTerminal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTerminal.Name = "lueTerminal";
            this.lueTerminal.ShowFooter = false;
            this.lueTerminal.ShowHeader = false;
            // 
            // colVehiculoID
            // 
            this.colVehiculoID.Caption = "Vehiculo";
            this.colVehiculoID.ColumnEdit = this.lueVehiculo;
            this.colVehiculoID.FieldName = "VehiculoID";
            this.colVehiculoID.Name = "colVehiculoID";
            this.colVehiculoID.Visible = true;
            this.colVehiculoID.VisibleIndex = 2;
            this.colVehiculoID.Width = 72;
            // 
            // lueVehiculo
            // 
            this.lueVehiculo.AutoHeight = false;
            this.lueVehiculo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVehiculo.Name = "lueVehiculo";
            // 
            // colVolumen
            // 
            this.colVolumen.FieldName = "Volumen";
            this.colVolumen.Name = "colVolumen";
            this.colVolumen.Visible = true;
            this.colVolumen.VisibleIndex = 3;
            this.colVolumen.Width = 39;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 39;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 5;
            this.colSubtotal.Width = 39;
            // 
            // colIVA
            // 
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 6;
            this.colIVA.Width = 39;
            // 
            // colIEPS
            // 
            this.colIEPS.FieldName = "IEPS";
            this.colIEPS.Name = "colIEPS";
            this.colIEPS.Visible = true;
            this.colIEPS.VisibleIndex = 7;
            this.colIEPS.Width = 39;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 39;
            // 
            // colDescuento
            // 
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 9;
            this.colDescuento.Width = 39;
            // 
            // colNoItems
            // 
            this.colNoItems.Caption = "Numero Items";
            this.colNoItems.FieldName = "NoItems";
            this.colNoItems.Name = "colNoItems";
            this.colNoItems.Visible = true;
            this.colNoItems.VisibleIndex = 10;
            this.colNoItems.Width = 39;
            // 
            // colChoferID
            // 
            this.colChoferID.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colChoferID.FieldName = "ChoferID";
            this.colChoferID.Name = "colChoferID";
            this.colChoferID.Width = 68;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            // 
            // spCatProductoDS
            // 
            this.spCatProductoDS.DataSetName = "spCatProductoDS";
            this.spCatProductoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatProductoBindingSource
            // 
            this.spCatProductoBindingSource.DataMember = "spCatProducto";
            this.spCatProductoBindingSource.DataSource = this.spCatProductoDS;
            // 
            // colPedidoID
            // 
            this.colPedidoID.FieldName = "PedidoID";
            this.colPedidoID.Name = "colPedidoID";
            this.colPedidoID.Width = 94;
            // 
            // spCatTerminalDS
            // 
            this.spCatTerminalDS.DataSetName = "spCatTerminalDS";
            this.spCatTerminalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatVehiculoDS
            // 
            this.spCatVehiculoDS.DataSetName = "spCatVehiculoDS";
            this.spCatVehiculoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatTerminalBindingSource
            // 
            this.spCatTerminalBindingSource.DataMember = "spCatTerminal";
            this.spCatTerminalBindingSource.DataSource = this.spCatTerminalDS;
            // 
            // spCatVehiculoBindingSource
            // 
            this.spCatVehiculoBindingSource.DataMember = "spCatVehiculo";
            this.spCatVehiculoBindingSource.DataSource = this.spCatVehiculoDS;
            // 
            // chkStatus
            // 
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spPedidoBindingSource, "Status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkStatus.Location = new System.Drawing.Point(24, 73);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Properties.Caption = "Activo";
            this.chkStatus.Size = new System.Drawing.Size(75, 19);
            this.chkStatus.TabIndex = 29;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.txtBuscar);
            this.panelControl1.Controls.Add(this.btnBuscar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(158, 480);
            this.panelControl1.TabIndex = 30;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.dgcPedido);
            this.panelControl2.Location = new System.Drawing.Point(5, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(148, 407);
            this.panelControl2.TabIndex = 29;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // dgcPedido
            // 
            this.dgcPedido.DataSource = this.spPedidoBindingSource;
            this.dgcPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcPedido.Location = new System.Drawing.Point(2, 2);
            this.dgcPedido.MainView = this.gvPedido;
            this.dgcPedido.Name = "dgcPedido";
            this.dgcPedido.Size = new System.Drawing.Size(144, 403);
            this.dgcPedido.TabIndex = 28;
            this.dgcPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedido});
            // 
            // gvPedido
            // 
            this.gvPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPedidoID1,
            this.colSerie,
            this.colFolio,
            this.colFecha,
            this.colFechaModificacion,
            this.colEjercicio,
            this.colPeriodo,
            this.colDia,
            this.colSubtotal1,
            this.colIVA1,
            this.colIEPS1,
            this.colTotal1,
            this.colDescuento1,
            this.colStatus,
            this.colObservacion,
            this.colEstacionID,
            this.colConfiguracionID,
            this.colUsuarioID,
            this.colStatusID});
            this.gvPedido.GridControl = this.dgcPedido;
            this.gvPedido.Name = "gvPedido";
            this.gvPedido.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPedido_FocusedRowChanged);
            // 
            // colPedidoID1
            // 
            this.colPedidoID1.FieldName = "PedidoID";
            this.colPedidoID1.Name = "colPedidoID1";
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 1;
            // 
            // colFolio
            // 
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 0;
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
            // 
            // colPeriodo
            // 
            this.colPeriodo.FieldName = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            // 
            // colDia
            // 
            this.colDia.FieldName = "Dia";
            this.colDia.Name = "colDia";
            // 
            // colSubtotal1
            // 
            this.colSubtotal1.FieldName = "Subtotal";
            this.colSubtotal1.Name = "colSubtotal1";
            // 
            // colIVA1
            // 
            this.colIVA1.FieldName = "IVA";
            this.colIVA1.Name = "colIVA1";
            // 
            // colIEPS1
            // 
            this.colIEPS1.FieldName = "IEPS";
            this.colIEPS1.Name = "colIEPS1";
            // 
            // colTotal1
            // 
            this.colTotal1.FieldName = "Total";
            this.colTotal1.Name = "colTotal1";
            // 
            // colDescuento1
            // 
            this.colDescuento1.FieldName = "Descuento";
            this.colDescuento1.Name = "colDescuento1";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            // 
            // colEstacionID
            // 
            this.colEstacionID.FieldName = "EstacionID";
            this.colEstacionID.Name = "colEstacionID";
            this.colEstacionID.Visible = true;
            this.colEstacionID.VisibleIndex = 4;
            // 
            // colConfiguracionID
            // 
            this.colConfiguracionID.FieldName = "ConfiguracionID";
            this.colConfiguracionID.Name = "colConfiguracionID";
            // 
            // colUsuarioID
            // 
            this.colUsuarioID.FieldName = "UsuarioID";
            this.colUsuarioID.Name = "colUsuarioID";
            this.colUsuarioID.Visible = true;
            this.colUsuarioID.VisibleIndex = 5;
            // 
            // colStatusID
            // 
            this.colStatusID.FieldName = "StatusID";
            this.colStatusID.Name = "colStatusID";
            this.colStatusID.Visible = true;
            this.colStatusID.VisibleIndex = 6;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnUpdate);
            this.pnlDatos.Controls.Add(this.panelControl4);
            this.pnlDatos.Controls.Add(this.labelControl10);
            this.pnlDatos.Controls.Add(this.txtTotal);
            this.pnlDatos.Controls.Add(this.lueEstacion);
            this.pnlDatos.Controls.Add(this.txtDescuento);
            this.pnlDatos.Controls.Add(this.chkStatus);
            this.pnlDatos.Controls.Add(this.txtIEPS);
            this.pnlDatos.Controls.Add(this.labelControl9);
            this.pnlDatos.Controls.Add(this.txtIVA);
            this.pnlDatos.Controls.Add(this.txtSerie);
            this.pnlDatos.Controls.Add(this.txtSubtotal);
            this.pnlDatos.Controls.Add(this.labelControl7);
            this.pnlDatos.Controls.Add(this.lueUsuario);
            this.pnlDatos.Controls.Add(this.labelControl6);
            this.pnlDatos.Controls.Add(this.txtFolio);
            this.pnlDatos.Controls.Add(this.labelControl5);
            this.pnlDatos.Controls.Add(this.labelControl8);
            this.pnlDatos.Controls.Add(this.labelControl4);
            this.pnlDatos.Controls.Add(this.labelControl1);
            this.pnlDatos.Controls.Add(this.labelControl3);
            this.pnlDatos.Controls.Add(this.labelControl11);
            this.pnlDatos.Controls.Add(this.labelControl12);
            this.pnlDatos.Controls.Add(this.dateFecha);
            this.pnlDatos.Controls.Add(this.labelControl2);
            this.pnlDatos.Controls.Add(this.memObservacion);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(675, 480);
            this.pnlDatos.TabIndex = 31;
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.dgcDetallePedido);
            this.panelControl4.Location = new System.Drawing.Point(22, 118);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(620, 247);
            this.panelControl4.TabIndex = 30;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pnlDatos);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(845, 480);
            this.splitContainerControl1.SplitterPosition = 158;
            this.splitContainerControl1.TabIndex = 29;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 480);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetallePedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatos)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit dateFecha;
        private DevExpress.XtraEditors.MemoEdit memObservacion;
        private UserControls.CTextEdit txtSerie;
        private UserControls.CTextEdit txtFolio;
        private UserControls.CTextEdit txtSubtotal;
        private UserControls.CTextEdit txtIVA;
        private UserControls.CTextEdit txtIEPS;
        private UserControls.CTextEdit txtDescuento;
        private UserControls.CTextEdit txtTotal;
        private DevExpress.XtraEditors.LookUpEdit lueUsuario;
        private DevExpress.XtraEditors.LookUpEdit lueEstacion;
        private UserControls.CTextEdit txtBuscar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DataSets.DetallePedidoDS spDetallePedidoDS;
        private DevExpress.XtraGrid.GridControl dgcDetallePedido;
        private System.Windows.Forms.BindingSource spDetallePedidoBindingSource;
        private DataSets.DetallePedidoDS detallePedidoDS1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetallePedido;
        private DevExpress.XtraGrid.Columns.GridColumn colDetallePedidoID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminalID;
        private DevExpress.XtraGrid.Columns.GridColumn colVehiculoID;
        private DevExpress.XtraGrid.Columns.GridColumn colVolumen;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colIEPS;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colNoItems;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferID;
        private System.Windows.Forms.BindingSource spCatUsuarioDSBindingSource;
        private DataSets.spCatUsuarioDS spCatUsuarioDS;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueProducto;
        private System.Windows.Forms.BindingSource spCatEstacionDS1BindingSource;
        private DataSets.spCatProductoDS spCatProductoDS;
        private System.Windows.Forms.BindingSource spCatProductoBindingSource;
        private DataSets.spCatEstacionDS spCatEstacionDS;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTerminal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueVehiculo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colPedidoID;
        private DataSets.spCatTerminalDS spCatTerminalDS;
        private DataSets.spCatVehiculoDS spCatVehiculoDS;
        private System.Windows.Forms.BindingSource spCatTerminalBindingSource;
        private System.Windows.Forms.BindingSource spCatVehiculoBindingSource;
        private DevExpress.XtraEditors.CheckEdit chkStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgcPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPedido;
        private DevExpress.XtraEditors.PanelControl pnlDatos;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.BindingSource spPedidoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPedidoID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEjercicio;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colDia;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA1;
        private DevExpress.XtraGrid.Columns.GridColumn colIEPS1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionID;
        private DevExpress.XtraGrid.Columns.GridColumn colConfiguracionID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusID;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}

