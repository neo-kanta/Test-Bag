using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TESTBAG.NPOI_Classes
{
    public class CsvFile
    {
        private const int MaxRowsPerSheet = 100;
        private static readonly string[] HeaderOpen = { "No.", "Time", "Voltage", "AVG Voltage", "Current" };
        private static readonly string[] ExportHeaders = { "Time", "Voltage", "AVG Voltage", "Current" };

        public ListView DataPlotListView { get; }

        public CsvFile(ListView listNpoi)
        {
            DataPlotListView = listNpoi ?? throw new ArgumentNullException(nameof(listNpoi));
        }

        public void OpenGraphFile()
        {
            using (var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            })
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    LoadWorkbookToListView(openFileDialog.FileName);
                    TryParseNumericColumns();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}");
                }
            }
        }

        public void SaveGraphFile()
        {
            using (var saveGraphFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            })
            {
                if (saveGraphFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    var filePath = BuildTimestampedPath(saveGraphFileDialog.FileName);
                    SaveListViewToWorkbook(filePath);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occurred while trying to save the file: {ex.Message}");
                }
            }
        }

        private void LoadWorkbookToListView(string filePath)
        {
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var workbook = new XSSFWorkbook(file);
                DataPlotListView.Items.Clear();

                for (int i = 0; i < HeaderOpen.Length && i < DataPlotListView.Columns.Count; i++)
                {
                    DataPlotListView.Columns[i].Text = HeaderOpen[i];
                }

                var sequence = 1;
                for (var sheetIndex = 0; sheetIndex < workbook.NumberOfSheets; sheetIndex++)
                {
                    var sheet = workbook.GetSheetAt(sheetIndex);
                    for (var rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
                    {
                        var row = sheet.GetRow(rowIndex);
                        if (row == null)
                        {
                            continue;
                        }

                        var item = new ListViewItem(sequence.ToString(CultureInfo.InvariantCulture));
                        item.SubItems.Add(GetCellText(row, 0));
                        item.SubItems.Add(GetCellText(row, 1));
                        item.SubItems.Add(GetCellText(row, 2));
                        item.SubItems.Add(GetCellText(row, 3));
                        DataPlotListView.Items.Add(item);
                        sequence++;
                    }
                }
            }
        }

        private static string GetCellText(IRow row, int cellIndex)
        {
            return row.GetCell(cellIndex)?.ToString() ?? string.Empty;
        }

        private void TryParseNumericColumns()
        {
            var openFileVoltageList = new List<double>();
            var openFileMovingAverageList = new List<double>();
            var openFileCurrentList = new List<double>();

            foreach (ListViewItem item in DataPlotListView.Items)
            {
                TryAddDouble(item.SubItems, 2, openFileVoltageList);
                TryAddDouble(item.SubItems, 3, openFileMovingAverageList);
                TryAddDouble(item.SubItems, 4, openFileCurrentList);
            }
        }

        private static void TryAddDouble(ListView.ListViewSubItemCollection subItems, int index, ICollection<double> destination)
        {
            if (index >= subItems.Count)
            {
                return;
            }

            if (double.TryParse(subItems[index].Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var value) ||
                double.TryParse(subItems[index].Text, NumberStyles.Any, CultureInfo.CurrentCulture, out value))
            {
                destination.Add(value);
            }
        }

        private static string BuildTimestampedPath(string originalPath)
        {
            var extension = Path.GetExtension(originalPath);
            var directory = Path.GetDirectoryName(originalPath) ?? string.Empty;
            var filename = Path.GetFileNameWithoutExtension(originalPath);
            var timestamp = DateTime.Now.ToString("yyyy-MMMM-dddd_HH-mm-ss", CultureInfo.InvariantCulture);
            return Path.Combine(directory, $"{filename}_{timestamp}{extension}");
        }

        private void SaveListViewToWorkbook(string filePath)
        {
            using (var file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                var sheet = workbook.CreateSheet("IV-Plot1");
                var rowIndex = 0;
                var sheetCount = 2;

                WriteHeaders(sheet, rowIndex);
                rowIndex++;

                foreach (ListViewItem item in DataPlotListView.Items)
                {
                    if (rowIndex % MaxRowsPerSheet == 0)
                    {
                        sheet = workbook.CreateSheet("IV-Plot" + sheetCount++);
                        rowIndex = 0;
                        WriteHeaders(sheet, rowIndex);
                        rowIndex++;
                    }

                    var row = sheet.CreateRow(rowIndex);
                    row.CreateCell(0).SetCellValue(GetSubItemText(item, 1));
                    row.CreateCell(1).SetCellValue(GetSubItemText(item, 2));
                    row.CreateCell(2).SetCellValue(GetSubItemText(item, 3));
                    row.CreateCell(3).SetCellValue(GetSubItemText(item, 4));
                    rowIndex++;
                }

                for (var i = 0; i < ExportHeaders.Length; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                workbook.Write(file, true);
            }
        }

        private static string GetSubItemText(ListViewItem item, int index)
        {
            return index < item.SubItems.Count ? item.SubItems[index].Text : string.Empty;
        }

        private static void WriteHeaders(ISheet sheet, int rowIndex)
        {
            var row = sheet.CreateRow(rowIndex);
            for (var i = 0; i < ExportHeaders.Length; i++)
            {
                row.CreateCell(i).SetCellValue(ExportHeaders[i]);
            }
        }
    }
}
