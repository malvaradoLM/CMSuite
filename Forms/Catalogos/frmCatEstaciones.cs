using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RedCoForm.Data;
using RedCoForm.Class;
using RedCoForm.Base;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatEstaciones : RedCoForm.Base.frmCatalogo
    {
        private List<DataParameter> Params = new List<DataParameter>();

        public frmCatEstaciones()
        {
            InitializeComponent();
            cdsCatalogo = spCatEstacionDS1;
            DataSource = spCatEstacionBindingSource;
            NombreDataSet = "spCatEstacion";
            Buscar("~`|`~");



            getZona();
            getGrupo();
            getFormaPago();
            getMetodoPago();
            CargarTerminal();
            getVendedor();
            getFormaCompra();
            getFacturaUso();

            //Cargar Los Estados
            GlobalVar.CargarEstados();
            lueEstado.Properties.DataSource = GlobalVar.Estados;
            lueEntregaEstado.Properties.DataSource = GlobalVar.Estados;

            //Cargar Los Estados

            //lueEntregaEstado.Properties.DataSource = GlobalVar.Estados;
            //lueEntregaEstado.Properties.DataSource = GlobalVar.Estados;


            //Cargar DiasRemision
         
            GlobalVar.CargarDiasSemana();
            lueDiaRevision.Properties.DataSource = GlobalVar.DiasSemana;
            lueDiaPago.Properties.DataSource = GlobalVar.DiasSemana;

        }

        #region Grupo
        public void getGrupo()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<clsGrupo> lstGrupo = new List<clsGrupo>();
            clsGrupo objGrupo = new clsGrupo();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS1, "spCatGrupo", Params.ToArray());

            dt = spCatEstacionDS1.Tables["spCatGrupo"];
            lstGrupo = objGrupo.FillList(dt);
            bs.DataSource = lstGrupo;

            this.lueGrupo.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueGrupo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueGrupo.Properties.DisplayMember = "Descripcion";
            this.lueGrupo.Properties.ValueMember = "GrupoID";

            this.lueGrupo.Properties.DropDownRows = lstGrupo.Count;

        }
        #endregion

        #region FormaPago
        public void getFormaPago()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            // Data.DataModule.FillDataSet(spCatFormaPagoDS1, "spCatFormaPago", null);
            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatFormaPagoDS1, "spCatFormaPago", Params.ToArray());

            dt = spCatFormaPagoDS1.Tables["spCatFormaPago"];
            lst = obj.FillListCombo(dt, "FormaPagoID", "Descripcion");
            bs.DataSource = lst;

            this.lueFormaPago.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueFormaPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueFormaPago.Properties.DisplayMember = "Nombre";
            this.lueFormaPago.Properties.ValueMember = "ID";

            this.lueFormaPago.Properties.DropDownRows = lst.Count;

        }
        #endregion


        #region MetodoPago
        public void getMetodoPago()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatMetodoPagoDS1, "spCatMetodoPago", Params.ToArray());

            dt = spCatMetodoPagoDS1.Tables["spCatMetodoPago"];
            lst = obj.FillListCombo(dt, "MetodoPagoID", "Descripcion");
            bs.DataSource = lst;

            this.lueMetodoPago.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueMetodoPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueMetodoPago.Properties.DisplayMember = "Nombre";
            this.lueMetodoPago.Properties.ValueMember = "ID";

            this.lueMetodoPago.Properties.DropDownRows = lst.Count;

        }
        #endregion

        #region Zona
        public void getZona()
        {

            //Variables 

            DataTable dt = new DataTable();

            List<clsZona> lstZona = new List<clsZona>();
            clsZona c = new clsZona();

            BindingSource bs = new BindingSource();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS1, "spCatZona", Params.ToArray());

            dt = spCatEstacionDS1.Tables["spCatZona"];
            lstZona = c.FillList(dt);
            bs.DataSource = lstZona;

            this.lueZona.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueZona.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueZona.Properties.DisplayMember = "Descripcion";
            this.lueZona.Properties.ValueMember = "ZonaID";

            this.lueZona.Properties.DropDownRows = lstZona.Count;

        }
        #endregion


        #region Terminal
        private void CargarTerminal()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsTerminal> Terminal = new List<clsTerminal>();
            clsTerminal c = new clsTerminal();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatTerminalDS, "spCatTerminal", Params.ToArray());

            dt = spCatTerminalDS.Tables["spCatTerminal"];
            Terminal = c.FillList(dt);
            bs.DataSource = Terminal;

            this.lueTerminalPrimaria.Properties.DataSource = bs.List;
            this.lueTerminalPrimaria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerminalID", "ID"));
            this.lueTerminalPrimaria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre"));
            this.lueTerminalPrimaria.Properties.DisplayMember = "Descripcion";
            this.lueTerminalPrimaria.Properties.ValueMember = "TerminalID";

            this.lueTerminalPrimaria.Properties.DropDownRows = Terminal.Count;

            //Terminal Secundaria
            this.lueTerminalSecundaria.Properties.DataSource = bs.List;
            this.lueTerminalSecundaria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerminalID", "ID"));
            this.lueTerminalSecundaria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre"));
            this.lueTerminalSecundaria.Properties.DisplayMember = "Descripcion";
            this.lueTerminalSecundaria.Properties.ValueMember = "TerminalID";

            this.lueTerminalSecundaria.Properties.DropDownRows = Terminal.Count;

        }
        #endregion


        #region Vendedor
        public void getVendedor()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatVendedorDS, "spCatVendedor", Params.ToArray());

            dt = spCatVendedorDS.Tables["spCatVendedor"];
            lst = obj.FillListCombo(dt, "VendedorID", "Nombre");
            bs.DataSource = lst;

            this.lueVendedor.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueVendedor.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueVendedor.Properties.DisplayMember = "Nombre";
            this.lueVendedor.Properties.ValueMember = "ID";

            this.lueVendedor.Properties.DropDownRows = lst.Count;
        }

        #endregion


        #region Forma de Compra
        private void getFormaCompra()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatFormaCompraDS, "spCatFormaCompra", Params.ToArray());

            dt = spCatFormaCompraDS.Tables["spCatFormaCompra"];
            lst = obj.FillListCombo(dt, "FormaCompraID", "Descripcion");
            bs.DataSource = lst;

            this.lueFormaCompra.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueFormaCompra.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueFormaCompra.Properties.DisplayMember = "Nombre";
            this.lueFormaCompra.Properties.ValueMember = "ID";

            this.lueFormaCompra.Properties.DropDownRows = lst.Count;

        }

        #endregion


        #region FacturaUso
        private void getFacturaUso()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatFacturaUsoDS, "spCatFacturaUso", Params.ToArray());

            dt = spCatFacturaUsoDS.Tables["spCatFacturaUso"];
            lst = obj.FillListCombo(dt, "FacturaUsoID", "Descripcion");
            bs.DataSource = lst;

            this.lueFacturaUso.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueFacturaUso.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueFacturaUso.Properties.DisplayMember = "Nombre";
            this.lueFacturaUso.Properties.ValueMember = "ID";

            this.lueFacturaUso.Properties.DropDownRows = lst.Count;


        }


        #endregion


        public override void DoNuevo(object key, object sender, EventArgs e)
        {

            txtEstacionID.Enabled = true;
            base.DoNuevo(key, sender, e);
        }
        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            try
            {
                //onBeforePost();
                DataSource.EndEdit();
                if (Data.DataModule.ApplyUpdates(cdsCatalogo))
                {
                    RPSuiteServer.TSaldo Saldo = new RPSuiteServer.TSaldo();
                    Saldo.EstacionID = Int32.Parse(txtEstacionID.Text);
                    Saldo.LimiteCredito = float.Parse(txtLimiteCredito.Text);
                    if (Data.DataModule.DataService.GuardarSaldo(Saldo))
                    {
                        State = stEstado.Browse;
                        newRecordRow = null;
                    }

                }
                txtEstacionID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["EstacionID"] = Data.DataModule.DataService.Folio("EstacionID", "");

            }
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void tpDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void tcCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
