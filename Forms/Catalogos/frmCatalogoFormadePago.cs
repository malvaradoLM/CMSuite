using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoFormadePago : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoFormadePago()
        {
            InitializeComponent();

            cdsCatalogo = spCatFormaPagoDS;
            DataSource = spCatFormaPagoBindingSource;
            NombreDataSet = "spCatFormaPago";
        }




    public override void onBeforePost()
    {
        if (newRecordRow != null)
        {
            newRecordRow["FormadePagoID"] = Data.DataModule.DataService.Folio("FormaPAgoID", "");

        }
    }

}
}
