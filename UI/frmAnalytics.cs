using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsFinanseSystem.BusinessLogic;

namespace WindowsFormsFinanseSystem.UI
{
    public partial class frmAnalytics : Form
    {
        private decimal _income;
        private decimal _expenses;

        public frmAnalytics()
        {
            decimal[] diag = Analytics.Diagram();
            _income = diag[0];
            _expenses = diag[1];
            InitializeComponent();
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Axis ax = new Axis();
            ax.Title = "Доходы";
            Axis ay = new Axis();
            ay.Title = "Расходы";
            chart1.ChartAreas[0].AxisX = ax;
            chart1.ChartAreas[0].AxisY = ay;
            chart1.Series[0].Points.AddXY("Доходы",_income);
            chart1.Series[0].Points.AddXY("Расходы",_expenses);
        }
    }
}
