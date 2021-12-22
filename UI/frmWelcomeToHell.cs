using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.UI
{
    public partial class frmWelcomeToHell : Form
    {
        private IUser _user;
        public IUser User => _user;

        private Form _form_auth;
        public frmWelcomeToHell(IUser user, Form formAuth)
        {
            InitializeComponent();
            _user = user;
            _form_auth = formAuth;
            txtUser.Text = _user.Name;
            Text = _user.Login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain(User);
            formMain.Show();
            Hide();
        }
    }
}
