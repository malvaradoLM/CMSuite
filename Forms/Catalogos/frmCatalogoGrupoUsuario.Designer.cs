namespace RedCoForm.Forms.Catalogos
{
    partial class frmCatalogoGrupoUsuario
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoGrupoUsuario));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new UserControls.CTextEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tpPermisos = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treePermisos = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imagecollection = new System.Windows.Forms.ImageList(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.tpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpPermisos});
            this.tcCatalogo.Controls.SetChildIndex(this.tpPermisos, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpDatos, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpBuscar, 0);
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
            // gvCatalogo
            // 
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
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(27, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(461, 180);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(33, 104);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(321, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 21);
            this.textBox1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Grupo Usuario";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id";
            // 
            // tpPermisos
            // 
            this.tpPermisos.Controls.Add(this.groupControl2);
            this.tpPermisos.Name = "tpPermisos";
            this.tpPermisos.Size = new System.Drawing.Size(678, 282);
            this.tpPermisos.Text = "Permisos";
            this.tpPermisos.Paint += new System.Windows.Forms.PaintEventHandler(this.tpPermisos_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.treePermisos);
            this.groupControl2.Location = new System.Drawing.Point(11, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(494, 255);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Permisos";
            // 
            // treePermisos
            // 
            this.treePermisos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePermisos.CheckBoxes = true;
            this.treePermisos.ImageIndex = 0;
            this.treePermisos.ImageList = this.imageList;
            this.treePermisos.Location = new System.Drawing.Point(19, 24);
            this.treePermisos.Name = "treePermisos";
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Node1";
            this.treePermisos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treePermisos.SelectedImageIndex = 0;
            this.treePermisos.Size = new System.Drawing.Size(470, 226);
            this.treePermisos.TabIndex = 1;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "agreement.ico");
            this.imageList.Images.SetKeyName(1, "bank.ico");
            this.imageList.Images.SetKeyName(2, "bank-banknotes.ico");
            this.imageList.Images.SetKeyName(3, "calculator-business-money-coins.ico");
            this.imageList.Images.SetKeyName(4, "cash-register-banknote.ico");
            this.imageList.Images.SetKeyName(5, "drive-customer.ico");
            // 
            // imagecollection
            // 
            this.imagecollection.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagecollection.ImageStream")));
            this.imagecollection.TransparentColor = System.Drawing.Color.Transparent;
            this.imagecollection.Images.SetKeyName(0, "graph-sales-bullish-pin.png");
            this.imagecollection.Images.SetKeyName(1, "cash-register-banknote.png");
            this.imagecollection.Images.SetKeyName(2, "embedding-cassette-padlock.png");
            this.imagecollection.Images.SetKeyName(3, "enum.png");
            this.imagecollection.Images.SetKeyName(4, "gift.png");
            // 
            // frmCatalogoGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoGrupoUsuario";
            this.Text = "Grupo Usuario";
            this.Load += new System.EventHandler(this.frmCatalogoGrupoUsuario_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.tpPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage tpPermisos;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.CTextEdit textEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TreeView treePermisos;
        private System.Windows.Forms.ImageList imagecollection;
        private System.Windows.Forms.ImageList imageList;
    }
}
