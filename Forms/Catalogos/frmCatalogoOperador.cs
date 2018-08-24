using RedCoForm.Class;
using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoOperador : RedCoForm.Base.frmCatalogo
    {

        private List<DataParameter> Params = new List<DataParameter>();

        public frmCatalogoOperador()
        {
            InitializeComponent();
            cdsCatalogo = spCatOperadorDS1;
            DataSource = spCatOperadorBindingSource;
            NombreDataSet = "spCatOperador";
            Buscar("~`|`~");


            //Cargar Transportistas
            getTransportista();
        }


        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["OperadorID"] = Data.DataModule.DataService.Folio("OperadorID", "");

            }
        }

        #region Transportista
        public void getTransportista()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsTransportista> Banco = new List<clsTransportista>();
            clsTransportista c = new clsTransportista();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatTransportistaDS, "spCatTransportista", Params.ToArray());

            dt = spCatTransportistaDS.Tables["spCatTransportista"];
            Banco = c.FillList(dt);
            bs.DataSource = Banco;

            this.lueTransportista.Properties.DataSource = bs.List;
            this.lueTransportista.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransportistaID", "ID"));
            this.lueTransportista.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueTransportista.Properties.DisplayMember = "Nombre";
            this.lueTransportista.Properties.ValueMember = "TransportistaID";

            this.lueTransportista.Properties.DropDownRows = Banco.Count;


        }
        #endregion
    }
}
