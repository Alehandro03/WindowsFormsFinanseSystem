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

namespace WindowsFormsFinanseSystem
{
    public partial class frmAddBills : Form
    {

        private string _context_name;
        IBankAccount _bills;
        private List<IFamilyMember> _fem;
        public string ContextName => _context_name;
        private bool IsChangeBills = false;
        public frmAddBills(IBankAccount bills = null)
        {
            InitializeComponent();
            _fem = FamilyMemberService.GetFamilyMember();
            foreach(var item in _fem)
            {
                cmbUserName.Items.Add(item.Name);
            }
            if(bills != null)
            {
                Text = "Редактирование";
                _bills = bills;
                IsChangeBills = true;
                RefreshData();
                // тут метод по обновлению формы
            }
            else
            {
                Text = "Добавление";
            }
        }

        private void DataChecking()
        {
            // метод проверки данных
        }

        private void RefreshData()
        {
            txtName.Text = _bills.Name;
            cmbUserName.Text = _bills.UserName;
            numBills.Value = _bills.Balance;
        }
        private void UpDateData()
        {
            txtName.Text = 
            _bills.Name = txtName.Text;
            _bills.UserName = cmbUserName.Text;
            _bills.Balance = numBills.Value;
            
        }

        private void pbAddBills_Click(object sender, EventArgs e)
        {
            frmPictureBox box = new frmPictureBox();
           
            if (box.ShowDialog() == DialogResult.OK)
            {
                pbAddBills.Image = box.ImageMyForm;
            }
          
        }

        private void btnAddBillsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshText()
        {
            _context_name = txtName.Text;
        }
        private void btnAddBillsOK_Click(object sender, EventArgs e)
        {
          
            try
            {
                DataChecking();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Неверно введены данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(IsChangeBills)
            {
                UpDateData();
            }
            else
            {
                BankAccountService.AddBankAccount(txtName.Text, cmbUserName.Text, numBills.Value);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
