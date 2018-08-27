namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatEstaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatEstaciones));
            this.colEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZonaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetodoPagoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spCatEstacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatEstacionDS1 = new RedCoForm.DataSets.spCatEstacionDS();
            this.spCatFormaPagoDS1 = new RedCoForm.DataSets.spCatFormaPagoDS();
            this.spCatMetodoPagoDS1 = new RedCoForm.DataSets.spCatMetodoPagoDS();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lueGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.lueFormaPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lueMetodoPago = new DevExpress.XtraEditors.LookUpEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtEstacionID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lueZona = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tpDireccion = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatFormaPagoDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatMetodoPagoDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueZona.Properties)).BeginInit();
            this.tpDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Size = new System.Drawing.Size(753, 421);
            this.tcCatalogo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpDireccion});
            this.tcCatalogo.Controls.SetChildIndex(this.tpDireccion, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpDatos, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpBuscar, 0);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(751, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(751, 396);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatEstacionBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(751, 296);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstacionID,
            this.colNombre,
            this.colRazonSocial,
            this.colRFC,
            this.colCalle,
            this.colNoExterior,
            this.colNoInterior,
            this.colCiudad,
            this.colMunicipio,
            this.colEstado,
            this.colStatus,
            this.colTelefono,
            this.colContacto,
            this.colEmail,
            this.colGrupoID,
            this.colZonaID,
            this.colFormaPagoID,
            this.colMetodoPagoID});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // colEstacionID
            // 
            this.colEstacionID.FieldName = "EstacionID";
            this.colEstacionID.Name = "colEstacionID";
            this.colEstacionID.Visible = true;
            this.colEstacionID.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            // 
            // colCalle
            // 
            this.colCalle.FieldName = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 4;
            // 
            // colNoExterior
            // 
            this.colNoExterior.FieldName = "NoExterior";
            this.colNoExterior.Name = "colNoExterior";
            this.colNoExterior.Visible = true;
            this.colNoExterior.VisibleIndex = 5;
            // 
            // colNoInterior
            // 
            this.colNoInterior.FieldName = "NoInterior";
            this.colNoInterior.Name = "colNoInterior";
            this.colNoInterior.Visible = true;
            this.colNoInterior.VisibleIndex = 6;
            // 
            // colCiudad
            // 
            this.colCiudad.FieldName = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.Visible = true;
            this.colCiudad.VisibleIndex = 7;
            // 
            // colMunicipio
            // 
            this.colMunicipio.FieldName = "Municipio";
            this.colMunicipio.Name = "colMunicipio";
            this.colMunicipio.Visible = true;
            this.colMunicipio.VisibleIndex = 8;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 10;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 11;
            // 
            // colContacto
            // 
            this.colContacto.FieldName = "Contacto";
            this.colContacto.Name = "colContacto";
            this.colContacto.Visible = true;
            this.colContacto.VisibleIndex = 12;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 13;
            // 
            // colGrupoID
            // 
            this.colGrupoID.FieldName = "GrupoID";
            this.colGrupoID.Name = "colGrupoID";
            this.colGrupoID.Visible = true;
            this.colGrupoID.VisibleIndex = 14;
            // 
            // colZonaID
            // 
            this.colZonaID.FieldName = "ZonaID";
            this.colZonaID.Name = "colZonaID";
            this.colZonaID.Visible = true;
            this.colZonaID.VisibleIndex = 15;
            // 
            // colFormaPagoID
            // 
            this.colFormaPagoID.FieldName = "FormaPagoID";
            this.colFormaPagoID.Name = "colFormaPagoID";
            this.colFormaPagoID.Visible = true;
            this.colFormaPagoID.VisibleIndex = 16;
            // 
            // colMetodoPagoID
            // 
            this.colMetodoPagoID.FieldName = "MetodoPagoID";
            this.colMetodoPagoID.Name = "colMetodoPagoID";
            this.colMetodoPagoID.Visible = true;
            this.colMetodoPagoID.VisibleIndex = 17;
            // 
            // spCatEstacionBindingSource
            // 
            this.spCatEstacionBindingSource.DataMember = "spCatEstacion";
            this.spCatEstacionBindingSource.DataSource = this.spCatEstacionDS1;
            this.spCatEstacionBindingSource.Sort = "";
            // 
            // spCatEstacionDS1
            // 
            this.spCatEstacionDS1.DataSetName = "spCatEstacionDS";
            this.spCatEstacionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatFormaPagoDS1
            // 
            this.spCatFormaPagoDS1.DataSetName = "spCatFormaPagoDS";
            this.spCatFormaPagoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatMetodoPagoDS1
            // 
            this.spCatMetodoPagoDS1.DataSetName = "spCatMetodoPagoDS";
            this.spCatMetodoPagoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textBox6);
            this.groupControl1.Controls.Add(this.textBox13);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.label25);
            this.groupControl1.Controls.Add(this.txtEstacionID);
            this.groupControl1.Controls.Add(this.label23);
            this.groupControl1.Controls.Add(this.label17);
            this.groupControl1.Controls.Add(this.label16);
            this.groupControl1.Controls.Add(this.textBox12);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.checkBox1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.lueZona);
            this.groupControl1.Controls.Add(this.txtRazonSocial);
            this.groupControl1.Controls.Add(this.txtRFC);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Location = new System.Drawing.Point(11, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1078, 390);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Contacto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox6.Location = new System.Drawing.Point(202, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(122, 21);
            this.textBox6.TabIndex = 79;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Deposito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox13.Location = new System.Drawing.Point(20, 184);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(148, 21);
            this.textBox13.TabIndex = 89;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label14);
            this.groupControl3.Controls.Add(this.dateTimePicker1);
            this.groupControl3.Controls.Add(this.label18);
            this.groupControl3.Controls.Add(this.dateTimePicker2);
            this.groupControl3.Controls.Add(this.label19);
            this.groupControl3.Controls.Add(this.dateTimePicker3);
            this.groupControl3.Location = new System.Drawing.Point(491, 227);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(229, 158);
            this.groupControl3.TabIndex = 104;
            this.groupControl3.Text = "Fechas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Fecha de Baja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spCatEstacionBindingSource, "FechaBaja", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 91;
            this.label18.Text = "Cambio de Credito";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spCatEstacionBindingSource, "CambioCredito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker2.Location = new System.Drawing.Point(17, 86);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker2.TabIndex = 92;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 93;
            this.label19.Text = "Ultimo Pago";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spCatEstacionBindingSource, "UltimoPago", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker3.Location = new System.Drawing.Point(17, 130);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker3.TabIndex = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lueGrupo);
            this.groupControl2.Controls.Add(this.lueFormaPago);
            this.groupControl2.Controls.Add(this.lueMetodoPago);
            this.groupControl2.Controls.Add(this.label20);
            this.groupControl2.Controls.Add(this.label22);
            this.groupControl2.Controls.Add(this.label21);
            this.groupControl2.Controls.Add(this.txtLimiteCredito);
            this.groupControl2.Controls.Add(this.label15);
            this.groupControl2.Controls.Add(this.textBox10);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Location = new System.Drawing.Point(491, 18);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(229, 203);
            this.groupControl2.TabIndex = 103;
            this.groupControl2.Text = "Pagos";
            // 
            // lueGrupo
            // 
            this.lueGrupo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatEstacionBindingSource, "GrupoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueGrupo.Location = new System.Drawing.Point(16, 37);
            this.lueGrupo.Name = "lueGrupo";
            this.lueGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupo.Size = new System.Drawing.Size(191, 20);
            this.lueGrupo.TabIndex = 62;
            // 
            // lueFormaPago
            // 
            this.lueFormaPago.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatEstacionBindingSource, "FormaPagoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueFormaPago.Location = new System.Drawing.Point(16, 79);
            this.lueFormaPago.Name = "lueFormaPago";
            this.lueFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFormaPago.Size = new System.Drawing.Size(191, 20);
            this.lueFormaPago.TabIndex = 63;
            // 
            // lueMetodoPago
            // 
            this.lueMetodoPago.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatEstacionBindingSource, "MetodoPagoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueMetodoPago.Location = new System.Drawing.Point(16, 122);
            this.lueMetodoPago.Name = "lueMetodoPago";
            this.lueMetodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMetodoPago.Size = new System.Drawing.Size(191, 20);
            this.lueMetodoPago.TabIndex = 64;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 95;
            this.label20.Text = "Grupo";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 97;
            this.label22.Text = "Metodo de Pago";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 96;
            this.label21.Text = "Forma de Pago";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "LimiteCredito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLimiteCredito.Location = new System.Drawing.Point(16, 166);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(84, 21);
            this.txtLimiteCredito.TabIndex = 85;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 86;
            this.label15.Text = "Limite de Credito";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "PlazoPago", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox10.Location = new System.Drawing.Point(119, 166);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(88, 21);
            this.textBox10.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Plazo de Pago";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 13);
            this.label25.TabIndex = 102;
            this.label25.Text = "ID";
            // 
            // txtEstacionID
            // 
            this.txtEstacionID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "EstacionID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEstacionID.Enabled = false;
            this.txtEstacionID.Location = new System.Drawing.Point(20, 55);
            this.txtEstacionID.Name = "txtEstacionID";
            this.txtEstacionID.Size = new System.Drawing.Size(60, 21);
            this.txtEstacionID.TabIndex = 101;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(341, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 98;
            this.label23.Text = "Zona";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "Deposito";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 88;
            this.label16.Text = "NIP";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "NIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox12.Location = new System.Drawing.Point(202, 140);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(122, 21);
            this.textBox12.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Contacto";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.spCatEstacionBindingSource, "Status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(344, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 77;
            this.checkBox1.Text = "Status";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Razón Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Estación";
            // 
            // lueZona
            // 
            this.lueZona.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatEstacionBindingSource, "ZonaID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueZona.Location = new System.Drawing.Point(344, 140);
            this.lueZona.Name = "lueZona";
            this.lueZona.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueZona.Size = new System.Drawing.Size(141, 20);
            this.lueZona.TabIndex = 65;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "RazonSocial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRazonSocial.Location = new System.Drawing.Point(20, 97);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(465, 21);
            this.txtRazonSocial.TabIndex = 57;
            // 
            // txtRFC
            // 
            this.txtRFC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "RFC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRFC.Location = new System.Drawing.Point(20, 140);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(160, 21);
            this.txtRFC.TabIndex = 53;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombre.Location = new System.Drawing.Point(105, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 21);
            this.txtNombre.TabIndex = 52;
            // 
            // tpDireccion
            // 
            this.tpDireccion.Controls.Add(this.groupControl4);
            this.tpDireccion.Name = "tpDireccion";
            this.tpDireccion.Size = new System.Drawing.Size(678, 282);
            this.tpDireccion.Text = "Direccion";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.groupControl5);
            this.groupControl4.Controls.Add(this.lookUpEdit1);
            this.groupControl4.Controls.Add(this.label7);
            this.groupControl4.Controls.Add(this.textBox1);
            this.groupControl4.Controls.Add(this.textBox4);
            this.groupControl4.Controls.Add(this.label9);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Controls.Add(this.textBox14);
            this.groupControl4.Controls.Add(this.label5);
            this.groupControl4.Controls.Add(this.textBox3);
            this.groupControl4.Controls.Add(this.label24);
            this.groupControl4.Controls.Add(this.label8);
            this.groupControl4.Controls.Add(this.textBox7);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Controls.Add(this.textBox8);
            this.groupControl4.Location = new System.Drawing.Point(11, 11);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(574, 241);
            this.groupControl4.TabIndex = 119;
            this.groupControl4.Text = "Datos";
            this.groupControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl4_Paint);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.label10);
            this.groupControl5.Controls.Add(this.textBox5);
            this.groupControl5.Controls.Add(this.label12);
            this.groupControl5.Controls.Add(this.textBox9);
            this.groupControl5.Location = new System.Drawing.Point(362, 63);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(200, 140);
            this.groupControl5.TabIndex = 120;
            this.groupControl5.Text = "Contacto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 114;
            this.label10.Text = "Telefono";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(19, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 21);
            this.textBox5.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "E-Mail";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox9.Location = new System.Drawing.Point(19, 50);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(148, 21);
            this.textBox9.TabIndex = 106;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(17, 192);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(156, 20);
            this.lookUpEdit1.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "Ciudad";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "NoExterior", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(130, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 21);
            this.textBox1.TabIndex = 118;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Ciudad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox4.Location = new System.Drawing.Point(17, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 21);
            this.textBox4.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 113;
            this.label9.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "No. Interior";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "CP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox14.Location = new System.Drawing.Point(241, 94);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(106, 21);
            this.textBox14.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "No. Interior";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "NoInterior", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(17, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 21);
            this.textBox3.TabIndex = 101;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(238, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 116;
            this.label24.Text = "C.P.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Municipio";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Calle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox7.Location = new System.Drawing.Point(17, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(330, 21);
            this.textBox7.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Calle";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatEstacionBindingSource, "Municipio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox8.Location = new System.Drawing.Point(188, 143);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 21);
            this.textBox8.TabIndex = 105;
            // 
            // frmCatEstaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(753, 421);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatEstaciones";
            this.Text = "Estacion";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatFormaPagoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatMetodoPagoDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueZona.Properties)).EndInit();
            this.tpDireccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNoExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNoInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoID;
        private DevExpress.XtraGrid.Columns.GridColumn colZonaID;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagoID;
        private DevExpress.XtraGrid.Columns.GridColumn colMetodoPagoID;
        private DataSets.spCatFormaPagoDS spCatFormaPagoDS1;
        private DataSets.spCatMetodoPagoDS spCatMetodoPagoDS1;
        private System.Windows.Forms.BindingSource spCatEstacionBindingSource;
        private DataSets.spCatEstacionDS spCatEstacionDS1;
        private DevExpress.XtraTab.XtraTabPage tpDireccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox13;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lueGrupo;
        private DevExpress.XtraEditors.LookUpEdit lueFormaPago;
        private DevExpress.XtraEditors.LookUpEdit lueMetodoPago;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtEstacionID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lueZona;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtNombre;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}
