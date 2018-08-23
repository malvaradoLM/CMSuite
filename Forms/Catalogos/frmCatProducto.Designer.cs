namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatProducto
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
            this.colProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.chkStatus = new DevExpress.XtraEditors.CheckEdit();
            this.spCatProductoDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatProductoDS = new RedCoForm.DataSets.spCatProductoDS();
            this.lueCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoBarras = new DevExpress.XtraEditors.TextEdit();
            this.txtClaveSAT = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaContCompra = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaContVenta = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaContIVA = new DevExpress.XtraEditors.TextEdit();
            this.txtCostoPromedio = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtProductoID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveSAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoPromedio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Size = new System.Drawing.Size(763, 399);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(761, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(761, 374);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatProductoDSBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(761, 274);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductoID,
            this.colDescripcion,
            this.colCodigo,
            this.colPrecio,
            this.colCodigoBarras,
            this.colClaveSAT,
            this.colCategoriaID});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // colProductoID
            // 
            this.colProductoID.FieldName = "ProductoID";
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.Visible = true;
            this.colProductoID.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 2;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            // 
            // colCodigoBarras
            // 
            this.colCodigoBarras.FieldName = "CodigoBarras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.Visible = true;
            this.colCodigoBarras.VisibleIndex = 4;
            // 
            // colClaveSAT
            // 
            this.colClaveSAT.FieldName = "ClaveSAT";
            this.colClaveSAT.Name = "colClaveSAT";
            this.colClaveSAT.Visible = true;
            this.colClaveSAT.VisibleIndex = 5;
            // 
            // colCategoriaID
            // 
            this.colCategoriaID.FieldName = "CategoriaID";
            this.colCategoriaID.Name = "colCategoriaID";
            this.colCategoriaID.Visible = true;
            this.colCategoriaID.VisibleIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(126, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Descripcion";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Codigo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(132, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Precio";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(253, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Codigo Barras";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(44, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Clave SAT";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(392, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Categoria";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(132, 125);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Costo Promedio";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(44, 174);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(121, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Cuenta Contable Compra";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(238, 125);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(112, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Cuenta Contable Venta";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(407, 125);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(101, 13);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Cuenta Contable IVA";
            // 
            // chkStatus
            // 
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CostoPromedio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkStatus.Location = new System.Drawing.Point(44, 229);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Properties.Caption = "Producto Activo";
            this.chkStatus.Size = new System.Drawing.Size(188, 19);
            this.chkStatus.TabIndex = 12;
            // 
            // spCatProductoDSBindingSource
            // 
            this.spCatProductoDSBindingSource.DataMember = "spCatProducto";
            this.spCatProductoDSBindingSource.DataSource = this.spCatProductoDS;
            // 
            // spCatProductoDS
            // 
            this.spCatProductoDS.DataSetName = "spCatProductoDS";
            this.spCatProductoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueCategoria
            // 
            this.lueCategoria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CategoriaID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueCategoria.Location = new System.Drawing.Point(407, 99);
            this.lueCategoria.Name = "lueCategoria";
            this.lueCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCategoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueCategoria.Properties.NullText = "[Seleccione una Categoria...]";
            this.lueCategoria.Size = new System.Drawing.Size(235, 20);
            this.lueCategoria.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(132, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(510, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "Codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCodigo.Location = new System.Drawing.Point(44, 99);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Size = new System.Drawing.Size(82, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "Precio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrecio.Location = new System.Drawing.Point(132, 99);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CodigoBarras", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCodigoBarras.Location = new System.Drawing.Point(238, 99);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarras.Size = new System.Drawing.Size(163, 20);
            this.txtCodigoBarras.TabIndex = 17;
            // 
            // txtClaveSAT
            // 
            this.txtClaveSAT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "ClaveSAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtClaveSAT.Location = new System.Drawing.Point(44, 148);
            this.txtClaveSAT.Name = "txtClaveSAT";
            this.txtClaveSAT.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveSAT.Size = new System.Drawing.Size(82, 20);
            this.txtClaveSAT.TabIndex = 18;
            this.txtClaveSAT.EditValueChanged += new System.EventHandler(this.textEdit5_EditValueChanged);
            // 
            // txtCuentaContCompra
            // 
            this.txtCuentaContCompra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CuentaContableCompra", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCuentaContCompra.Location = new System.Drawing.Point(44, 193);
            this.txtCuentaContCompra.Name = "txtCuentaContCompra";
            this.txtCuentaContCompra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContCompra.Size = new System.Drawing.Size(188, 20);
            this.txtCuentaContCompra.TabIndex = 19;
            // 
            // txtCuentaContVenta
            // 
            this.txtCuentaContVenta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CuentaContableVenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCuentaContVenta.Location = new System.Drawing.Point(238, 148);
            this.txtCuentaContVenta.Name = "txtCuentaContVenta";
            this.txtCuentaContVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContVenta.Size = new System.Drawing.Size(163, 20);
            this.txtCuentaContVenta.TabIndex = 20;
            // 
            // txtCuentaContIVA
            // 
            this.txtCuentaContIVA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CuentaContableIVA", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCuentaContIVA.Location = new System.Drawing.Point(407, 148);
            this.txtCuentaContIVA.Name = "txtCuentaContIVA";
            this.txtCuentaContIVA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContIVA.Size = new System.Drawing.Size(235, 20);
            this.txtCuentaContIVA.TabIndex = 22;
            // 
            // txtCostoPromedio
            // 
            this.txtCostoPromedio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "CostoPromedio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCostoPromedio.Location = new System.Drawing.Point(132, 148);
            this.txtCostoPromedio.Name = "txtCostoPromedio";
            this.txtCostoPromedio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCostoPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtCostoPromedio.TabIndex = 23;
            this.txtCostoPromedio.EditValueChanged += new System.EventHandler(this.textEdit10_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtProductoID);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.chkStatus);
            this.groupControl1.Controls.Add(this.txtCostoPromedio);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtCuentaContIVA);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtCuentaContVenta);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCuentaContCompra);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lueCategoria);
            this.groupControl1.Controls.Add(this.txtClaveSAT);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtCodigoBarras);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtCodigo);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtPrecio);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(28, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(684, 281);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Datos";
            // 
            // txtProductoID
            // 
            this.txtProductoID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoDSBindingSource, "ProductoID", true));
            this.txtProductoID.Location = new System.Drawing.Point(44, 54);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Properties.ReadOnly = true;
            this.txtProductoID.Size = new System.Drawing.Size(82, 20);
            this.txtProductoID.TabIndex = 25;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(44, 35);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(11, 13);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "ID";
            // 
            // frmCatProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(763, 399);
            this.Name = "frmCatProducto";
            this.Text = "Catalogo Producto";
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
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveSAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoPromedio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveSAT;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaID;
        private DevExpress.XtraEditors.TextEdit txtCostoPromedio;
        private DevExpress.XtraEditors.TextEdit txtCuentaContIVA;
        private DevExpress.XtraEditors.TextEdit txtCuentaContVenta;
        private DevExpress.XtraEditors.TextEdit txtCuentaContCompra;
        private DevExpress.XtraEditors.TextEdit txtClaveSAT;
        private DevExpress.XtraEditors.TextEdit txtCodigoBarras;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LookUpEdit lueCategoria;
        private DevExpress.XtraEditors.CheckEdit chkStatus;
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
        private System.Windows.Forms.BindingSource spCatProductoDSBindingSource;
        private DataSets.spCatProductoDS spCatProductoDS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtProductoID;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}
