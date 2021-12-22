using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinanseSystem.UI
{
    public partial class frmCategoryFin : Form
    {
        private string _str;
        public string Str => _str;
        public frmCategoryFin()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _str = txtName.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
