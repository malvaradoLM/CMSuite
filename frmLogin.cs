using DevExpress.Utils.OAuth.Provider;
using RedCoForm.Data;
using RPSuiteServer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RedCoForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RemObjects.DataAbstract.Server.UserInfo Info;
            try
            {
                if (DataModule.LoginService.Login(txtUsuario.Text, txtClave.Text, out Info))
                {
                    DataModule.Seguridad = Info;
                    Close();
                    //mandamos llamar el GetEstaciones que llena el lookupedit de estaciones.
                    frmPrincipal principal = (frmPrincipal)Application.OpenForms["frmPrincipal"];
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClave_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
