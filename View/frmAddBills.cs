using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinanseSystem
{
    public partial class frmAddBills : Form
    {
        string _context_name;
        public string ContextName => _context_name;
        string _context_group;
        public string ContextGroup => _context_group;
        string _context_balance;
        public string ContextBalance => _context_balance;
        string _context_comments;
        public string ContextComments => _context_comments;
        public frmAddBills()
        {
            InitializeComponent();
        }

        private void gbAddBills_Enter(object sender, EventArgs e)
        {

        }

        private void pbAddBills_Click(object sender, EventArgs e)
        {
            
            frmPictureBox box = new frmPictureBox();
           
            if (box.ShowDialog() == DialogResult.OK)
            {
                pbAddBills.Image = box.ImageMyForm;
            }
          
        }

        private void frmAddBills_Load(object sender, EventArgs e)
        {
           
        }

        private void lblAddBills_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void lbAddBillsCurrency_Click(object sender, EventArgs e)
        {

        }

        private void dudCurrency_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBillsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RefreshText()
        {
            //if (_context_group == dudAddBillsGroup.Items[0])
            //{ 
                _context_name = txtbNameAddBills.Text;
                _context_balance = Convert.ToString(numupdAddBills.Value);
                _context_comments = rtbAddBillsComment.Text;
            //}  
        }


        private void btnAddBillsOK_Click(object sender, EventArgs e)
        {
            RefreshText();
            this.DialogResult = DialogResult.OK;
            Close();

            //txtbStartBalanceAddBills.Text = _context.ToString();
        }
    }
}
