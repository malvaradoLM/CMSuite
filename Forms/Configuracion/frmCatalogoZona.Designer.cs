namespace RedCoForm.Forms.Configuracion
{
    partial class frmCatalogoZona
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
            this.textEdit2 = new UserControls.CTextEdit();
            this.textEdit1 = new UserControls.CTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spCatZonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatZonaDS1 = new RedCoForm.DataSets.spCatZonaDS();
            this.colZonaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatZonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatZonaDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            // 
            // txtDatosBusqueda
            // 
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatZonaBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZonaID,
            this.colDescripcion});
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
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(22, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(499, 170);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatZonaBindingSource, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit2.Location = new System.Drawing.Point(29, 110);
            this.textEdit2.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.NDecimales = 2;
            this.textEdit2.Size = new System.Drawing.Size(429, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatZonaBindingSource, "ZonaID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit1.Location = new System.Drawing.Point(29, 64);
            this.textEdit1.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.NDecimales = 2;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descripcion";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ZonaID";
            // 
            // spCatZonaBindingSource
            // 
            this.spCatZonaBindingSource.DataMember = "spCatZona";
            this.spCatZonaBindingSource.DataSource = this.spCatZonaDS1;
            this.spCatZonaBindingSource.Sort = "";
            // 
            // spCatZonaDS1
            // 
            this.spCatZonaDS1.DataSetName = "spCatZonaDS";
            this.spCatZonaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colZonaID
            // 
            this.colZonaID.FieldName = "ZonaID";
            this.colZonaID.Name = "colZonaID";
            this.colZonaID.Visible = true;
            this.colZonaID.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // frmCatalogoZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoZona";
            this.Text = "Catalogo Zona";
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatZonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatZonaDS1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.CTextEdit textEdit2;
        private UserControls.CTextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource spCatZonaBindingSource;
        private DataSets.spCatZonaDS spCatZonaDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colZonaID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
    }
}
