using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoGrupoUsuario : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoGrupoUsuario()
        {
            InitializeComponent();
            TreeNode mainNode = new TreeNode();
            TreeNode Nodo = new TreeNode();
            mainNode.Name = "mainNode";
            mainNode.Text = "Main";

          


            //trlPermisos.Nodes.Add()
            // Limpia los nodos existentes
            treeView1.Nodes.Clear();

            Nodo.Name = "Hijo";
            Nodo.Text = "Hijo";
            this.treeView1.Nodes.Add(mainNode);

            treeView1.Nodes.Add(Nodo);
            //mainNode.Nodes[0].ImageIndex = 1;
            mainNode = treeView1.Nodes.Add("Principal");
            // treeView1.ImageIndex = 0;
            //mainNode.ImageIndex=1;
            mainNode.Nodes[1].ImageIndex = 2;
            mainNode.Nodes.Add("Hijo 1");
            mainNode.Nodes[2].ImageIndex = 3;
            //mainNode.ImageIndex = 2;
            mainNode.Nodes.Add("Hijo 2");
            mainNode.Nodes.Add("Hijo 3");
            mainNode.Nodes.Add("Hijo 4");
            mainNode = treeView1.Nodes.Add("Catalogos");
            mainNode.Nodes.Add("Hijo 5");
            mainNode.Expand();


         


        }

        private void frmCatalogoGrupoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
