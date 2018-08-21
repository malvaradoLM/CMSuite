using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoProveedor : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoProveedor()
        {
            InitializeComponent();
            cdsCatalogo = spCatProveedorDS1;
            DataSource = spCatProveedorBindingSource;
            NombreDataSet = "spCatProveedor";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["ProveedorID"] = Data.DataModule.DataService.Folio("ProveedorID", "");

            }
        }
    }
}
