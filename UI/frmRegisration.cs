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
    public partial class frmRegisration : Form
    {
        public frmRegisration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizationProcess.RegisterUser(txtFIORegistr.Text, txtUsersRegistr.Text, txtPasswordRegistr.Text);
                MessageBox.Show("Вы успешно авторизовались", "!Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }                 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
