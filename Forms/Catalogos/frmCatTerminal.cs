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
    public partial class frmCatTerminal : RedCoForm.Base.frmCatalogo
    {
        public frmCatTerminal()
        {
            InitializeComponent();
            cdsCatalogo = spCatTerminalDS1;
            DataSource = spCatTerminalBindingSource;
            NombreDataSet = "spCatTerminal";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["TerminalID"] = Data.DataModule.DataService.Folio("TerminalID", "");

            }
        }

        private void txtDomicilio_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
