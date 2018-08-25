namespace RedCoForm.Forms.Movimientos
{
    partial class frmMovimientoProductoIEPS
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
            this.dgcProductoIEPS = new DevExpress.XtraGrid.GridControl();
            this.bgvProductoIEPS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.spProductoIEPSDS1 = new RedCoForm.DataSets.spProductoIEPSDS();
            this.spProductoIEPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gbEstacion = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gb87 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gb91 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gbDiesel = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gbMisc = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcProductoIEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvProductoIEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Size = new System.Drawing.Size(712, 476);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.dateEdit1);
            this.tpDatos.Controls.Add(this.label1);
            this.tpDatos.Controls.Add(this.dgcProductoIEPS);
            this.tpDatos.Size = new System.Drawing.Size(710, 451);
            // 
            // dgcProductoIEPS
            // 
            this.dgcProductoIEPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgcProductoIEPS.Location = new System.Drawing.Point(11, 62);
            this.dgcProductoIEPS.MainView = this.bgvProductoIEPS;
            this.dgcProductoIEPS.Name = "dgcProductoIEPS";
            this.dgcProductoIEPS.Size = new System.Drawing.Size(688, 386);
            this.dgcProductoIEPS.TabIndex = 0;
            this.dgcProductoIEPS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvProductoIEPS});
            this.dgcProductoIEPS.Click += new System.EventHandler(this.dgcProductoIEPS_Click);
            // 
            // bgvProductoIEPS
            // 
            this.bgvProductoIEPS.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gbEstacion,
            this.gb87,
            this.gb91,
            this.gbDiesel,
            this.gbMisc});
            this.bgvProductoIEPS.CustomizationFormBounds = new System.Drawing.Rectangle(562, 500, 204, 209);
            this.bgvProductoIEPS.GridControl = this.dgcProductoIEPS;
            this.bgvProductoIEPS.Name = "bgvProductoIEPS";
            // 
            // spProductoIEPSDS1
            // 
            this.spProductoIEPSDS1.DataSetName = "spProductoIEPSDS";
            this.spProductoIEPSDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spProductoIEPSBindingSource
            // 
            this.spProductoIEPSBindingSource.DataMember = "spProductoIEP";
            this.spProductoIEPSBindingSource.DataSource = this.spProductoIEPSDS1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplicar en Fecha:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(11, 24);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // gbEstacion
            // 
            this.gbEstacion.Name = "gbEstacion";
            this.gbEstacion.VisibleIndex = 0;
            // 
            // gb87
            // 
            this.gb87.Caption = "87 Octanos";
            this.gb87.Name = "gb87";
            this.gb87.VisibleIndex = 1;
            this.gb87.Width = 215;
            // 
            // gb91
            // 
            this.gb91.Caption = "91 Octanos";
            this.gb91.Name = "gb91";
            this.gb91.VisibleIndex = 2;
            this.gb91.Width = 234;
            // 
            // gbDiesel
            // 
            this.gbDiesel.Caption = "Diesel";
            this.gbDiesel.Name = "gbDiesel";
            this.gbDiesel.VisibleIndex = 3;
            this.gbDiesel.Width = 242;
            // 
            // gbMisc
            // 
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.VisibleIndex = 4;
            // 
            // frmMovimientoProductoIEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 476);
            this.Name = "frmMovimientoProductoIEPS";
            this.Text = "Producto IEPS";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcProductoIEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvProductoIEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcProductoIEPS;
        private DataSets.spProductoIEPSDS spProductoIEPSDS1;
        private System.Windows.Forms.BindingSource spProductoIEPSBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvProductoIEPS;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbEstacion;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gb87;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gb91;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbDiesel;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbMisc;
    }
}
