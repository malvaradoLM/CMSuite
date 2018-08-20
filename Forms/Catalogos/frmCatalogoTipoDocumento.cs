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
    public partial class frmCatalogoTipoDocumento : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoTipoDocumento()
        {
            InitializeComponent();
            cdsCatalogo = spCatTipoDocumentoDS1;
            DataSource = bindingsourceTipoDocumento;
            NombreDataSet = "spCatTipoDocumento";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["TipoDocumentoID"] = Data.DataModule.DataService.Folio("TipoDocumentoID", "");

            }
        }
    }
}
