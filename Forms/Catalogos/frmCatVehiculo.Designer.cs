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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatVehiculo));
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
            this.txtCapacidad = new UserControls.CTextEdit();
            this.txtMarca = new UserControls.CTextEdit();
            this.txtNoEconomico = new UserControls.CTextEdit();
            this.txtModelo = new UserControls.CTextEdit();
            this.txtNoToneles = new UserControls.CTextEdit();
            this.txtNoSerie = new UserControls.CTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtVehiculoID = new UserControls.CTextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit2 = new UserControls.CTextEdit();
            this.textEdit1 = new UserControls.CTextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehiculoID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.labelControl1.Location = new System.Drawing.Point(175, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Numero Economico";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(338, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Numero de Serie";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(175, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Marca";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(175, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Modelo";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(175, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Capacidad";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(338, 135);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Numero de Toneles";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "Capacidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCapacidad.Location = new System.Drawing.Point(175, 204);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(92, 20);
            this.txtCapacidad.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "Marca", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMarca.Location = new System.Drawing.Point(175, 150);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(127, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // txtNoEconomico
            // 
            this.txtNoEconomico.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "NoEconomico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoEconomico.Location = new System.Drawing.Point(175, 49);
            this.txtNoEconomico.Name = "txtNoEconomico";
            this.txtNoEconomico.Size = new System.Drawing.Size(127, 20);
            this.txtNoEconomico.TabIndex = 10;
            this.txtNoEconomico.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "Modelo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtModelo.Location = new System.Drawing.Point(175, 103);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(127, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtNoToneles
            // 
            this.txtNoToneles.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "NoToneles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoToneles.Location = new System.Drawing.Point(338, 150);
            this.txtNoToneles.Name = "txtNoToneles";
            this.txtNoToneles.Size = new System.Drawing.Size(92, 20);
            this.txtNoToneles.TabIndex = 12;
            // 
            // txtNoSerie
            // 
            this.txtNoSerie.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatVehiculoBindingSource, "NoSerie", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoSerie.Location = new System.Drawing.Point(338, 103);
            this.txtNoSerie.Name = "txtNoSerie";
            this.txtNoSerie.Size = new System.Drawing.Size(198, 20);
            this.txtNoSerie.TabIndex = 13;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.txtVehiculoID);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNoSerie);
            this.groupControl1.Controls.Add(this.txtNoToneles);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtModelo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNoEconomico);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtMarca);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCapacidad);
            this.groupControl1.Location = new System.Drawing.Point(11, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(633, 250);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Datos";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(338, 49);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(198, 20);
            this.lookUpEdit1.TabIndex = 24;
            // 
            // txtVehiculoID
            // 
            this.txtVehiculoID.Location = new System.Drawing.Point(20, 49);
            this.txtVehiculoID.Name = "txtVehiculoID";
            this.txtVehiculoID.Properties.ReadOnly = true;
            this.txtVehiculoID.Size = new System.Drawing.Size(127, 20);
            this.txtVehiculoID.TabIndex = 23;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(20, 30);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(11, 13);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "ID";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(20, 204);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(127, 20);
            this.dateEdit1.TabIndex = 21;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(20, 150);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(127, 20);
            this.textEdit2.TabIndex = 19;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(20, 103);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(127, 20);
            this.textEdit1.TabIndex = 18;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(338, 30);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 13);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Transportista";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(20, 185);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Fecha Certificado";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(20, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Certificado";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 84);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Placas";
            // 
            // frmCatVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatVehiculo";
            this.Text = "Vehiculo";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatVehiculoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEconomico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoToneles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehiculoID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
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
        private UserControls.CTextEdit txtCapacidad;
        private UserControls.CTextEdit txtMarca;
        private UserControls.CTextEdit txtNoEconomico;
        private UserControls.CTextEdit txtModelo;
        private UserControls.CTextEdit txtNoToneles;
        private UserControls.CTextEdit txtNoSerie;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private UserControls.CTextEdit txtVehiculoID;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private UserControls.CTextEdit textEdit2;
        private UserControls.CTextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
