using DevExpress.XtraGrid;
using RedCoForm.Class;
using RemObjects.DataAbstract.Server;
using RPSuiteServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    
    public partial class frmFacturacion : RedCoForm.Base.frmEstructura
    {
        //Variables
        TPedido pedido = new TPedido();
        TDetallePedido detallepedido = new TDetallePedido();


        //Listas 
        List<clsEstacion> lstEstacion = new List<clsEstacion>();
        List<clsVehiculo> lstVehiculo = new List<clsVehiculo>();
        List<clsTerminal> lstTerminal = new List<clsTerminal>();
        List<clsProducto> lstProducto = new List<clsProducto>();
        List<clsStatus> lstStatus = new List<clsStatus>();
        //Clases
        clsEstacion clsEstacion = new clsEstacion();
        clsVehiculo clsVehiculo = new clsVehiculo();
        clsTerminal clsTerminal = new clsTerminal();
        clsProducto clsProducto = new clsProducto();
        clsStatus clsStatus = new clsStatus();
     

        private List<DataParameter> Params = new List<DataParameter>();
        public frmFacturacion()
        {
            InitializeComponent();
            getUsuarios();
            getEstaciones();
            getStatusPedido();

            getProductos();
            getTerminales();
            getVehiculos();
            //creamos metodo editvaluechanged a los lue 
            lueUsuario.EditValueChanged += LueUsuario_EditValueChanged;
            lueProducto.EditValueChanged += LueProducto_EditValueChanged;
            lueEstacion.EditValueChanged += LueEstacion_EditValueChanged;

            txtDetalleVolumen.EditValueChanging += TxtDetalleVolumen_EditValueChanging;
            gvDetallePedido.CustomDrawFooterCell += GvDetallePedido_CustomDrawFooterCell;
            gvDetallePedido.Columns["Total"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Total: {0}");
            gvDetallePedido.Columns["Subtotal"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "Subtotal: {0}");
            gvDetallePedido.Columns["IVA"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "IVA", "IVA: {0}");
            gvDetallePedido.Columns["IEPS"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "IEPS", "IEPS: {0}");

        }

        private void LueEstacion_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
            pedido.EstacionID = int.Parse(editor.EditValue.ToString());
        }

        private void LueUsuario_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
            pedido.UsuarioID= int.Parse(editor.EditValue.ToString());
        }

        private void GvDetallePedido_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            switch (summary.FieldName)
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

        private void TxtDetalleVolumen_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            double Volumen;
            double.TryParse(((DevExpress.XtraEditors.TextEdit)sender).Text, out Volumen);
            CalcularTotales(Volumen);
            gvDetallePedido.UpdateTotalSummary();

            detallepedido.Volumen = Volumen;
        }

        private void LueProducto_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit lue = sender as DevExpress.XtraEditors.LookUpEdit;
            CalcularTotales(Convert.ToInt32(lue.EditValue));
            gvDetallePedido.UpdateTotalSummary();

            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
            detallepedido.ProductoID = int.Parse(editor.EditValue.ToString());
        }

        private void CalcularTotales(int ProductoID)
        {
            clsProducto Producto = lstProducto.Find(obj => obj.ProductoID == ProductoID);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "Precio", Producto.Precio);
            double Volumen;
            double.TryParse(gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Volumen").ToString(), out Volumen);
            CalcularTotales(Volumen);
        }

       
        private void CalcularTotales(double Volumen)
        {
            double Total = Convert.ToDouble(gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Precio")) * Volumen;
            double IVA = Total * 0.16;
            double IEPS = Total * 0.40;
            double Subtotal = Total - IVA - IEPS;
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "Subtotal", Subtotal);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA", IVA);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "IEPS", IEPS);
            gvDetallePedido.SetRowCellValue(gvDetallePedido.FocusedRowHandle, "Total", Total);
        }
        #region CargaCombos
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

        #endregion

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            try
            {


                pedido.PedidoID = 0;//(int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "PedidoID");

                //MOVIMIENTO
                pedido.Fecha = DateTime.Parse(dateFecha.Text);// (DateTime)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Fecha");
                pedido.FechaModificacion = DateTime.Today; //(DateTime)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "FechaModificacion");
                pedido.Ejercisio = DateTime.Today.Year;// (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Ejercicio");
                pedido.Periodo = DateTime.Today.Month;// (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Periodo");
                pedido.Total = double.Parse(txtTotal.Text); //(double)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Total");
                //pedido.UsuarioID = lueUsuario (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "UsuarioID");
                //pedido.EstacionID = (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "EstacionID");

                //FACTURA
                pedido.Serie = "FF";// txtSerie.Text;
                //pedido.Folio = int.Parse(txtFolio.Text);
                pedido.Dia = DateTime.Today.Day;// (int)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Dia");
                pedido.IVA = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA");
                //pedido.Status = (bool)gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "Status");
                pedido.Observacion = memObservacion.Text;

                //DETALLEPEDIDO
                detallepedido.Volumen = (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Volumen");
                detallepedido.Precio = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Precio");
                detallepedido.Subtotal = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Subtotal");
                detallepedido.IVA = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IVA");
                detallepedido.IEPS = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "IEPS");
                detallepedido.Total = (double)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "Total");
                detallepedido.Descuento = double.Parse(txtcDescuento.Text);
                detallepedido.NoItems = (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "NoItems");
                detallepedido.ProductoID = (int)gvDetallePedido.GetRowCellValue(gvDetallePedido.FocusedRowHandle, "ProductoID");

                //mOVIMIENTOID


                int MovimientoID = RedCoForm.Data.DataModule.DataService.GenerarFactura(pedido, detallepedido);
                if (MovimientoID <= 0)
                {
                    throw new Exception("Error al generar la Factura");
                }
                else
                {
                   
                   // lblFactura.Text = MovimientoID.ToString();
                    MessageBox.Show("Factura generada correctamente");
                  
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
