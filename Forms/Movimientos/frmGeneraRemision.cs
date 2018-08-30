using DevExpress.XtraEditors.DXErrorProvider;
using RedCoForm.Class;
using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Movimientos
{
    public partial class frmGeneraRemision : RedCoForm.Base.frmEstructura
    {

        public int TerminalPrimaria=0;
        public int EstacionSeleccionada = 0;
        RPSuiteServer.TEstacion datosestacion = new RPSuiteServer.TEstacion();

        private List<DataParameter> Params = new List<DataParameter>();


        public frmGeneraRemision()
        {
            InitializeComponent();

            CargarTerminal();

             CargarEstacion();
            CargarTransportista();

            CargarOperador();

            CargarVehiculo();


        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }



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

            this.lueTerminal.Properties.DataSource = bs.List;
            this.lueTerminal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerminalID", "ID"));
            this.lueTerminal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre"));
            this.lueTerminal.Properties.DisplayMember = "Descripcion";
            this.lueTerminal.Properties.ValueMember = "TerminalID";

            this.lueTerminal.Properties.DropDownRows = Terminal.Count;
        }
        #endregion


        #region Estacion


        private void CargarEstacion()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsEstacion> Estacion = new List<clsEstacion>();
            clsEstacion c = new clsEstacion();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");

       

           // gvPedidos.DataSource = dt.Select("StatusID=" + 1 + " or StatusID =" + 3);

            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatEstacion", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatEstacion"];

            //DataRow[] dr = dt.Select("TerminalPrimaria=" + TerminalPrimaria);
            //dt = dr.CopyToDataTable();

            Estacion = c.FillList(dt);


          

            bs.DataSource = Estacion ;

            this.lueEstacion.Properties.DataSource = bs.List;
            this.lueEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "ID"));
            this.lueEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueEstacion.Properties.DisplayMember = "Nombre";
            this.lueEstacion.Properties.ValueMember = "EstacionID";

            this.lueEstacion.Properties.DropDownRows = Estacion.Count;
        }


        #endregion Producto

        #region Transportista
        private void CargarTransportista()
        {

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsTransportista> Transportista = new List<clsTransportista>();
            clsTransportista c = new clsTransportista();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatTransportistaDS, "spCatTransportista", Params.ToArray());

            dt = spCatTransportistaDS.Tables["spCatTransportista"];
            Transportista = c.FillList(dt);
            bs.DataSource = Transportista;

            this.lueTransportista.Properties.DataSource = bs.List;
            this.lueTransportista.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransportistaID", "ID"));
            this.lueTransportista.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueTransportista.Properties.DisplayMember = "Nombre";
            this.lueTransportista.Properties.ValueMember = "TransportistaID";

            this.lueTransportista.Properties.DropDownRows = Transportista.Count;
        }

        #endregion

        #region CargarOperador
        private void CargarOperador()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatOperadorDS1, "spCatOperador", Params.ToArray());

            dt = spCatOperadorDS1.Tables["spCatOperador"];
            lst = obj.FillListCombo(dt, "OperadorID", "Nombre");
            bs.DataSource = lst;

            this.lueNombreOperador.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueNombreOperador.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"));
            this.lueNombreOperador.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueNombreOperador.Properties.DisplayMember = "Nombre";
            this.lueNombreOperador.Properties.ValueMember = "ID";

            this.lueNombreOperador.Properties.DropDownRows = lst.Count;
        }

        #endregion

        #region Vehiculo

        private void CargarVehiculo()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> lst = new List<FillCombos>();
            FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatVehiculoDS, "spCatVehiculo", Params.ToArray());

            dt = spCatVehiculoDS.Tables["spCatVehiculo"];
            lst = obj.FillListCombo(dt, "VehiculoID", "NoEconomico");
            bs.DataSource = lst;

            this.lueVehiculo.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"));
            this.lueVehiculo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueVehiculo.Properties.DisplayMember = "Nombre";
            this.lueVehiculo.Properties.ValueMember = "ID";

            this.lueVehiculo.Properties.DropDownRows = lst.Count;
        }
        #endregion

        private Boolean Valida()
        {
            //Crea Regla para Validar txt en Blanco
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Falta ingresar un Valor...";
            //..
            vpValidador.SetValidationRule(txtSellos, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtTemperatura, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtCantidadAlNat, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtCantidad20Grados, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtPlacas, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtCertificado, notEmptyValidationRule);

            if (vpValidador.Validate())
            {

                return true;
            }
            else
            {


                return false;
            }
        }





        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lueTerminal_EnabledChanged(object sender, EventArgs e)
        {
          
        }

        private void lueEstacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
          

        }

        private void lueTerminal_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void lueEstacion_EditValueChanged(object sender, EventArgs e)
        {
            //Cuando Seleccionamos UnaEstacion Cargar Los Datos de la Estacion
            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);

            EstacionSeleccionada = int.Parse(editor.EditValue.ToString());
            // MessageBox.Show("Estacion Seleccionada " + EstacionSeleccionada, "Ejemplo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            datosestacion = Data.DataModule.DataService.GetEstacion(EstacionSeleccionada.ToString());

            if (datosestacion.EstacionID != -1)
            {
                txtNombreEstacion.Text = EstacionSeleccionada.ToString() + " - "+ datosestacion.RazonSocial;
                txtLugarEntrega.Text = datosestacion.EntregaCalle + " "+ datosestacion.EntregaNoExterior + " " + datosestacion.EntregaNoInterior;
                txtLugarEntrega.Text = txtLugarEntrega.Text + " " + datosestacion.EntregaColonia;
            }
            else
            {
                MessageBox.Show("Error al Cargar Estacion", "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
