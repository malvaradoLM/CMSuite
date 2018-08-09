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
    public partial class frmCatVehiculo : RedCoForm.Base.frmCatalogo
    {
        public frmCatVehiculo()
        {
            InitializeComponent();
            cdsCatalogo = spCatVehiculoDS1;
            DataSource = spCatVehiculoBindingSource;
            NombreDataSet = "spCatVehiculo";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["VehiculoID"] = Data.DataModule.DataService.Folio("VehiculoID", "");

            }
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
