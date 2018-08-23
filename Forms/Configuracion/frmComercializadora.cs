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
    public partial class frmComercializadora : RedCoForm.Base.frmCatalogo
    {

        private List<DataParameter> Params = new List<DataParameter>();
        
        public frmComercializadora()
        {
            InitializeComponent();

            getRegimenFiscal();

            //Cargar Los Estados
            GlobalVar.CargarEstados();
            lueEstado.Properties.DataSource = GlobalVar.Estados;
            lueExpEstado.Properties.DataSource = GlobalVar.Estados;
        }


        #region RegimenFiscal

        public void getRegimenFiscal()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsRegimenFiscal> Regimen = new List<clsRegimenFiscal>();
            clsRegimenFiscal c = new clsRegimenFiscal();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatRegimenFiscalDS, "spCatRegimenFiscal", Params.ToArray());

            dt = spCatRegimenFiscalDS.Tables["spCatRegimenFiscal"];
            Regimen = c.FillList(dt);
            bs.DataSource = Regimen;

            this.lueRegimenFiscal.Properties.DataSource = bs.List;
            this.lueRegimenFiscal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegimenFiscalID", "ID"));
            this.lueRegimenFiscal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoSAT", "CodigoSAT"));
            this.lueRegimenFiscal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueRegimenFiscal.Properties.DisplayMember = "Descripcion";
            this.lueRegimenFiscal.Properties.ValueMember = "RegimenFiscalID";

            this.lueRegimenFiscal.Properties.DropDownRows = Regimen.Count;
        }
        #endregion  

    }
}
