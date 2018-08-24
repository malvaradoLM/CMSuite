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
            this.gvProductoIEPS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spProductoIEPSDS1 = new RedCoForm.DataSets.spProductoIEPSDS();
            this.spProductoIEPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcProductoIEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductoIEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.dgcProductoIEPS);
            // 
            // dgcProductoIEPS
            // 
            this.dgcProductoIEPS.Location = new System.Drawing.Point(11, 20);
            this.dgcProductoIEPS.MainView = this.gvProductoIEPS;
            this.dgcProductoIEPS.Name = "dgcProductoIEPS";
            this.dgcProductoIEPS.Size = new System.Drawing.Size(669, 412);
            this.dgcProductoIEPS.TabIndex = 0;
            this.dgcProductoIEPS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductoIEPS});
            // 
            // gvProductoIEPS
            // 
            this.gvProductoIEPS.GridControl = this.dgcProductoIEPS;
            this.gvProductoIEPS.Name = "gvProductoIEPS";
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
            // frmMovimientoProductoIEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 581);
            this.Name = "frmMovimientoProductoIEPS";
            this.Text = "Producto IEPS";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcProductoIEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductoIEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductoIEPSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcProductoIEPS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductoIEPS;
        private DataSets.spProductoIEPSDS spProductoIEPSDS1;
        private System.Windows.Forms.BindingSource spProductoIEPSBindingSource;
    }
}
