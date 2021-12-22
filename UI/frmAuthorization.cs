using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFinanseSystem.BusinessLogic;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.UI
{
    public partial class frmAuthorization : Form
    {
        IUser _user;
        public frmAuthorization()
        {
            
            InitializeComponent();
            
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegisration form_reg = new frmRegisration();
            form_reg.ShowDialog();
        }

        private void btnAuthOK_Click(object sender, EventArgs e)
        {
            try
            {
                IUser user = AuthorizationProcess.FindAndCheckPassword(txtUsersAuth.Text, txtPasswordAuth.Text);
                if (user == null)
                {
                    throw new Exception("Пользователь с таким Логином или Паролем не найден!");
                }
                frmWelcomeToHell welcome = new frmWelcomeToHell(user, this);
                welcome.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
