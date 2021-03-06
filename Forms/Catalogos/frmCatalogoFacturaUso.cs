﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Catalogos
{
    public partial class frmCatalogoFacturaUso : RedCoForm.Base.frmCatalogo
    {
        public frmCatalogoFacturaUso()
        {
            InitializeComponent();
            cdsCatalogo = spCatFacturaUsoDS1;
            DataSource = spCatFacturaUsoBindingSource;
            NombreDataSet = "spCatFacturaUso";
            Buscar("~`|`~");
        }
        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["FacturaUsoID"] = Data.DataModule.DataService.Folio("FacturaUsoID", "");

            }
        }
    }
}
