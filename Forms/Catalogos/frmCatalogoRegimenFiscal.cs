using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoRegimenFiscal : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoRegimenFiscal()
        {
            InitializeComponent();
            cdsCatalogo = spCatRegimenFiscalDS1;
            DataSource = spCatRegimenFiscalBindingSource1;
            NombreDataSet = "spCatRegimenFiscal";
            Buscar("~`|`~");
        }
        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["RegimenFiscalID"] = Data.DataModule.DataService.Folio("RegimenFiscalID", "");

            }
        }
    }
}
