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
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private string Sum()
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double num3 = num1 + num2;
            return num3.ToString();
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            txtAnswer.Text =  Sum();
        }

        private string Mult()
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double num3 = num1 * num2;
            return num3.ToString();
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = Mult();
        }
        private string Substraction()
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double num3 = num1 - num2;
            return num3.ToString();
        }
        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = Substraction();
        }
        private string Division()
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            if (num2 == 0)
            {
                throw new Exception("На ноль делить нельзя");
            }
            double num3 = num1 / num2;
            return num3.ToString();
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            { txtAnswer.Text = Division(); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "На ноль делить нельзя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string InDegree()
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double num3 = Math.Pow(num1,num2);
            return num3.ToString();
        }
        private void btnInDegree_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = InDegree();
        }
        private string Root()
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            if(num2 == 0)
            {
                throw new Exception("На ноль делить нельзя");
            }
            double num3 = Math.Sqrt(num1);
            return num3.ToString();
        }
        private void btnRoot_Click(object sender, EventArgs e)
        {
            try
            { txtAnswer.Text = Root(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "На ноль делить нельзя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
