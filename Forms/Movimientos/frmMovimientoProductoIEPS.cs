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
                bgvProductoIEPS.Columns["TerminalID"].Visible = false;
                bgvProductoIEPS.Columns["Descripcion"].Caption = "Terminal";
                bgvProductoIEPS.Columns["PIEPSID87"].Visible = false;
                bgvProductoIEPS.Columns["Precio87"].Caption = "Precio";
                bgvProductoIEPS.Columns["IEPS87"].Caption = "IEPS";
                bgvProductoIEPS.Columns["PIEPSID91"].Visible = false;
                bgvProductoIEPS.Columns["Precio91"].Caption = "Precio";
                bgvProductoIEPS.Columns["IEPS91"].Caption = "IEPS";
                bgvProductoIEPS.Columns["PIEPSIDDiesel"].Visible = false;
                bgvProductoIEPS.Columns["PrecioDiesel"].Caption = "Precio";
                bgvProductoIEPS.Columns["IEPSDiesel"].Caption = "IEPS";
                bgvProductoIEPS.Columns["Ejercicio"].Visible = false;
                bgvProductoIEPS.Columns["Periodo"].Visible = false;
                bgvProductoIEPS.Columns["Dia"].Visible = false;
                bgvProductoIEPS.Columns["Fecha"].Visible = false;
                bgvProductoIEPS.Columns["UsuarioID"].Visible = false;

                bgvProductoIEPS.Columns["Descripcion"].OwnerBand = gbEstacion;

                bgvProductoIEPS.Columns["Precio87"].OwnerBand = gb87;
                bgvProductoIEPS.Columns["IEPS87"].OwnerBand = gb87;

                bgvProductoIEPS.Columns["Precio91"].OwnerBand = gb91;
                bgvProductoIEPS.Columns["IEPS91"].OwnerBand = gb91;

                bgvProductoIEPS.Columns["PrecioDiesel"].OwnerBand = gbDiesel;
                bgvProductoIEPS.Columns["IEPSDiesel"].OwnerBand = gbDiesel;

                bgvProductoIEPS.Columns["IVA"].OwnerBand = gbMisc;

                bgvProductoIEPS.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridHeaders()
        {
                //GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);
                //TableHeaderCell cell = new TableHeaderCell();
                //cell.Text = "Customers";
                //cell.ColumnSpan = 2;
                //row.Controls.Add(cell);

                //cell = new TableHeaderCell();
                //cell.ColumnSpan = 2;
                //cell.Text = "Employees";
                //row.Controls.Add(cell);

                //row.BackColor = ColorTranslator.FromHtml("#3AC0F2");
                //GridView1.HeaderRow.Parent.Controls.AddAt(0, row);
        }

        public override void DoBuscar(object key, object sender, EventArgs e)
        {

        }

        private void dgcProductoIEPS_Click(object sender, EventArgs e)
        {

        }
    }
}
