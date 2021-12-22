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
    public partial class frmMain : Form
    {


        IUser _user;
        public IUser User => _user;
        decimal _dec;
        ITransaction _context;
        private List<IFamilyMember> _fem;
        public frmMain(IUser user,string str = null,ITransaction transaction = null)
        {
            InitializeComponent();
            _user = user;
            decimal dec = Analytics.Bills();
            rtbSumOverallBalance.Text = dec.ToString();
            if (transaction != null)
            {
                Text = "Добавление";
                cmbType.SelectedIndex = 0;
            }
            try
            {
                _fem = FamilyMemberService.GetFamilyMember();
                foreach (var item in _fem)
                {
                    cmbAddUser.Items.Add(item.Name);
                }
                cmbAddUser.Text = str;
            }
            catch(Exception)
            {

            }
        }
       
        private void DataChecking()
        {
            if(numSum.Value == 0)
            {
                throw new Exception("Вы не ввели сумму");
            }
        }
        private void RefreshData()
        {
            cnbCategory.Text = _context.Category;
            txtComment.Text = _context.Comment;
            cmbType.SelectedItem = _context.Type;
        }
        private void UpDateData()
        {
            _context.Comment = txtComment.Text;
            _context.Sum = numSum.Value;
            _context.Type = (TransactionType)cmbType.SelectedIndex;
            _context.User.Name = cmbAddUser.Text;
            _context.Category = cnbCategory.Text;
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                string str = cmbAddUser.Text;
                frmFamilyMember form = new frmFamilyMember(User);
                form.Show();
                Hide();
            }
            catch(Exception)
            {

            }
        }

        private void RefreshView()
        {
            decimal dec = Analytics.ShowTotalSum();
            _dec = dec;
            rtbSumOverallBalance.Text = Convert.ToString(_dec);

        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction form = new frmTransaction(User);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                RefreshView();
            }
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog form = new OpenFileDialog();
            form.ShowDialog();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            frmBills form = new frmBills();
            form.ShowDialog();
        }


        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategoryFin form = new frmCategoryFin();
            form.ShowDialog();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmAnalytics form = new frmAnalytics();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmCategoryFin form = new frmCategoryFin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cnbCategory.Items.Add(form.Str);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbAddUser.SelectedIndex == -1)
            {
                cmbAddUser.Text = "";
            }
            try
            {

                User.Name = cmbAddUser.Text;
                TransactionService.AddTransaction(DateTime.Now, cnbCategory.Text, User, 
                    numSum.Value, (TransactionType)cmbType.SelectedIndex, txtComment.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Неверно заполнены данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;
            txtComment.Text = "";
            numSum.Value = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmCredits form = new frmCredits();
            form.ShowDialog();
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            frmTransaction form = new frmTransaction(User);
            //if(form.ShowDialog() == DialogResult.Cancel)
            {
                Export.ExportDGVTransactionToExel(form.Dgv);
            }
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            
            ExchangeRates form = new ExchangeRates();
            try
            {
                form.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Нет соединения с интернетом","Проверьте интернет соединение!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuAboutProgDev_Click(object sender, EventArgs e)
        {
            frmDevelopers form = new frmDevelopers();
            form.ShowDialog();
        }
    }
}
