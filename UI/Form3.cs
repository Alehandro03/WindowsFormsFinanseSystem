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

namespace WindowsFormsFinanseSystem
{
    public partial class frmAdd : Form
    {

        private IUser _user;
        public IUser User => _user;
        private string _context_peop_name;
        public string ContextPeopName => _context_peop_name;
        public frmAdd(IUser user)
        {
            InitializeComponent();
            _user = user;
            txtName.Text = User.Name;

        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshText()
        {
            _context_peop_name = richTextBox1.Text;
        }

        private void btnUserOK_Click(object sender, EventArgs e)
        {
            RefreshText();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
