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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmFamilyMember form = new frmFamilyMember();
            form.ShowDialog();
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gbButton_Enter(object sender, EventArgs e)
        {

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction form = new frmTransaction();
            form.ShowDialog();
        }

        private void rtbDebts_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbDebtsSum_TextChanged(object sender, EventArgs e)
        {

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

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
