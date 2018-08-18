using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoCategoria : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoCategoria()
        {
            InitializeComponent();
            cdsCatalogo = spCatCategoriaDS;
            DataSource = spCatCategoriaBindingSource;
            NombreDataSet = "spCatCategoria";
      
        }



  

    public override void onBeforePost()
    {
        if (newRecordRow != null)
        {
            newRecordRow["CategoriaID"] = Data.DataModule.DataService.Folio("CategoriaID", "");

        }
    }
}
}
