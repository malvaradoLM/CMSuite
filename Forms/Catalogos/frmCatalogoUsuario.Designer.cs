namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatalogoUsuario
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new UserControls.CTextEdit();
            this.textEdit1 = new UserControls.CTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spCatUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatUsuarioDS1 = new RedCoForm.DataSets.spCatUsuarioDS();
            this.colUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTextEdit1 = new UserControls.CTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cTextEdit2 = new UserControls.CTextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueEstacion = new DevExpress.XtraEditors.LookUpEdit();
            this.spCatEstacionDS1 = new RedCoForm.DataSets.spCatEstacionDS();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoUsuario));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit2 = new UserControls.CTextEdit();
            this.textEdit1 = new UserControls.CTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
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
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.Size = new System.Drawing.Size(680, 392);
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
            this.tpDatos.Size = new System.Drawing.Size(678, 367);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatUsuarioBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsuarioID,
            this.colNombre,
            this.colStatus,
            this.colUsuario,
            this.colClave,
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cTextEdit2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cTextEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lueEstacion);
            this.groupControl1.Location = new System.Drawing.Point(47, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(452, 291);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
<<<<<<< HEAD
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatUsuarioBindingSource, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit2.Location = new System.Drawing.Point(20, 98);
            this.textEdit2.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.NDecimales = 2;
            this.textEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit2.Size = new System.Drawing.Size(383, 20);
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatUsuarioBindingSource, "UsuarioID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(20, 53);
            this.textEdit1.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.NDecimales = 2;
            this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 4;
=======
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(20, 144);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(383, 20);
            this.lookUpEdit1.TabIndex = 6;
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
            // 
            // textEdit2
            // 
<<<<<<< HEAD
            this.labelControl2.Location = new System.Drawing.Point(20, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario ID";
            // 
            // spCatUsuarioBindingSource
            // 
            this.spCatUsuarioBindingSource.DataMember = "spCatUsuario";
            this.spCatUsuarioBindingSource.DataSource = this.spCatUsuarioDS1;
            this.spCatUsuarioBindingSource.Sort = "";
            // 
            // spCatUsuarioDS1
            // 
            this.spCatUsuarioDS1.DataSetName = "spCatUsuarioDS";
            this.spCatUsuarioDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colUsuarioID
            // 
            this.colUsuarioID.FieldName = "UsuarioID";
            this.colUsuarioID.Name = "colUsuarioID";
            this.colUsuarioID.Visible = true;
            this.colUsuarioID.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "UserName";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 3;
            // 
            // colClave
            // 
            this.colClave.Caption = "Contrasena";
            this.colClave.FieldName = "Password";
            this.colClave.Name = "colClave";
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 4;
            // 
            // colEstacionID
            // 
            this.colEstacionID.FieldName = "EstacionID";
            this.colEstacionID.Name = "colEstacionID";
            this.colEstacionID.Visible = true;
            this.colEstacionID.VisibleIndex = 5;
            // 
            // cTextEdit1
            // 
            this.cTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatUsuarioBindingSource, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cTextEdit1.Location = new System.Drawing.Point(20, 150);
            this.cTextEdit1.MaskType = UserControls.GlobalVar.CMask.None;
            this.cTextEdit1.Name = "cTextEdit1";
            this.cTextEdit1.NDecimales = 2;
            this.cTextEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextEdit1.Size = new System.Drawing.Size(383, 20);
            this.cTextEdit1.TabIndex = 7;
=======
            this.textEdit2.Location = new System.Drawing.Point(20, 98);
            this.textEdit2.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.NDecimales = 2;
            this.textEdit2.Size = new System.Drawing.Size(383, 20);
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(20, 53);
            this.textEdit1.MaskType = UserControls.GlobalVar.CMask.None;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.NDecimales = 2;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 4;
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nombre Usuario";
            // 
<<<<<<< HEAD
            // cTextEdit2
            // 
            this.cTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatUsuarioBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cTextEdit2.Location = new System.Drawing.Point(20, 201);
            this.cTextEdit2.MaskType = UserControls.GlobalVar.CMask.None;
            this.cTextEdit2.Name = "cTextEdit2";
            this.cTextEdit2.NDecimales = 2;
            this.cTextEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextEdit2.Size = new System.Drawing.Size(383, 20);
            this.cTextEdit2.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 182);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Contrasena";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 233);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Contrasena";
            // 
            // lueEstacion
            // 
            this.lueEstacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatUsuarioBindingSource, "EstacionID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueEstacion.Location = new System.Drawing.Point(20, 252);
            this.lueEstacion.Name = "lueEstacion";
            this.lueEstacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueEstacion.Properties.NullText = "";
            this.lueEstacion.Size = new System.Drawing.Size(383, 20);
            this.lueEstacion.TabIndex = 11;
            // 
            // spCatEstacionDS1
            // 
            this.spCatEstacionDS1.DataSetName = "spCatEstacionDS";
            this.spCatEstacionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatUsuarioBindingSource, "Status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkEdit1.Location = new System.Drawing.Point(176, 53);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Status";
            this.checkEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 12;
=======
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Usuario";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
            // 
            // frmCatalogoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(680, 392);
=======
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
            this.Name = "frmCatalogoUsuario";
            this.Text = "Catalogo Usuario";
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
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatUsuarioDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
>>>>>>> e96f8b797903f41ed8822607bb03109f402b3d40
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.CTextEdit textEdit2;
        private UserControls.CTextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource spCatUsuarioBindingSource;
        private DataSets.spCatUsuarioDS spCatUsuarioDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private UserControls.CTextEdit cTextEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private UserControls.CTextEdit cTextEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueEstacion;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DataSets.spCatEstacionDS spCatEstacionDS1;
    }
}
