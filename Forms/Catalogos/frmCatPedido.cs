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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using RPSuiteServer;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatPedido : RedCoForm.Base.frmCatalogo
    {
        List<clsVehiculo> lstVehiculo = new List<clsVehiculo>();
        clsVehiculo clsVehiculo = new clsVehiculo();
        List<clsEstacion> lstEstacion = new List<clsEstacion>();
        clsEstacion clsEstacion = new clsEstacion();
        List<clsTerminal> lstTerminal = new List<clsTerminal>();
        clsTerminal clsTerminal = new clsTerminal();
        List<clsProducto> lstProducto = new List<clsProducto>();
        clsProducto clsProducto = new clsProducto();
        List<clsStatus> lstStatus = new List<clsStatus>();
        clsStatus clsStatus = new clsStatus();

        private List<DataParameter> Params = new List<DataParameter>();
        public frmCatPedido()
        {
            InitializeComponent();
            cdsCatalogo = spPedidoDS1;
            DataSource = spCatPedidoBindingSource;
            NombreDataSet = "spPedido";
            Buscar("~`|`~");
            getUsuarios();
            getEstaciones();
            getStatusPedido();
            
            getProductos();
            getTerminales();
            getVehiculos();
            lueProducto.EditValueChanged += LueProducto_EditValueChanged;
            gvDetallePedido.CustomDrawFooterCell += gvDetallePedido_CustomDrawFooterCell;
            gvDetallePedido.Columns["Total"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Total: {0}");
            gvDetallePedido.Columns["Subtotal"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "Subtotal: {0}");
            gvDetallePedido.Columns["IVA"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "IVA", "IVA: {0}");
            gvDetallePedido.Columns["IEPS"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "IEPS", "IEPS: {0}");

        }

        private void gvDetallePedido_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            switch(summary.FieldName)
            {
                case "Subtotal":
                    txtSubtotal.Text = summary.SummaryValue.ToString();
                    break;
                case "Total":
                    txtTotal.Text = summary.SummaryValue.ToString();
                    break;
                case "IVA":
                    txtIVA.Text = summary.SummaryValue.ToString();
                    break;
                case "IEPS":
                    txtIEPS.Text = summary.SummaryValue.ToString();
                    break;
            }
        }

        private void LueProducto_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit lue = sender as DevExpress.XtraEditors.LookUpEdit;
            CalcularTotales(Convert.ToInt32(lue.EditValue));
            gvDetallePedido.UpdateTotalSummary();
         
        }

        private void CalcularTotales(int ProductoID)
        {
            clsProducto Producto = lstProducto.Find(obj => obj.ProductoID == ProductoID);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "Precio", Producto.Precio);
            double Volumen =Convert.ToDouble( gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Volumen"));
            double Total = Producto.Precio * Volumen;
            double IVA = Total * 0.16;
            double IEPS = Total * 0.40;
            double Subtotal = Total - IVA - IEPS;
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "Subtotal", Subtotal);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA", IVA);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "IEPS", IEPS);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "Total", Total);
        }

        #region Estacion
        public void getEstaciones()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "1738");
            Data.DataModule.FillDataSet(spPedidoDS1, "spCatEstacion", Params.ToArray());

            dt = spPedidoDS1.Tables["spCatEstacion"];
            lstEstacion = clsEstacion.FillList(dt);
            bs.DataSource = lstEstacion;

            this.lueEstacion.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueEstacion.Properties.DisplayMember = "Nombre";
            this.lueEstacion.Properties.ValueMember = "EstacionID";

            this.lueEstacion.Properties.DropDownRows = lstEstacion.Count;


            lueColEstacion.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            lueColEstacion.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            lueColEstacion.DisplayMember = "Nombre";
            lueColEstacion.ValueMember = "EstacionID";

            lueColEstacion.DropDownRows = lstEstacion.Count;

        }
        #endregion

        #region StatusPedido
        public void getStatusPedido()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spPedidoDS1, "spStatus", Params.ToArray());

            dt = spPedidoDS1.Tables["spStatus"];
            lstStatus = clsStatus.FillList(dt);
            bs.DataSource = lstStatus;

            this.lueStatusPedido.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueStatusPedido.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueStatusPedido.Properties.DisplayMember = "Nombre";
            this.lueStatusPedido.Properties.ValueMember = "StatusID";

            this.lueStatusPedido.Properties.DropDownRows = lstStatus.Count;

            lueColStatus.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            lueColStatus.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            lueColStatus.DisplayMember = "Nombre";
            lueColStatus.ValueMember = "StatusID";

            lueColStatus.DropDownRows = lstStatus.Count;

        }
        #endregion

        #region Usuario
        public void getUsuarios()
        {

            //Variables 

            DataTable dt = new DataTable();

            List<clsUsuario> Usuario = new List<clsUsuario>();
            clsUsuario c = new clsUsuario();

            BindingSource bs = new BindingSource();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spPedidoDS1, "spCatUsuario", Params.ToArray());

            dt = spPedidoDS1.Tables["spCatUsuario"];
            Usuario = c.FillList(dt);
            bs.DataSource = Usuario;

            this.lueUsuario.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueUsuario.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueUsuario.Properties.DisplayMember = "Nombre";
            this.lueUsuario.Properties.ValueMember = "UsuarioID";

            this.lueUsuario.Properties.DropDownRows = Usuario.Count;

            lueColUsuario.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            lueColUsuario.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            lueColUsuario.DisplayMember = "Nombre";
            lueColUsuario.ValueMember = "UsuarioID";

            lueColUsuario.DropDownRows = Usuario.Count;

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
            Data.DataModule.FillDataSet(detallePedidoDS1, "spCatProducto", Params.ToArray());

            dt = detallePedidoDS1.Tables["spCatProducto"];
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
            Data.DataModule.FillDataSet(detallePedidoDS1, "spCatTerminal", Params.ToArray());

            dt = detallePedidoDS1.Tables["spCatTerminal"];
            lstTerminal = clsTerminal.FillList(dt);
            bs.DataSource = lstTerminal;
            lueCatTerminal.Properties.DataSource = bs.List;
            lueCatTerminal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueCatTerminal.Properties.DisplayMember = "Descripcion";
            lueCatTerminal.Properties.ValueMember = "TerminalID";
            lueCatTerminal.Properties.DropDownRows = lstTerminal.Count;
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
            Data.DataModule.FillDataSet(detallePedidoDS1, "spCatVehiculo", Params.ToArray());

            dt = detallePedidoDS1.Tables["spCatVehiculo"];
            lstVehiculo = clsVehiculo.FillList(dt);
            bs.DataSource = lstVehiculo;
            lueCatVehiculo.Properties.DataSource = bs.List;
            lueCatVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoEconomico"));
            lueCatVehiculo.Properties.Columns["NoEconomico"].Caption = "Numero Economico";
            lueCatVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Marca"));
            lueCatVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modelo"));
            lueCatVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoToneles"));
            lueCatVehiculo.Properties.Columns["NoToneles"].Caption = "Numero Toneles";
            lueCatVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Capacidad"));
            lueCatVehiculo.Properties.DisplayMember = "NoEconomico";
            lueCatVehiculo.Properties.ValueMember = "VehiculoID";
            lueCatVehiculo.Properties.DropDownRows = lstVehiculo.Count;
        }
        #endregion

        private void LlenarDetallePedido(int PedidoID)
        {
            try
            {
                DataSet cdsDatos = detallePedidoDS1;
                BindingSource cbsDataSource = spDetallePedidoBindingSource;
                string cDataSetDatos = "spDetallePedido";
                cdsDatos.Clear();

                //Lenamos el DS de Categorias

                Params.Clear();

                DataModule.ParamByName(Params, "PedidoID", PedidoID);
                DataModule.FillDataSet(cdsDatos, cDataSetDatos, Params.ToArray());
                gvDetallePedido.BestFitColumns(false);
                if (gvDetallePedido.DataRowCount > 0)
                {
                    IEnumerable<DataRow> query = from dts in detallePedidoDS1.Tables["spDetallePedido"].AsEnumerable() select dts;
                    foreach (DataRow dr in query)
                    {
                        CalcularTotales(dr.Field<int>("ProductoID"));
                    }
                    gvDetallePedido.UpdateTotalSummary();

                }
                ButtonGenerarRecibo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvCatalogo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int PedidoID = Int32.Parse(gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "PedidoID").ToString());
                LlenarDetallePedido(PedidoID);
            }
            catch(Exception ex)
            {

            }
        }

        private void ButtonGenerarRecibo()
        {

            if(int.Parse(gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "StatusID").ToString()) == 5)//En proceso de entrega
            {
                if (lblFactura.Text != string.Empty)
                    btnGenerarRecibo.Visible = false;
                else
                    btnGenerarRecibo.Visible = true;
            }
            else
                btnGenerarRecibo.Visible = false;

        }

        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            try
            {
                onBeforePost();
                DataSource.EndEdit();
                if (Data.DataModule.ApplyUpdates(cdsCatalogo))
                {
                    UpdateDetallePedido();
                    State = stEstado.Browse;
                    newRecordRow = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDetallePedido()
        {
            try
            {
                List<RPSuiteServer.TDetallePedido> lstDetallePedido = FillListDetallePedido(detallePedidoDS1.Tables["spDetallePedido"]);
                foreach (RPSuiteServer.TDetallePedido clsDetallePedido in lstDetallePedido)
                {
                    bool Pedido = RedCoForm.Data.DataModule.DataService.UpdateDetallePedido(clsDetallePedido);
                    if (!Pedido)
                        throw new Exception();
                }
                ButtonGenerarRecibo();

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
                        PedidoID = dr.Field<int>("PedidoID"),
                        VehiculoID = dr.Field<int>("VehiculoID"),
                        ProductoID = dr.Field<int>("ProductoID"),
                        TerminalID = dr.Field<int>("TerminalID"),
                        Volumen = dr.Field<int>("Volumen")
                    }
                    );

            }
            return DetallePedido;
        }

        private void dgcCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void gcBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lueStatusPedido_EditValueChanged(object sender, EventArgs e)
        {
            //switch (lueStatusPedido.Text)
            //{
            //    case "Proceso de Entrega":
            //        {
            //            if (lblFactura.Text != string.Empty)
            //                btnGenerarRecibo.Visible = true;
            //            else
            //                btnGenerarRecibo.Visible = false;
            //            break;
            //        }
            //    default:
            //        {
            //            btnGenerarRecibo.Visible = false;
            //            break;
            //        }
            //}
            
        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                TPedido pedido = new TPedido();
                TDetallePedido detallepedido = new TDetallePedido();

                pedido.PedidoID = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "PedidoID");

                //MOVIMIENTO
                pedido.Fecha = (DateTime)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Fecha");
                pedido.FechaModificacion = (DateTime)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "FechaModificacion");
                pedido.Ejercisio = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Ejercicio");
                pedido.Periodo = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Periodo");
                pedido.Total = (double)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Total");
                pedido.UsuarioID = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "UsuarioID");
                pedido.EstacionID = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "EstacionID");

                //FACTURA
                pedido.Serie = txtSerie.Text;
                pedido.Folio =int.Parse( txtFolio.Text);
                pedido.Dia = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Dia");
                pedido.IVA= (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA");
                //pedido.Status = (bool)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Status");
                pedido.Observacion = memObservacion.Text;

                //DETALLEPEDIDO
                detallepedido.Volumen = (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Volumen");
                detallepedido.Precio = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Precio");
                detallepedido.Subtotal = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Subtotal");
                detallepedido.IVA = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA");
                detallepedido.IEPS = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IEPS");
                detallepedido.Total = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Total");
                detallepedido.Descuento= double.Parse(txtcDescuento.Text);
                detallepedido.NoItems = (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "NoItems");
                detallepedido.ProductoID = (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "ProductoID");

                //mOVIMIENTOID


                int MovimientoID = RedCoForm.Data.DataModule.DataService.GenerarFactura(pedido, detallepedido);
                if (MovimientoID <= 0)
                {
                    throw new Exception("Error al generar el recibo");
                }
                else
                {
                    //   int detalleFactura;

                    //   detalleFactura= RedCoForm.Data.DataModule.DataService.InsertarDetalleFactura((int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Volumen"),
                    //       (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Precio"),
                    //       (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Subtotal"),
                    //       (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA"),
                    //       (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IEPS"),
                    //       (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Total"),
                    //       double.Parse(txtDescuento.Text),
                    //       (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "NoItems"),
                    //       MovimientoID, (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "ProductoID"));

                    //   //Actualiza saldo del cliente por un cargo
                    //double saldo = RedCoForm.Data.DataModule.DataService.UpdateSaldoCargoPedido( (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Total"), (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "EstacionID"));

                    //Actualiza facturaid del pedidoid
                    //lblFactura.Text= DataModule.DataService.UpdatePedidoFactura((int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "PedidoID"), MovimientoID).ToString();

                    lblFactura.Text = MovimientoID.ToString();
                    MessageBox.Show("Recibo generado correctamente");
                    ButtonGenerarRecibo();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgcDetallePedido_Click(object sender, EventArgs e)
        {

        }
    }
}
