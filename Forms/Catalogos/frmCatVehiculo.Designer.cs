namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatVehiculo
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
            this.spCatVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatVehiculoDS1 = new RedCoForm.DataSets.spCatVehiculoDS();
            this.colVehiculoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoEconomico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoToneles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCapacidad = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtNoEconomico = new DevExpress.XtraEditors.TextEdit();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.txtNoToneles = new DevExpress.XtraEditors.TextEdit();
            this.txtNoSerie = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEconomico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoToneles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSerie.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
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
            this.tpDatos.Controls.Add(this.labelControl1);
            this.tpDatos.Controls.Add(this.labelControl2);
            this.tpDatos.Controls.Add(this.labelControl3);
            this.tpDatos.Controls.Add(this.labelControl4);
            this.tpDatos.Controls.Add(this.labelControl5);
            this.tpDatos.Controls.Add(this.labelControl6);
            this.tpDatos.Controls.Add(this.txtCapacidad);
            this.tpDatos.Controls.Add(this.txtMarca);
            this.tpDatos.Controls.Add(this.txtNoEconomico);
            this.tpDatos.Controls.Add(this.txtModelo);
            this.tpDatos.Controls.Add(this.txtNoToneles);
            this.tpDatos.Controls.Add(this.txtNoSerie);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatVehiculoBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVehiculoID,
            this.colNoEconomico,
            this.colNoSerie,
            this.colMarca,
            this.colModelo,
            this.colNoToneles,
            this.colCapacidad});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spCatVehiculoBindingSource
            // 
            this.spCatVehiculoBindingSource.DataMember = "spCatVehiculo";
            this.spCatVehiculoBindingSource.DataSource = this.spCatVehiculoDS1;
            this.spCatVehiculoBindingSource.Sort = "";
            // 
            // spCatVehiculoDS1
            // 
            this.spCatVehiculoDS1.DataSetName = "spCatVehiculoDS";
            this.spCatVehiculoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colVehiculoID
            // 
            this.colVehiculoID.FieldName = "VehiculoID";
            this.colVehiculoID.Name = "colVehiculoID";
            this.colVehiculoID.Visible = true;
            this.colVehiculoID.VisibleIndex = 0;
            // 
            // colNoEconomico
            // 
            this.colNoEconomico.FieldName = "NoEconomico";
            this.colNoEconomico.Name = "colNoEconomico";
            this.colNoEconomico.Visible = true;
            this.colNoEconomico.VisibleIndex = 1;
            // 
            // colNoSerie
            // 
            this.colNoSerie.FieldName = "NoSerie";
            this.colNoSerie.Name = "colNoSerie";
            this.colNoSerie.Visible = true;
            this.colNoSerie.VisibleIndex = 2;
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 3;
            // 
            // colModelo
            // 
            this.colModelo.FieldName = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 4;
            // 
            // colNoToneles
            // 
            this.colNoToneles.FieldName = "NoToneles";
            this.colNoToneles.Name = "colNoToneles";
            this.colNoToneles.Visible = true;
            this.colNoToneles.VisibleIndex = 5;
            // 
            // colCapacidad
            // 
            this.colCapacidad.FieldName = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.Visible = true;
            this.colCapacidad.VisibleIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Numero Economico";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Numero de Serie";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Marca";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(312, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Modelo";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(312, 102);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Capacidad";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(312, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Numero de Toneles";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "Capacidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCapacidad.Location = new System.Drawing.Point(419, 99);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "Marca", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMarca.Location = new System.Drawing.Point(134, 99);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // txtNoEconomico
            // 
            this.txtNoEconomico.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "NoEconomico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoEconomico.Location = new System.Drawing.Point(134, 26);
            this.txtNoEconomico.Name = "txtNoEconomico";
            this.txtNoEconomico.Size = new System.Drawing.Size(100, 20);
            this.txtNoEconomico.TabIndex = 10;
            this.txtNoEconomico.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "Modelo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtModelo.Location = new System.Drawing.Point(419, 26);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtNoToneles
            // 
            this.txtNoToneles.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "NoToneles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoToneles.Location = new System.Drawing.Point(419, 63);
            this.txtNoToneles.Name = "txtNoToneles";
            this.txtNoToneles.Size = new System.Drawing.Size(100, 20);
            this.txtNoToneles.TabIndex = 12;
            // 
            // txtNoSerie
            // 
            this.txtNoSerie.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "NoSerie", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoSerie.Location = new System.Drawing.Point(134, 63);
            this.txtNoSerie.Name = "txtNoSerie";
            this.txtNoSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNoSerie.TabIndex = 13;
            // 
            // frmCatVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            this.tpBuscar.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEconomico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoToneles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSerie.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatVehiculoBindingSource;
        private DataSets.spCatVehiculoDS spCatVehiculoDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colVehiculoID;
        private DevExpress.XtraGrid.Columns.GridColumn colNoEconomico;
        private DevExpress.XtraGrid.Columns.GridColumn colNoSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colNoToneles;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacidad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCapacidad;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtNoEconomico;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.TextEdit txtNoToneles;
        private DevExpress.XtraEditors.TextEdit txtNoSerie;
    }
}
