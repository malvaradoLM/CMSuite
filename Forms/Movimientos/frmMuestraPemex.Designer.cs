namespace RedCoForm.Forms.Movimientos
{
    partial class frmMuestraPemex
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMuestraID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoMuestra = new DevExpress.XtraEditors.TextEdit();
            this.txtPesoCarga = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lueTerminal = new DevExpress.XtraEditors.LookUpEdit();
            this.lueProductoID = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAzufre = new DevExpress.XtraEditors.TextEdit();
            this.txtOctanos = new DevExpress.XtraEditors.TextEdit();
            this.txtAdimensional = new DevExpress.XtraEditors.TextEdit();
            this.spCatTerminalDS = new RedCoForm.DataSets.spCatTerminalDS();
            this.button1 = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuestraID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoMuestra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoCarga.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTerminal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductoID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAzufre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOctanos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdimensional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.SelectedTabPage = this.tpDatos;
            this.tbControl.Size = new System.Drawing.Size(762, 524);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.simpleButton1);
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Controls.Add(this.button1);
            this.tpDatos.Size = new System.Drawing.Size(760, 499);
            // 
            // vpValidador
            // 
            this.vpValidador.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtObservacion);
            this.groupControl1.Controls.Add(this.txtAdimensional);
            this.groupControl1.Controls.Add(this.txtOctanos);
            this.groupControl1.Controls.Add(this.txtAzufre);
            this.groupControl1.Controls.Add(this.lueProductoID);
            this.groupControl1.Controls.Add(this.lueTerminal);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtPesoCarga);
            this.groupControl1.Controls.Add(this.txtNoMuestra);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMuestraID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(42, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 469);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Muestra Pemex";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // txtMuestraID
            // 
            this.txtMuestraID.Location = new System.Drawing.Point(24, 57);
            this.txtMuestraID.Name = "txtMuestraID";
            this.txtMuestraID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMuestraID.Properties.ReadOnly = true;
            this.txtMuestraID.Size = new System.Drawing.Size(67, 20);
            this.txtMuestraID.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "No debe Quedar Vacio";
            this.vpValidador.SetValidationRule(this.txtMuestraID, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "No. de Muestra";
            // 
            // txtNoMuestra
            // 
            this.txtNoMuestra.Location = new System.Drawing.Point(24, 106);
            this.txtNoMuestra.Name = "txtNoMuestra";
            this.txtNoMuestra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoMuestra.Size = new System.Drawing.Size(138, 20);
            this.txtNoMuestra.TabIndex = 3;
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(198, 106);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesoCarga.Size = new System.Drawing.Size(134, 20);
            this.txtPesoCarga.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(198, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Peso de Carga";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 235);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Azufre";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(194, 235);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Octanos";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 280);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Adimensional";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 145);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Terminal";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 190);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Producto";
            // 
            // lueTerminal
            // 
            this.lueTerminal.Location = new System.Drawing.Point(24, 164);
            this.lueTerminal.Name = "lueTerminal";
            this.lueTerminal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTerminal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueTerminal.Properties.NullText = "[Seleccione Terminal...]";
            this.lueTerminal.Size = new System.Drawing.Size(308, 20);
            this.lueTerminal.TabIndex = 11;
            // 
            // lueProductoID
            // 
            this.lueProductoID.Location = new System.Drawing.Point(24, 209);
            this.lueProductoID.Name = "lueProductoID";
            this.lueProductoID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductoID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueProductoID.Properties.NullText = "[Seleccione Producto...]";
            this.lueProductoID.Size = new System.Drawing.Size(308, 20);
            this.lueProductoID.TabIndex = 12;
            // 
            // txtAzufre
            // 
            this.txtAzufre.Location = new System.Drawing.Point(24, 254);
            this.txtAzufre.Name = "txtAzufre";
            this.txtAzufre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAzufre.Size = new System.Drawing.Size(138, 20);
            this.txtAzufre.TabIndex = 13;
            // 
            // txtOctanos
            // 
            this.txtOctanos.Location = new System.Drawing.Point(194, 254);
            this.txtOctanos.Name = "txtOctanos";
            this.txtOctanos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOctanos.Size = new System.Drawing.Size(138, 20);
            this.txtOctanos.TabIndex = 14;
            // 
            // txtAdimensional
            // 
            this.txtAdimensional.Location = new System.Drawing.Point(24, 299);
            this.txtAdimensional.Name = "txtAdimensional";
            this.txtAdimensional.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdimensional.Size = new System.Drawing.Size(138, 20);
            this.txtAdimensional.TabIndex = 15;
            // 
            // spCatTerminalDS
            // 
            this.spCatTerminalDS.DataSetName = "spCatTerminalDS";
            this.spCatTerminalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(24, 344);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(325, 98);
            this.txtObservacion.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 325);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Observacion";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(530, 178);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(131, 81);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmMuestraPemex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(762, 524);
            this.Name = "frmMuestraPemex";
            this.Text = "Muestra Pemex";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuestraID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoMuestra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoCarga.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTerminal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductoID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAzufre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOctanos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdimensional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtAdimensional;
        private DevExpress.XtraEditors.TextEdit txtOctanos;
        private DevExpress.XtraEditors.TextEdit txtAzufre;
        private DevExpress.XtraEditors.LookUpEdit lueProductoID;
        private DevExpress.XtraEditors.LookUpEdit lueTerminal;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPesoCarga;
        private DevExpress.XtraEditors.TextEdit txtNoMuestra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMuestraID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DataSets.spCatTerminalDS spCatTerminalDS;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
