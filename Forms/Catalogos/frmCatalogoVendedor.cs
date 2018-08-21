using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoVendedor : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoVendedor()
        {
            InitializeComponent();
            cdsCatalogo = spCatVendedorDS1;
            DataSource = spCatVendedorBindingSource;
            NombreDataSet = "spCatVendedor";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["VendedorID"] = Data.DataModule.DataService.Folio("VendedorID", "");

            }
        }

    }
}
