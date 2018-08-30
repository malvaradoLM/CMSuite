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
            //TreeNode mainNode = new TreeNode();
            //TreeNode Nodo = new TreeNode();
            //mainNode.Name = "mainNode";
            //mainNode.Text = "Main";




            //trlPermisos.Nodes.Add()
            // Limpia los nodos existentes


            //Nodo.Name = "Hijo";
            //Nodo.Text = "Hijo";
            //this.treeView1.Nodes.Add(mainNode);

            //treeView1.Nodes.Add(Nodo);

            //mainNode = treeView1.Nodes.Add("Principal");

            //mainNode.Nodes.Add("Hijo 1");

            //mainNode.Nodes.Add("Hijo 2");
            //mainNode.Nodes[2].SelectedImageIndex = 3;
            //mainNode.Nodes.Add("Hijo 3");
            //mainNode.Nodes.Add("Hijo 4");
            //mainNode = treeView1.Nodes.Add("Catalogos");
            //mainNode.Nodes.Add("Hijo 5");
            //mainNode.Expand();

            CargarPermisos();





        }

        private void frmCatalogoGrupoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void tpPermisos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarPermisos()
        {
            treePermisos.Nodes.Clear();

            TreeNode tNode;
            tNode = treePermisos.Nodes.Add("Persisos Comercializadora");
        }
    }
}
