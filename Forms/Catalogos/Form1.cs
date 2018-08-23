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

namespace RedCoForm
{
    public partial class Form1 : Form
    {
        List<clsVehiculo> lstVehiculo = new List<clsVehiculo>();
        clsVehiculo clsVehiculo = new clsVehiculo();
        List<clsEstacion> lstEstacion = new List<clsEstacion>();
        clsEstacion clsEstacion = new clsEstacion();
        List<clsTerminal> lstTerminal = new List<clsTerminal>();
        clsTerminal clsTerminal = new clsTerminal();
        List<clsProducto> lstProducto = new List<clsProducto>();
        clsProducto clsProducto = new clsProducto();
        int PedidoID;

        public System.Data.DataSet cdsDatos { get; set; }
        public string NombreDataSetDatos { get; set; }
        private System.Windows.Forms.BindingSource DataSource { get; set; }
        private List<DataParameter> Params = new List<DataParameter>();
        public Form1()
        {
            InitializeComponent();
            getEstaciones();
            getUsuarios();
            getProductos();
            getTerminales();
            getVehiculos();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //RPSuiteServer.TPedido Pedido = RedCoForm.Data.DataModule.DataService.BuscarPedido(txtBuscar.Text);
            //if (Pedido.PedidoID != -1)
            //    FillControls(Pedido);
            LlenarBusquedaPedido(txtBuscar.Text);
        }

        private void LlenarBusquedaPedido(string Datos)
        {
            try
            {
                //cdsDatos = spPedidoDS1;
                DataSource = spPedidoBindingSource;
                NombreDataSetDatos = "spPedido";
                cdsDatos.Clear();

                //Lenamos el DS de Categorias

                Params.Clear();

                DataModule.ParamByName(Params, "Datos", Datos);
                DataModule.FillDataSet(cdsDatos, NombreDataSetDatos, Params.ToArray());
                gvPedido.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillControls(RPSuiteServer.TPedido Pedido)
        {
            dateFecha.DateTime = Pedido.Fecha;
            lueUsuario.EditValue = Pedido.UsuarioID;
            lueEstacion.EditValue = Pedido.EstacionID;
            txtSerie.Text = Pedido.Serie;
            txtFolio.Text = Pedido.Folio.ToString();
            //chkStatus.Checked = Pedido.Status;
            memObservacion.Text = Pedido.Observacion;
            txtTotal.Text = Pedido.Total.ToString();
            txtSubtotal.Text = Pedido.Subtotal.ToString();
            txtIVA.Text = Pedido.IVA.ToString();
            txtIEPS.Text = Pedido.IEPS.ToString();
            txtDescuento.Text = Pedido.Descuento.ToString();
            LlenarDetallePedido(Pedido.PedidoID);
        }

        private void FillGridBusqueda(string Datos)
        {

        }

        private void LlenarDetallePedido(int PedidoID)
        {
            try
            {
                cdsDatos = detallePedidoDS1;
                DataSource = spDetallePedidoBindingSource;
                NombreDataSetDatos = "spDetallePedido";
                cdsDatos.Clear();

                //Lenamos el DS de Categorias

                Params.Clear();

                DataModule.ParamByName(Params, "PedidoID", PedidoID);
                DataModule.FillDataSet(cdsDatos, NombreDataSetDatos, Params.ToArray());
                gvDetallePedido.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<RPSuiteServer.TDetallePedido> FillListDetallePedido(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<RPSuiteServer.TDetallePedido> DetallePedido = new List<RPSuiteServer.TDetallePedido>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                DetallePedido.Add
                    (new RPSuiteServer.TDetallePedido()
                    {
                        DetallePedidoID = dr.Field<int>("DetallePedidoID"),
                        PedidoID = PedidoID,
                        VehiculoID = dr.Field<int>("VehiculoID"),
                        ProductoID = dr.Field<int>("ProductoID"),
                        TerminalID = dr.Field<int>("TerminalID"),
                        Volumen = dr.Field<int>("Volumen")
                    }
                    );

            }
            return DetallePedido;
        }

        private void UpdateDetallePedido()
        {
            try
            {
                List<RPSuiteServer.TDetallePedido> lstDetallePedido = FillListDetallePedido(detallePedidoDS1.Tables["spDetallePedido"]);
                RPSuiteServer.TDetallePedido[] TADetallePedido = lstDetallePedido.ToArray();
                bool Pedido = RedCoForm.Data.DataModule.DataService.UpdateDetallePedido(TADetallePedido);
                if (!Pedido)
                    throw new Exception();
                //foreach (RPSuiteServer.TDetallePedido clsDetallePedido in lstDetallePedido)
                //{
                //    bool Pedido = RedCoForm.Data.DataModule.DataService.UpdateDetallePedido(clsDetallePedido);
                //    if (!Pedido)
                //        throw new Exception();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Estacion
        public void getEstaciones()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();



            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatEstacion", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatEstacion"];
            lstEstacion = clsEstacion.FillList(dt);
            bs.DataSource = lstEstacion;

            this.lueEstacion.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueEstacion.Properties.DisplayMember = "Nombre";
            this.lueEstacion.Properties.ValueMember = "EstacionID";

            this.lueEstacion.Properties.DropDownRows = lstEstacion.Count;

        }
        #endregion

        #region Usuario
        public void getUsuarios()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsUsuario> Usuario = new List<clsUsuario>();
            clsUsuario c = new clsUsuario();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatUsuarioDS, "spCatUsuario", Params.ToArray());

            dt = spCatUsuarioDS.Tables["spCatUsuario"];
            Usuario = c.FillList(dt);
            bs.DataSource = Usuario;

            this.lueUsuario.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueUsuario.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueUsuario.Properties.DisplayMember = "Nombre";
            this.lueUsuario.Properties.ValueMember = "UsuarioID";

            this.lueUsuario.Properties.DropDownRows = Usuario.Count;

        }
        #endregion

        #region Producto
        public void getProductos()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();



            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatProductoDS, "spCatProducto", Params.ToArray());

            dt = spCatProductoDS.Tables["spCatProducto"];
            lstProducto = clsProducto.FillList(dt);
            bs.DataSource = lstProducto;
            lueProducto.DataSource = bs.List;
            lueProducto.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueProducto.DisplayMember = "Descripcion";
            lueProducto.ValueMember = "ProductoID";
            lueProducto.DropDownRows = lstProducto.Count;

        }
        #endregion

        #region Terminal
        public void getTerminales()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();



            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatTerminalDS, "spCatTerminal", Params.ToArray());

            dt = spCatTerminalDS.Tables["spCatTerminal"];
            lstTerminal = clsTerminal.FillList(dt);
            bs.DataSource = lstTerminal;        
            lueTerminal.DataSource = bs.List;
            lueTerminal.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueTerminal.DisplayMember = "Descripcion";
            lueTerminal.ValueMember = "TerminalID";
            lueTerminal.DropDownRows = lstTerminal.Count;
        }
        #endregion

        #region Vehiculo
        public void getVehiculos()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatVehiculoDS, "spCatVehiculo", Params.ToArray());

            dt = spCatVehiculoDS.Tables["spCatVehiculo"];
            lstVehiculo = clsVehiculo.FillList(dt);
            bs.DataSource = lstVehiculo;
            lueVehiculo.DataSource = bs.List;
            lueVehiculo.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoEconomico"));
            lueVehiculo.Columns["NoEconomico"].Caption = "Numero Economico";
            lueVehiculo.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Marca"));
            lueVehiculo.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modelo"));
            lueVehiculo.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoToneles"));
            lueVehiculo.Columns["NoToneles"].Caption = "Numero Toneles";
            lueVehiculo.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Capacidad"));
            lueVehiculo.DisplayMember = "NoEconomico";
            lueVehiculo.ValueMember = "VehiculoID";
            lueVehiculo.DropDownRows = lstVehiculo.Count;
        }
        #endregion

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvDetallePedido_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if(gvDetallePedido.IsLastRow)
            //{
            //    gvDetallePedido.AddNewRow();
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDetallePedido();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvPedido_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            PedidoID= Int32.Parse( gvPedido.GetRowCellValue(gvPedido.FocusedRowHandle, "PedidoID").ToString());
            LlenarDetallePedido(PedidoID);
        }
    }
}
