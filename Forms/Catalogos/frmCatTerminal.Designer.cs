namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatTerminal));
            this.spCatTerminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatTerminalDS1 = new RedCoForm.DataSets.spCatTerminalDS();
            this.colTerminalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new UserControls.CTextEdit();
            this.txtDomicilio = new UserControls.CTextEdit();
            this.txtRFC = new UserControls.CTextEdit();
            this.txtRazonSocial = new UserControls.CTextEdit();
            this.txtTelefono = new UserControls.CTextEdit();
            this.txtContacto = new UserControls.CTextEdit();
            this.txtEmail = new UserControls.CTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new UserControls.CTextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Size = new System.Drawing.Size(819, 380);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(817, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(817, 355);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Size = new System.Drawing.Size(817, 355);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatTerminalBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(817, 255);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTerminalID,
            this.colDescripcion,
            this.colDomicilio,
            this.colRFC,
            this.colRazonSocial,
            this.colTelefono,
            this.colContacto,
            this.colEmail});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spCatTerminalBindingSource
            // 
            this.spCatTerminalBindingSource.DataMember = "spCatTerminal";
            this.spCatTerminalBindingSource.DataSource = this.spCatTerminalDS1;
            this.spCatTerminalBindingSource.Sort = "";
            // 
            // spCatTerminalDS1
            // 
            this.spCatTerminalDS1.DataSetName = "spCatTerminalDS";
            this.spCatTerminalDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colTerminalID
            // 
            this.colTerminalID.FieldName = "TerminalID";
            this.colTerminalID.Name = "colTerminalID";
            this.colTerminalID.Visible = true;
            this.colTerminalID.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colDomicilio
            // 
            this.colDomicilio.FieldName = "Domicilio";
            this.colDomicilio.Name = "colDomicilio";
            this.colDomicilio.Visible = true;
            this.colDomicilio.VisibleIndex = 2;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 4;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 5;
            // 
            // colContacto
            // 
            this.colContacto.FieldName = "Contacto";
            this.colContacto.Name = "colContacto";
            this.colContacto.Visible = true;
            this.colContacto.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(113, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Descripcion";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Domicilio";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "RFC";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Razon Social";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 212);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Telefono";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(179, 212);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Contacto";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(179, 168);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Email";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(113, 51);
            this.txtDescripcion.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NDecimales = 2;
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(461, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "Domicilio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDomicilio.Location = new System.Drawing.Point(19, 142);
            this.txtDomicilio.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.NDecimales = 2;
            this.txtDomicilio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Size = new System.Drawing.Size(555, 20);
            this.txtDomicilio.TabIndex = 10;
            this.txtDomicilio.EditValueChanged += new System.EventHandler(this.txtDomicilio_EditValueChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "RFC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRFC.Location = new System.Drawing.Point(19, 187);
            this.txtRFC.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.NDecimales = 2;
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Size = new System.Drawing.Size(154, 20);
            this.txtRFC.TabIndex = 11;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "RazonSocial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRazonSocial.Location = new System.Drawing.Point(19, 96);
            this.txtRazonSocial.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.NDecimales = 2;
            this.txtRazonSocial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Size = new System.Drawing.Size(555, 20);
            this.txtRazonSocial.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTelefono.Location = new System.Drawing.Point(19, 231);
            this.txtTelefono.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.NDecimales = 2;
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Size = new System.Drawing.Size(154, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtContacto
            // 
            this.txtContacto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "Contacto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtContacto.Location = new System.Drawing.Point(179, 231);
            this.txtContacto.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.NDecimales = 2;
            this.txtContacto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContacto.Size = new System.Drawing.Size(395, 20);
            this.txtContacto.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEmail.Location = new System.Drawing.Point(179, 187);
            this.txtEmail.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NDecimales = 2;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Size = new System.Drawing.Size(395, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtContacto);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtTelefono);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtRazonSocial);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtRFC);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtDomicilio);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Location = new System.Drawing.Point(11, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(643, 295);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Datos";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBindingSource, "TerminalID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit2.Location = new System.Drawing.Point(19, 51);
            this.textEdit2.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.NDecimales = 2;
            this.textEdit2.Size = new System.Drawing.Size(88, 20);
            this.textEdit2.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(19, 32);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "No. TAD";
            // 
            // frmCatTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(819, 380);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatTerminal";
            this.Text = "Terminal";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatTerminalBindingSource;
        private DataSets.spCatTerminalDS spCatTerminalDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminalID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private UserControls.CTextEdit txtEmail;
        private UserControls.CTextEdit txtContacto;
        private UserControls.CTextEdit txtTelefono;
        private UserControls.CTextEdit txtRazonSocial;
        private UserControls.CTextEdit txtRFC;
        private UserControls.CTextEdit txtDomicilio;
        private UserControls.CTextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.CTextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}
