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
    public partial class AddTransaction : Form
    {
        IUser _user;
        public IUser User => _user;
        
        ITransaction _context;
        bool IsChangeTrans = false;
        //bool ChoiceOfFinance = false;
        private TransactionType _type;
        private decimal _sum;
        public AddTransaction(IUser user,ITransaction transaction = null)
        {
            InitializeComponent();
            
            _user = user;
            txtUser.Text = user.Name;


            if (transaction != null)
            {
                Text = "Редактирование";
                _context = transaction;
                IsChangeTrans = true;
                RefreshView();
            }
            else
            {
                Text = "Добавление";
                dudAddTrans.SelectedIndex = 0;
            }
        }

        private void DataChecking()
        {
            if(numUpd.Value == 0)
            {
                throw new Exception("Вы не ввели сумму");
            }
        }
        private void RefreshView()
        {
            
            txtComment.Text = _context.Comment;
            numUpd.Value = _context.Sum;
            dudAddTrans.SelectedItem = _context.Type;
            if (lblCmb.Text == cmbIncome.Text)
            { 
                lblCmb.Text = cmbIncome.Text; 
            }
            else
            {
                lblCmb.Text = cmbExpenes.Text;
            }
        }
        private void UpDateData()
        {
            
            _context.Comment = txtComment.Text;
            _context.Sum = numUpd.Value;
            _context.Type = (TransactionType)dudAddTrans.SelectedIndex;
            _context.User.Name = User.Name;
            _context.Category = lblCmb.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            frmCategoryFin form = new frmCategoryFin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cmbIncome.Items.Add(form.Str);
            }
        }

        private void AddCategorys()
        {
            if(dudAddTrans.Text == "Доходы")
            {
                
                lblCmb.Text = cmbIncome.Text;
            }
            else if(dudAddTrans.Text == "Расходы")
            {
                lblCmb.Text = cmbExpenes.Text;
            }
        }
        private void ForAnalytics()
        {
            _sum = numUpd.Value;
            _type = (TransactionType)dudAddTrans.SelectedIndex;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ForAnalytics();
            Analytics.AddIncomSum(_sum, _type);
            AddCategorys();
            try
            {
                DataChecking();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Неверно заполнены данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(IsChangeTrans)
            {
                UpDateData();
            }
            else
            {
                TransactionService.AddTransaction(DateTime.Now, lblCmb.Text,User, numUpd.Value, (TransactionType)dudAddTrans.SelectedIndex, txtComment.Text);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmCategoryFin form = new frmCategoryFin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cmbExpenes.Items.Add(form.Str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategoryFin form = new frmCategoryFin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cmbIncome.Items.Add(form.Str);
            }
            else
            {
                cmbExpenes.Items.Add(form.Str);
            }
        }

        private void dudAddTrans_SelectedItemChanged(object sender, EventArgs e)
        {
            cmbExpenes.Visible = false;
            cmbIncome.Visible = false;
            label1.Visible = false;
            label5.Visible = false;
            if (dudAddTrans.Text == "Доходы")
            {
                cmbExpenes.Visible = false;
                cmbIncome.Visible = true;
                label1.Visible = true;
                label7.Visible = true;
            }
            if (dudAddTrans.Text == "Расходы")
            {
                cmbIncome.Visible = false;
                cmbExpenes.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
            }
        }
    }
}
