using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

namespace CurvedSpringFatigueTester
{
    public partial class FrmLogin : Form
    {
        private DialogResult dialogResult = DialogResult.Cancel;

        private string ID = "DAEWON";
        private string PW = "1234";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalValue.Form.FormLogin = null;
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = dialogResult;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        #region Button
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == ID &&
                txt_PW.Text == PW
               )
            {
                dialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                GlobalFunction.MessageBox(MethodBase.GetCurrentMethod().Name, "ID, PW 확인 후에 재시도 해주세요", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
