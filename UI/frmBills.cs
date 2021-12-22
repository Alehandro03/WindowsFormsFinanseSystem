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

namespace WindowsFormsFinanseSystem
{
  
    public partial class frmBills : Form
    {
        private List<IBankAccount> _account;
        public frmBills()
        {
            InitializeComponent();
            _account = BankAccountService.GetBankAccount();
            dgvBills.AutoGenerateColumns = false;
            dgvBills.DataSource = _account;

        }
        private void UpdateTheForm()
        {
            dgvBills.DataSource = null;
            dgvBills.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddBills form = new frmAddBills();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateTheForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IBankAccount iba = _account[dgvBills.SelectedRows[0].Index];
            frmAddBills form = new frmAddBills(iba);
            if(form.ShowDialog() == DialogResult.OK)
            {
                BankAccountService.EditBankAccount();
                UpdateTheForm();
            }
        }

        private void btnDeleteBills_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите удалить счет?", "Удалить?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach(DataGridViewRow dgv in dgvBills.SelectedRows)
                {
                    BankAccountService.RemoveBankAccount(_account[dgv.Index]);
                }
                UpdateTheForm();
            }
        }
    }
}
