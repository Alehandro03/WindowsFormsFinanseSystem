using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinanseSystem.UI
{
    public partial class ExchangeRates : Form
    {
        public ExchangeRates()
        {
            InitializeComponent();
            try
            {
                txtExchange.Text = ExchangeRateDollar();
                txtEuro.Text = ExchangeRateEuro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Проверьте интернет соединение!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

      private string ExchangeRateDollar()
      {
        System.Net.WebClient wc = new System.Net.WebClient();
        string Response = wc.DownloadString("https://www.cbr.ru/");
        string Rate = System.Text.RegularExpressions.Regex.Match(Response,
            @"col-xs-9 _right mono-num"">([0-9][0-9]+\,[0-9]+[0-9]+)").Groups[1].Value;
        return Rate;
        //col-xs-9 _right mono-num">73,6059
      }

      private string ExchangeRateEuro()
      {
        System.Net.WebClient wc = new System.Net.WebClient();
        string response = wc.DownloadString("https://www.banki.ru/products/currency/eur/");
        string rate = System.Text.RegularExpressions.Regex.Match(response,
            @"currency-table__large-text"">([0-9][0-9]+\,[0-9][0-9]+)").Groups[1].Value;
            //currency-table__large-text">83,12</div>
            return rate;
        }
        private void ExchangeRates_Shown(object sender, EventArgs e)
      {

      }

      private void txtExchange_TextChanged(object sender, EventArgs e)
      {
        txtExchange.Text = ExchangeRateDollar();
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
        Close();
      }

      private void txtEuro_TextChanged(object sender, EventArgs e)
      {
        txtEuro.Text = ExchangeRateEuro();
      }

        private void pbCalc_Click(object sender, EventArgs e)
        {
            frmCalc form = new frmCalc();
            form.ShowDialog();
            Close();
        }
    }
}
