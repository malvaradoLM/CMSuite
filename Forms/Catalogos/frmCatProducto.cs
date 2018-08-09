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
    public partial class frmCatProducto : RedCoForm.Base.frmCatalogo
    {
        private List<DataParameter> Params = new List<DataParameter>();
        public frmCatProducto()
        {
            InitializeComponent();
            cdsCatalogo = spCatProductoDS;
            DataSource = spCatProductoDSBindingSource;
            NombreDataSet = "spCatProducto";
            getCategoria();
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["ProductoID"] = Data.DataModule.DataService.Folio("ProductoID", "");

            }
        }

        #region Categoria
        public void getCategoria()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<clsCategoria> lstCategoria = new List<clsCategoria>();
            clsCategoria objCategoria = new clsCategoria();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatProductoDS, "spCatCategoria", Params.ToArray());

            dt = spCatProductoDS.Tables["spCatCategoria"];
            lstCategoria = objCategoria.FillList(dt);
            bs.DataSource = lstCategoria;

            this.lueCategoria.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueCategoria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueCategoria.Properties.DisplayMember = "Descripcion";
            this.lueCategoria.Properties.ValueMember = "CategoriaID";

            this.lueCategoria.Properties.DropDownRows = lstCategoria.Count;

        }
        #endregion

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
