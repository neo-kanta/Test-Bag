using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace TESTBAG.NPOI_Classes
{
    public class CsvFile
    {
        public ListView _listDataPlot { get; set; }
        public CsvFile(ListView listNpoi)
        {
            _listDataPlot = listNpoi;
        }
        public void OpenGraphFile()
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int listSequence = 1;
                try
                {
                    using (var file = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        var workbook = new XSSFWorkbook(file);
                        _listDataPlot.Items.Clear();
                        string[] headerOpen = { "No.", "Time", "Voltage", "AVG Voltage", "Current" };
                        for (int hValue = 0; hValue < headerOpen.Length; hValue++)
                        {
                            _listDataPlot.Columns[hValue].Text = headerOpen[hValue];
                        }
                        for (int wValue = 0; wValue < workbook.NumberOfSheets; wValue++)
                        {
                            var sheet = workbook.GetSheetAt(wValue);
                            for (int row = 1; row <= sheet.LastRowNum; row++)
                            {
                                var currentRow = sheet.GetRow(row);
                                var lvi = new ListViewItem();
                                lvi.Text = listSequence.ToString();
                                lvi.SubItems.Add(currentRow.GetCell(0).ToString());
                                lvi.SubItems.Add(currentRow.GetCell(1).ToString());
                                lvi.SubItems.Add(currentRow.GetCell(2).ToString());
                                lvi.SubItems.Add(currentRow.GetCell(3).ToString());
                                _listDataPlot.Items.Add(lvi);
                                listSequence++;
                            }
                        }
                        if (openFileDialog.CheckFileExists)
                        {
                            List<double> openFileVoltageList = new List<double>();
                            List<double> openFileMovingAverageList = new List<double>();
                            List<double> openFileCurrentList = new List<double>();
                            for (int readOpenFile = 0; readOpenFile < _listDataPlot.Items.Count; readOpenFile++)
                            {
                                openFileVoltageList.Add(double.Parse(_listDataPlot.Items[readOpenFile].SubItems[2].Text));
                                openFileMovingAverageList.Add(double.Parse(_listDataPlot.Items[readOpenFile].SubItems[3].Text));
                                openFileCurrentList.Add(double.Parse(_listDataPlot.Items[readOpenFile].SubItems[4].Text));
                            }

                        }
                    }
                }
                catch (IOException ex) { MessageBox.Show($"An error occurred while trying to open the file:  " + ex.Message); }
                finally { openFileDialog.Dispose(); }
            }
        }

        public void SaveGraphFile()
        {
            System.Windows.Forms.SaveFileDialog saveGraphFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveGraphFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveGraphFileDialog.FilterIndex = 1;
            saveGraphFileDialog.RestoreDirectory = true;
            try
            {
                if (saveGraphFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int MaxRowsPerSheet = 100;
                    int sheetCount = 2;
                    string filePath = saveGraphFileDialog.FileName;
                    string extension = Path.GetExtension(filePath);
                    string[] headers = { "Time", "Voltage", "AVG Voltage", "Current" };
                    DateTime currentDate = DateTime.Now;
                    string formattedDate = currentDate.ToString("yyyy-MMMM-dddd_HH-mm-ss");
                    filePath = Path.GetDirectoryName(filePath) + "//" + Path.GetFileNameWithoutExtension(filePath) + "_" + formattedDate + extension;

                    if (extension == ".csv")
                    {
                        using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            IWorkbook workbook = new XSSFWorkbook();
                            ICellStyle cellStyle = workbook.CreateCellStyle();
                            IDataFormat format = workbook.CreateDataFormat();
                            cellStyle.DataFormat = format.GetFormat("@");
                            ISheet sheet = workbook.CreateSheet($"IV-Plot1");
                            int rowIndex = 0;
                            string sheetName;
                            IRow row = sheet.CreateRow(rowIndex);
                            rowIndex++;

                            for (int i = 0; i < headers.Length; i++)
                            {
                                row.CreateCell(i).SetCellValue(headers[i]);
                            }
                            foreach (ListViewItem item in _listDataPlot.Items)
                            {
                                if (rowIndex % MaxRowsPerSheet == 0)
                                {
                                    sheetName = "IV-Plot" + sheetCount++;
                                    sheet = workbook.CreateSheet(sheetName);
                                    rowIndex = 0;
                                    row = sheet.CreateRow(rowIndex);
                                    for (int i = 0; i < headers.Length; i++)
                                    {
                                        row.CreateCell(i).SetCellValue(headers[i]);
                                    }
                                    rowIndex++;
                                }
                                row = sheet.CreateRow(rowIndex);
                                row.CreateCell(0).SetCellValue(item.SubItems[(1)].Text.ToString()); // - - - Time - - - //
                                row.CreateCell(1).SetCellValue(item.SubItems[2].Text); // - - - Voltage - - - //
                                row.CreateCell(2).SetCellValue(item.SubItems[3].Text); // - - - Moving Average Voltage - - - //
                                row.CreateCell(3).SetCellValue(item.SubItems[4].Text); // - - - Current - - - //
                                rowIndex++;
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                sheet.AutoSizeColumn(i);
                            }
                            workbook.Write(file, true);
                            file.Close();
                        }
                    }
                    else if (extension == ".xlsx")
                    {
                        using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            IWorkbook workbook = new XSSFWorkbook();
                            ICellStyle cellStyle = workbook.CreateCellStyle();
                            IDataFormat format = workbook.CreateDataFormat();
                            cellStyle.DataFormat = format.GetFormat("@");
                            ISheet sheet = workbook.CreateSheet($"IV-Plot1");
                            int rowIndex = 0;
                            string sheetName;
                            IRow row = sheet.CreateRow(rowIndex);
                            rowIndex++;

                            for (int i = 0; i < headers.Length; i++)
                            {
                                row.CreateCell(i).SetCellValue(headers[i]);
                            }
                            foreach (ListViewItem item in _listDataPlot.Items)
                            {
                                if (rowIndex % MaxRowsPerSheet == 0)
                                {
                                    sheetName = "IV-Plot" + sheetCount++;
                                    sheet = workbook.CreateSheet(sheetName);
                                    rowIndex = 0;
                                    row = sheet.CreateRow(rowIndex);
                                    for (int i = 0; i < headers.Length; i++)
                                    {
                                        row.CreateCell(i).SetCellValue(headers[i]);
                                    }
                                    rowIndex++;
                                }
                                row = sheet.CreateRow(rowIndex);
                                row.CreateCell(0).SetCellValue(item.SubItems[(1)].Text.ToString()); // - - - Time - - - //
                                row.CreateCell(1).SetCellValue(item.SubItems[2].Text); // - - - Voltage - - - //
                                row.CreateCell(2).SetCellValue(item.SubItems[3].Text); // - - - Moving Average Voltage - - - //
                                row.CreateCell(3).SetCellValue(item.SubItems[4].Text); // - - - Current - - - //
                                rowIndex++;
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                sheet.AutoSizeColumn(i);
                            }
                            workbook.Write(file, true);

                        }
                    }
                }
            }
            catch (IOException ex) { MessageBox.Show($"An error occurred while trying to open the file:  " + ex.Message); }
            finally { saveGraphFileDialog.Dispose(); }
        }
    }
}
