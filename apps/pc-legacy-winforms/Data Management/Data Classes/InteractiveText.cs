using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Data_Classes
{
    public class InteractiveText : IDisposable
    {
        private frmMain mainDesk;

        private readonly Entities _context;
        public InteractiveText(frmMain form)
        {
            mainDesk = form;
            _context = new Entities();
        }

        #region SERACH DATA ---------------------------------------------------------------------------
        public void LoadProductTableData()
        {
            var selectedProductToMeasureMain = _context.PRODUCT.ToList();
            mainDesk.cboProductGroupM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.PRODUCT_GRUOP != null).
                Select(selectedGroup => selectedGroup.PRODUCT_GRUOP).Distinct().ToList();
            mainDesk.cboProductGroupM.DisplayMember = "PRODUCT_GRUOP";
            mainDesk.cboProductGroupM.Text = string.Empty;

            mainDesk.cboSeriesM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.SERIES != null).
                Select(selectedSeries => selectedSeries.SERIES).Distinct().ToList();
            mainDesk.cboSeriesM.DisplayMember = "SERIES";
            mainDesk.cboSeriesM.Text = string.Empty;

            mainDesk.cboModelM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.MODEL != null).
                Select(selectedModel => selectedModel.MODEL).Distinct().ToList();
            mainDesk.cboModelM.DisplayMember = "MODEL";
            mainDesk.cboModelM.Text = string.Empty;

            mainDesk.cboBatteryTypeM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.BATTERY_TYPE != null).
                Select(selectedBatterytype => selectedBatterytype.BATTERY_TYPE).Distinct().ToList();
            mainDesk.cboBatteryTypeM.DisplayMember = "BATTERY_TYPE";
            mainDesk.cboBatteryTypeM.Text = string.Empty;

            mainDesk.cboBatteryCapacityM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.BATTERY_CAPACITY != null).
                Select(selectedBatteryCapacity => selectedBatteryCapacity.BATTERY_CAPACITY).Distinct().ToList();
            mainDesk.cboBatteryCapacityM.DisplayMember = "BATTERY_CAPACITY";
            mainDesk.cboBatteryCapacityM.Text = string.Empty;

        }
        public async Task LoadProductTableDataAsync()
        {
            var selectedProductToMeasureMain = await _context.PRODUCT.ToListAsync();
            mainDesk.cboProductGroupM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.PRODUCT_GRUOP != null).
                Select(selectedGroup => selectedGroup.PRODUCT_GRUOP).Distinct().ToList();
            mainDesk.cboProductGroupM.DisplayMember = "PRODUCT_GRUOP";
            mainDesk.cboProductGroupM.Text = string.Empty;

            mainDesk.cboSeriesM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.SERIES != null).
                Select(selectedSeries => selectedSeries.SERIES).Distinct().ToList();
            mainDesk.cboSeriesM.DisplayMember = "SERIES";
            mainDesk.cboSeriesM.Text = string.Empty;

            mainDesk.cboModelM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.MODEL != null).
                Select(selectedModel => selectedModel.MODEL).Distinct().ToList();
            mainDesk.cboModelM.DisplayMember = "MODEL";
            mainDesk.cboModelM.Text = string.Empty;

            mainDesk.cboBatteryTypeM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.BATTERY_TYPE != null).
                Select(selectedBatterytype => selectedBatterytype.BATTERY_TYPE).Distinct().ToList();
            mainDesk.cboBatteryTypeM.DisplayMember = "BATTERY_TYPE";
            mainDesk.cboBatteryTypeM.Text = string.Empty;

            mainDesk.cboBatteryCapacityM.DataSource = selectedProductToMeasureMain.
                Where(notSelectedNull => notSelectedNull.BATTERY_CAPACITY != null).
                Select(selectedBatteryCapacity => selectedBatteryCapacity.BATTERY_CAPACITY).Distinct().ToList();
            mainDesk.cboBatteryCapacityM.DisplayMember = "BATTERY_CAPACITY";
            mainDesk.cboBatteryCapacityM.Text = string.Empty;
        }

        public void ProductGroupSearch()
        {

            string selectedProductGroup = mainDesk.cboProductGroupM.SelectedItem.ToString();
            mainDesk.cboSeriesM.DataSource = _context.PRODUCT.
                Where(seriesOfGroup => seriesOfGroup.PRODUCT_GRUOP == selectedProductGroup).
                Select(pg => pg.SERIES).Distinct().ToList();
            mainDesk.cboSeriesM.Text = string.Empty;

        }
        public void SeriesSearch()
        {

            string selectedSeries = mainDesk.cboSeriesM.SelectedItem.ToString();
            mainDesk.cboModelM.DataSource = _context.PRODUCT.
                Where(ModelOfGroup => ModelOfGroup.SERIES == selectedSeries).
                Select(pg => pg.MODEL).Distinct().ToList();
            mainDesk.cboModelM.Text = string.Empty;

        }
        public void ModelSearch()
        {

            string selectedModel = mainDesk.cboModelM.SelectedItem.ToString();
            mainDesk.cboBatteryTypeM.DataSource = _context.PRODUCT.
                Where(ModelOfGroup => ModelOfGroup.MODEL == selectedModel).
                Select(pg => pg.BATTERY_TYPE).Distinct().ToList();
            mainDesk.cboBatteryTypeM.Text = string.Empty;
            mainDesk.cboBatteryCapacityM.DataSource = _context.PRODUCT.
                Where(batteryCapacityOfGroup => batteryCapacityOfGroup.MODEL == selectedModel).
                Select(pg => pg.BATTERY_CAPACITY).Distinct().ToList();
            mainDesk.cboBatteryCapacityM.Text = string.Empty;

        }
        public void BatteryTypeSearch()
        {
            string selectedModel = mainDesk.cboModelM.SelectedItem.ToString();
            string selectedBatteryType = mainDesk.cboBatteryTypeM.SelectedItem.ToString();
            mainDesk.cboBatteryCapacityM.DataSource = _context.PRODUCT.
                Where(batteryCapacityOfGroup => batteryCapacityOfGroup.BATTERY_TYPE == selectedBatteryType && batteryCapacityOfGroup.MODEL == selectedModel).
                Select(pg => pg.BATTERY_CAPACITY).Distinct().ToList();
            mainDesk.cboBatteryCapacityM.Text = string.Empty;

        }
        #endregion SEARCH DATA .......................................................................


        #region TEXT AND COMBOBOX CONTROL ---------------------------------------------------------------------------
        public void StartNewMeasurement()
        {
            Guid jobNumberGuid = Guid.NewGuid();
            mainDesk.txtJobNumber.Text = jobNumberGuid.ToString();
            mainDesk.txtSerialNumber.Text = string.Empty;
            mainDesk.txtSerialNumber.Enabled = true;
            mainDesk.txtLot.Text = string.Empty;
            mainDesk.txtLot.Enabled = true;
            mainDesk.txtManufacDate.Text = string.Empty;
            mainDesk.txtManufacDate.Enabled = true;
            mainDesk.txtMeasureBy.Text = string.Empty;
            mainDesk.txtMeasureBy.Enabled = true;

            mainDesk.btnSubmitComment.Enabled = true;
            mainDesk.txtComment.Enabled = true;
            mainDesk.cboProductGroupM.Enabled = true;
            mainDesk.cboModelM.Enabled = true;
            mainDesk.cboSeriesM.Enabled = true;
            mainDesk.cboBatteryTypeM.Enabled = true;
            mainDesk.cboBatteryCapacityM.Enabled = true;
            mainDesk.btnSubmitMeasurement.Text = "Submit New Measurement";
            mainDesk.newMeasurementFlag = true;
        }


        public void EndCurrentMeasurement()
        {
            ClearMeasurementFields();
            if (AreProductFieldsValid() && CheckText() && !mainDesk.newMeasurementFlag)
            {
                DisableProductFields();
                EnableControlFields();
                mainDesk.NavigateRelateToProduct();
                mainDesk.btnSubmitMeasurement.Text = "New Measurement";
            }
            else if (AreProductFieldsValid() && CheckText() && mainDesk.newMeasurementFlag)
            {
                mainDesk.newMeasurementFlag = false;
                EnableControlFields();
                DisableProductFields();
                mainDesk.NavigateRelateToProduct();
                mainDesk.btnSubmitMeasurement.Text = "New Measurement";
            }
            else
            {
                EnableProductFields();
                mainDesk.btnSubmitMeasurement.Text = "Submit New Measurement";
                MessageBox.Show("Please enter the Product", "Please enter to search", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
        public void ClearMeasurementFields()
        {
            mainDesk.txtVoltageChargerMinMaxLow.Text = string.Empty;
            mainDesk.txtVoltageChargerMinMaxHigh.Text = string.Empty;
            mainDesk.txtVoltageChargerMinMaxCurrentConstant.Text = string.Empty;
            mainDesk.txtLowVoltageCutOffMinMax.Text = string.Empty;
            mainDesk.txtMeanVoltageChargerLow.Text = string.Empty;
            mainDesk.txtMeanVoltageChargerHigh.Text = string.Empty;
            mainDesk.txtMeanVoltageChargerCurrentConstant.Text = string.Empty;
            mainDesk.txtMeanVoltageCutOff.Text = string.Empty;
        }

        public bool CheckProductInput()
        {
            if (AreProductFieldsValid() && CheckText())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AreProductFieldsValid()
        {
            return !string.IsNullOrEmpty(mainDesk.cboProductGroupM.Text)
                && !string.IsNullOrEmpty(mainDesk.cboSeriesM.Text)
                && !string.IsNullOrEmpty(mainDesk.cboModelM.Text)
                && !string.IsNullOrEmpty(mainDesk.cboBatteryTypeM.Text)
                && !string.IsNullOrEmpty(mainDesk.cboBatteryCapacityM.Text);
        }
        public bool CheckText()
        {
            if (!DateTime.TryParseExact(mainDesk.txtManufacDate.Text, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime mfgDate))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void DisableProductFields()
        {
            mainDesk.txtJobNumber.Enabled = false;
            mainDesk.txtSerialNumber.Enabled = false;
            mainDesk.txtLot.Enabled = false;
            mainDesk.txtManufacDate.Enabled = false;
            mainDesk.txtMeasureBy.Enabled = false;
            mainDesk.cboProductGroupM.Enabled = false;
            mainDesk.cboModelM.Enabled = false;
            mainDesk.cboSeriesM.Enabled = false;
            mainDesk.cboBatteryTypeM.Enabled = false;
            mainDesk.cboBatteryTypeM.Enabled = false;
            mainDesk.cboBatteryCapacityM.Enabled = false;
        }

        public void EnableProductFields()
        {
            mainDesk.txtJobNumber.Enabled = true;
            mainDesk.txtSerialNumber.Enabled = true;
            mainDesk.txtLot.Enabled = true;
            mainDesk.txtManufacDate.Enabled = true;
            mainDesk.txtMeasureBy.Enabled = true;
            mainDesk.cboProductGroupM.Enabled = true;
            mainDesk.cboModelM.Enabled = true;
            mainDesk.cboSeriesM.Enabled = true;
            mainDesk.cboBatteryTypeM.Enabled = true;
            mainDesk.cboBatteryTypeM.Enabled = true;
            mainDesk.cboBatteryCapacityM.Enabled = true;
        }


        public void EnableControlFields()
        {
            mainDesk.cboManualCheck.Enabled = true;
            mainDesk.cboSelectBuffer.Enabled = true;
            mainDesk.cboSelectBuffer.DataSource = mainDesk.bufferSize;
            mainDesk.btnConnect.Enabled = true;
            mainDesk.btnSubmitComment.Enabled = true;
            mainDesk.cboManualCheck.Enabled = true;
            mainDesk.txtComment.Enabled = true;
            mainDesk.btnStart.Enabled = true;
            mainDesk.btnStop.Enabled = true;
        }
        #endregion TEXT AND COMBOBOX CONTROL ........................................................................
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}