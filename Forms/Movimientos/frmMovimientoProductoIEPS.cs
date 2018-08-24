using RedCoForm.Data;
using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RedCoForm.Class;

namespace RedCoForm.Forms.Movimientos
{
    public partial class frmMovimientoProductoIEPS : RedCoForm.Base.frmEstructura
    {
        private List<DataParameter> Params = new List<DataParameter>();

        public frmMovimientoProductoIEPS()
        {
            InitializeComponent();
            Cargar();

        }

        public void Cargar()
        {
            try
            {
                RPSuiteServer.TCustomProductoIEPS[] arrayProductoIEPS = RedCoForm.Data.DataModule.DataService.CargarProductoIEPS();
                dgcProductoIEPS.DataSource = arrayProductoIEPS;
                gvProductoIEPS.Columns["TerminalID"].Visible = false;
                gvProductoIEPS.Columns["Descripcion"].Caption = "Estacion";
                gvProductoIEPS.Columns["PIEPSID87"].Visible = false;
                gvProductoIEPS.Columns["Precio87"].Caption = "87 Octanos";
                gvProductoIEPS.Columns["PIEPSID91"].Visible = false;
                gvProductoIEPS.Columns["Precio91"].Caption = "91 Octanos";
                gvProductoIEPS.Columns["PIEPSIDDiesel"].Visible = false;
                gvProductoIEPS.Columns["PrecioDiesel"].Caption = "Diesel";
                gvProductoIEPS.Columns["UsuarioID"].Visible = false;             
                gvProductoIEPS.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void DoBuscar(object key, object sender, EventArgs e)
        {

        }
    }
}
