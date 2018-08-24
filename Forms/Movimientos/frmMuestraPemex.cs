using DevExpress.XtraEditors.DXErrorProvider;
using RedCoForm.Class;
using RemObjects.DataAbstract.Server;
using RPSuiteServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedCoForm.Forms.Movimientos
{
    public partial class frmMuestraPemex : RedCoForm.Base.frmEstructura
    {

        private List<DataParameter> Params = new List<DataParameter>();
        public frmMuestraPemex()
        {
            InitializeComponent();

            //Cargar Terminal
            Terminal();
        }


        #region Terminal
        private void Terminal()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsTerminal> Terminal = new List<clsTerminal>();
            clsTerminal c = new clsTerminal();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatTerminalDS, "spCatTerminal", Params.ToArray());

            dt = spCatTerminalDS.Tables["spCatTerminal"];
            Terminal = c.FillList(dt);
            bs.DataSource = Terminal;

            this.lueTerminal.Properties.DataSource = bs.List;
            this.lueTerminal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerminalID", "ID"));
            this.lueTerminal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre"));
            this.lueTerminal.Properties.DisplayMember = "Descripcion";
            this.lueTerminal.Properties.ValueMember = "TerminalID";

            this.lueTerminal.Properties.DropDownRows = Terminal.Count;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            TMuestraProducto MuestradeProducto = new TMuestraProducto();

            try
            {


                MuestradeProducto.NoMuestra = txtNoMuestra.Text;
                MuestradeProducto.PesodeCarga = txtPesoCarga.Text;
                MuestradeProducto.TerminalID = Int32.Parse( lueTerminal.Properties.ValueMember);
                MuestradeProducto.ProductoID = Int32.Parse(lueProductoID.Properties.ValueMember);
                MuestradeProducto.Azufre = txtAzufre.Text;
                MuestradeProducto.Octanaje = txtOctanos.Text;
                MuestradeProducto.Adimensional = txtAdimensional.Text;
                MuestradeProducto.Observacion = txtObservacion.Text;

                res = Data.DataModule.DataService.InsertaMuestradeProducto(MuestradeProducto);
            }
            catch
            {

            }




        }

        private void Valida()
        {

            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Please enter a value";
            //..
            vpValidador.SetValidationRule(txtNoMuestra, notEmptyValidationRule);

         
            vpValidador.ValidationMode = (ValidationMode.Auto);


         
                vpValidador.Validate();
            


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Valida();
        }
    }
}
