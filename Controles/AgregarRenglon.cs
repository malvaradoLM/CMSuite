using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedCoForm.Controles
{
    public partial class AgregarRenglon : UserControl
    {
        public DataSet CustomDataSet { get; set; }
        public string NombreDataSet { get; set; }
        private BindingSource CustomBindingSource { get; set; }
        public AgregarRenglon()
        {
            InitializeComponent();
        }
        public void Bindear(DataSet DataSet, BindingSource BindingSource, string DataMember)
        {
            CustomBindingSource = new BindingSource();
            CustomBindingSource.DataSource = DataSet;
            CustomBindingSource.DataMember = DataMember;




            CustomDataSet = DataSet;

            NombreDataSet = DataMember;

            CustomBindingSource.DataSource = DataSet.Tables[NombreDataSet];
            CustomGridControl.DataSource = CustomBindingSource;
        }
    }
}
