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
    public partial class frmBills : Form
    {
        public frmBills()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmAddBills form = new frmAddBills();
            string str = $"{form.ContextName}\t{form.ContextComments}\t{form.ContextBalance} руб.";
            form.ShowDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {

               // dataGridViewCash.Columns.Add
                    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddBills form = new frmAddBills();
            form.ShowDialog();
        }

        private void btnDeleteBills_Click(object sender, EventArgs e)
        {
            int a = dataGridViewCash.CurrentRow.Index;
            dataGridViewCash.Rows.Remove(dataGridViewCash.Rows[a]);
        }
    }
}
