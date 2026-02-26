using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.Data_Classes;
using TESTBAG.Data_Management;
using TESTBAG.Data_Management.Database;
using TESTBAG.Log;
using TESTBAG.NPOI_Classes;
using TESTBAG.ProductQuality;
using TESTBAG.Protocol;
using TESTBAG.Zed;
using Windows.Networking.NetworkOperators;
using ZedGraph;

namespace TESTBAG
{
    public partial class frmMain : Form
    {
        #region Main Form ---------------------------------------------------------------------------

        private CancellationTokenSource _cts;
        private HttpWiFiClient _httpWiFiClient;
        private readonly Dictionary<string, string> _esp32Devices;
        private UdpWiFiClient _udpWiFiClient;
        private ArduinoSerialConnection _serialPortCon;
        private SaveData _saveData;
        private InteractiveText interText;
        private NevigateSpecification _navSpec;
        public NevigateProduct _nevigateProductMain;
        private ZedGraphManager _zedGraphManager;
        private RegistryManager _registryManager = new RegistryManager(Application.ProductName);
        private AlternativeCurrentState currentState;
        private ChargingSystem chargingSystem;

        int pointPairCount;

        Point previousLocation;
        bool isMouseDown = false;

        public frmMain()
        {
            InitializeComponent();
            //InitHotSpot(txtSSID.Text, txtPassword.Text);
            errDisplay.Clear();
            okDisplay.Clear();

            // - - - - - - - - - - - - - SELECT PORT ARDUINO - - - - - - - - - - - - - - //
            cboSelectBuffer.Enabled = false;
            // - - - - - - - - - - - - - USER CONTROL COMBO BOX - - - - - - - - - - - - - //
            //InitData();
            _nevigateProductMain = new NevigateProduct(cboProductGroupM.SelectedItem?.ToString(),
                                          cboSeriesM.SelectedItem?.ToString(),
                                          cboModelM.SelectedItem?.ToString(),
                                          cboBatteryTypeM.SelectedItem?.ToString(),
                                          cboBatteryCapacityM.SelectedItem?.ToString());
            InitZed();
            InitProtocol();
            _esp32Devices = new Dictionary<string, string>();

            _saveData = new SaveData(this);
            interText = new InteractiveText(this);
            _ = interText.LoadProductTableDataAsync();
            OpenMobileHotspotSettings();
        }
        private void hotSpot_Click(object sender, EventArgs e)
        {

        }
        public void OpenMobileHotspotSettings()
        {
            Process.Start(new ProcessStartInfo("ms-settings:network-mobilehotspot") { UseShellExecute = true });
        }
        private async void InitHotSpot(String ssid, String password)
        {
            try
            {
                await ProvisionHotspotAsync(ssid, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async Task ProvisionHotspotAsync(string ssid, string password)
        {
            string xmlConfig = $@"
                <CarrierProvisioning>
                    <MSDM>
                        <slice>
                            <sliceId>0</sliceId>
                            <ssid>{ssid}</ssid>
                            <authentication>1</authentication>
                            <encryption>3</encryption>
                            <keyMaterial>{password}</keyMaterial>
                            <keyProvided>true</keyProvided>
                            <isAutoConnectable>true</isAutoConnectable>
                            <isHidden>false</isHidden>
                        </slice>
                    </MSDM>
                </CarrierProvisioning>";

            IReadOnlyList<string> networkAccIds = MobileBroadbandAccount.AvailableNetworkAccountIds;
            if (networkAccIds.Count > 0)
            {
                string networkAccountId = networkAccIds[0];
                ProvisioningAgent provisioningAgent = ProvisioningAgent.CreateFromNetworkAccountId(networkAccountId);
                ProvisionFromXmlDocumentResults results = await provisioningAgent.ProvisionFromXmlDocumentAsync(xmlConfig);

                if (results.AllElementsProvisioned)
                {
                    MessageBox.Show("Hotspot was provisioned successfully");
                }
                else
                {
                    MessageBox.Show("Failed to provision hotspot: " + results.ProvisionResultsXml);
                }
            }
            else
            {
                MessageBox.Show("No network account IDs available");
            }
        }

        private void InitProtocol()
        {
            _udpWiFiClient = new UdpWiFiClient(this);
            _udpWiFiClient.UdpWiFiDataReceived += UdpWiFiDataReceivedHandler;

            HttpClient httpClient = new HttpClient();
            _httpWiFiClient = new HttpWiFiClient(httpClient);
            _httpWiFiClient.ConnectionStatusChanged += HandleConnectionStatusChanged;
            //_httpWiFiClient.PinStatusCheck += HttpWiFiClient_PinStatusCheck;
            _httpWiFiClient.CheckAllStatus += HttpWiFiClient_CheckAllStatus;

            _serialPortCon = new ArduinoSerialConnection();
            _serialPortCon.NanoDataReceived += _serialPortCon_NanoDataReceived;
        }
        private void InitZed()
        {
            _zedGraphManager = new ZedGraphManager(zedPlot);
            _zedGraphManager.UpdateConfigureGraph();
            _zedGraphManager.SetCurveVisibility(CurveType.VoltageDc, false);
            zedPlot.Invalidate();
        }

        private void InitData()
        {
            _nevigateProductMain = new NevigateProduct(cboProductGroupM.SelectedItem?.ToString(),
                                                      cboSeriesM.SelectedItem?.ToString(),
                                                      cboModelM.SelectedItem?.ToString(),
                                                      cboBatteryTypeM.SelectedItem?.ToString(),
                                                      cboBatteryCapacityM.SelectedItem?.ToString());
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowSizeIcon();


            var combinedControlsToLoad = new List<Tuple<Control, Control>> { Tuple.Create<Control, Control>(txtSSID, txtPassword) };
            _registryManager.LoadCombinedControlsData(combinedControlsToLoad, "|");
        }
        // - - - - - - DISABLE X BUTTON - - - - - - - //
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (var closingContext = new Entities())
                {
                    closingContext.Dispose();
                }
                _httpWiFiClient?.Dispose();
                _udpWiFiClient?.Dispose();
                _serialPortCon?.Disconnect();
                _serialPortCon?.Dispose();
                _cts?.Dispose();

                var combinedControlsToSave = new List<Tuple<Control, Control>> { Tuple.Create<Control, Control>(txtSSID, txtPassword) };
                _registryManager.SaveCombinedControlsData(combinedControlsToSave, "|");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        #endregion Main Form ........................................................................


        #region CONTROL_DATA_ENTRY ------------------------------------------------------------------------------
        int measureProductIdPublic;
        //public int MeasureProductId { get { return measureProductId; } }
        // - - - - - - - - - - - - - - OPEN PRODUCT MANAGEMENT - - - - - - - - - - - - - //
        private void productMangamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDataManage masterForm = new frmDataManage(this, _saveData);
                masterForm.Show();
            }
            catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
        }
        private void cboProductGroupM_SelectedIndexChanged(object sender, EventArgs e)
        {
            interText.ProductGroupSearch();
        }

        private void cboSeriesM_SelectedIndexChanged(object sender, EventArgs e)
        {
            interText.SeriesSearch();
        }

        private void cboModelM_SelectedIndexChanged(object sender, EventArgs e)
        {
            interText.ModelSearch();
        }
        private void cboBatteryTypeM_SelectedIndexChanged(object sender, EventArgs e)
        {
            interText.BatteryTypeSearch();
        }

        public bool newMeasurementFlag = false; //FOR THE FIRST TIME THE USER CLICK
        private void btnSubmitMeasurement_Click(object sender, EventArgs e)
        {
            try
            {
                if (!newMeasurementFlag)
                {
                    interText.StartNewMeasurement();
                }
                else
                {
                    interText.EndCurrentMeasurement();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Validation errors occurred while saving data: {ex.Message.Select(x => x.ToString())}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                MessageBox.Show($"Validation errors occurred while saving data: {errorMessages}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Cannot update the Measurement ID" + ex.Message, "Cannot Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private Dictionary<string, (double minCon, double maxCon, bool success)> minMaxMeanResults = new Dictionary<string, (double minCon, double maxCon, bool success)>();

        public void NavigateRelateToProduct()
        {
            _nevigateProductMain = new NevigateProduct(cboProductGroupM.SelectedItem?.ToString(),
                              cboSeriesM.SelectedItem?.ToString(),
                              cboModelM.SelectedItem?.ToString(),
                              cboBatteryTypeM.SelectedItem?.ToString(),
                              cboBatteryCapacityM.SelectedItem?.ToString());

            int productId = _nevigateProductMain.FindProductId();
            if (productId <= 0)
            {
                MessageBox.Show("Invalid product selection. Please select valid product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var stageText = _nevigateProductMain.FindStageText();
            var maxValue = _nevigateProductMain.FindMaxValue();
            var minValue = _nevigateProductMain.FindMinValue();
            var prefferedValue = _nevigateProductMain.FindPreferredValue();

            if (!DateTime.TryParseExact(txtManufacDate.Text, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime mfgDate))
            {
                MessageBox.Show("Invalid manufacture date. Please enter valid date in the format of ddMMyy such as 130719.", "Error"
                    , MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            try
            {
                txtComment.Text = "No Comment";
                SaveData gg = new SaveData(this);
                gg.FirstTimeSaveMeasurementProduct(productId, txtJobNumber.Text, txtSerialNumber.Text, txtManufacDate.Text, txtLot.Text, txtAutoCheck.Text, txtMeasureBy.Text, txtComment.Text);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Validation errors occurred while saving data: {ex.Message.Select(x => x.ToString())}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                MessageBox.Show($"Validation errors occurred while saving data: {errorMessages}", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Cannot update the Measurement ID" + ex.Message, "Cannot Update Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            var specStage = DataPattern.GetStageReg(stageText);
            var specValues = DataPattern.GetSpecValue(minValue, maxValue, prefferedValue);
            txtVoltageChargerMinMaxLow.Text = specValues.Item1;
            txtMeanVoltageChargerLow.Text = specValues.Item2;
            txtVoltageChargerMinMaxHigh.Text = specValues.Item3;
            txtMeanVoltageChargerHigh.Text = specValues.Item4;
            txtVoltageChargerMinMaxCurrentConstant.Text = specValues.Item5;
            txtMeanVoltageChargerCurrentConstant.Text = specValues.Item6;
            txtLowVoltageCutOffMinMax.Text = specValues.Item7;
            txtMeanVoltageCutOff.Text = specValues.Item8;


        }
        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            var nevigateProduct = new NevigateProduct(
                cboProductGroupM.SelectedItem.ToString(),
                cboSeriesM.SelectedItem.ToString(),
                cboModelM.SelectedItem.ToString(),
                cboBatteryTypeM.SelectedItem.ToString(),
                cboBatteryCapacityM.SelectedItem.ToString());
            int? productId = nevigateProduct.FindProductId();
            int? rawId = nevigateProduct.FindRawId(measureProductIdPublic);
            if (!productId.HasValue || !rawId.HasValue) { return; }
            using (var commentText = new Entities())
            {
                var measurementComment = commentText.MEASUREMENT_PRODUCT.FirstOrDefault(mp => mp.ID == measurementProductId);
                {
                    measurementComment.COMMENT = txtComment.Text;
                    //measurementComment.COMMENT = string.Join(",", txtComment.Text);
                    try { commentText.SaveChanges(); }
                    catch (DbUpdateException ex)
                    {
                        var errorMessage = "";
                        if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        { errorMessage = ex.InnerException.InnerException.Message; }
                        else { errorMessage = ex.Message; }
                        MessageBox.Show("Cannot update measurement data: " + errorMessage, "Measurement Data Update Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        bool NGFlag = false;
        private void DetectNGList()
        {
            var nevigateProduct = new NevigateProduct(
               cboProductGroupM.SelectedItem.ToString(),
               cboSeriesM.SelectedItem.ToString(),
               cboModelM.SelectedItem.ToString(),
               cboBatteryTypeM.SelectedItem.ToString(),
               cboBatteryCapacityM.SelectedItem.ToString());
            int? productId = nevigateProduct.FindProductId();
            int? rawId = nevigateProduct.FindRawId(measureProductIdPublic);
            if (!productId.HasValue || !rawId.HasValue) { return; }
            using (var changeNGList = new Entities())
            {
                var measurementProduct = changeNGList.MEASUREMENT_PRODUCT.FirstOrDefault(mp => mp.ID == rawId.Value);
                if (measurementProduct == null) { return; }
                if (cboManualCheck.SelectedIndex == -1)
                {
                    if (txtAutoCheck.Text == "NG" && !NGFlag)
                    {
                        NGFlag = true;
                        measurementProduct.NG_LIST = txtAutoCheck.Text;
                        changeNGList.SaveChanges();
                    }
                }
                else
                {
                    measurementProduct.NG_LIST = cboManualCheck.Text;
                    changeNGList.SaveChanges();
                }
            }
        }
        #endregion CONTROL_DATA_ENTRY ...........................................................................


        #region ZedPlot ---------------------------------------------------------------------------
        public AlternativeCurrentState GetCurrentState() { return currentState; }

        bool autoCheckFlag = false;
        public async Task TimerEventProcessor(double yAxisVoltage, double yAxisMovingAverageVoltage = 0, double yAxisCurrent = 0)
        {
            double totalSecond = stopwatch.Elapsed.TotalSeconds;
            pointPairCount++;

            var low = DataPattern.GetMinMaxMean(txtVoltageChargerMinMaxLow.Text, txtMeanVoltageChargerLow.Text); // get data from text box and regular expression
            double lowMinCharge = low.minCon;
            double lowMaxCharge = low.maxCon;

            var high = DataPattern.GetMinMaxMean(txtVoltageChargerMinMaxHigh.Text, txtMeanVoltageChargerHigh.Text);
            double highMinCharge = high.minCon;
            double highMaxCharge = high.maxCon;

            var currentConstant = DataPattern.GetMinMaxMean(txtVoltageChargerMinMaxCurrentConstant.Text, txtMeanVoltageChargerCurrentConstant.Text);
            double currentConstantMin = currentConstant.minCon;
            double currentConstantMax = currentConstant.maxCon;

            var cutOff = DataPattern.GetMinMaxMean(txtLowVoltageCutOffMinMax.Text, txtMeanVoltageCutOff.Text);
            double cutoffMin = cutOff.minCon;
            double cutoffMax = cutOff.maxCon;

            double[] batteryVoltageCurrent = { yAxisVoltage, yAxisMovingAverageVoltage, yAxisCurrent };

            AlternativeCurrentState currentState = GetCurrentState();

            if (low.success && high.success && cutOff.success) // Three Step Charge
            {
                await _zedGraphManager.PlotGroupAsync(CurveTypeConfiguration.DcCurveTypes, totalSecond, batteryVoltageCurrent);
                var (stage, autoCheck) = QuailityCheck.CheckThreeStepCharge(yAxisMovingAverageVoltage, derivativeVoltage, // Plot graph from Zedlibrary
                                                                                   highMinCharge, highMaxCharge,
                                                                                   lowMinCharge, lowMaxCharge,
                                                                                   cutoffMin, cutoffMax,
                                                                                   currentState);

                txtStage.Text = ChargingStageDescriptions.GetString(stage);
                txtAutoCheck.Text = QualityDescription.GetQualityString(autoCheck);

                await _zedGraphManager.PlotSpecificationThreeStepCharge(stage, totalSecond, highMinCharge, highMaxCharge,
                                                                                   lowMinCharge, lowMaxCharge,
                                                                                   cutoffMin, cutoffMax);

            }
            else if (currentConstant.success && cutOff.success) // Current Constant
            {
                await _zedGraphManager.PlotGroupAsync(CurveTypeConfiguration.DcCurveTypes, totalSecond, batteryVoltageCurrent);
                var (stage, autoCheck) = QuailityCheck.CheckCurrentConstant(yAxisMovingAverageVoltage, derivativeVoltage, // Plot graph from ZedLibrary
                                                                                  currentConstantMin, currentConstantMax,
                                                                                  cutoffMin, cutoffMax,
                                                                                  currentState);
                txtStage.Text = ChargingStageDescriptions.GetString(stage);
                txtAutoCheck.Text = QualityDescription.GetQualityString(autoCheck);

                await _zedGraphManager.PlotSpecificationCurrentConstant(stage, totalSecond, currentConstantMin, currentConstantMax, cutoffMin, cutoffMax);
            }
        }
        private void chbVisibleVoltageAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVisibleVoltageAxis.Checked)
            {
                _zedGraphManager.SetCurveVisibility(CurveType.VoltageDc, true);
                chbVisibleVoltageAxis.Text = "Show";
            }
            else if (!chbVisibleVoltageAxis.Checked)
            {
                _zedGraphManager.SetCurveVisibility(CurveType.VoltageDc, false);
                chbVisibleVoltageAxis.Text = "Hide";
            }
        }
        private void chbMAVoltageAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMAVoltageAxis.Checked)
            {
                _zedGraphManager.SetCurveVisibility(CurveType.MovingAverageVoltageDc, true);
                chbMAVoltageAxis.Text = "Show";
            }
            else if (!chbMAVoltageAxis.Checked)
            {
                _zedGraphManager.SetCurveVisibility(CurveType.MovingAverageVoltageDc, false);
                chbMAVoltageAxis.Text = "Hide";
            }
        }
        private void chbVisibleCurrentAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVisibleCurrentAxis.Checked)
            {
                _zedGraphManager.SetCurveVisibility(CurveType.CurrentDc, true);
                chbVisibleCurrentAxis.Text = "Show";
            }
            else if (!chbVisibleCurrentAxis.Checked)
            {
                _zedGraphManager.SetCurveVisibility(CurveType.CurrentDc, false);
                chbVisibleCurrentAxis.Text = "Hide";
            }
        }
        // - - - - - - - - - - - - - MOVING AVERAGE OF VOLTAGE VALUE - - - - - - - - - - - - - - - - //
        // - - - - - - - - - - - - - - - SELECT BUFFER MOVING AVERAGE OF VOLTAGE - - - - - - - - - //
        public double totalBatteryVoltage = 0;
        public double[] bufferBatterVoltage;
        public int indexAVGBatteryvoltage = 0;
        public bool firstMovingAverage = true;
        public List<int> bufferSize = Enumerable.Range(15, 100).ToList();

        private void cboSelectBuffer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bufferBatterVoltage = new double[bufferSize[cboSelectBuffer.SelectedIndex]];
            bufferBatterVoltageEMA = new double[bufferSize[cboSelectBuffer.SelectedIndex]];

            indexAVGBatteryvoltage = 0;
            totalBatteryVoltage = 0;
            firstMovingAverage = true;
            emaFirstValue = true;
        }
        private double movingAverage(double physicalVoltage) // Having return 2 type of data
        {
            try
            {
                var v = (double)physicalVoltage;
                totalBatteryVoltage = totalBatteryVoltage - bufferBatterVoltage[indexAVGBatteryvoltage];
                bufferBatterVoltage[indexAVGBatteryvoltage] = v;
                totalBatteryVoltage = totalBatteryVoltage + bufferBatterVoltage[indexAVGBatteryvoltage];
                double averageBatteryVoltage = totalBatteryVoltage / bufferBatterVoltage.Length;
                if (firstMovingAverage && indexAVGBatteryvoltage == bufferBatterVoltage.Length - 1) firstMovingAverage = false;
                if (bufferBatterVoltage.Length - 1 <= indexAVGBatteryvoltage++)
                    indexAVGBatteryvoltage = 0;
                if (firstMovingAverage) return physicalVoltage;
                else return averageBatteryVoltage;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"No variable + {ex}");
                return 0;
            }
        }

        public double emaBatteryVoltage = 0;
        public bool emaFirstValue = true;
        public double[] bufferBatterVoltageEMA;

        private double ExponentialMovingAverage(double physicalVoltage)
        {
            try
            {
                int bufferSize = bufferBatterVoltageEMA.Length;
                double smoothingFactor = 2.0 / (bufferSize + 1);

                if (emaFirstValue)
                {
                    for (int i = 0; i < bufferSize; i++)
                    {
                        bufferBatterVoltageEMA[i] = physicalVoltage;
                    }
                    emaBatteryVoltage = physicalVoltage;
                    emaFirstValue = false;
                }
                else { emaBatteryVoltage = (smoothingFactor * physicalVoltage) + (1 - smoothingFactor) * emaBatteryVoltage; }

                return emaBatteryVoltage;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"No variable + {ex}");
                return 0;
            }
        }

        #endregion ZedPlot .........................................................................


        #region Timer --------------------------------------------------------------------------------

        // - - - - - - - - - - - - - - - - - TIME ELAPSED - - - - - - - - - - - - - - - - -// 
        private Stopwatch stopwatch = new Stopwatch();
        private Stopwatch derivativeStopwatch = new Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!txtTimer1.IsDisposed && txtTimer1.IsHandleCreated)
            {
                txtTimer1.Invoke((MethodInvoker)delegate
                {
                    txtTimer1.Text = string.Format("{0:00}:{1:00}:{2:00}",
                        stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);
                });
            }
        }
        public double currentAverageVoltage = 0;

        private Dictionary<int, (double voltage, double time)> previousValues = new Dictionary<int, (double voltage, double time)>()
        {
            { 0, (0.0,0.0) },// 9
            { 60, (0.0, 0.0) }, // 1 minute
            { 300, (0.0, 0.0) }, // 5 minutes
            { 600, (0.0, 0.0) }, // 10 minutes
            { 900, (0.0, 0.0) }, // 15 minutes
            { 1200, (0.0, 0.0) } // 20 minutes
        };

        private void timerDerivative_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)derivativeStopwatch.Elapsed.TotalSeconds;
            double currentTime = derivativeStopwatch.Elapsed.TotalSeconds;

            switch (elapsedSeconds)
            {
                case 60:
                    
                    break;
                case 300:
                    
                    break;
                case 600:
                    
                    break;
                case 900:
                    
                    break;
                case 1200:
                    
                    break; ;
                default:
                    if (elapsedSeconds >= 1200)
                    {
                        derivativeStopwatch.Restart();
                        elapsedSeconds = 0;
                    }
                    break;

            }
            foreach (var key in previousValues.Keys.ToList())
            {
                if (elapsedSeconds % key == 0)
                {
                    var previousValue = previousValues[key];
                    currentAverageVoltage = derivativeVoltage;
                    double derivativeVoltageCalculate = Calculation.DerivativeVoltage(currentAverageVoltage, previousValue.voltage, elapsedSeconds, previousValue.time);
                    previousValues[key] = (currentAverageVoltage, currentTime);
                }
            }
        }

        // - - - - - - - - - - - - - - - CONNTECT BUTTON TO MEASURE - - - - - - - - - - - //
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = await _httpWiFiClient.SendWiFiCredentialsAsync(txtSSID.Text, txtPassword.Text);
                if (success)
                {
                    lblStatus.Text = "Status: Connected";
                    lblStatus.BackColor = Color.LimeGreen;
                }
                else
                {
                    lblStatus.Text = "Status: Connecting";
                    lblStatus.BackColor = Color.FromArgb(255, 192, 192);

                    int retryCount = 3;
                    for (int i = 0; i < retryCount; i++)
                    {
                        bool successTwice = await _httpWiFiClient.SendWiFiCredentialsAsync(txtSSID.Text, txtPassword.Text);
                        if (successTwice)
                        {
                            lblStatus.Text = "Status: Connected";
                            lblStatus.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            lblStatus.Text = "Status: Try again";
                            lblStatus.BackColor = Color.FromArgb(255, 192, 192);
                        }
                    }
                }
                InitializeHttpWiFiClient();
                await _httpWiFiClient.SetUdpTargetAsync();
            }
            catch (SocketException ex) { MessageBox.Show($"Error: Invalid IP address or port number:{ex.Message}"); _udpWiFiClient.Dispose(); }
            catch (FormatException ex) { MessageBox.Show($"Error: Invalid IP address or port number:{ex.Message}"); _udpWiFiClient.Dispose(); }
            catch (ArgumentNullException ex) { MessageBox.Show($"Error: Message is null: {ex.Message}"); _udpWiFiClient.Dispose(); }
            catch (NullReferenceException ex) { MessageBox.Show($"Error: Message is null: {ex.Message}"); }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message); }
            //finally { _udpWiFiClient.Dispose(); }
        }
        private void InitializeHttpWiFiClient()
        {
            _httpWiFiClient.ConnectionLost += HttpWiFiClient_ConnectionLost;
            _httpWiFiClient.ConnectionEstablished += HttpWiFiClient_ConnectionEstablished;
            MaintainWiFiConnection();
        }
        private async void MaintainWiFiConnection()
        {
            while (true)
            {
                await _httpWiFiClient.GetEntireStatus();
                //await _httpWiFiClient.CheckWiFiConnectionAsync(txtSSID.Text, txtPassword.Text);
                await Task.Delay(TimeSpan.FromMinutes(5));
            }
        }
        private async void HttpWiFiClient_ConnectionStatusChanged(object sender, ConnectionStatusEventArgs e)
        {
            bool result = await _httpWiFiClient.SendWiFiCredentialsAsync(txtSSID.Text, txtPassword.Text);
        }
        private void HttpWiFiClient_ConnectionLost(object sender, EventArgs e) { lblStatus.Invoke(new Action(() => lblStatus.Text = "Status: Lost Connection")); }
        private void HttpWiFiClient_ConnectionEstablished(object sender, EventArgs e) { lblStatus.Invoke(new Action(() => lblStatus.Text = "Status: Connected")); }
        private async void HttpWiFiClient_PinStatusCheck(object sender, List<(bool ledStatus, bool relayStatus)> pinStatusList)
        {
            await Task.Run(() =>
            {
                var pinStatus = pinStatusList[0];
                string led = pinStatus.ledStatus ? "ON" : "OFF";
                string relay = pinStatus.relayStatus ? "ON" : "OFF";
                lblLedState.Text = $"WiFi Status: {led}";
                lblRelayState.Text = $"EMER AC state: {relay}";
            });
        }

        private async void HttpWiFiClient_CheckAllStatus(object sender, List<(ConnectionStatus connection, bool connectionStatus, bool ledStatus, bool relayStatus)> statusList)
        {
            await Task.Run(() =>
            {
                var entireStatus = statusList[0];
                string connection = entireStatus.connectionStatus ? "Connected" : "Lost Connection";
                string led = entireStatus.ledStatus ? "ON" : "OFF";
                string relay = entireStatus.relayStatus ? "ON" : "OFF";

                this.Invoke((MethodInvoker)delegate
                {
                    // lblStatus.Text = $"Status: {connection}";
                    lblLedState.Text = $"WiFi Status: {led}";
                    lblRelayState.Text = $"EMER AC state: {relay}";
                });

            });
        }

        private void HandleConnectionStatusChanged(object sender, ConnectionStatusEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lblStatus.Text = $"WiFi Status: {e.Status}";
            }));
        }

        private async void btnToggleLed_Click(object sender, EventArgs e)
        {
            string ledState = await _httpWiFiClient.ToggleLedAsync();
            if (ledState != null)
            {
                lblLedState.Text = $"LED State: {ledState}";
            }
            else
            {
                lblLedState.Text = "LED State Error : Unable to toggle LED";
            }
            InitializeHttpWiFiClient();
        }

        private async void btnToggleRelay_Click(object sender, EventArgs e)
        {
            string relayState = await _httpWiFiClient.ToggleRelayAsync();
            if (relayState != null)
            {
                lblRelayState.Text = $"EMER AC state: {relayState}";
            }
            else
            {
                lblRelayState.Text = "EMER AC state : Error";
            }
            InitializeHttpWiFiClient();
        }
        private async void btnFindDevice_Click(object sender, EventArgs e)
        {
            cboEsp32Devices.Items.Clear();
            _httpWiFiClient.Esp32DevicesDiscovered += OnEsp32DevicesDiscovered;
            await _httpWiFiClient.DiscoverEspAsync();
            //await _httpWiFiClient.DiscoverEspAsync();
        }
        private void cboEsp32Devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDevice = cboEsp32Devices.SelectedItem.ToString();
            _httpWiFiClient.SetBaseUrlByDeviceName(selectedDevice);
        }
        private void OnEsp32DevicesDiscovered(object sender, List<(string displayName, string ipAddress, string macAddress)> deviceInfoList)
        {
            if (cboEsp32Devices.InvokeRequired)
            {
                cboEsp32Devices.Invoke(new Action(() =>
                {
                    cboEsp32Devices.Items.Clear();
                    foreach (var deviceInfo in deviceInfoList)
                    {
                        cboEsp32Devices.Items.Add(deviceInfo.displayName);
                    }
                }));
            }
            else
            {
                cboEsp32Devices.Items.Clear();
                foreach (var deviceInfo in deviceInfoList)
                {
                    cboEsp32Devices.Items.Add(deviceInfo.displayName);
                }
            }
        }
        // - - - - - - - - - - - - START MEASURE BUTTON WITH USING THREADING - - - - - - - //
        bool isTimerRunning = false;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_cts == null)
            {
                InitializeCancellationTokenSource();
            }
            else if (IsDataReadingInProgress())
            {
                MessageBox.Show("Data reading is already in progress.");
                return;
            }
            ButtonStartEnable();

            if (!isTimerRunning)
            {
                //startTime = DateTime.Now;
                stopwatch.Start();
                timer1.Start();
                timerDerivative.Start();
                isTimerRunning = true;
                //await ReadAndProcessDataAsync(_cts.Token);
                startThreadTask_UpdateDashboard();
                //await StatProtocolThread();
            }
            else
            {
                isTimerRunning = false;
            }
        }

        private async Task StatProtocolThread()
        {

            if (!_serialPortCon.IsConnected)
            {
                _udpWiFiClient.UdpThreadStart();
                //await _udpWiFiClient.UdpReceiveData();
            }
            else if (_serialPortCon.IsConnected)
            {
                _serialPortCon.SerialThreadStart();
                //_udpWiFiClient.UdpThreadStart();
                await _udpWiFiClient.UdpListenerStartAsync();
            }
        }
        private void ButtonStartEnable()
        {
            btnClearTime_PC.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            timer1.Enabled = true;
            timerDerivative.Enabled = true;
            backUpTimer.Enabled = true;
        }

        // - - - - - - - - - - - - STOP MEASURE BUTTON WITH USING THREADING - - - - - - - //
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (IsDataReadingInProgress())
            {
                _cts.Cancel();
                _cts = null;
            }
            stopwatch.Stop();
            timer1.Stop();
            timerDerivative.Stop();
            backUpTimer.Enabled = false;

            timerDerivative.Enabled = false;
            timer1.Enabled = false;
            isTimerRunning = false;

            btnClearTime_PC.Enabled = true;
            btnStart.Enabled = true;
            stopFlag_UpdateDashboard = true;
        }

        // - - - - - - - - - - - - CLEAR MEASURE VALUES BUTTON WITH USING THREADING - - - - - - - //
        private void btnClearTime_PC_Click(object sender, EventArgs e)
        {
            _cts = null;
            ClearZedGraph();
            ClearDataPlot();
            ResetTimerAndElapsedTime();
        }
        private void ClearZedGraph()
        {
            _zedGraphManager.ClearAllPointPairLists();
            _zedGraphManager.Clear();
            //_zedGraphManager.UpdateConfigureGraph();
            InitZed();
            zedPlot.Invalidate();
        }

        private void ClearDataPlot()
        {
            sequenceListView = 1;
            derivativeVoltage = 0;
            listDataPlot.Items.Clear();
        }
        private void ResetTimerAndElapsedTime()
        {
            timer1.Stop();
            timerDerivative.Stop();
            flagFirstMAValue = false;
            derivativeStopwatch.Reset();
            stopwatch.Reset();
            txtTimer1.Text = TimeSpan.Zero.ToString();
        }
        private void txtTimerCountUp_TextChanged(object sender, EventArgs e)
        {
            txtTimer1.Enabled = false;
        }
        private bool IsDataReadingInProgress()
        {
            return _cts != null;
        }

        private void InitializeCancellationTokenSource()
        {
            _cts = new CancellationTokenSource();
        }
        #endregion Timer .....................................................................


        #region DASHBOARD --------------------------------------------------------------------
        int sequenceListView = 1;
        public double derivativeVoltage = 0;

        private (double voltageDc, double movingAverageVoltage, double currentTime) GetLastDataPointFromListView()
        {
            if (listDataPlot.Items.Count > 0)
            {
                double previousVoltage = double.Parse(listDataPlot.Items[listDataPlot.Items.Count - 1].SubItems[2].Text);
                double previousMovingAverageVoltage = double.Parse(listDataPlot.Items[listDataPlot.Items.Count - 1].SubItems[3].Text);
                string[] timeParts = listDataPlot.Items[listDataPlot.Items.Count - 1].SubItems[1].Text.Split(':');
                double previousTime = double.Parse(timeParts[0]) * 3600 + double.Parse(timeParts[1]) * 60 + double.Parse(timeParts[2]) + double.Parse(timeParts[3]) / 1000;
                return (previousVoltage, previousMovingAverageVoltage, previousTime);
            }
            else
            {
                return (0, 0, 0);
            }
        }

        private async Task UpdateZedGraph(double voltageDc, double movingAverageVoltage, double currentDc)
        {
            if (InvokeRequired)
            {
                await (Task)BeginInvoke(new Func<double, double, double, Task>(UpdateZedGraph), voltageDc, movingAverageVoltage, currentDc);
            }
            else
            {
                double totalSecond = stopwatch.Elapsed.TotalSeconds;
                pointPairCount++;

                var low = DataPattern.GetMinMaxMean(txtVoltageChargerMinMaxLow.Text, txtMeanVoltageChargerLow.Text); // get data from text box and regular expression
                double lowMinCharge = low.minCon;
                double lowMaxCharge = low.maxCon;

                var high = DataPattern.GetMinMaxMean(txtVoltageChargerMinMaxHigh.Text, txtMeanVoltageChargerHigh.Text);
                double highMinCharge = high.minCon;
                double highMaxCharge = high.maxCon;

                var currentConstant = DataPattern.GetMinMaxMean(txtVoltageChargerMinMaxCurrentConstant.Text, txtMeanVoltageChargerCurrentConstant.Text);
                double currentConstantMin = currentConstant.minCon;
                double currentConstantMax = currentConstant.maxCon;

                var cutOff = DataPattern.GetMinMaxMean(txtLowVoltageCutOffMinMax.Text, txtMeanVoltageCutOff.Text);
                double cutoffMin = cutOff.minCon;
                double cutoffMax = cutOff.maxCon;

                double[] batteryVoltageCurrent = { voltageDc, movingAverageVoltage, currentDc };

                double currentVoltage = voltageDc;
                double previousVoltage = 0;
                double currentTime = totalSecond;
                double previousTime = 0;
                if (listDataPlot.Items.Count > 0)
                {
                    var lastDataPoint = GetLastDataPointFromListView();
                    previousVoltage = lastDataPoint.voltageDc;
                    previousTime = lastDataPoint.currentTime;
                }
                AlternativeCurrentState currentState = GetCurrentState();
                if (low.success && high.success && cutOff.success) // Three Step Charge
                {
                    await _zedGraphManager.PlotGroupAsync(CurveTypeConfiguration.DcCurveTypes, totalSecond, batteryVoltageCurrent);
                    var (stage, autoCheck) = QuailityCheck.CheckThreeStepCharge(movingAverageVoltage, derivativeVoltage, // Plot graph from Zedlibrary
                                                                                       highMinCharge, highMaxCharge,
                                                                                       lowMinCharge, lowMaxCharge,
                                                                                       cutoffMin, cutoffMax,
                                                                                       currentState);
                    txtStage.Text = ChargingStageDescriptions.GetString(stage);
                    txtAutoCheck.Text = QualityDescription.GetQualityString(autoCheck);

                    await _zedGraphManager.PlotSpecificationThreeStepCharge(stage, totalSecond, highMinCharge, highMaxCharge,
                                                                                       lowMinCharge, lowMaxCharge,
                                                                                       cutoffMin, cutoffMax);
                    zedPlot.Invalidate();

                }
                else if (currentConstant.success && cutOff.success) // Current Constant
                {
                    await _zedGraphManager.PlotGroupAsync(CurveTypeConfiguration.DcCurveTypes, totalSecond, batteryVoltageCurrent);
                    var (stage, autoCheck) = QuailityCheck.CheckCurrentConstant(movingAverageVoltage, derivativeVoltage, // Plot graph from ZedLibrary
                                                                                      currentConstantMin, currentConstantMax,
                                                                                      cutoffMin, cutoffMax,
                                                                                      currentState);
                    txtStage.Text = ChargingStageDescriptions.GetString(stage);
                    txtAutoCheck.Text = QualityDescription.GetQualityString(autoCheck);

                    await _zedGraphManager.PlotSpecificationCurrentConstant(stage, totalSecond, currentConstantMin, currentConstantMax, cutoffMin, cutoffMax);
                    zedPlot.Invalidate();
                }
            }
        }

        private void UpdateListView(double voltageDc, double movingAverageVoltage, double currentDc, double currentADC, double derivative)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<double, double, double, double, double>(UpdateListView), voltageDc, movingAverageVoltage, currentDc, currentADC, derivative);
            }
            else
            {
                ListViewItem espList = new ListViewItem();
                espList.Text = sequenceListView.ToString();
                espList.SubItems.Add(string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                    (int)stopwatch.Elapsed.TotalHours, (int)stopwatch.Elapsed.Minutes, (int)stopwatch.Elapsed.Seconds, (int)stopwatch.Elapsed.Milliseconds));
                espList.SubItems.Add(voltageDc.ToString());
                espList.SubItems.Add(movingAverageVoltage.ToString());
                espList.SubItems.Add(currentDc.ToString());
                espList.SubItems.Add(currentADC.ToString());
                espList.SubItems.Add(derivative.ToString());
                listDataPlot.Items.Add(espList);
            }
        }
        private void lblRelayState_TextChanged(object sender, EventArgs e)
        {
            string relayStateText = lblRelayState.Text.Split(':')[1].Trim();

            switch (relayStateText)
            {
                case "ON":
                    currentState = AlternativeCurrentState.ON;
                    break;
                case "OFF":
                    currentState = AlternativeCurrentState.OFF;
                    break;
                default:
                    currentState = AlternativeCurrentState.Error;
                    break;
            }
        }

        bool isUpdateDashboarPic_Running = false;
        bool stopFlag_UpdateDashboard = true;
        void startThreadTask_UpdateDashboard()
        {
            if (!isUpdateDashboarPic_Running)
            {
                stopFlag_UpdateDashboard = false;
                Thread trd = new Thread(new ThreadStart(this.ThreadTask))
                {
                    IsBackground = true
                };
                trd.Start();
            }
            else
            {
                //isUpdateDashboarPic_Running = true;
            }
        }
        bool flagFirstMAValue = false;
        double firstMAVoltage = 0.0;
        private async void ThreadTask()
        {
            while (!stopFlag_UpdateDashboard)
            {
                try
                {
                    var dataReceive = await _udpWiFiClient.UdpReceiveDataAsyncNoCancle();
                    var (currentDc, voltageDc, currentAc, voltageAc, success) = DataPattern.GetDataEsp(dataReceive.ToString());


                    //double physicalVoltage = (voltageDc / 4095) * 3.3 * 5 ;
                    //double voltageReferenceAcs = (currentDc / 4095.0) * 3.3;
                    double physicalVoltage = (voltageDc / 3926) * 3.3 * 5;
                    double voltageReferenceAcs = (currentDc / 3926) * 3.3 * 5;
                    double voltageDifference = voltageReferenceAcs - 2.5;
                    //double physicalCurrent = voltageDifference / 0.185;
                    double physicalCurrent = (currentDc / 3926) * 3.3 * 5;

                    double derivative = derivativeVoltage;
                    double averageVoltageEsp = (double)movingAverage(physicalVoltage);
                    if (!flagFirstMAValue)
                    {
                        firstMAVoltage = physicalVoltage;
                        flagFirstMAValue = true;
                    }
                    UpdateZedGraph(physicalVoltage, averageVoltageEsp, physicalCurrent);
                    UpdateListView(physicalVoltage, averageVoltageEsp, physicalCurrent, currentDc, derivative);
                    sequenceListView++;
                    Thread.Sleep(50);
                    splitContainer2.Panel1.BeginInvoke((Action)(() =>
                    {
                        txtMovingAverageText.Text = $"{averageVoltageEsp:F2}";
                        txtVoltageText.Text = $"{physicalVoltage:F2}";
                        txtCurrentText.Text = $"{physicalCurrent:F2}";
                        txtAcCurrent.Text = $"{currentAc:F2}";
                        txtAcVoltage.Text = $"{voltageAc:F2}";
                        txtDerivative.Text = $"{derivativeVoltage:F2}";
                    }));

                    BeginInvoke((Action)(() =>
                    {
                        txtTimer1.Text = string.Format("{0:00}:{1:00}:{2:00}",
                           stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);
                        splitContainerMid.Panel1.Text = "Dot per seconds: " + pointPairCount.ToString(); pointPairCount = 0;

                        _saveData = new SaveData(this);
                        _saveData.SaveRawData((double)stopwatch.Elapsed.TotalSeconds, voltageDc, physicalCurrent, averageVoltageEsp, derivative);
                        DetectNGList();
                        txtMovingAverageText.Text = averageVoltageEsp.ToString();

                        lblTimerStatusDashboardPic.Text = "Stopped";
                        lblTimerStatusDashboardPic.BackColor = Color.Red;
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Runtime Error : {ex}");
                    return;
                }
            }

        }
        // - - - - - - - - - - - - - - - - - - - - - - TODO LIST IN ThreadTask_UpdateDashboard - - - - - - - - - - - - - - - - - - - - //

        // TODO 1 : หน่วงเวลา total of 50 milisec || ทำ UI บวกค่าหน่วงเวลา == TOTAL OF DISTANCE BETWEEN TWO TICK
        // IDEA : I don't know

        // TODO 2 : READING DATA THROUGH WIFI WITH ESP32 WROOM 32U USING UDP PROTOCOL
        // IDEA : I DON'T HAVE ANY IDEA RIGHT NOW

        private async Task DataToListViewAsync(double voltageDc, double movingAverageVoltage, double currentDc)
        {
            await Task.Run(() =>
            {
                ListViewItem espList = new ListViewItem();
                espList.Text = sequenceListView.ToString();
                espList.SubItems.Add(string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                    (int)stopwatch.Elapsed.TotalHours, (int)stopwatch.Elapsed.Minutes, (int)stopwatch.Elapsed.Seconds, (int)stopwatch.Elapsed.Milliseconds));
                espList.SubItems.Add(voltageDc.ToString());
                espList.SubItems.Add(movingAverageVoltage.ToString());
                espList.SubItems.Add(currentDc.ToString());
                listDataPlot.Invoke((Action)(() => listDataPlot.Items.Add(espList)));
                sequenceListView++;
            });
        }

        private readonly object _lockObject = new object();
        public int measurementProductId;
        private async void UdpWiFiDataReceivedHandler(double currentDcEsp, double voltageDcEsp, double currentAcEsp, double voltageAcEsp)
        {
            try
            {
                double averageVoltageEsp = (double)movingAverage(voltageDcEsp);
                txtMovingAverageText.BeginInvoke((Action)(() => txtMovingAverageText.Text = averageVoltageEsp.ToString()));
                txtVoltageText.BeginInvoke((Action)(() => txtVoltageText.Text = voltageDcEsp.ToString()));
                txtCurrentText.BeginInvoke((Action)(() => txtCurrentText.Text = currentDcEsp.ToString()));
                txtAcCurrent.BeginInvoke((Action)(() => txtAcCurrent.Text = currentAcEsp.ToString()));
                txtAcVoltage.BeginInvoke((Action)(() => txtAcVoltage.Text = voltageAcEsp.ToString()));

                await DataToListViewAsync(voltageDcEsp, averageVoltageEsp, currentDcEsp);
                await TimerEventProcessor(yAxisVoltage: voltageDcEsp, yAxisMovingAverageVoltage: averageVoltageEsp, yAxisCurrent: currentAcEsp);
                BeginInvoke((Action)(() =>
                {
                    splitContainerMid.Panel1.Text = "Dot per seconds: " + pointPairCount.ToString(); pointPairCount = 0;

                    _saveData = new SaveData(this);
                    _saveData.SaveRawData((double)stopwatch.Elapsed.TotalSeconds, voltageDcEsp, currentDcEsp, averageVoltageEsp);
                    DetectNGList();
                    txtMovingAverageText.Text = averageVoltageEsp.ToString();

                    lblTimerStatusDashboardPic.Text = "Stopped";
                    lblTimerStatusDashboardPic.BackColor = Color.Red;
                }));
                Thread.Sleep(50);
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                MessageBox.Show($"Validation errors occurred while saving data: {errorMessages}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Cannot update the Measurement ID" + ex.Message, "Cannot Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (NullReferenceException ex) { MessageBox.Show($"Cannot Save data to server + {ex}"); }
            catch (Exception ex)
            {
                Logger.ReferenceEquals(this, ex); Trace.WriteLine($"{ex}");
                if (ex.Message.Contains("ESP 32 is denied."))
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        lblTimerStatusDashboardPic.Text = "Stopped";
                        MessageBox.Show($"updating failed!\r\n\r\n{ex}" + MessageBoxButtons.OK + MessageBoxIcon.Exclamation);
                    }));
                    _udpWiFiClient._stopFlagUdpWiFi = true;
                }
            }
        }
        private async void _serialPortCon_NanoDataReceived(double currentDcNano, double voltageDcNano, double currentAcNano, double voltageAcNano)
        {
            try
            {
                txtCurrentText.BeginInvoke((Action)(() => txtCurrentText.Text = currentDcNano.ToString()));
                txtVoltageText.BeginInvoke((Action)(() => txtVoltageText.Text = voltageDcNano.ToString()));
                txtAcCurrent.BeginInvoke((Action)(() => txtAcCurrent.Text = currentAcNano.ToString()));
                txtAcVoltage.BeginInvoke((Action)(() => txtAcVoltage.Text = voltageAcNano.ToString()));
                double averageVoltageNano = (double)movingAverage(voltageDcNano);
                await DataToListViewAsync(voltageDcNano, averageVoltageNano, currentDcNano);
                BeginInvoke((Action)delegate
                {
                    splitContainerMid.Panel1.Text = "Dot per seconds: " + pointPairCount.ToString(); pointPairCount = 0;
                    TimerEventProcessor(yAxisVoltage: voltageDcNano, yAxisMovingAverageVoltage: averageVoltageNano, yAxisCurrent: currentDcNano);
                    int measurementProductId = _saveData.LastMeasureProductIdPublic;
                    _saveData.SaveRawData(stopwatch.Elapsed.TotalSeconds, voltageDcNano, currentDcNano, averageVoltageNano);

                    bufferBatterVoltage = new double[(int)cboSelectBuffer.SelectedItem];
                    DetectNGList();

                    lblTimerStatusDashboardPic.Text = "Stopped";
                    lblTimerStatusDashboardPic.BackColor = Color.Red;
                });
                Thread.Sleep(50);

            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                MessageBox.Show($"Validation errors occurred while saving data: {errorMessages}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Cannot update the Measurement ID" + ex.Message, "Cannot Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (NotImplementedException ex) { Logger.ReferenceEquals(this, ex); }
            catch (Exception ex)
            {
                Logger.ReferenceEquals(this, ex); Trace.WriteLine($"{ex}");
                if (ex.Message.Contains("ArduinoNano is denied."))
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        lblTimerStatusDashboardPic.Text = "Stopped";
                        MessageBox.Show($"updating failed!\r\n\r\n{ex}" + MessageBoxButtons.OK + MessageBoxIcon.Exclamation);
                    }));
                    _serialPortCon._stopFlagSerial = true;
                }
            }
        }

        #endregion DASHBOARD ..............................................................................


        #region MENU --------------------------------------------------------------------

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portToolStripMenuItem.DropDownItems.Clear();
            foreach (string portName in SerialPort.GetPortNames())
            {
                ToolStripMenuItem submenuItem = new ToolStripMenuItem(portName);
                submenuItem.Click += new EventHandler(submitPort_Click);
                portToolStripMenuItem.DropDownItems.Add(submenuItem);
            }
            if (portToolStripMenuItem.DropDownItems.Count == 0) { portToolStripMenuItem.Enabled = false; }
            portToolStripMenuItem.Enabled = (portToolStripMenuItem.DropDownItems.Count > 0);
        }

        private void submitPort_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedPort = sender as ToolStripMenuItem;
            if (clickedPort != null)
            {
                string portName = clickedPort.Text;
                if (_serialPortCon.IsConnected) { _serialPortCon.Disconnect(); }
                else { _serialPortCon.Connect(portName); }
            }
        }

        // - - - - - - - - - - - - - - - - - OPEN FILE DIALOG BUTTON FROM MENU STRIP - - - - - - - - - - - - - //
        private async void openGraphFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var npoiOpen = new CsvFile(listDataPlot);
            npoiOpen.OpenGraphFile();
            _zedGraphManager.ClearEntireCurve();
            _zedGraphManager.ConfigureGraph();
            zedPlot.Invalidate();
        }
        // - - - - - - - - - - - - - - - - - - - - - - SAVE AS FILE DIALOG FROM MENU STRIP - - - - - - - - - - - - - - - - //
        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var npoiSave = new CsvFile(listDataPlot);
            npoiSave.SaveGraphFile();
        }

        // - - - - - - - - - - - - - - - - - - - - - - MINIMIZE , MAXIMIZE/RESTORE AND CLOSE - - - - - - - - - - - - - - - - //
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            WindowSizeIcon();
        }
        private void btnMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point lastLocation;
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void WindowSizeIcon()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion MENU...................................................................................

        private async void btnChangeIPAdress_Click(object sender, EventArgs e)
        {
            try
            {
                await _httpWiFiClient.SetUdpTargetAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void splitContainerMain_Panel2_Init()
        {
            this.splitContainerMain.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainerMain_Panel2_MouseDown);
            this.splitContainerMain.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainerMain_Panel2_MouseMove);
            this.splitContainerMain.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel1_MouseUp);
        }
        private void splitContainerMain_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                previousLocation = e.Location;
            }
        }

        private void splitContainerMain_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point currentLocation = e.Location;
                int dx = currentLocation.X - previousLocation.X;
                int dy = currentLocation.Y - previousLocation.Y;

                this.splitContainerMain.Panel2.Left += dx;
                this.splitContainerMain.Panel2.Top += dy;

                previousLocation = currentLocation;
            }
        }

        private void splitContainerMain_Panel2_Init_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }


        private void splitContainer2_Panel1_Init()
        {
            this.splitContainer2.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel1_MouseDown);
            this.splitContainer2.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel1_MouseMove);
            this.splitContainer2.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel1_MouseUp);
        }
        private void splitContainer2_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                previousLocation = e.Location;
            }
        }

        private void splitContainer2_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point currentLocation = e.Location;
                int dx = currentLocation.X - previousLocation.X;
                int dy = currentLocation.Y - previousLocation.Y;

                this.splitContainer2.Panel1.Left += dx;
                this.splitContainer2.Panel1.Top += dy;

                previousLocation = currentLocation;
            }
        }

        private void splitContainer2_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        private void labelVoltageFocus_Click(object sender, EventArgs e)
        {

        }

        private void pnMovingAverage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCurrentFocus_Click(object sender, EventArgs e)
        {

        }

        private void pnConnection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labelMovingAVGVoltageDataText_Click(object sender, EventArgs e)
        {

        }

        private void lblspecifiations_Click(object sender, EventArgs e)
        {

        }

        private void cboProductGroupM_Click(object sender, EventArgs e)
        {

        }
    }
}