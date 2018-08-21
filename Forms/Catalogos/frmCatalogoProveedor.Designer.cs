namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatalogoProveedor
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtRazonSocial = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.spCatProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatProveedorDS1 = new RedCoForm.DataSets.spCatProveedorDS();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colProveedorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPlazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Size = new System.Drawing.Size(555, 331);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(553, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(553, 306);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Size = new System.Drawing.Size(553, 306);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatProveedorBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(553, 206);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProveedorId,
            this.colNombre,
            this.colCalle,
            this.colColonia,
            this.colCiudad,
            this.colRFC,
            this.colTelefono,
            this.colFax,
            this.colCodPostal,
            this.colEmail,
            this.colReferencia,
            this.colDiasPlazo,
            this.colCuentaContable});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtCorreo);
            this.groupControl1.Controls.Add(this.txtTelefono);
            this.groupControl1.Controls.Add(this.txtRazonSocial);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(23, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(424, 219);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Email", true));
            this.txtCorreo.Location = new System.Drawing.Point(132, 185);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(260, 20);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Telefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(19, 185);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(19, 142);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(373, 20);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(19, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // spCatProveedorBindingSource
            // 
            this.spCatProveedorBindingSource.DataMember = "spCatProveedor";
            this.spCatProveedorBindingSource.DataSource = this.spCatProveedorDS1;
            this.spCatProveedorBindingSource.Sort = "";
            // 
            // spCatProveedorDS1
            // 
            this.spCatProveedorDS1.DataSetName = "spCatProveedorDS";
            this.spCatProveedorDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "ProveedorId", true));
            this.txtID.Location = new System.Drawing.Point(19, 52);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(49, 20);
            this.txtID.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(132, 168);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Email";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tel";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Razon Social";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // colProveedorId
            // 
            this.colProveedorId.FieldName = "ProveedorId";
            this.colProveedorId.Name = "colProveedorId";
            this.colProveedorId.Visible = true;
            this.colProveedorId.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colCalle
            // 
            this.colCalle.FieldName = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 2;
            // 
            // colColonia
            // 
            this.colColonia.FieldName = "Colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.Visible = true;
            this.colColonia.VisibleIndex = 3;
            // 
            // colCiudad
            // 
            this.colCiudad.FieldName = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.Visible = true;
            this.colCiudad.VisibleIndex = 4;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 5;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colCodPostal
            // 
            this.colCodPostal.FieldName = "CodPostal";
            this.colCodPostal.Name = "colCodPostal";
            this.colCodPostal.Visible = true;
            this.colCodPostal.VisibleIndex = 8;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            // 
            // colReferencia
            // 
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 10;
            // 
            // colDiasPlazo
            // 
            this.colDiasPlazo.FieldName = "DiasPlazo";
            this.colDiasPlazo.Name = "colDiasPlazo";
            this.colDiasPlazo.Visible = true;
            this.colDiasPlazo.VisibleIndex = 11;
            // 
            // colCuentaContable
            // 
            this.colCuentaContable.FieldName = "CuentaContable";
            this.colCuentaContable.Name = "colCuentaContable";
            this.colCuentaContable.Visible = true;
            this.colCuentaContable.VisibleIndex = 12;
            // 
            // frmCatalogoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(555, 331);
            this.Name = "frmCatalogoProveedor";
            this.Text = "Catalogo Proveedor";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtRazonSocial;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource spCatProveedorBindingSource;
        private DataSets.spCatProveedorDS spCatProveedorDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedorId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCodPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPlazo;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContable;
    }
}
