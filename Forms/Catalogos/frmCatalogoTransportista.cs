using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoTransportista : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoTransportista()
        {
            InitializeComponent();

            cdsCatalogo = spCatTransportistaDS;
            DataSource = spCatTransportistaBindingSource;
            NombreDataSet = "spCatTransportista";
            Buscar("~`|`~");

        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["TransportistaID"] = Data.DataModule.DataService.Folio("TransportistaID", "");

            }
        }
    }
}
