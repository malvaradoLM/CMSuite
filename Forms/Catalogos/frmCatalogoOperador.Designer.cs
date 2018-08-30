namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatalogoOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoOperador));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.spCatOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatOperadorDS1 = new RedCoForm.DataSets.spCatOperadorDS();
            this.colOperadorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransportistaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOperadorID = new UserControls.CTextEdit();
            this.txtNombre = new UserControls.CTextEdit();
            this.lueTransportista = new DevExpress.XtraEditors.LookUpEdit();
            this.chkStatus = new DevExpress.XtraEditors.CheckEdit();
            this.spCatTransportistaDS = new RedCoForm.DataSets.spCatTransportistaDS();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatOperadorDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperadorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTransportista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTransportistaDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.Size = new System.Drawing.Size(603, 356);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(861, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(861, 452);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Size = new System.Drawing.Size(601, 331);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatOperadorBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(861, 352);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOperadorID,
            this.colNombre,
            this.colstatus,
            this.colTransportistaID});
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
            this.groupControl1.Controls.Add(this.chkStatus);
            this.groupControl1.Controls.Add(this.lueTransportista);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.txtOperadorID);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(31, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(469, 230);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // spCatOperadorBindingSource
            // 
            this.spCatOperadorBindingSource.DataMember = "spCatOperador";
            this.spCatOperadorBindingSource.DataSource = this.spCatOperadorDS1;
            this.spCatOperadorBindingSource.Sort = "";
            // 
            // spCatOperadorDS1
            // 
            this.spCatOperadorDS1.DataSetName = "spCatOperadorDS";
            this.spCatOperadorDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colOperadorID
            // 
            this.colOperadorID.FieldName = "OperadorID";
            this.colOperadorID.Name = "colOperadorID";
            this.colOperadorID.Visible = true;
            this.colOperadorID.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 2;
            // 
            // colTransportistaID
            // 
            this.colTransportistaID.FieldName = "TransportistaID";
            this.colTransportistaID.Name = "colTransportistaID";
            this.colTransportistaID.Visible = true;
            this.colTransportistaID.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "OperadorID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Transportista";
            // 
            // txtOperadorID
            // 
            this.txtOperadorID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatOperadorBindingSource, "OperadorID", true));
            this.txtOperadorID.Location = new System.Drawing.Point(39, 56);
            this.txtOperadorID.Name = "txtOperadorID";
            this.txtOperadorID.Properties.ReadOnly = true;
            this.txtOperadorID.Size = new System.Drawing.Size(57, 20);
            this.txtOperadorID.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatOperadorBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(39, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(349, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lueTransportista
            // 
            this.lueTransportista.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatOperadorBindingSource, "TransportistaID", true));
            this.lueTransportista.Location = new System.Drawing.Point(39, 147);
            this.lueTransportista.Name = "lueTransportista";
            this.lueTransportista.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTransportista.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueTransportista.Properties.NullText = "[Seleccione un Transportista...]";
            this.lueTransportista.Size = new System.Drawing.Size(349, 20);
            this.lueTransportista.TabIndex = 5;
            // 
            // chkStatus
            // 
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatOperadorBindingSource, "status", true));
            this.chkStatus.Location = new System.Drawing.Point(39, 186);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Properties.Caption = "Status";
            this.chkStatus.Size = new System.Drawing.Size(75, 19);
            this.chkStatus.TabIndex = 6;
            // 
            // spCatTransportistaDS
            // 
            this.spCatTransportistaDS.DataSetName = "spCatTransportistaDS";
            this.spCatTransportistaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCatalogoOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(603, 356);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalogoOperador";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatOperadorDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperadorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTransportista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTransportistaDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource spCatOperadorBindingSource;
        private DataSets.spCatOperadorDS spCatOperadorDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colOperadorID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportistaID;
        private DevExpress.XtraEditors.CheckEdit chkStatus;
        private DevExpress.XtraEditors.LookUpEdit lueTransportista;
        private UserControls.CTextEdit txtNombre;
        private UserControls.CTextEdit txtOperadorID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DataSets.spCatTransportistaDS spCatTransportistaDS;
    }
}
