using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoUsuario : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoUsuario()
        {
            InitializeComponent();
            cdsCatalogo = spCatUsuarioDS1;
            DataSource = spCatUsuarioBindingSource;
            NombreDataSet = "spCatUsuario";
            Buscar("~`|`~");
        }

        private void GetEstacion()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            //List<clsBanco> Banco = new List<clsBanco>();
            //clsBanco c = new clsBanco();

            ////Lenamos el DS de Categorias

            //Params.Clear();

            //Data.DataModule.ParamByName(Params, "Datos", "");
            //Data.DataModule.FillDataSet(spCatBancoDS, "spCatEstacion", Params.ToArray());

            //dt = spCatBancoDS.Tables["spcatbanco"];
            //Banco = c.FillList(dt);
            //bs.DataSource = Banco;

            //this.lueBanco.Properties.DataSource = bs.List;
            //this.lueBanco.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BancoID", "Banco ID"));
            //this.lueBanco.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            //this.lueBanco.Properties.DisplayMember = "Nombre";
            //this.lueBanco.Properties.ValueMember = "BancoID";

            //this.lueBanco.Properties.DropDownRows = Banco.Count;

        }
    }
}
