using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoBanco : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoBanco()
        {
            InitializeComponent();
            cdsCatalogo = spCatBancoDS1;
            DataSource = spCatBancoBindingSource;
            NombreDataSet = "spCatBanco";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["BancoID"] = Data.DataModule.DataService.Folio("BancoID", "");

            }
        }


    }
}
