using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System;



namespace SDSY
{
    public class zapis_xlsx
    {
        public void zapis2(string name, List<double> liczby, int kolumny, string sciezka_zapisu)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook plik = app.Workbooks.Open(Directory.GetCurrentDirectory() + "/obszar_roboczy.xlsx");
                Excel.Worksheet arkusz = null;
                foreach (Excel.Worksheet shit in plik.Sheets)
                {
                    if (shit.Name.Equals("Arkusz1"))
                    {
                        arkusz = shit;
                        break;
                    }
                }
                arkusz.Cells[1, 1].value = "t [ ]";
                arkusz.Cells[1, 2].value = "U [V]";
                if (kolumny > 2)
                    for (int i = 3; i < kolumny + 1; i++)
                    {
                        arkusz.Cells[1, i].value = "U [V]";
                    }

                int wiersz = 2;
                for (int i = 0; i < liczby.Count - 3; i += kolumny)
                {
                    Form1.progress2++;
                    for (int j = 1; j < kolumny + 1; j++)
                    {
                        arkusz.Cells[wiersz, j].value = liczby[i + j - 1];

                    }
                    wiersz++;
                    if (Form1.przerwanie == 1)
                        break;
                }
                wiersz = 2;
                if (Form1.przerwanie != 1)
                {
                    plik.SaveAs(sciezka_zapisu+"/" + name + " - przerobione" + ".xlsx");
                    plik.Close();
                    kill_process();
                    plik = null;
                    arkusz = null;
                    app = null;
                }
                else
                    kill_process();

            }
            catch(Exception e)
            {
                Form1.przerwanie = 1;
            }

        }

        private void kill_process()
        {
            Process[] Excel = Process.GetProcessesByName("Excel");
            foreach (Process CurrentExcel in Excel)
            {
                CurrentExcel.Kill();
            }
        }
    }
}