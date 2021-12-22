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

namespace WindowsFormsFinanseSystem.UI
{
    public partial class frmCredits : Form
    {
        List<Payment> _pay; 
        public frmCredits()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Credit cred = new Credit(numSum.Value,numPercent.Value,(int)numMonth.Value);
            _pay = cred.PaymentList();
            dgvCredits.DataSource = _pay;
            dgvCredits.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Export.ExportDGVCreditsToExel(dgvCredits);
        }
    }
}
