using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using WindowsFormsFinanseSystem.UI;



namespace WindowsFormsFinanseSystem.BusinessLogic
{
    static class Export
    {
        /// <summary>
        /// Экспортирует DataGridView в Excel
        /// </summary>
        /// <param name="dgvTablGeneral">DataGridView Transaction</param>
        public static void ExportDGVTransactionToExel(DataGridView dgvTablGeneral)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            ExcelApp.Cells[1, 1] = "Дата";
            ExcelApp.Cells[1, 2] = "Сумма";
            ExcelApp.Cells[1, 3] = "Категория";
            ExcelApp.Cells[1, 4] = "Член семьи";
            ExcelApp.Cells[1, 5] = "Комментарий";

            for (int i = 0; i < dgvTablGeneral.ColumnCount; i++)
            {
                for (int j = 0; j < dgvTablGeneral.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dgvTablGeneral[i, j].Value).ToString();
                }
            }

            ExcelApp.Columns.AutoFit();
            ExcelApp.Visible = true;
        }
        /// <summary>
        /// Экспортирует DataGridView в Excel
        /// </summary>
        /// <param name="dgvCredits">DataGridView Credit</param>
        public static void ExportDGVCreditsToExel(DataGridView dgvCredits)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            ExcelApp.Cells[1, 1] = "Месяц";
            ExcelApp.Cells[1, 2] = "Платеж";
            ExcelApp.Cells[1, 3] = "Проценты";
            ExcelApp.Cells[1, 4] = "Остаток по кредиту";

            for (int i = 0; i < dgvCredits.ColumnCount; i++)
            {
                for (int j = 0; j < dgvCredits.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dgvCredits[i, j].Value).ToString();
                }
            }

            ExcelApp.Columns.AutoFit();
            ExcelApp.Visible = true;
        }
    }
}
