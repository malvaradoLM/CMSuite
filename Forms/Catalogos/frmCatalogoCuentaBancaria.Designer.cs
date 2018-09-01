namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatalogoCuentaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoCuentaBancaria));
            this.spCatCuentaBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatCuentaBancariaDS1 = new RedCoForm.DataSets.spCatCuentaBancariaDS();
            this.colCuentaBancariaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDlls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new UserControls.CTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkdll = new DevExpress.XtraEditors.CheckEdit();
            this.lueBanco = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCuentaBancaria = new UserControls.CTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spCatBancoDS = new RedCoForm.DataSets.spCatBancoDS();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkdll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaBancaria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatBancoDS)).BeginInit();
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
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatCuentaBancariaBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCuentaBancariaID,
            this.colCuenta,
            this.colCuentaContable,
            this.colDlls,
            this.colBancoID,
            this.colEstacionID});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spCatCuentaBancariaBindingSource
            // 
            this.spCatCuentaBancariaBindingSource.DataMember = "spCatCuentaBancaria";
            this.spCatCuentaBancariaBindingSource.DataSource = this.spCatCuentaBancariaDS1;
            this.spCatCuentaBancariaBindingSource.Sort = "";
            // 
            // spCatCuentaBancariaDS1
            // 
            this.spCatCuentaBancariaDS1.DataSetName = "spCatCuentaBancariaDS";
            this.spCatCuentaBancariaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCuentaBancariaID
            // 
            this.colCuentaBancariaID.FieldName = "CuentaBancariaID";
            this.colCuentaBancariaID.Name = "colCuentaBancariaID";
            this.colCuentaBancariaID.Visible = true;
            this.colCuentaBancariaID.VisibleIndex = 0;
            // 
            // colCuenta
            // 
            this.colCuenta.FieldName = "Cuenta";
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.Visible = true;
            this.colCuenta.VisibleIndex = 1;
            // 
            // colCuentaContable
            // 
            this.colCuentaContable.FieldName = "CuentaContable";
            this.colCuentaContable.Name = "colCuentaContable";
            this.colCuentaContable.Visible = true;
            this.colCuentaContable.VisibleIndex = 2;
            // 
            // colDlls
            // 
            this.colDlls.FieldName = "Dlls";
            this.colDlls.Name = "colDlls";
            this.colDlls.Visible = true;
            this.colDlls.VisibleIndex = 3;
            // 
            // colBancoID
            // 
            this.colBancoID.FieldName = "BancoID";
            this.colBancoID.Name = "colBancoID";
            this.colBancoID.Visible = true;
            this.colBancoID.VisibleIndex = 4;
            // 
            // colEstacionID
            // 
            this.colEstacionID.FieldName = "EstacionID";
            this.colEstacionID.Name = "colEstacionID";
            this.colEstacionID.Visible = true;
            this.colEstacionID.VisibleIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "CuentaBancariaID", true));
            this.txtID.Location = new System.Drawing.Point(26, 52);
            this.txtID.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtID.Name = "txtID";
            this.txtID.NDecimales = 2;
            this.txtID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkdll);
            this.groupControl1.Controls.Add(this.lueBanco);
            this.groupControl1.Controls.Add(this.txtCuentaBancaria);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(41, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(534, 230);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Datos";
            // 
            // chkdll
            // 
            this.chkdll.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "Dlls", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkdll.Location = new System.Drawing.Point(26, 181);
            this.chkdll.Name = "chkdll";
            this.chkdll.Properties.Caption = "Dlls";
            this.chkdll.Size = new System.Drawing.Size(75, 19);
            this.chkdll.TabIndex = 6;
            // 
            // lueBanco
            // 
            this.lueBanco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "BancoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueBanco.Location = new System.Drawing.Point(26, 142);
            this.lueBanco.Name = "lueBanco";
            this.lueBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBanco.Properties.NullText = "[Selecciona un Banco...]";
            this.lueBanco.Size = new System.Drawing.Size(272, 20);
            this.lueBanco.TabIndex = 5;
            // 
            // txtCuentaBancaria
            // 
            this.txtCuentaBancaria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "NoCuenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCuentaBancaria.Location = new System.Drawing.Point(26, 97);
            this.txtCuentaBancaria.MaskType = UserControls.GlobalVar.CMask.None;
            this.txtCuentaBancaria.Name = "txtCuentaBancaria";
            this.txtCuentaBancaria.NDecimales = 2;
            this.txtCuentaBancaria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaBancaria.Size = new System.Drawing.Size(272, 20);
            this.txtCuentaBancaria.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Banco";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cuenta Bancaria";
            // 
            // spCatBancoDS
            // 
            this.spCatBancoDS.DataSetName = "spCatBancoDS";
            this.spCatBancoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCatalogoCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalogoCuentaBancaria";
            this.Text = "Catalogo Cuenta Bancaria";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkdll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaBancaria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatBancoDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatCuentaBancariaBindingSource;
        private DataSets.spCatCuentaBancariaDS spCatCuentaBancariaDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaBancariaID;
        private DevExpress.XtraGrid.Columns.GridColumn colCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContable;
        private DevExpress.XtraGrid.Columns.GridColumn colDlls;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoID;
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkdll;
        private DevExpress.XtraEditors.LookUpEdit lueBanco;
        private UserControls.CTextEdit txtCuentaBancaria;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private UserControls.CTextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DataSets.spCatBancoDS spCatBancoDS;
    }
}
