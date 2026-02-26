using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.Data_Classes;
using TESTBAG.Data_Management.Database;
using TESTBAG.Protocol;
using TESTBAG.Zed;

namespace TESTBAG.Data_Management
{
    public partial class frmDataManage : Form
    {
        private readonly frmMain _mainDesk;
        private readonly SaveData _saveData;
        private NevigateProduct _nevigateProduct;
        private ZedGraphManager _zedgraphManager;
        public frmDataManage(frmMain mainDesk, SaveData saveData)
        {
            InitializeComponent();
            _mainDesk = mainDesk;
            _saveData = saveData;
            _nevigateProduct = _mainDesk._nevigateProductMain;
            InitGridView();
            _zedgraphManager = new ZedGraphManager(this._mainDesk.zedPlot);
        }
        private async void InitGridView()
        {
            try
            {
                SaveData loadGrid = new SaveData(_mainDesk);
                await loadGrid.LoadDataGridViewAsync(gridProduct, gridSpecifications, gridHistory);
            }
            catch (SqlException ex) { MessageBox.Show("A database error occurred: " + ex.Message, "Error"); }
        }
        private void frmDataManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurveTypeConfiguration.ResetToApplicationSettings();
        }

        #region PRODUCT ------------------------------------------------------------------------------
        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            gridProduct.Refresh();
            InitGridView();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            mdiAddProduct frmProduct = new mdiAddProduct();
            frmProduct.ShowDialog();
        }
        private void gridProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedProductRow = gridProduct.Rows[e.RowIndex];
                int idProduct = Convert.ToInt32(clickedProductRow.Cells["gridProductId"].Value);

                mdiEditProduct frmEditProduct = new mdiEditProduct(idProduct);
                frmEditProduct.ShowDialog();
            }
        }
        #endregion PRODUCT ........................................................................


        #region SPECIFICATIONS ------------------------------------------------------------------------------
        private void btnRefreshSpecifications_Click(object sender, EventArgs e)
        {
            gridSpecifications.Refresh();
            InitGridView();
        }

        private void btnAddSpecifications_Click(object sender, EventArgs e)
        {
            mdiAddSpecifications frmSpecifications = new mdiAddSpecifications();
            frmSpecifications.ShowDialog();
        }
        private void mASTER_SPECIFICATIONSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = gridSpecifications.Rows[e.RowIndex];
                int id = Convert.ToInt32(clickedRow.Cells["gridSpecId"].Value);

                mdiEdiSpecifications frmEditSpecifications = new mdiEdiSpecifications(id);
                frmEditSpecifications.ShowDialog();
            }
        }
        #endregion SPECIFICATIONS ........................................................................


        #region MEASURE HISTORY (MEASUREMENT_PRODUCT)--------------------------------------------------------
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridHistory.Refresh();
            InitGridView();
        }
        private async Task UpdateListDataPlot(ListView listDataPlot, List<RAW_MEASUREMENT> rawData,
                                              double lowMinCharge, double lowMaxCharge,
                                              double highMinCharge, double highMaxCharge,
                                              double cutoffMin, double cutoffMax)
        {
            await Task.Run(() =>
            {

                double[] batteryHighSpecifications = { highMinCharge, highMaxCharge };
                double[] batteryLowSpecifications = { lowMinCharge, lowMaxCharge };
                double[] batteryCutOffSpecifications = { cutoffMin, cutoffMax };


                var groupedData = rawData.GroupBy(x => x.TOTAL_SECONDS).ToList();
                var items = new ListViewItem[groupedData.Count];

                Parallel.For(0, groupedData.Count, i =>
                {
                    var group = groupedData[i];
                    double? time = group.Key;
                    double voltage = group.FirstOrDefault(x => x.MEASUREMENT_NAME == "Voltage")?.MEASUREMENT_VALUE ?? 0;
                    double current = group.FirstOrDefault(x => x.MEASUREMENT_NAME == "Current")?.MEASUREMENT_VALUE ?? 0;
                    double movingAverage = group.FirstOrDefault(x => x.MEASUREMENT_NAME == "Average_Voltage")?.MEASUREMENT_VALUE ?? 0;
                    double currentAdc = group.FirstOrDefault(x => x.MEASUREMENT_NAME == "Current_ADC")?.MEASUREMENT_VALUE ?? 0;
                    double derivativeVoltage = group.First(x => x.MEASUREMENT_NAME == "Derivative_Voltage")?.MEASUREMENT_VALUE ?? 0;

                    var item = new ListViewItem(new[]
                    {
                        (i + 1).ToString(),
                        time.ToString(),
                        voltage.ToString(),
                        movingAverage.ToString(),
                        current.ToString(),
                        currentAdc.ToString(),
                        derivativeVoltage.ToString()

                    });
                    items[i] = item;
                });

                listDataPlot.Invoke((Action)(() =>
                {
                    listDataPlot.BeginUpdate();
                    listDataPlot.Items.Clear();
                    listDataPlot.Items.AddRange(items);
                    listDataPlot.EndUpdate();

                }));

                List<Tuple<double, double[], bool>> plotData = new List<Tuple<double, double[], bool>>();
                List<Tuple<double>> specData = new List<Tuple<double>>();

                foreach (var item in items)
                {
                    double time = double.Parse(item.SubItems[1].Text);
                    double voltage = double.Parse(item.SubItems[2].Text);
                    double movingAverage = double.Parse(item.SubItems[3].Text);
                    double current = double.Parse(item.SubItems[4].Text);

                    double[] listViewData = { voltage, movingAverage, current };
                    plotData.Add(Tuple.Create(time, listViewData, false));
                    specData.Add(Tuple.Create(time));
                }
                _mainDesk.zedPlot.Invoke((Action)(() =>
                {
                    _zedgraphManager.UpdateGroupRollingPointPairList(CurveTypeConfiguration.DcCurveTypes, _mainDesk.listDataPlot.Items.Count);
                    _zedgraphManager.UpdateGroupRollingPointPairList(CurveTypeConfiguration.HighChargeMinMaxTypes, _mainDesk.listDataPlot.Items.Count);
                    _zedgraphManager.UpdateGroupRollingPointPairList(CurveTypeConfiguration.LowChargeMinMaxTypes, _mainDesk.listDataPlot.Items.Count);
                    _zedgraphManager.UpdateGroupRollingPointPairList(CurveTypeConfiguration.LowCutOffMinMaxTypes, _mainDesk.listDataPlot.Items.Count);

                    _zedgraphManager.UpdateConfigureGraph();
                    _zedgraphManager.PlotListData(CurveTypeConfiguration.DcCurveTypes, plotData);
                    _zedgraphManager.PlotListSpecifications(CurveTypeConfiguration.HighChargeMinMaxTypes, specData, batteryHighSpecifications);
                    _zedgraphManager.PlotListSpecifications(CurveTypeConfiguration.LowChargeMinMaxTypes, specData, batteryLowSpecifications);
                    _zedgraphManager.PlotListSpecifications(CurveTypeConfiguration.LowCutOffMinMaxTypes, specData, batteryCutOffSpecifications);
                    _zedgraphManager.RefreshGraph();
                }));
            });

        }
        private async void gridHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = gridHistory.Rows[e.RowIndex];
                int id = Convert.ToInt32(clickedRow.Cells["gridHistoryId"].Value);
                int spec = Convert.ToInt32(clickedRow.Cells["productId"].Value);

                var maxValue = _nevigateProduct.SearchMaxValue(spec);
                var minValue = _nevigateProduct.SearchMinValue(spec);
                var prefferedValue = _nevigateProduct.SearchPreferredValue(spec);

                var specValues = DataPattern.GetSpecValue(minValue, maxValue, prefferedValue);
                _mainDesk.txtVoltageChargerMinMaxLow.Text = specValues.Item1;
                _mainDesk.txtMeanVoltageChargerLow.Text = specValues.Item2;
                _mainDesk.txtVoltageChargerMinMaxHigh.Text = specValues.Item3;
                _mainDesk.txtMeanVoltageChargerHigh.Text = specValues.Item4;
                _mainDesk.txtVoltageChargerMinMaxCurrentConstant.Text = specValues.Item5;
                _mainDesk.txtMeanVoltageChargerCurrentConstant.Text = specValues.Item6;
                _mainDesk.txtLowVoltageCutOffMinMax.Text = specValues.Item7;
                _mainDesk.txtMeanVoltageCutOff.Text = specValues.Item8;

                var low = DataPattern.GetMinMaxMean(_mainDesk.txtVoltageChargerMinMaxLow.Text, _mainDesk.txtMeanVoltageChargerLow.Text);
                double lowMinCharge = low.minCon;
                double lowMaxCharge = low.maxCon;

                var high = DataPattern.GetMinMaxMean(_mainDesk.txtVoltageChargerMinMaxHigh.Text, _mainDesk.txtMeanVoltageChargerHigh.Text);
                double highMinCharge = high.minCon;
                double highMaxCharge = high.maxCon;

                var currentConstant = DataPattern.GetMinMaxMean(_mainDesk.txtVoltageChargerMinMaxCurrentConstant.Text, _mainDesk.txtMeanVoltageChargerCurrentConstant.Text);
                double currentConstantMin = currentConstant.minCon;
                double currentConstantMax = currentConstant.maxCon;

                var cutOff = DataPattern.GetMinMaxMean(_mainDesk.txtLowVoltageCutOffMinMax.Text, _mainDesk.txtMeanVoltageCutOff.Text);
                double cutoffMin = cutOff.minCon;
                double cutoffMax = cutOff.maxCon;

                NevigateProduct navPro = new NevigateProduct(id);
                navPro.FindRawId(id);
                var rawData = navPro.GetRawMeasurementData(id);
                _zedgraphManager.Clear();
                await UpdateListDataPlot(listDataPlot: _mainDesk.listDataPlot, rawData,
                                         lowMinCharge, lowMaxCharge,
                                         highMinCharge, highMaxCharge,
                                         cutoffMin, cutoffMax);
                this.Close();
            }
        }
        #endregion MEASURE HISTORY (MEASUREMENT_PRODUCT) ...................................................
    }
}
