using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Gestion_PDA
{
    class C_Export
    {
		public static void ExcelGenerate(DataGridView dtgPDA)
		{
            Excel.Application myexcelApplication = new Excel.Application();
			if (myexcelApplication != null)
			{
				Excel.Workbook myexcelWorkbook = myexcelApplication.Workbooks.Add();
				Excel.Worksheet myexcelWorksheet = (Excel.Worksheet)myexcelWorkbook.Sheets.Add();

				for (int i = 0; i < dtgPDA.Rows.Count - 1; i++)
				{
					myexcelWorksheet.Cells[1, 1] = "SOCIETE";
					myexcelWorksheet.Cells[1, 2] = "N° PDA";
					myexcelWorksheet.Cells[1, 3] = "IMEI";
					myexcelWorksheet.Cells[1, 4] = "S° SERIE";
					myexcelWorksheet.Cells[1, 5] = "N° TELEPHONE";
					myexcelWorksheet.Cells[1, 6] = "N° SIM";
					myexcelWorksheet.Cells[1, 7] = "PRENOM";
					myexcelWorksheet.Cells[1, 8] = "NOM";
					myexcelWorksheet.Cells[1, 9] = "TYPE";
					myexcelWorksheet.Cells[1, 10] = "PROBLEME";

					myexcelWorksheet.Cells[i + 2, 1] = dtgPDA.Rows[i].Cells[0].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 2] = dtgPDA.Rows[i].Cells[1].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 3] = dtgPDA.Rows[i].Cells[2].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 4] = dtgPDA.Rows[i].Cells[3].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 5] = dtgPDA.Rows[i].Cells[4].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 6] = dtgPDA.Rows[i].Cells[5].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 7] = dtgPDA.Rows[i].Cells[6].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 8] = dtgPDA.Rows[i].Cells[7].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 9] = dtgPDA.Rows[i].Cells[8].Value.ToString();
					myexcelWorksheet.Cells[i + 2, 10] = dtgPDA.Rows[i].Cells[9].Value.ToString();
				}

				myexcelWorkbook.Close();
				myexcelApplication.Quit();
			}
		}
	}
}
