using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedCoForm.Class;
using DevExpress.XtraEditors.Repository;

namespace RedCoForm.Controles
{
    public partial class CTextBox : UserControl,System.ComponentModel.ISupportInitialize
    {
        private string mask;
        private GlobalVar.CMask masktype;
        private int ndecimales;
        private string Text;
        

        void ISupportInitialize.BeginInit()
        { }
        void ISupportInitialize.EndInit()
        { }

        [DisplayName("Precision")]
        [Description("Set number of decimals when using Numeric, Currency and Percentaje Mask")]
        public int NDecimales
        {
            get
            {
                return ndecimales;
            }
            set
            {
                ndecimales = value;
                if (masktype == GlobalVar.CMask.Numeric || masktype == GlobalVar.CMask.Currency || masktype == GlobalVar.CMask.Percentaje)
                {
                    mask = Type(masktype);
                }
            }
        }
        [Description("Defines the mask applied to the control")]
        public GlobalVar.CMask MaskType
        {
            get
            {
                return masktype;
            }
            set
            {
                masktype = value;
                mask = Type(value);
            }
        }

        public CTextBox()
        {
            InitializeComponent();
            masktype = GlobalVar.CMask.None;
            ndecimales = 2;
        }

        private string Type(GlobalVar.CMask Mascara)
        {
            string Texto = "";
            switch (Mascara)
            {
                case GlobalVar.CMask.Phone:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    Texto = "\\(\\d{3}\\)-\\d{3}-\\d{4}";
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
                case GlobalVar.CMask.String:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    Texto = "([^0-9^a-z])+";
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
                case GlobalVar.CMask.Numeric:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    Texto = "n" + ndecimales;
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
                case GlobalVar.CMask.Currency:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    Texto = "c" + ndecimales;
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
                case GlobalVar.CMask.Email:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    Texto = "[a-zA-Z0-9_\\.]+@[a-zA-Z0-9]+\\.[a-z]{2,}\\.?[a-z]{0,3}";
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
                case GlobalVar.CMask.RFC:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    Texto = "[A-Z]{3,4}(\\d{6})([A-Z0-9]{3})?";
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
                case GlobalVar.CMask.None:
                    textEdit1.Properties.CharacterCasing = CharacterCasing.Upper;
                    break;
                case GlobalVar.CMask.Percentaje:
                    textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    Texto = "p" + ndecimales;
                    textEdit1.Properties.Mask.EditMask = Texto;
                    break;
            }
            return Texto;
        }
    }
}
