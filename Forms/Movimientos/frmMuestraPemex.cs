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
        TMuestraProducto MuestradeProducto = new TMuestraProducto();

        public frmMuestraPemex()
        {
            InitializeComponent();

            //Cargar Terminal
            Terminal();
            CargaProductos();
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

        #region Productos

        private void CargaProductos()
        {
            //Variables 

            DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        List<FillCombos> lst = new List<FillCombos>();
        FillCombos obj = new FillCombos();

            //Lenamos el DS de FormaPago
            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatProductoDS, "spCatProducto", Params.ToArray());

            dt = spCatProductoDS.Tables["spCatProducto"];
            lst = obj.FillListCombo(dt,"ProductoID","Descripcion");
            bs.DataSource = lst;

            this.lueProductoID.Properties.DataSource = bs.List;
            //this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueProductoID.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"));
            this.lueProductoID.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueProductoID.Properties.DisplayMember = "Nombre";
            this.lueProductoID.Properties.ValueMember = "ID";

            this.lueProductoID.Properties.DropDownRows = lst.Count;

        }
    #endregion

    private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void GuardaMuestraPemex()
        {
            int res = 0;
           

            try
            {

                MuestradeProducto.NoMuestra = txtNoMuestra.Text;
                MuestradeProducto.PesodeCarga = txtPesoCarga.Text;
                //MuestradeProducto.TerminalID = lueTerminal.ItemIndex;
                //MuestradeProducto.ProductoID = lueProductoID.lastChangedEditValue;
                MuestradeProducto.Azufre = txtAzufre.Text;
                MuestradeProducto.Octanaje = txtOctanos.Text;
                MuestradeProducto.Adimensional = txtAdimensional.Text;
                MuestradeProducto.Observacion = txtObservacion.Text;

                res = Data.DataModule.DataService.InsertaMuestradeProducto(MuestradeProducto);
                if (res == -1)
                {
                    MessageBox.Show("Error al guardar...", "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Guardado... ", "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Limpiar los controles
                }
            }
            catch
            {
                MessageBox.Show("Error en la Captura de Datos", "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private Boolean Valida()
        {
            //Crea Regla para Validar txt en Blanco
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Falta ingresar un Valor...";
            //..
            vpValidador.SetValidationRule(txtNoMuestra, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtPesoCarga, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtAzufre, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtOctanos, notEmptyValidationRule);
            vpValidador.SetValidationRule(txtAdimensional, notEmptyValidationRule);

           


            //Crea Regla pra validar no sea igual a un Valor 
            ConditionValidationRule notEqualsValidationRule = new ConditionValidationRule();
            notEqualsValidationRule.ConditionOperator = ConditionOperator.NotEquals;
            notEqualsValidationRule.Value1 = "[Seleccione Una Opcion...]";
            notEqualsValidationRule.ErrorText = "Seleccione Una Opcion";
           // notEqualsValidationRule.ErrorType = ErrorType.Information;

            //..
            vpValidador.SetValidationRule(lueTerminal, notEqualsValidationRule);
            vpValidador.SetValidationRule(lueProductoID, notEqualsValidationRule);


            vpValidador.ValidationMode = (ValidationMode.Auto);


            if (vpValidador.Validate())
            {
             
                return true;
            }
            else
            {
                
              
                return false;
            }

         


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                GuardaMuestraPemex();
               // MessageBox.Show("Todos Captyrados", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Error ", "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lueTerminal_Validated(object sender, EventArgs e)
        {

        }

        private void lueProductoID_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);

            MuestradeProducto.ProductoID =int.Parse( editor.EditValue.ToString());

           // MessageBox.Show(MuestradeProducto.ProductoID.ToString(), "RedPacifico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void lueTerminal_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
            MuestradeProducto.TerminalID = int.Parse(editor.EditValue.ToString());
        }
    }
}
