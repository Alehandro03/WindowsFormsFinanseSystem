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
using WindowsFormsFinanseSystem.UI;

namespace WindowsFormsFinanseSystem
{
    public partial class frmTransaction : Form
    {
        IUser _user;
        public IUser User => _user;
        private DataGridView _dgv;
        public DataGridView Dgv => _dgv; 
        private List<ITransaction> _trans;
        private decimal _total_sum;
        
        public frmTransaction(IUser user)
        {
            InitializeComponent();

            decimal dec = Analytics.Bills();
            txtGenBalance.Text = dec.ToString();
            _user = user;
            _trans = TransactionService.GetTransactions();
            dgvTablGeneral.AutoGenerateColumns = false;
            dgvTablGeneral.DataSource = _trans;
            _dgv = dgvTablGeneral;
        }
        private void UpdateTheForm()
        {
            decimal dec = Analytics.ShowTotalSum();
            txtGenBalance.Text = Convert.ToString(dec);
            dgvTablGeneral.DataSource = null;
            _trans = TransactionService.GetTransactions();
            dgvTablGeneral.DataSource = _trans;
            dgvTablGeneral.Refresh();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _total_sum = Convert.ToDecimal(txtGenBalance.Text);
            Analytics.TotalSum(_total_sum);
            AddTransaction form = new AddTransaction(User);
            if(form.ShowDialog() == DialogResult.OK)
            {
                UpdateTheForm();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ITransaction itr = _trans[dgvTablGeneral.SelectedRows[0].Index];
            AddTransaction form = new AddTransaction(User,itr);
            if(form.ShowDialog() == DialogResult.OK)
            {
                
                TransactionService.EditTransaction();
                UpdateTheForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Вы уверены, что хотите удалить транзакцию?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) 
            {
                foreach (DataGridViewRow dgv in dgvTablGeneral.SelectedRows)
                {
                    TransactionService.RemoveTransaction(_trans[dgv.Index]);
                }
                UpdateTheForm();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Export.ExportDGVTransactionToExel(dgvTablGeneral);
        }
    }
}
