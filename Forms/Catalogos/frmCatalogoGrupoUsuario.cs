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
            int i = 0;
            TreeNode tNode;
            tNode = treePermisos.Nodes.Add("Persisos Comercializadora");

            RPSuiteServer.TPermiso[] arrayPermiso = RedCoForm.Data.DataModule.DataService.SelectPermisos();


            int Padre = -1;
            int Hijo = -1;

            for (i = 0; i <= arrayPermiso.Length-1; i++)
            {
               // MessageBox.Show(arrayPermiso[i].PermisoID + " " + arrayPermiso[i].Descripcion, "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (arrayPermiso[i].PermisoID== arrayPermiso[i].PadreID)
                {
                    // es Padre
                    Padre++;
                    treePermisos.Nodes[0].Nodes.Add(arrayPermiso[i].Descripcion);
                    treePermisos.Nodes[0].Nodes[Padre].ImageIndex = arrayPermiso[i].ImagenIndex;
                    treePermisos.Nodes[0].Nodes[Padre].SelectedImageIndex = arrayPermiso[i].ImagenIndex;
                    treePermisos.Nodes[0].Nodes[Padre].Tag = arrayPermiso[i].PermisoID;

                    Hijo = -1;
                  
                }
                else
                {
                    // es Hijo
                    Hijo++;
                    treePermisos.Nodes[0].Nodes[Padre].Nodes.Add(arrayPermiso[i].Descripcion);
                    treePermisos.Nodes[0].Nodes[Padre].Nodes[Hijo].ImageIndex = arrayPermiso[i].ImagenIndex;
                    treePermisos.Nodes[0].Nodes[Padre].Nodes[Hijo].SelectedImageIndex = arrayPermiso[i].ImagenIndex;
                    treePermisos.Nodes[0].Nodes[Padre].Nodes[Hijo].Tag = arrayPermiso[i].PermisoID;
                }

            }

            treePermisos.ExpandAll();
            //            treePermisos.Nodes[0].Nodes[0].Nodes.Add("CLR");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
         

        }


        // Recorremos el Árbol

      
    }
}
