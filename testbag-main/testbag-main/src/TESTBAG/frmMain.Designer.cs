namespace TESTBAG
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.errDisplay = new System.Windows.Forms.ErrorProvider(this.components);
            this.okDisplay = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.backUpTimer = new System.Windows.Forms.Timer(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.timerDerivative = new System.Windows.Forms.Timer(this.components);
            this.iDropDownButtonMenu = new FontAwesome.Sharp.IconDropDownButton();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.labelAutoCheck = new System.Windows.Forms.Label();
            this.txtAutoCheck = new System.Windows.Forms.TextBox();
            this.cboManualCheck = new System.Windows.Forms.ComboBox();
            this.txtTimer1 = new System.Windows.Forms.TextBox();
            this.lbtime_pc = new System.Windows.Forms.Label();
            this.lblTimerStatusDashboardPic = new System.Windows.Forms.Label();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabLeftControl = new System.Windows.Forms.TabControl();
            this.tabProductInput = new System.Windows.Forms.TabPage();
            this.subPanelToPutData = new System.Windows.Forms.Panel();
            this.pnBatteryCapacity = new System.Windows.Forms.Panel();
            this.labelBatteryCapacity = new System.Windows.Forms.Label();
            this.cboBatteryCapacityM = new System.Windows.Forms.ComboBox();
            this.pnBatteryType = new System.Windows.Forms.Panel();
            this.labelBatteryType = new System.Windows.Forms.Label();
            this.cboBatteryTypeM = new System.Windows.Forms.ComboBox();
            this.pnSeries = new System.Windows.Forms.Panel();
            this.labelProductSeries = new System.Windows.Forms.Label();
            this.cboModelM = new System.Windows.Forms.ComboBox();
            this.pnModel = new System.Windows.Forms.Panel();
            this.labelSeriesModel = new System.Windows.Forms.Label();
            this.cboSeriesM = new System.Windows.Forms.ComboBox();
            this.pnProductGroup = new System.Windows.Forms.Panel();
            this.cboProductGroupM = new System.Windows.Forms.ComboBox();
            this.labelProductGroup = new System.Windows.Forms.Label();
            this.pnPerson = new System.Windows.Forms.Panel();
            this.labelMeasureBy = new System.Windows.Forms.Label();
            this.txtMeasureBy = new System.Windows.Forms.TextBox();
            this.pnMfgDate = new System.Windows.Forms.Panel();
            this.txtManufacDate = new System.Windows.Forms.TextBox();
            this.labelManufactorData = new System.Windows.Forms.Label();
            this.pnLot = new System.Windows.Forms.Panel();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.labelLot = new System.Windows.Forms.Label();
            this.pnSerialNumber = new System.Windows.Forms.Panel();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.pnJobNumber = new System.Windows.Forms.Panel();
            this.labelJobNumber = new System.Windows.Forms.Label();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.pnHeaderDataInput = new System.Windows.Forms.Panel();
            this.lblHeaderInputData = new System.Windows.Forms.Label();
            this.btnSubmitMeasurement = new FontAwesome.Sharp.IconButton();
            this.tabBuffer = new System.Windows.Forms.TabPage();
            this.pnMovingAverage = new System.Windows.Forms.Panel();
            this.pnCurrentAxis = new System.Windows.Forms.Panel();
            this.pnChbCurrentVisibility = new System.Windows.Forms.Panel();
            this.chbVisibleCurrentAxis = new System.Windows.Forms.CheckBox();
            this.pnCurrentAxisLabel = new System.Windows.Forms.Panel();
            this.labelCurrentFocus = new System.Windows.Forms.Label();
            this.pnMAAxis = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chbMAVoltageAxis = new System.Windows.Forms.CheckBox();
            this.pnMAlabel = new System.Windows.Forms.Panel();
            this.lblMovingAverage = new System.Windows.Forms.Label();
            this.pnVoltageAxis = new System.Windows.Forms.Panel();
            this.pnChbVoltageVisibility = new System.Windows.Forms.Panel();
            this.chbVisibleVoltageAxis = new System.Windows.Forms.CheckBox();
            this.pnLabelVoltageAxis = new System.Windows.Forms.Panel();
            this.labelVoltageFocus = new System.Windows.Forms.Label();
            this.pnVoltageBuffer = new System.Windows.Forms.Panel();
            this.cboSelectBuffer = new System.Windows.Forms.ComboBox();
            this.pnHeaderMovingAverage = new System.Windows.Forms.Panel();
            this.lbHeaderMovingAverage = new System.Windows.Forms.Label();
            this.tabSpecificationsMM = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hotSpot = new FontAwesome.Sharp.IconButton();
            this.tabRealtimeData = new System.Windows.Forms.TabPage();
            this.pnSpecificationMean = new System.Windows.Forms.Panel();
            this.pnLowCutOffMean = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtMeanVoltageCutOff = new System.Windows.Forms.TextBox();
            this.labelMeanVoltageCutOff = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtMeanVoltageChargerCurrentConstant = new System.Windows.Forms.TextBox();
            this.pnCurrentConstantLabel = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtMeanVoltageChargerHigh = new System.Windows.Forms.TextBox();
            this.pnHighMeanLabel = new System.Windows.Forms.Label();
            this.pnLowMeanlable = new System.Windows.Forms.Panel();
            this.pnLowMeanText = new System.Windows.Forms.Panel();
            this.txtMeanVoltageChargerLow = new System.Windows.Forms.TextBox();
            this.labelVoltageChargerConnectMean = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSpeMean = new System.Windows.Forms.Label();
            this.pnRealTimeData = new System.Windows.Forms.Panel();
            this.pnAlternativeCurrent = new System.Windows.Forms.Panel();
            this.pnVoltageAc = new System.Windows.Forms.Panel();
            this.pnVoltageAcText = new System.Windows.Forms.Panel();
            this.txtAcVoltage = new System.Windows.Forms.TextBox();
            this.labelAcVoltage = new System.Windows.Forms.Label();
            this.pnCurrentAc = new System.Windows.Forms.Panel();
            this.pnCurrentAcText = new System.Windows.Forms.Panel();
            this.txtAcCurrent = new System.Windows.Forms.TextBox();
            this.labelAcCurrent = new System.Windows.Forms.Label();
            this.pnDirectCurrent = new System.Windows.Forms.Panel();
            this.pnCurrentDc = new System.Windows.Forms.Panel();
            this.pnCurrentDCText = new System.Windows.Forms.Panel();
            this.txtCurrentText = new System.Windows.Forms.TextBox();
            this.labelCurrentDataText = new System.Windows.Forms.Label();
            this.pnVoltageDc = new System.Windows.Forms.Panel();
            this.pnVoltageDcText = new System.Windows.Forms.Panel();
            this.txtVoltageText = new System.Windows.Forms.TextBox();
            this.labelVoltageDataText = new System.Windows.Forms.Label();
            this.pnDericative = new System.Windows.Forms.Panel();
            this.pnTextDerivative = new System.Windows.Forms.Panel();
            this.txtDerivative = new System.Windows.Forms.TextBox();
            this.lblDvDt = new System.Windows.Forms.Label();
            this.pnMaVolage = new System.Windows.Forms.Panel();
            this.pnMAvoltageText = new System.Windows.Forms.Panel();
            this.txtMovingAverageText = new System.Windows.Forms.TextBox();
            this.labelMovingAVGVoltageDataText = new System.Windows.Forms.Label();
            this.pnHeaderRealTimeData = new System.Windows.Forms.Panel();
            this.lblHeaderRealTimeData = new System.Windows.Forms.Label();
            this.pnSpecifications = new System.Windows.Forms.Panel();
            this.pnLowCutOffMM = new System.Windows.Forms.Panel();
            this.pnLowVoltageCutOff = new System.Windows.Forms.Panel();
            this.txtLowVoltageCutOffMinMax = new System.Windows.Forms.TextBox();
            this.labelLowVoltageCutOffMinMax = new System.Windows.Forms.Label();
            this.pnCurrentConstantMM = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtVoltageChargerMinMaxCurrentConstant = new System.Windows.Forms.TextBox();
            this.labelVoltageChargerCurrentConstant = new System.Windows.Forms.Label();
            this.pnLabelHighMM = new System.Windows.Forms.Panel();
            this.pnHighMMText = new System.Windows.Forms.Panel();
            this.txtVoltageChargerMinMaxHigh = new System.Windows.Forms.TextBox();
            this.labelVoltageChargerMinMaxCut = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnLowMMText = new System.Windows.Forms.Panel();
            this.txtVoltageChargerMinMaxLow = new System.Windows.Forms.TextBox();
            this.labelVoltageChargerMinMaxConnect = new System.Windows.Forms.Label();
            this.pnStage = new System.Windows.Forms.Panel();
            this.pnStageText = new System.Windows.Forms.Panel();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.labelStage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblspecifiations = new System.Windows.Forms.Label();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.pnConnection = new System.Windows.Forms.Panel();
            this.pnLedStage = new System.Windows.Forms.Panel();
            this.pnToggleLED = new System.Windows.Forms.Panel();
            this.btnToggleLed = new FontAwesome.Sharp.IconButton();
            this.pnLEDStateLabel = new System.Windows.Forms.Panel();
            this.lblLedState = new System.Windows.Forms.Label();
            this.pnWiFiConnection = new System.Windows.Forms.Panel();
            this.btnConnect = new FontAwesome.Sharp.IconButton();
            this.pnChangeIPAdress = new System.Windows.Forms.Panel();
            this.btnChangeIPAdress = new FontAwesome.Sharp.IconButton();
            this.pnFindESP = new System.Windows.Forms.Panel();
            this.btnFindDevice = new FontAwesome.Sharp.IconButton();
            this.panel18 = new System.Windows.Forms.Panel();
            this.cboEsp32Devices = new System.Windows.Forms.ComboBox();
            this.pnStateConnection = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnRelay = new System.Windows.Forms.Panel();
            this.pnBtnRelay = new System.Windows.Forms.Panel();
            this.btnToggleRelay = new FontAwesome.Sharp.IconButton();
            this.pnRelayLabel = new System.Windows.Forms.Panel();
            this.lblRelayState = new System.Windows.Forms.Label();
            this.pnPasswordLabel = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnSSID = new System.Windows.Forms.Panel();
            this.pnSSIDText = new System.Windows.Forms.Panel();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.lblSSID = new System.Windows.Forms.Label();
            this.pnCommunication = new System.Windows.Forms.Panel();
            this.lblCommunications = new System.Windows.Forms.Label();
            this.splitContainerMid = new System.Windows.Forms.SplitContainer();
            this.zedPlot = new ZedGraph.ZedGraphControl();
            this.listDataPlot = new System.Windows.Forms.ListView();
            this.sequence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voltage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.current = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adcCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.derivative = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQualityCheck = new System.Windows.Forms.TabPage();
            this.pnQualityCheck = new System.Windows.Forms.Panel();
            this.pnManualCheck = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelManualCheck = new System.Windows.Forms.Label();
            this.pnAutoCheck = new System.Windows.Forms.Panel();
            this.pnAutoCheckText = new System.Windows.Forms.Panel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmitComment = new FontAwesome.Sharp.IconButton();
            this.pnHeaderProductQuality = new System.Windows.Forms.Panel();
            this.lblHeaderCheck = new System.Windows.Forms.Label();
            this.tabMeasurement = new System.Windows.Forms.TabPage();
            this.pnMeasurement = new System.Windows.Forms.Panel();
            this.pnClear = new System.Windows.Forms.Panel();
            this.btnClearTime_PC = new FontAwesome.Sharp.IconButton();
            this.pnStop = new System.Windows.Forms.Panel();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.pnbtnStart = new System.Windows.Forms.Panel();
            this.pnStopTold = new System.Windows.Forms.Panel();
            this.pnStopWatch = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblHeaderMeasurement = new System.Windows.Forms.Label();
            this.frmMainRawMeasurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCloseForm = new FontAwesome.Sharp.IconButton();
            this.btnMiniSize = new FontAwesome.Sharp.IconButton();
            this.panelBackGround = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnMinimum = new FontAwesome.Sharp.IconButton();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnCLose = new FontAwesome.Sharp.IconButton();
            this.pnSubTopMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGraphFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movingAverageBufferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificationMinMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificationMeanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMangamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabLeftControl.SuspendLayout();
            this.tabProductInput.SuspendLayout();
            this.subPanelToPutData.SuspendLayout();
            this.pnBatteryCapacity.SuspendLayout();
            this.pnBatteryType.SuspendLayout();
            this.pnSeries.SuspendLayout();
            this.pnModel.SuspendLayout();
            this.pnProductGroup.SuspendLayout();
            this.pnPerson.SuspendLayout();
            this.pnMfgDate.SuspendLayout();
            this.pnLot.SuspendLayout();
            this.pnSerialNumber.SuspendLayout();
            this.pnJobNumber.SuspendLayout();
            this.pnHeaderDataInput.SuspendLayout();
            this.tabBuffer.SuspendLayout();
            this.pnMovingAverage.SuspendLayout();
            this.pnCurrentAxis.SuspendLayout();
            this.pnChbCurrentVisibility.SuspendLayout();
            this.pnCurrentAxisLabel.SuspendLayout();
            this.pnMAAxis.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnMAlabel.SuspendLayout();
            this.pnVoltageAxis.SuspendLayout();
            this.pnChbVoltageVisibility.SuspendLayout();
            this.pnLabelVoltageAxis.SuspendLayout();
            this.pnVoltageBuffer.SuspendLayout();
            this.pnHeaderMovingAverage.SuspendLayout();
            this.tabSpecificationsMM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabRealtimeData.SuspendLayout();
            this.pnSpecificationMean.SuspendLayout();
            this.pnLowCutOffMean.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.pnLowMeanlable.SuspendLayout();
            this.pnLowMeanText.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnRealTimeData.SuspendLayout();
            this.pnAlternativeCurrent.SuspendLayout();
            this.pnVoltageAc.SuspendLayout();
            this.pnVoltageAcText.SuspendLayout();
            this.pnCurrentAc.SuspendLayout();
            this.pnCurrentAcText.SuspendLayout();
            this.pnDirectCurrent.SuspendLayout();
            this.pnCurrentDc.SuspendLayout();
            this.pnCurrentDCText.SuspendLayout();
            this.pnVoltageDc.SuspendLayout();
            this.pnVoltageDcText.SuspendLayout();
            this.pnDericative.SuspendLayout();
            this.pnTextDerivative.SuspendLayout();
            this.pnMaVolage.SuspendLayout();
            this.pnMAvoltageText.SuspendLayout();
            this.pnHeaderRealTimeData.SuspendLayout();
            this.pnSpecifications.SuspendLayout();
            this.pnLowCutOffMM.SuspendLayout();
            this.pnLowVoltageCutOff.SuspendLayout();
            this.pnCurrentConstantMM.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnLabelHighMM.SuspendLayout();
            this.pnHighMMText.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnLowMMText.SuspendLayout();
            this.pnStage.SuspendLayout();
            this.pnStageText.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.pnConnection.SuspendLayout();
            this.pnLedStage.SuspendLayout();
            this.pnToggleLED.SuspendLayout();
            this.pnLEDStateLabel.SuspendLayout();
            this.pnWiFiConnection.SuspendLayout();
            this.pnChangeIPAdress.SuspendLayout();
            this.pnFindESP.SuspendLayout();
            this.panel18.SuspendLayout();
            this.pnStateConnection.SuspendLayout();
            this.pnRelay.SuspendLayout();
            this.pnBtnRelay.SuspendLayout();
            this.pnRelayLabel.SuspendLayout();
            this.pnPasswordLabel.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnSSID.SuspendLayout();
            this.pnSSIDText.SuspendLayout();
            this.pnCommunication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMid)).BeginInit();
            this.splitContainerMid.Panel1.SuspendLayout();
            this.splitContainerMid.Panel2.SuspendLayout();
            this.splitContainerMid.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabQualityCheck.SuspendLayout();
            this.pnQualityCheck.SuspendLayout();
            this.pnManualCheck.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnAutoCheck.SuspendLayout();
            this.pnAutoCheckText.SuspendLayout();
            this.pnHeaderProductQuality.SuspendLayout();
            this.tabMeasurement.SuspendLayout();
            this.pnMeasurement.SuspendLayout();
            this.pnClear.SuspendLayout();
            this.pnStop.SuspendLayout();
            this.pnbtnStart.SuspendLayout();
            this.pnStopTold.SuspendLayout();
            this.pnStopWatch.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainRawMeasurementBindingSource)).BeginInit();
            this.panelBackGround.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnSubTopMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errDisplay
            // 
            this.errDisplay.ContainerControl = this;
            // 
            // okDisplay
            // 
            this.okDisplay.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // timerDerivative
            // 
            this.timerDerivative.Interval = 1000;
            this.timerDerivative.Tick += new System.EventHandler(this.timerDerivative_Tick);
            // 
            // iDropDownButtonMenu
            // 
            this.iDropDownButtonMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iDropDownButtonMenu.IconColor = System.Drawing.Color.Black;
            this.iDropDownButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iDropDownButtonMenu.Name = "iDropDownButtonMenu";
            this.iDropDownButtonMenu.Size = new System.Drawing.Size(23, 23);
            this.iDropDownButtonMenu.Text = "iconDropDownButton2";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem2.Text = "iconMenuItem2";
            // 
            // labelAutoCheck
            // 
            this.labelAutoCheck.AutoSize = true;
            this.labelAutoCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAutoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAutoCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAutoCheck.Location = new System.Drawing.Point(45, 0);
            this.labelAutoCheck.Name = "labelAutoCheck";
            this.labelAutoCheck.Size = new System.Drawing.Size(135, 29);
            this.labelAutoCheck.TabIndex = 89;
            this.labelAutoCheck.Text = "Auto Check";
            // 
            // txtAutoCheck
            // 
            this.txtAutoCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAutoCheck.Enabled = false;
            this.txtAutoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAutoCheck.Location = new System.Drawing.Point(8, 43);
            this.txtAutoCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutoCheck.Name = "txtAutoCheck";
            this.txtAutoCheck.ReadOnly = true;
            this.txtAutoCheck.Size = new System.Drawing.Size(219, 45);
            this.txtAutoCheck.TabIndex = 88;
            this.txtAutoCheck.Text = "Not Check";
            this.txtAutoCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboManualCheck
            // 
            this.cboManualCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboManualCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManualCheck.Enabled = false;
            this.cboManualCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboManualCheck.FormattingEnabled = true;
            this.cboManualCheck.Items.AddRange(new object[] {
            "GOOD",
            "NG"});
            this.cboManualCheck.Location = new System.Drawing.Point(8, 49);
            this.cboManualCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboManualCheck.Name = "cboManualCheck";
            this.cboManualCheck.Size = new System.Drawing.Size(219, 46);
            this.cboManualCheck.TabIndex = 91;
            // 
            // txtTimer1
            // 
            this.txtTimer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTimer1.Location = new System.Drawing.Point(8, 64);
            this.txtTimer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimer1.Name = "txtTimer1";
            this.txtTimer1.ReadOnly = true;
            this.txtTimer1.Size = new System.Drawing.Size(219, 36);
            this.txtTimer1.TabIndex = 4;
            this.txtTimer1.Text = "00:00:00";
            this.txtTimer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimer1.TextChanged += new System.EventHandler(this.txtTimerCountUp_TextChanged);
            // 
            // lbtime_pc
            // 
            this.lbtime_pc.AutoSize = true;
            this.lbtime_pc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbtime_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbtime_pc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbtime_pc.Location = new System.Drawing.Point(45, 0);
            this.lbtime_pc.Name = "lbtime_pc";
            this.lbtime_pc.Size = new System.Drawing.Size(131, 29);
            this.lbtime_pc.TabIndex = 1;
            this.lbtime_pc.Text = "Stopwatch";
            // 
            // lblTimerStatusDashboardPic
            // 
            this.lblTimerStatusDashboardPic.BackColor = System.Drawing.Color.Red;
            this.lblTimerStatusDashboardPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimerStatusDashboardPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerStatusDashboardPic.ForeColor = System.Drawing.Color.White;
            this.lblTimerStatusDashboardPic.Location = new System.Drawing.Point(10, 10);
            this.lblTimerStatusDashboardPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimerStatusDashboardPic.Name = "lblTimerStatusDashboardPic";
            this.lblTimerStatusDashboardPic.Size = new System.Drawing.Size(217, 53);
            this.lblTimerStatusDashboardPic.TabIndex = 55;
            this.lblTimerStatusDashboardPic.Text = "Stoped";
            this.lblTimerStatusDashboardPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStart.IconColor = System.Drawing.Color.Black;
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.Location = new System.Drawing.Point(10, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(217, 53);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainerMain.Panel1MinSize = 20;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainerMain.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerMain.Size = new System.Drawing.Size(1920, 966);
            this.splitContainerMain.SplitterDistance = 1628;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.tabLeftControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainerMid);
            this.splitContainer2.Size = new System.Drawing.Size(1628, 966);
            this.splitContainer2.SplitterDistance = 456;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabLeftControl
            // 
            this.tabLeftControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabLeftControl.Controls.Add(this.tabProductInput);
            this.tabLeftControl.Controls.Add(this.tabBuffer);
            this.tabLeftControl.Controls.Add(this.tabSpecificationsMM);
            this.tabLeftControl.Controls.Add(this.tabRealtimeData);
            this.tabLeftControl.Controls.Add(this.tabConnection);
            this.tabLeftControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLeftControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabLeftControl.Location = new System.Drawing.Point(0, 0);
            this.tabLeftControl.Multiline = true;
            this.tabLeftControl.Name = "tabLeftControl";
            this.tabLeftControl.SelectedIndex = 0;
            this.tabLeftControl.Size = new System.Drawing.Size(456, 966);
            this.tabLeftControl.TabIndex = 0;
            // 
            // tabProductInput
            // 
            this.tabProductInput.Controls.Add(this.subPanelToPutData);
            this.tabProductInput.Location = new System.Drawing.Point(4, 4);
            this.tabProductInput.Name = "tabProductInput";
            this.tabProductInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductInput.Size = new System.Drawing.Size(413, 958);
            this.tabProductInput.TabIndex = 0;
            this.tabProductInput.Text = "Product";
            this.tabProductInput.UseVisualStyleBackColor = true;
            // 
            // subPanelToPutData
            // 
            this.subPanelToPutData.AutoScroll = true;
            this.subPanelToPutData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.subPanelToPutData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPanelToPutData.Controls.Add(this.pnBatteryCapacity);
            this.subPanelToPutData.Controls.Add(this.pnBatteryType);
            this.subPanelToPutData.Controls.Add(this.pnSeries);
            this.subPanelToPutData.Controls.Add(this.pnModel);
            this.subPanelToPutData.Controls.Add(this.pnProductGroup);
            this.subPanelToPutData.Controls.Add(this.pnPerson);
            this.subPanelToPutData.Controls.Add(this.pnMfgDate);
            this.subPanelToPutData.Controls.Add(this.pnLot);
            this.subPanelToPutData.Controls.Add(this.pnSerialNumber);
            this.subPanelToPutData.Controls.Add(this.pnJobNumber);
            this.subPanelToPutData.Controls.Add(this.pnHeaderDataInput);
            this.subPanelToPutData.Controls.Add(this.btnSubmitMeasurement);
            this.subPanelToPutData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelToPutData.Location = new System.Drawing.Point(3, 3);
            this.subPanelToPutData.Name = "subPanelToPutData";
            this.subPanelToPutData.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.subPanelToPutData.Size = new System.Drawing.Size(407, 952);
            this.subPanelToPutData.TabIndex = 89;
            // 
            // pnBatteryCapacity
            // 
            this.pnBatteryCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBatteryCapacity.Controls.Add(this.labelBatteryCapacity);
            this.pnBatteryCapacity.Controls.Add(this.cboBatteryCapacityM);
            this.pnBatteryCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBatteryCapacity.Location = new System.Drawing.Point(0, 962);
            this.pnBatteryCapacity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnBatteryCapacity.Name = "pnBatteryCapacity";
            this.pnBatteryCapacity.Padding = new System.Windows.Forms.Padding(5);
            this.pnBatteryCapacity.Size = new System.Drawing.Size(384, 100);
            this.pnBatteryCapacity.TabIndex = 107;
            // 
            // labelBatteryCapacity
            // 
            this.labelBatteryCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBatteryCapacity.AutoSize = true;
            this.labelBatteryCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBatteryCapacity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBatteryCapacity.Location = new System.Drawing.Point(4, 10);
            this.labelBatteryCapacity.Name = "labelBatteryCapacity";
            this.labelBatteryCapacity.Size = new System.Drawing.Size(185, 29);
            this.labelBatteryCapacity.TabIndex = 86;
            this.labelBatteryCapacity.Text = "Battery Capacity";
            // 
            // cboBatteryCapacityM
            // 
            this.cboBatteryCapacityM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboBatteryCapacityM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatteryCapacityM.Enabled = false;
            this.cboBatteryCapacityM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboBatteryCapacityM.FormattingEnabled = true;
            this.cboBatteryCapacityM.Location = new System.Drawing.Point(5, 45);
            this.cboBatteryCapacityM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBatteryCapacityM.Name = "cboBatteryCapacityM";
            this.cboBatteryCapacityM.Size = new System.Drawing.Size(370, 46);
            this.cboBatteryCapacityM.TabIndex = 87;
            this.cboBatteryCapacityM.Click += new System.EventHandler(this.cboProductGroupM_Click);
            // 
            // pnBatteryType
            // 
            this.pnBatteryType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBatteryType.Controls.Add(this.labelBatteryType);
            this.pnBatteryType.Controls.Add(this.cboBatteryTypeM);
            this.pnBatteryType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBatteryType.Location = new System.Drawing.Point(0, 864);
            this.pnBatteryType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnBatteryType.Name = "pnBatteryType";
            this.pnBatteryType.Padding = new System.Windows.Forms.Padding(5);
            this.pnBatteryType.Size = new System.Drawing.Size(384, 98);
            this.pnBatteryType.TabIndex = 106;
            // 
            // labelBatteryType
            // 
            this.labelBatteryType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBatteryType.AutoSize = true;
            this.labelBatteryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBatteryType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBatteryType.Location = new System.Drawing.Point(4, 9);
            this.labelBatteryType.Name = "labelBatteryType";
            this.labelBatteryType.Size = new System.Drawing.Size(148, 29);
            this.labelBatteryType.TabIndex = 84;
            this.labelBatteryType.Text = "Battery Type";
            // 
            // cboBatteryTypeM
            // 
            this.cboBatteryTypeM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboBatteryTypeM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatteryTypeM.Enabled = false;
            this.cboBatteryTypeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboBatteryTypeM.FormattingEnabled = true;
            this.cboBatteryTypeM.Location = new System.Drawing.Point(5, 43);
            this.cboBatteryTypeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBatteryTypeM.Name = "cboBatteryTypeM";
            this.cboBatteryTypeM.Size = new System.Drawing.Size(370, 46);
            this.cboBatteryTypeM.TabIndex = 85;
            this.cboBatteryTypeM.SelectedIndexChanged += new System.EventHandler(this.cboBatteryTypeM_SelectedIndexChanged);
            this.cboBatteryTypeM.Click += new System.EventHandler(this.cboProductGroupM_Click);
            // 
            // pnSeries
            // 
            this.pnSeries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSeries.Controls.Add(this.labelProductSeries);
            this.pnSeries.Controls.Add(this.cboModelM);
            this.pnSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSeries.Location = new System.Drawing.Point(0, 769);
            this.pnSeries.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnSeries.Name = "pnSeries";
            this.pnSeries.Padding = new System.Windows.Forms.Padding(5);
            this.pnSeries.Size = new System.Drawing.Size(384, 95);
            this.pnSeries.TabIndex = 104;
            // 
            // labelProductSeries
            // 
            this.labelProductSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductSeries.AutoSize = true;
            this.labelProductSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelProductSeries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProductSeries.Location = new System.Drawing.Point(4, 9);
            this.labelProductSeries.Name = "labelProductSeries";
            this.labelProductSeries.Size = new System.Drawing.Size(83, 29);
            this.labelProductSeries.TabIndex = 68;
            this.labelProductSeries.Text = "Series";
            // 
            // cboModelM
            // 
            this.cboModelM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboModelM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelM.Enabled = false;
            this.cboModelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboModelM.FormattingEnabled = true;
            this.cboModelM.Location = new System.Drawing.Point(5, 40);
            this.cboModelM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboModelM.Name = "cboModelM";
            this.cboModelM.Size = new System.Drawing.Size(370, 46);
            this.cboModelM.TabIndex = 83;
            this.cboModelM.SelectedIndexChanged += new System.EventHandler(this.cboModelM_SelectedIndexChanged);
            this.cboModelM.Click += new System.EventHandler(this.cboProductGroupM_Click);
            // 
            // pnModel
            // 
            this.pnModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnModel.Controls.Add(this.labelSeriesModel);
            this.pnModel.Controls.Add(this.cboSeriesM);
            this.pnModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnModel.Location = new System.Drawing.Point(0, 671);
            this.pnModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnModel.Name = "pnModel";
            this.pnModel.Padding = new System.Windows.Forms.Padding(5);
            this.pnModel.Size = new System.Drawing.Size(384, 98);
            this.pnModel.TabIndex = 105;
            // 
            // labelSeriesModel
            // 
            this.labelSeriesModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeriesModel.AutoSize = true;
            this.labelSeriesModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSeriesModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeriesModel.Location = new System.Drawing.Point(4, 9);
            this.labelSeriesModel.Name = "labelSeriesModel";
            this.labelSeriesModel.Size = new System.Drawing.Size(81, 29);
            this.labelSeriesModel.TabIndex = 69;
            this.labelSeriesModel.Text = "Model";
            // 
            // cboSeriesM
            // 
            this.cboSeriesM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboSeriesM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeriesM.Enabled = false;
            this.cboSeriesM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboSeriesM.FormattingEnabled = true;
            this.cboSeriesM.Location = new System.Drawing.Point(5, 43);
            this.cboSeriesM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSeriesM.Name = "cboSeriesM";
            this.cboSeriesM.Size = new System.Drawing.Size(370, 46);
            this.cboSeriesM.TabIndex = 82;
            this.cboSeriesM.SelectedIndexChanged += new System.EventHandler(this.cboSeriesM_SelectedIndexChanged);
            this.cboSeriesM.Click += new System.EventHandler(this.cboProductGroupM_Click);
            // 
            // pnProductGroup
            // 
            this.pnProductGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnProductGroup.Controls.Add(this.cboProductGroupM);
            this.pnProductGroup.Controls.Add(this.labelProductGroup);
            this.pnProductGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnProductGroup.Location = new System.Drawing.Point(0, 563);
            this.pnProductGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnProductGroup.Name = "pnProductGroup";
            this.pnProductGroup.Padding = new System.Windows.Forms.Padding(5);
            this.pnProductGroup.Size = new System.Drawing.Size(384, 108);
            this.pnProductGroup.TabIndex = 103;
            // 
            // cboProductGroupM
            // 
            this.cboProductGroupM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboProductGroupM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductGroupM.Enabled = false;
            this.cboProductGroupM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboProductGroupM.FormattingEnabled = true;
            this.cboProductGroupM.Location = new System.Drawing.Point(5, 53);
            this.cboProductGroupM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProductGroupM.Name = "cboProductGroupM";
            this.cboProductGroupM.Size = new System.Drawing.Size(370, 46);
            this.cboProductGroupM.TabIndex = 81;
            this.cboProductGroupM.SelectedIndexChanged += new System.EventHandler(this.cboProductGroupM_SelectedIndexChanged);
            this.cboProductGroupM.Click += new System.EventHandler(this.cboProductGroupM_Click);
            // 
            // labelProductGroup
            // 
            this.labelProductGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductGroup.AutoSize = true;
            this.labelProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProductGroup.Location = new System.Drawing.Point(4, 9);
            this.labelProductGroup.Name = "labelProductGroup";
            this.labelProductGroup.Size = new System.Drawing.Size(169, 29);
            this.labelProductGroup.TabIndex = 78;
            this.labelProductGroup.Text = "Product Group";
            // 
            // pnPerson
            // 
            this.pnPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPerson.Controls.Add(this.labelMeasureBy);
            this.pnPerson.Controls.Add(this.txtMeasureBy);
            this.pnPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPerson.Location = new System.Drawing.Point(0, 455);
            this.pnPerson.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnPerson.Name = "pnPerson";
            this.pnPerson.Padding = new System.Windows.Forms.Padding(5);
            this.pnPerson.Size = new System.Drawing.Size(384, 108);
            this.pnPerson.TabIndex = 102;
            // 
            // labelMeasureBy
            // 
            this.labelMeasureBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMeasureBy.AutoSize = true;
            this.labelMeasureBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMeasureBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMeasureBy.Location = new System.Drawing.Point(4, 13);
            this.labelMeasureBy.Name = "labelMeasureBy";
            this.labelMeasureBy.Size = new System.Drawing.Size(267, 29);
            this.labelMeasureBy.TabIndex = 95;
            this.labelMeasureBy.Text = "Person (บุคคลที่ตรวจสอบ)";
            // 
            // txtMeasureBy
            // 
            this.txtMeasureBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeasureBy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMeasureBy.Enabled = false;
            this.txtMeasureBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMeasureBy.Location = new System.Drawing.Point(5, 54);
            this.txtMeasureBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasureBy.Name = "txtMeasureBy";
            this.txtMeasureBy.Size = new System.Drawing.Size(370, 45);
            this.txtMeasureBy.TabIndex = 96;
            // 
            // pnMfgDate
            // 
            this.pnMfgDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMfgDate.Controls.Add(this.txtManufacDate);
            this.pnMfgDate.Controls.Add(this.labelManufactorData);
            this.pnMfgDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMfgDate.Location = new System.Drawing.Point(0, 352);
            this.pnMfgDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnMfgDate.Name = "pnMfgDate";
            this.pnMfgDate.Padding = new System.Windows.Forms.Padding(5);
            this.pnMfgDate.Size = new System.Drawing.Size(384, 103);
            this.pnMfgDate.TabIndex = 101;
            // 
            // txtManufacDate
            // 
            this.txtManufacDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManufacDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtManufacDate.Enabled = false;
            this.txtManufacDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtManufacDate.Location = new System.Drawing.Point(5, 49);
            this.txtManufacDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManufacDate.Name = "txtManufacDate";
            this.txtManufacDate.Size = new System.Drawing.Size(370, 45);
            this.txtManufacDate.TabIndex = 94;
            // 
            // labelManufactorData
            // 
            this.labelManufactorData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelManufactorData.AutoSize = true;
            this.labelManufactorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelManufactorData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManufactorData.Location = new System.Drawing.Point(4, 10);
            this.labelManufactorData.Name = "labelManufactorData";
            this.labelManufactorData.Size = new System.Drawing.Size(224, 29);
            this.labelManufactorData.TabIndex = 93;
            this.labelManufactorData.Text = "MFG Date (วันที่ผลิต)";
            // 
            // pnLot
            // 
            this.pnLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLot.Controls.Add(this.txtLot);
            this.pnLot.Controls.Add(this.labelLot);
            this.pnLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLot.Location = new System.Drawing.Point(0, 254);
            this.pnLot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnLot.Name = "pnLot";
            this.pnLot.Padding = new System.Windows.Forms.Padding(5);
            this.pnLot.Size = new System.Drawing.Size(384, 98);
            this.pnLot.TabIndex = 100;
            // 
            // txtLot
            // 
            this.txtLot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLot.Enabled = false;
            this.txtLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLot.Location = new System.Drawing.Point(5, 44);
            this.txtLot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(370, 45);
            this.txtLot.TabIndex = 92;
            // 
            // labelLot
            // 
            this.labelLot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLot.AutoSize = true;
            this.labelLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelLot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLot.Location = new System.Drawing.Point(4, 11);
            this.labelLot.Name = "labelLot";
            this.labelLot.Size = new System.Drawing.Size(61, 29);
            this.labelLot.TabIndex = 91;
            this.labelLot.Text = "LOT";
            // 
            // pnSerialNumber
            // 
            this.pnSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSerialNumber.Controls.Add(this.labelSerialNumber);
            this.pnSerialNumber.Controls.Add(this.txtSerialNumber);
            this.pnSerialNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSerialNumber.Location = new System.Drawing.Point(0, 154);
            this.pnSerialNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnSerialNumber.Name = "pnSerialNumber";
            this.pnSerialNumber.Padding = new System.Windows.Forms.Padding(5);
            this.pnSerialNumber.Size = new System.Drawing.Size(384, 100);
            this.pnSerialNumber.TabIndex = 99;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSerialNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSerialNumber.Location = new System.Drawing.Point(4, 10);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(169, 29);
            this.labelSerialNumber.TabIndex = 89;
            this.labelSerialNumber.Text = "Serial Number";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSerialNumber.Enabled = false;
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSerialNumber.Location = new System.Drawing.Point(5, 46);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(370, 45);
            this.txtSerialNumber.TabIndex = 90;
            // 
            // pnJobNumber
            // 
            this.pnJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnJobNumber.Controls.Add(this.labelJobNumber);
            this.pnJobNumber.Controls.Add(this.txtJobNumber);
            this.pnJobNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnJobNumber.Location = new System.Drawing.Point(0, 54);
            this.pnJobNumber.Name = "pnJobNumber";
            this.pnJobNumber.Padding = new System.Windows.Forms.Padding(5);
            this.pnJobNumber.Size = new System.Drawing.Size(384, 100);
            this.pnJobNumber.TabIndex = 98;
            // 
            // labelJobNumber
            // 
            this.labelJobNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJobNumber.AutoSize = true;
            this.labelJobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelJobNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelJobNumber.Location = new System.Drawing.Point(4, 10);
            this.labelJobNumber.Name = "labelJobNumber";
            this.labelJobNumber.Size = new System.Drawing.Size(146, 29);
            this.labelJobNumber.TabIndex = 79;
            this.labelJobNumber.Text = "Job Number";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtJobNumber.Enabled = false;
            this.txtJobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtJobNumber.Location = new System.Drawing.Point(5, 46);
            this.txtJobNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(370, 45);
            this.txtJobNumber.TabIndex = 80;
            // 
            // pnHeaderDataInput
            // 
            this.pnHeaderDataInput.BackColor = System.Drawing.Color.DarkRed;
            this.pnHeaderDataInput.Controls.Add(this.lblHeaderInputData);
            this.pnHeaderDataInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderDataInput.Location = new System.Drawing.Point(0, 10);
            this.pnHeaderDataInput.Name = "pnHeaderDataInput";
            this.pnHeaderDataInput.Size = new System.Drawing.Size(384, 44);
            this.pnHeaderDataInput.TabIndex = 97;
            // 
            // lblHeaderInputData
            // 
            this.lblHeaderInputData.AutoSize = true;
            this.lblHeaderInputData.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeaderInputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeaderInputData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeaderInputData.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderInputData.Name = "lblHeaderInputData";
            this.lblHeaderInputData.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblHeaderInputData.Size = new System.Drawing.Size(162, 34);
            this.lblHeaderInputData.TabIndex = 98;
            this.lblHeaderInputData.Text = "Product Input";
            this.lblHeaderInputData.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSubmitMeasurement
            // 
            this.btnSubmitMeasurement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSubmitMeasurement.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubmitMeasurement.IconColor = System.Drawing.Color.Black;
            this.btnSubmitMeasurement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmitMeasurement.Location = new System.Drawing.Point(0, 1062);
            this.btnSubmitMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitMeasurement.Name = "btnSubmitMeasurement";
            this.btnSubmitMeasurement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnSubmitMeasurement.Size = new System.Drawing.Size(384, 105);
            this.btnSubmitMeasurement.TabIndex = 88;
            this.btnSubmitMeasurement.Text = "New Measurement";
            this.btnSubmitMeasurement.UseVisualStyleBackColor = true;
            this.btnSubmitMeasurement.Click += new System.EventHandler(this.btnSubmitMeasurement_Click);
            // 
            // tabBuffer
            // 
            this.tabBuffer.Controls.Add(this.pnMovingAverage);
            this.tabBuffer.Location = new System.Drawing.Point(4, 4);
            this.tabBuffer.Name = "tabBuffer";
            this.tabBuffer.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuffer.Size = new System.Drawing.Size(413, 958);
            this.tabBuffer.TabIndex = 1;
            this.tabBuffer.Text = "Buffer";
            this.tabBuffer.UseVisualStyleBackColor = true;
            // 
            // pnMovingAverage
            // 
            this.pnMovingAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnMovingAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMovingAverage.Controls.Add(this.pnCurrentAxis);
            this.pnMovingAverage.Controls.Add(this.pnMAAxis);
            this.pnMovingAverage.Controls.Add(this.pnVoltageAxis);
            this.pnMovingAverage.Controls.Add(this.pnVoltageBuffer);
            this.pnMovingAverage.Controls.Add(this.pnHeaderMovingAverage);
            this.pnMovingAverage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMovingAverage.Location = new System.Drawing.Point(3, 3);
            this.pnMovingAverage.Name = "pnMovingAverage";
            this.pnMovingAverage.Padding = new System.Windows.Forms.Padding(1, 10, 1, 0);
            this.pnMovingAverage.Size = new System.Drawing.Size(407, 526);
            this.pnMovingAverage.TabIndex = 107;
            this.pnMovingAverage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMovingAverage_Paint);
            // 
            // pnCurrentAxis
            // 
            this.pnCurrentAxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCurrentAxis.Controls.Add(this.pnChbCurrentVisibility);
            this.pnCurrentAxis.Controls.Add(this.pnCurrentAxisLabel);
            this.pnCurrentAxis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCurrentAxis.Location = new System.Drawing.Point(1, 346);
            this.pnCurrentAxis.Name = "pnCurrentAxis";
            this.pnCurrentAxis.Size = new System.Drawing.Size(403, 93);
            this.pnCurrentAxis.TabIndex = 100;
            // 
            // pnChbCurrentVisibility
            // 
            this.pnChbCurrentVisibility.Controls.Add(this.chbVisibleCurrentAxis);
            this.pnChbCurrentVisibility.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChbCurrentVisibility.Location = new System.Drawing.Point(0, 37);
            this.pnChbCurrentVisibility.Name = "pnChbCurrentVisibility";
            this.pnChbCurrentVisibility.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnChbCurrentVisibility.Size = new System.Drawing.Size(401, 34);
            this.pnChbCurrentVisibility.TabIndex = 11;
            // 
            // chbVisibleCurrentAxis
            // 
            this.chbVisibleCurrentAxis.AutoSize = true;
            this.chbVisibleCurrentAxis.Checked = true;
            this.chbVisibleCurrentAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVisibleCurrentAxis.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbVisibleCurrentAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chbVisibleCurrentAxis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chbVisibleCurrentAxis.Location = new System.Drawing.Point(20, 0);
            this.chbVisibleCurrentAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbVisibleCurrentAxis.Name = "chbVisibleCurrentAxis";
            this.chbVisibleCurrentAxis.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.chbVisibleCurrentAxis.Size = new System.Drawing.Size(92, 34);
            this.chbVisibleCurrentAxis.TabIndex = 9;
            this.chbVisibleCurrentAxis.Text = "Show";
            this.chbVisibleCurrentAxis.UseVisualStyleBackColor = true;
            this.chbVisibleCurrentAxis.CheckedChanged += new System.EventHandler(this.chbVisibleCurrentAxis_CheckedChanged);
            // 
            // pnCurrentAxisLabel
            // 
            this.pnCurrentAxisLabel.Controls.Add(this.labelCurrentFocus);
            this.pnCurrentAxisLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCurrentAxisLabel.Location = new System.Drawing.Point(0, 0);
            this.pnCurrentAxisLabel.Name = "pnCurrentAxisLabel";
            this.pnCurrentAxisLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnCurrentAxisLabel.Size = new System.Drawing.Size(401, 37);
            this.pnCurrentAxisLabel.TabIndex = 10;
            // 
            // labelCurrentFocus
            // 
            this.labelCurrentFocus.AutoSize = true;
            this.labelCurrentFocus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCurrentFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelCurrentFocus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCurrentFocus.Location = new System.Drawing.Point(20, 0);
            this.labelCurrentFocus.Name = "labelCurrentFocus";
            this.labelCurrentFocus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelCurrentFocus.Size = new System.Drawing.Size(120, 35);
            this.labelCurrentFocus.TabIndex = 8;
            this.labelCurrentFocus.Text = "Current Axis";
            this.labelCurrentFocus.Click += new System.EventHandler(this.labelCurrentFocus_Click);
            // 
            // pnMAAxis
            // 
            this.pnMAAxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMAAxis.Controls.Add(this.panel4);
            this.pnMAAxis.Controls.Add(this.pnMAlabel);
            this.pnMAAxis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMAAxis.Location = new System.Drawing.Point(1, 251);
            this.pnMAAxis.Name = "pnMAAxis";
            this.pnMAAxis.Size = new System.Drawing.Size(403, 95);
            this.pnMAAxis.TabIndex = 109;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chbMAVoltageAxis);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(401, 42);
            this.panel4.TabIndex = 9;
            // 
            // chbMAVoltageAxis
            // 
            this.chbMAVoltageAxis.AutoSize = true;
            this.chbMAVoltageAxis.Checked = true;
            this.chbMAVoltageAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMAVoltageAxis.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbMAVoltageAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chbMAVoltageAxis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chbMAVoltageAxis.Location = new System.Drawing.Point(20, 0);
            this.chbMAVoltageAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMAVoltageAxis.Name = "chbMAVoltageAxis";
            this.chbMAVoltageAxis.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.chbMAVoltageAxis.Size = new System.Drawing.Size(92, 42);
            this.chbMAVoltageAxis.TabIndex = 7;
            this.chbMAVoltageAxis.Text = "Show";
            this.chbMAVoltageAxis.UseVisualStyleBackColor = true;
            this.chbMAVoltageAxis.CheckedChanged += new System.EventHandler(this.chbMAVoltageAxis_CheckedChanged);
            // 
            // pnMAlabel
            // 
            this.pnMAlabel.Controls.Add(this.lblMovingAverage);
            this.pnMAlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMAlabel.Location = new System.Drawing.Point(0, 0);
            this.pnMAlabel.Name = "pnMAlabel";
            this.pnMAlabel.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.pnMAlabel.Size = new System.Drawing.Size(401, 38);
            this.pnMAlabel.TabIndex = 8;
            // 
            // lblMovingAverage
            // 
            this.lblMovingAverage.AutoSize = true;
            this.lblMovingAverage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMovingAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMovingAverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovingAverage.Location = new System.Drawing.Point(20, 10);
            this.lblMovingAverage.Name = "lblMovingAverage";
            this.lblMovingAverage.Size = new System.Drawing.Size(158, 25);
            this.lblMovingAverage.TabIndex = 6;
            this.lblMovingAverage.Text = "MA Voltage Axis";
            // 
            // pnVoltageAxis
            // 
            this.pnVoltageAxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVoltageAxis.Controls.Add(this.pnChbVoltageVisibility);
            this.pnVoltageAxis.Controls.Add(this.pnLabelVoltageAxis);
            this.pnVoltageAxis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVoltageAxis.Location = new System.Drawing.Point(1, 155);
            this.pnVoltageAxis.Name = "pnVoltageAxis";
            this.pnVoltageAxis.Size = new System.Drawing.Size(403, 96);
            this.pnVoltageAxis.TabIndex = 99;
            // 
            // pnChbVoltageVisibility
            // 
            this.pnChbVoltageVisibility.Controls.Add(this.chbVisibleVoltageAxis);
            this.pnChbVoltageVisibility.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChbVoltageVisibility.Location = new System.Drawing.Point(0, 38);
            this.pnChbVoltageVisibility.Name = "pnChbVoltageVisibility";
            this.pnChbVoltageVisibility.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnChbVoltageVisibility.Size = new System.Drawing.Size(401, 42);
            this.pnChbVoltageVisibility.TabIndex = 9;
            // 
            // chbVisibleVoltageAxis
            // 
            this.chbVisibleVoltageAxis.AutoSize = true;
            this.chbVisibleVoltageAxis.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbVisibleVoltageAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chbVisibleVoltageAxis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chbVisibleVoltageAxis.Location = new System.Drawing.Point(20, 0);
            this.chbVisibleVoltageAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbVisibleVoltageAxis.Name = "chbVisibleVoltageAxis";
            this.chbVisibleVoltageAxis.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.chbVisibleVoltageAxis.Size = new System.Drawing.Size(92, 42);
            this.chbVisibleVoltageAxis.TabIndex = 7;
            this.chbVisibleVoltageAxis.Text = "Show";
            this.chbVisibleVoltageAxis.UseVisualStyleBackColor = true;
            this.chbVisibleVoltageAxis.CheckedChanged += new System.EventHandler(this.chbVisibleVoltageAxis_CheckedChanged);
            // 
            // pnLabelVoltageAxis
            // 
            this.pnLabelVoltageAxis.Controls.Add(this.labelVoltageFocus);
            this.pnLabelVoltageAxis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLabelVoltageAxis.Location = new System.Drawing.Point(0, 0);
            this.pnLabelVoltageAxis.Name = "pnLabelVoltageAxis";
            this.pnLabelVoltageAxis.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.pnLabelVoltageAxis.Size = new System.Drawing.Size(401, 38);
            this.pnLabelVoltageAxis.TabIndex = 8;
            // 
            // labelVoltageFocus
            // 
            this.labelVoltageFocus.AutoSize = true;
            this.labelVoltageFocus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVoltageFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelVoltageFocus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVoltageFocus.Location = new System.Drawing.Point(20, 10);
            this.labelVoltageFocus.Name = "labelVoltageFocus";
            this.labelVoltageFocus.Size = new System.Drawing.Size(122, 25);
            this.labelVoltageFocus.TabIndex = 6;
            this.labelVoltageFocus.Text = "Voltage Axis";
            this.labelVoltageFocus.Click += new System.EventHandler(this.labelVoltageFocus_Click);
            // 
            // pnVoltageBuffer
            // 
            this.pnVoltageBuffer.Controls.Add(this.cboSelectBuffer);
            this.pnVoltageBuffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVoltageBuffer.Location = new System.Drawing.Point(1, 57);
            this.pnVoltageBuffer.Name = "pnVoltageBuffer";
            this.pnVoltageBuffer.Padding = new System.Windows.Forms.Padding(10);
            this.pnVoltageBuffer.Size = new System.Drawing.Size(403, 98);
            this.pnVoltageBuffer.TabIndex = 98;
            // 
            // cboSelectBuffer
            // 
            this.cboSelectBuffer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSelectBuffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboSelectBuffer.FormattingEnabled = true;
            this.cboSelectBuffer.Location = new System.Drawing.Point(10, 10);
            this.cboSelectBuffer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSelectBuffer.Name = "cboSelectBuffer";
            this.cboSelectBuffer.Size = new System.Drawing.Size(383, 46);
            this.cboSelectBuffer.TabIndex = 5;
            this.cboSelectBuffer.SelectedIndexChanged += new System.EventHandler(this.cboSelectBuffer_SelectedIndexChanged);
            // 
            // pnHeaderMovingAverage
            // 
            this.pnHeaderMovingAverage.BackColor = System.Drawing.Color.DarkRed;
            this.pnHeaderMovingAverage.Controls.Add(this.lbHeaderMovingAverage);
            this.pnHeaderMovingAverage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderMovingAverage.Location = new System.Drawing.Point(1, 10);
            this.pnHeaderMovingAverage.Name = "pnHeaderMovingAverage";
            this.pnHeaderMovingAverage.Size = new System.Drawing.Size(403, 47);
            this.pnHeaderMovingAverage.TabIndex = 97;
            // 
            // lbHeaderMovingAverage
            // 
            this.lbHeaderMovingAverage.AutoSize = true;
            this.lbHeaderMovingAverage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbHeaderMovingAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbHeaderMovingAverage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbHeaderMovingAverage.Location = new System.Drawing.Point(0, 0);
            this.lbHeaderMovingAverage.Name = "lbHeaderMovingAverage";
            this.lbHeaderMovingAverage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbHeaderMovingAverage.Size = new System.Drawing.Size(173, 34);
            this.lbHeaderMovingAverage.TabIndex = 98;
            this.lbHeaderMovingAverage.Text = "Voltage Buffer";
            this.lbHeaderMovingAverage.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabSpecificationsMM
            // 
            this.tabSpecificationsMM.Controls.Add(this.panel1);
            this.tabSpecificationsMM.Location = new System.Drawing.Point(4, 4);
            this.tabSpecificationsMM.Name = "tabSpecificationsMM";
            this.tabSpecificationsMM.Size = new System.Drawing.Size(413, 958);
            this.tabSpecificationsMM.TabIndex = 2;
            this.tabSpecificationsMM.Text = "Specification";
            this.tabSpecificationsMM.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hotSpot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(413, 74);
            this.panel1.TabIndex = 125;
            // 
            // hotSpot
            // 
            this.hotSpot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotSpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.hotSpot.IconChar = FontAwesome.Sharp.IconChar.None;
            this.hotSpot.IconColor = System.Drawing.Color.Black;
            this.hotSpot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hotSpot.Location = new System.Drawing.Point(10, 10);
            this.hotSpot.Name = "hotSpot";
            this.hotSpot.Size = new System.Drawing.Size(393, 54);
            this.hotSpot.TabIndex = 113;
            this.hotSpot.Text = "Change IP Address";
            this.hotSpot.UseVisualStyleBackColor = true;
            this.hotSpot.Click += new System.EventHandler(this.hotSpot_Click);
            // 
            // tabRealtimeData
            // 
            this.tabRealtimeData.Controls.Add(this.pnSpecificationMean);
            this.tabRealtimeData.Controls.Add(this.pnRealTimeData);
            this.tabRealtimeData.Controls.Add(this.pnSpecifications);
            this.tabRealtimeData.Location = new System.Drawing.Point(4, 4);
            this.tabRealtimeData.Name = "tabRealtimeData";
            this.tabRealtimeData.Size = new System.Drawing.Size(413, 958);
            this.tabRealtimeData.TabIndex = 4;
            this.tabRealtimeData.Text = "Real Time Data";
            this.tabRealtimeData.UseVisualStyleBackColor = true;
            // 
            // pnSpecificationMean
            // 
            this.pnSpecificationMean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnSpecificationMean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSpecificationMean.Controls.Add(this.pnLowCutOffMean);
            this.pnSpecificationMean.Controls.Add(this.panel16);
            this.pnSpecificationMean.Controls.Add(this.panel14);
            this.pnSpecificationMean.Controls.Add(this.pnLowMeanlable);
            this.pnSpecificationMean.Controls.Add(this.panel2);
            this.pnSpecificationMean.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpecificationMean.Location = new System.Drawing.Point(0, 799);
            this.pnSpecificationMean.Name = "pnSpecificationMean";
            this.pnSpecificationMean.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnSpecificationMean.Size = new System.Drawing.Size(413, 491);
            this.pnSpecificationMean.TabIndex = 126;
            this.pnSpecificationMean.Visible = false;
            // 
            // pnLowCutOffMean
            // 
            this.pnLowCutOffMean.Controls.Add(this.panel19);
            this.pnLowCutOffMean.Controls.Add(this.labelMeanVoltageCutOff);
            this.pnLowCutOffMean.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLowCutOffMean.Location = new System.Drawing.Point(0, 255);
            this.pnLowCutOffMean.Name = "pnLowCutOffMean";
            this.pnLowCutOffMean.Size = new System.Drawing.Size(411, 66);
            this.pnLowCutOffMean.TabIndex = 113;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtMeanVoltageCutOff);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel19.Location = new System.Drawing.Point(268, 0);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.panel19.Size = new System.Drawing.Size(143, 66);
            this.panel19.TabIndex = 84;
            // 
            // txtMeanVoltageCutOff
            // 
            this.txtMeanVoltageCutOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeanVoltageCutOff.Enabled = false;
            this.txtMeanVoltageCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMeanVoltageCutOff.Location = new System.Drawing.Point(5, 5);
            this.txtMeanVoltageCutOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeanVoltageCutOff.Name = "txtMeanVoltageCutOff";
            this.txtMeanVoltageCutOff.ReadOnly = true;
            this.txtMeanVoltageCutOff.Size = new System.Drawing.Size(128, 45);
            this.txtMeanVoltageCutOff.TabIndex = 104;
            this.txtMeanVoltageCutOff.Visible = false;
            // 
            // labelMeanVoltageCutOff
            // 
            this.labelMeanVoltageCutOff.AutoSize = true;
            this.labelMeanVoltageCutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMeanVoltageCutOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMeanVoltageCutOff.Location = new System.Drawing.Point(51, 18);
            this.labelMeanVoltageCutOff.Name = "labelMeanVoltageCutOff";
            this.labelMeanVoltageCutOff.Size = new System.Drawing.Size(117, 25);
            this.labelMeanVoltageCutOff.TabIndex = 105;
            this.labelMeanVoltageCutOff.Text = "Low Cut-Off";
            this.labelMeanVoltageCutOff.Visible = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.pnCurrentConstantLabel);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 189);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(411, 66);
            this.panel16.TabIndex = 112;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtMeanVoltageChargerCurrentConstant);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(268, 0);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.panel17.Size = new System.Drawing.Size(143, 66);
            this.panel17.TabIndex = 84;
            // 
            // txtMeanVoltageChargerCurrentConstant
            // 
            this.txtMeanVoltageChargerCurrentConstant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeanVoltageChargerCurrentConstant.Enabled = false;
            this.txtMeanVoltageChargerCurrentConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMeanVoltageChargerCurrentConstant.Location = new System.Drawing.Point(5, 5);
            this.txtMeanVoltageChargerCurrentConstant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeanVoltageChargerCurrentConstant.Name = "txtMeanVoltageChargerCurrentConstant";
            this.txtMeanVoltageChargerCurrentConstant.ReadOnly = true;
            this.txtMeanVoltageChargerCurrentConstant.Size = new System.Drawing.Size(128, 45);
            this.txtMeanVoltageChargerCurrentConstant.TabIndex = 108;
            this.txtMeanVoltageChargerCurrentConstant.Visible = false;
            // 
            // pnCurrentConstantLabel
            // 
            this.pnCurrentConstantLabel.AutoSize = true;
            this.pnCurrentConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pnCurrentConstantLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnCurrentConstantLabel.Location = new System.Drawing.Point(17, 18);
            this.pnCurrentConstantLabel.Name = "pnCurrentConstantLabel";
            this.pnCurrentConstantLabel.Size = new System.Drawing.Size(161, 25);
            this.pnCurrentConstantLabel.TabIndex = 109;
            this.pnCurrentConstantLabel.Text = "Current Constant";
            this.pnCurrentConstantLabel.Visible = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.pnHighMeanLabel);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 123);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(411, 66);
            this.panel14.TabIndex = 111;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtMeanVoltageChargerHigh);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(268, 0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.panel15.Size = new System.Drawing.Size(143, 66);
            this.panel15.TabIndex = 84;
            // 
            // txtMeanVoltageChargerCut
            // 
            this.txtMeanVoltageChargerHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeanVoltageChargerHigh.Enabled = false;
            this.txtMeanVoltageChargerHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMeanVoltageChargerHigh.Location = new System.Drawing.Point(5, 5);
            this.txtMeanVoltageChargerHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeanVoltageChargerHigh.Name = "txtMeanVoltageChargerCut";
            this.txtMeanVoltageChargerHigh.ReadOnly = true;
            this.txtMeanVoltageChargerHigh.Size = new System.Drawing.Size(128, 45);
            this.txtMeanVoltageChargerHigh.TabIndex = 106;
            this.txtMeanVoltageChargerHigh.Visible = false;
            // 
            // pnHighMeanLabel
            // 
            this.pnHighMeanLabel.AutoSize = true;
            this.pnHighMeanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pnHighMeanLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnHighMeanLabel.Location = new System.Drawing.Point(76, 18);
            this.pnHighMeanLabel.Name = "pnHighMeanLabel";
            this.pnHighMeanLabel.Size = new System.Drawing.Size(93, 25);
            this.pnHighMeanLabel.TabIndex = 107;
            this.pnHighMeanLabel.Text = "High (ตัด)";
            this.pnHighMeanLabel.Visible = false;
            // 
            // pnLowMeanlable
            // 
            this.pnLowMeanlable.Controls.Add(this.pnLowMeanText);
            this.pnLowMeanlable.Controls.Add(this.labelVoltageChargerConnectMean);
            this.pnLowMeanlable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLowMeanlable.Location = new System.Drawing.Point(0, 57);
            this.pnLowMeanlable.Name = "pnLowMeanlable";
            this.pnLowMeanlable.Size = new System.Drawing.Size(411, 66);
            this.pnLowMeanlable.TabIndex = 110;
            // 
            // pnLowMeanText
            // 
            this.pnLowMeanText.Controls.Add(this.txtMeanVoltageChargerLow);
            this.pnLowMeanText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLowMeanText.Location = new System.Drawing.Point(268, 0);
            this.pnLowMeanText.Name = "pnLowMeanText";
            this.pnLowMeanText.Padding = new System.Windows.Forms.Padding(5, 8, 10, 5);
            this.pnLowMeanText.Size = new System.Drawing.Size(143, 66);
            this.pnLowMeanText.TabIndex = 84;
            // 
            // txtMeanVoltageChargerConnect
            // 
            this.txtMeanVoltageChargerLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeanVoltageChargerLow.Enabled = false;
            this.txtMeanVoltageChargerLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMeanVoltageChargerLow.Location = new System.Drawing.Point(5, 8);
            this.txtMeanVoltageChargerLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeanVoltageChargerLow.Name = "txtMeanVoltageChargerConnect";
            this.txtMeanVoltageChargerLow.ReadOnly = true;
            this.txtMeanVoltageChargerLow.Size = new System.Drawing.Size(128, 45);
            this.txtMeanVoltageChargerLow.TabIndex = 102;
            this.txtMeanVoltageChargerLow.Visible = false;
            // 
            // labelVoltageChargerConnectMean
            // 
            this.labelVoltageChargerConnectMean.AutoSize = true;
            this.labelVoltageChargerConnectMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelVoltageChargerConnectMean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVoltageChargerConnectMean.Location = new System.Drawing.Point(79, 21);
            this.labelVoltageChargerConnectMean.Name = "labelVoltageChargerConnectMean";
            this.labelVoltageChargerConnectMean.Size = new System.Drawing.Size(87, 25);
            this.labelVoltageChargerConnectMean.TabIndex = 103;
            this.labelVoltageChargerConnectMean.Text = "Low (ต่อ)";
            this.labelVoltageChargerConnectMean.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.lblSpeMean);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 47);
            this.panel2.TabIndex = 97;
            // 
            // lblSpeMean
            // 
            this.lblSpeMean.AutoSize = true;
            this.lblSpeMean.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSpeMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSpeMean.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSpeMean.Location = new System.Drawing.Point(0, 0);
            this.lblSpeMean.Name = "lblSpeMean";
            this.lblSpeMean.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblSpeMean.Size = new System.Drawing.Size(76, 34);
            this.lblSpeMean.TabIndex = 98;
            this.lblSpeMean.Text = "Mean";
            this.lblSpeMean.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnRealTimeData
            // 
            this.pnRealTimeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnRealTimeData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRealTimeData.Controls.Add(this.pnAlternativeCurrent);
            this.pnRealTimeData.Controls.Add(this.pnDirectCurrent);
            this.pnRealTimeData.Controls.Add(this.pnHeaderRealTimeData);
            this.pnRealTimeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRealTimeData.Location = new System.Drawing.Point(0, 392);
            this.pnRealTimeData.Name = "pnRealTimeData";
            this.pnRealTimeData.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnRealTimeData.Size = new System.Drawing.Size(413, 407);
            this.pnRealTimeData.TabIndex = 108;
            // 
            // pnAlternativeCurrent
            // 
            this.pnAlternativeCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAlternativeCurrent.Controls.Add(this.pnVoltageAc);
            this.pnAlternativeCurrent.Controls.Add(this.pnCurrentAc);
            this.pnAlternativeCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAlternativeCurrent.Location = new System.Drawing.Point(0, 271);
            this.pnAlternativeCurrent.Name = "pnAlternativeCurrent";
            this.pnAlternativeCurrent.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnAlternativeCurrent.Size = new System.Drawing.Size(411, 129);
            this.pnAlternativeCurrent.TabIndex = 123;
            // 
            // pnVoltageAc
            // 
            this.pnVoltageAc.Controls.Add(this.pnVoltageAcText);
            this.pnVoltageAc.Controls.Add(this.labelAcVoltage);
            this.pnVoltageAc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVoltageAc.Location = new System.Drawing.Point(0, 65);
            this.pnVoltageAc.Name = "pnVoltageAc";
            this.pnVoltageAc.Size = new System.Drawing.Size(409, 51);
            this.pnVoltageAc.TabIndex = 118;
            // 
            // pnVoltageAcText
            // 
            this.pnVoltageAcText.Controls.Add(this.txtAcVoltage);
            this.pnVoltageAcText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnVoltageAcText.Location = new System.Drawing.Point(233, 0);
            this.pnVoltageAcText.Name = "pnVoltageAcText";
            this.pnVoltageAcText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnVoltageAcText.Size = new System.Drawing.Size(176, 51);
            this.pnVoltageAcText.TabIndex = 84;
            // 
            // txtAcVoltage
            // 
            this.txtAcVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAcVoltage.Enabled = false;
            this.txtAcVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAcVoltage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAcVoltage.Location = new System.Drawing.Point(5, 10);
            this.txtAcVoltage.Name = "txtAcVoltage";
            this.txtAcVoltage.Size = new System.Drawing.Size(161, 45);
            this.txtAcVoltage.TabIndex = 105;
            // 
            // labelAcVoltage
            // 
            this.labelAcVoltage.AutoSize = true;
            this.labelAcVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAcVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAcVoltage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAcVoltage.Location = new System.Drawing.Point(0, 0);
            this.labelAcVoltage.Name = "labelAcVoltage";
            this.labelAcVoltage.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.labelAcVoltage.Size = new System.Drawing.Size(128, 40);
            this.labelAcVoltage.TabIndex = 104;
            this.labelAcVoltage.Text = "Voltage AC";
            // 
            // pnCurrentAc
            // 
            this.pnCurrentAc.Controls.Add(this.pnCurrentAcText);
            this.pnCurrentAc.Controls.Add(this.labelAcCurrent);
            this.pnCurrentAc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCurrentAc.Location = new System.Drawing.Point(0, 10);
            this.pnCurrentAc.Name = "pnCurrentAc";
            this.pnCurrentAc.Size = new System.Drawing.Size(409, 55);
            this.pnCurrentAc.TabIndex = 119;
            // 
            // pnCurrentAcText
            // 
            this.pnCurrentAcText.Controls.Add(this.txtAcCurrent);
            this.pnCurrentAcText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCurrentAcText.Location = new System.Drawing.Point(233, 0);
            this.pnCurrentAcText.Name = "pnCurrentAcText";
            this.pnCurrentAcText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnCurrentAcText.Size = new System.Drawing.Size(176, 55);
            this.pnCurrentAcText.TabIndex = 84;
            // 
            // txtAcCurrent
            // 
            this.txtAcCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAcCurrent.Enabled = false;
            this.txtAcCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAcCurrent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAcCurrent.Location = new System.Drawing.Point(5, 10);
            this.txtAcCurrent.Name = "txtAcCurrent";
            this.txtAcCurrent.Size = new System.Drawing.Size(161, 45);
            this.txtAcCurrent.TabIndex = 89;
            // 
            // labelAcCurrent
            // 
            this.labelAcCurrent.AutoSize = true;
            this.labelAcCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAcCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAcCurrent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAcCurrent.Location = new System.Drawing.Point(0, 0);
            this.labelAcCurrent.Name = "labelAcCurrent";
            this.labelAcCurrent.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.labelAcCurrent.Size = new System.Drawing.Size(126, 40);
            this.labelAcCurrent.TabIndex = 103;
            this.labelAcCurrent.Text = "Current AC";
            // 
            // pnDirectCurrent
            // 
            this.pnDirectCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDirectCurrent.Controls.Add(this.pnCurrentDc);
            this.pnDirectCurrent.Controls.Add(this.pnVoltageDc);
            this.pnDirectCurrent.Controls.Add(this.pnDericative);
            this.pnDirectCurrent.Controls.Add(this.pnMaVolage);
            this.pnDirectCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDirectCurrent.Location = new System.Drawing.Point(0, 60);
            this.pnDirectCurrent.Name = "pnDirectCurrent";
            this.pnDirectCurrent.Size = new System.Drawing.Size(411, 211);
            this.pnDirectCurrent.TabIndex = 122;
            // 
            // pnCurrentDc
            // 
            this.pnCurrentDc.Controls.Add(this.pnCurrentDCText);
            this.pnCurrentDc.Controls.Add(this.labelCurrentDataText);
            this.pnCurrentDc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCurrentDc.Location = new System.Drawing.Point(0, 151);
            this.pnCurrentDc.Name = "pnCurrentDc";
            this.pnCurrentDc.Size = new System.Drawing.Size(409, 51);
            this.pnCurrentDc.TabIndex = 115;
            // 
            // pnCurrentDCText
            // 
            this.pnCurrentDCText.Controls.Add(this.txtCurrentText);
            this.pnCurrentDCText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCurrentDCText.Location = new System.Drawing.Point(233, 0);
            this.pnCurrentDCText.Name = "pnCurrentDCText";
            this.pnCurrentDCText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnCurrentDCText.Size = new System.Drawing.Size(176, 51);
            this.pnCurrentDCText.TabIndex = 84;
            // 
            // txtCurrentText
            // 
            this.txtCurrentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentText.Enabled = false;
            this.txtCurrentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCurrentText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCurrentText.Location = new System.Drawing.Point(5, 10);
            this.txtCurrentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentText.Name = "txtCurrentText";
            this.txtCurrentText.Size = new System.Drawing.Size(161, 45);
            this.txtCurrentText.TabIndex = 102;
            // 
            // labelCurrentDataText
            // 
            this.labelCurrentDataText.AutoSize = true;
            this.labelCurrentDataText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentDataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelCurrentDataText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCurrentDataText.Location = new System.Drawing.Point(0, 0);
            this.labelCurrentDataText.Name = "labelCurrentDataText";
            this.labelCurrentDataText.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.labelCurrentDataText.Size = new System.Drawing.Size(126, 40);
            this.labelCurrentDataText.TabIndex = 101;
            this.labelCurrentDataText.Text = "Current DC";
            // 
            // pnVoltageDc
            // 
            this.pnVoltageDc.Controls.Add(this.pnVoltageDcText);
            this.pnVoltageDc.Controls.Add(this.labelVoltageDataText);
            this.pnVoltageDc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVoltageDc.Location = new System.Drawing.Point(0, 100);
            this.pnVoltageDc.Name = "pnVoltageDc";
            this.pnVoltageDc.Size = new System.Drawing.Size(409, 51);
            this.pnVoltageDc.TabIndex = 116;
            // 
            // pnVoltageDcText
            // 
            this.pnVoltageDcText.Controls.Add(this.txtVoltageText);
            this.pnVoltageDcText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnVoltageDcText.Location = new System.Drawing.Point(233, 0);
            this.pnVoltageDcText.Name = "pnVoltageDcText";
            this.pnVoltageDcText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnVoltageDcText.Size = new System.Drawing.Size(176, 51);
            this.pnVoltageDcText.TabIndex = 84;
            // 
            // txtVoltageText
            // 
            this.txtVoltageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoltageText.Enabled = false;
            this.txtVoltageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVoltageText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVoltageText.Location = new System.Drawing.Point(5, 10);
            this.txtVoltageText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoltageText.Name = "txtVoltageText";
            this.txtVoltageText.Size = new System.Drawing.Size(161, 45);
            this.txtVoltageText.TabIndex = 98;
            // 
            // labelVoltageDataText
            // 
            this.labelVoltageDataText.AutoSize = true;
            this.labelVoltageDataText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageDataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelVoltageDataText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVoltageDataText.Location = new System.Drawing.Point(0, 0);
            this.labelVoltageDataText.Name = "labelVoltageDataText";
            this.labelVoltageDataText.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.labelVoltageDataText.Size = new System.Drawing.Size(128, 40);
            this.labelVoltageDataText.TabIndex = 97;
            this.labelVoltageDataText.Text = "Voltage DC";
            // 
            // pnDericative
            // 
            this.pnDericative.Controls.Add(this.pnTextDerivative);
            this.pnDericative.Controls.Add(this.lblDvDt);
            this.pnDericative.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDericative.Location = new System.Drawing.Point(0, 51);
            this.pnDericative.Name = "pnDericative";
            this.pnDericative.Size = new System.Drawing.Size(409, 49);
            this.pnDericative.TabIndex = 120;
            // 
            // pnTextDerivative
            // 
            this.pnTextDerivative.Controls.Add(this.txtDerivative);
            this.pnTextDerivative.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTextDerivative.Location = new System.Drawing.Point(233, 0);
            this.pnTextDerivative.Name = "pnTextDerivative";
            this.pnTextDerivative.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnTextDerivative.Size = new System.Drawing.Size(176, 49);
            this.pnTextDerivative.TabIndex = 84;
            // 
            // txtDerivative
            // 
            this.txtDerivative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDerivative.Enabled = false;
            this.txtDerivative.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDerivative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDerivative.Location = new System.Drawing.Point(5, 10);
            this.txtDerivative.Name = "txtDerivative";
            this.txtDerivative.Size = new System.Drawing.Size(161, 45);
            this.txtDerivative.TabIndex = 89;
            // 
            // lblDvDt
            // 
            this.lblDvDt.AutoSize = true;
            this.lblDvDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDvDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDvDt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDvDt.Location = new System.Drawing.Point(0, 0);
            this.lblDvDt.Name = "lblDvDt";
            this.lblDvDt.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblDvDt.Size = new System.Drawing.Size(70, 40);
            this.lblDvDt.TabIndex = 103;
            this.lblDvDt.Text = "DvDt";
            // 
            // pnMaVolage
            // 
            this.pnMaVolage.Controls.Add(this.pnMAvoltageText);
            this.pnMaVolage.Controls.Add(this.labelMovingAVGVoltageDataText);
            this.pnMaVolage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMaVolage.Location = new System.Drawing.Point(0, 0);
            this.pnMaVolage.Name = "pnMaVolage";
            this.pnMaVolage.Size = new System.Drawing.Size(409, 51);
            this.pnMaVolage.TabIndex = 117;
            // 
            // pnMAvoltageText
            // 
            this.pnMAvoltageText.Controls.Add(this.txtMovingAverageText);
            this.pnMAvoltageText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMAvoltageText.Location = new System.Drawing.Point(233, 0);
            this.pnMAvoltageText.Name = "pnMAvoltageText";
            this.pnMAvoltageText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnMAvoltageText.Size = new System.Drawing.Size(176, 51);
            this.pnMAvoltageText.TabIndex = 84;
            // 
            // txtMovingAverageText
            // 
            this.txtMovingAverageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMovingAverageText.Enabled = false;
            this.txtMovingAverageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMovingAverageText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMovingAverageText.Location = new System.Drawing.Point(5, 10);
            this.txtMovingAverageText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovingAverageText.Name = "txtMovingAverageText";
            this.txtMovingAverageText.Size = new System.Drawing.Size(161, 45);
            this.txtMovingAverageText.TabIndex = 100;
            // 
            // labelMovingAVGVoltageDataText
            // 
            this.labelMovingAVGVoltageDataText.AutoSize = true;
            this.labelMovingAVGVoltageDataText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMovingAVGVoltageDataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMovingAVGVoltageDataText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMovingAVGVoltageDataText.Location = new System.Drawing.Point(0, 0);
            this.labelMovingAVGVoltageDataText.Name = "labelMovingAVGVoltageDataText";
            this.labelMovingAVGVoltageDataText.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.labelMovingAVGVoltageDataText.Size = new System.Drawing.Size(142, 40);
            this.labelMovingAVGVoltageDataText.TabIndex = 99;
            this.labelMovingAVGVoltageDataText.Text = "AVG Voltage";
            this.labelMovingAVGVoltageDataText.Click += new System.EventHandler(this.labelMovingAVGVoltageDataText_Click);
            // 
            // pnHeaderRealTimeData
            // 
            this.pnHeaderRealTimeData.BackColor = System.Drawing.Color.DarkRed;
            this.pnHeaderRealTimeData.Controls.Add(this.lblHeaderRealTimeData);
            this.pnHeaderRealTimeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderRealTimeData.Location = new System.Drawing.Point(0, 15);
            this.pnHeaderRealTimeData.Name = "pnHeaderRealTimeData";
            this.pnHeaderRealTimeData.Size = new System.Drawing.Size(411, 45);
            this.pnHeaderRealTimeData.TabIndex = 97;
            // 
            // lblHeaderRealTimeData
            // 
            this.lblHeaderRealTimeData.AutoSize = true;
            this.lblHeaderRealTimeData.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeaderRealTimeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeaderRealTimeData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeaderRealTimeData.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderRealTimeData.Name = "lblHeaderRealTimeData";
            this.lblHeaderRealTimeData.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblHeaderRealTimeData.Size = new System.Drawing.Size(189, 34);
            this.lblHeaderRealTimeData.TabIndex = 98;
            this.lblHeaderRealTimeData.Text = "Real TIme Data";
            this.lblHeaderRealTimeData.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnSpecifications
            // 
            this.pnSpecifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnSpecifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSpecifications.Controls.Add(this.pnLowCutOffMM);
            this.pnSpecifications.Controls.Add(this.pnCurrentConstantMM);
            this.pnSpecifications.Controls.Add(this.pnLabelHighMM);
            this.pnSpecifications.Controls.Add(this.panel9);
            this.pnSpecifications.Controls.Add(this.pnStage);
            this.pnSpecifications.Controls.Add(this.panel3);
            this.pnSpecifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpecifications.Location = new System.Drawing.Point(0, 0);
            this.pnSpecifications.Name = "pnSpecifications";
            this.pnSpecifications.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnSpecifications.Size = new System.Drawing.Size(413, 392);
            this.pnSpecifications.TabIndex = 125;
            // 
            // pnLowCutOffMM
            // 
            this.pnLowCutOffMM.Controls.Add(this.pnLowVoltageCutOff);
            this.pnLowCutOffMM.Controls.Add(this.labelLowVoltageCutOffMinMax);
            this.pnLowCutOffMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLowCutOffMM.Location = new System.Drawing.Point(0, 303);
            this.pnLowCutOffMM.Name = "pnLowCutOffMM";
            this.pnLowCutOffMM.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.pnLowCutOffMM.Size = new System.Drawing.Size(411, 62);
            this.pnLowCutOffMM.TabIndex = 102;
            // 
            // pnLowVoltageCutOff
            // 
            this.pnLowVoltageCutOff.Controls.Add(this.txtLowVoltageCutOffMinMax);
            this.pnLowVoltageCutOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLowVoltageCutOff.Location = new System.Drawing.Point(263, 15);
            this.pnLowVoltageCutOff.Name = "pnLowVoltageCutOff";
            this.pnLowVoltageCutOff.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnLowVoltageCutOff.Size = new System.Drawing.Size(148, 47);
            this.pnLowVoltageCutOff.TabIndex = 84;
            // 
            // txtLowVoltageCutOffMinMax
            // 
            this.txtLowVoltageCutOffMinMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLowVoltageCutOffMinMax.Enabled = false;
            this.txtLowVoltageCutOffMinMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLowVoltageCutOffMinMax.Location = new System.Drawing.Point(5, 10);
            this.txtLowVoltageCutOffMinMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLowVoltageCutOffMinMax.Name = "txtLowVoltageCutOffMinMax";
            this.txtLowVoltageCutOffMinMax.ReadOnly = true;
            this.txtLowVoltageCutOffMinMax.Size = new System.Drawing.Size(133, 45);
            this.txtLowVoltageCutOffMinMax.TabIndex = 84;
            // 
            // labelLowVoltageCutOffMinMax
            // 
            this.labelLowVoltageCutOffMinMax.AutoSize = true;
            this.labelLowVoltageCutOffMinMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLowVoltageCutOffMinMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelLowVoltageCutOffMinMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLowVoltageCutOffMinMax.Location = new System.Drawing.Point(40, 15);
            this.labelLowVoltageCutOffMinMax.Name = "labelLowVoltageCutOffMinMax";
            this.labelLowVoltageCutOffMinMax.Size = new System.Drawing.Size(122, 25);
            this.labelLowVoltageCutOffMinMax.TabIndex = 85;
            this.labelLowVoltageCutOffMinMax.Text = "Low Cut-Off ";
            // 
            // pnCurrentConstantMM
            // 
            this.pnCurrentConstantMM.Controls.Add(this.panel11);
            this.pnCurrentConstantMM.Controls.Add(this.labelVoltageChargerCurrentConstant);
            this.pnCurrentConstantMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCurrentConstantMM.Location = new System.Drawing.Point(0, 241);
            this.pnCurrentConstantMM.Name = "pnCurrentConstantMM";
            this.pnCurrentConstantMM.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.pnCurrentConstantMM.Size = new System.Drawing.Size(411, 62);
            this.pnCurrentConstantMM.TabIndex = 101;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtVoltageChargerMinMaxCurrentConstant);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(263, 5);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.panel11.Size = new System.Drawing.Size(148, 57);
            this.panel11.TabIndex = 84;
            // 
            // txtVoltageChargerMinMaxCurrentConstant
            // 
            this.txtVoltageChargerMinMaxCurrentConstant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoltageChargerMinMaxCurrentConstant.Enabled = false;
            this.txtVoltageChargerMinMaxCurrentConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVoltageChargerMinMaxCurrentConstant.Location = new System.Drawing.Point(5, 10);
            this.txtVoltageChargerMinMaxCurrentConstant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoltageChargerMinMaxCurrentConstant.Name = "txtVoltageChargerMinMaxCurrentConstant";
            this.txtVoltageChargerMinMaxCurrentConstant.ReadOnly = true;
            this.txtVoltageChargerMinMaxCurrentConstant.Size = new System.Drawing.Size(133, 45);
            this.txtVoltageChargerMinMaxCurrentConstant.TabIndex = 96;
            // 
            // labelVoltageChargerCurrentConstant
            // 
            this.labelVoltageChargerCurrentConstant.AutoSize = true;
            this.labelVoltageChargerCurrentConstant.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVoltageChargerCurrentConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelVoltageChargerCurrentConstant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVoltageChargerCurrentConstant.Location = new System.Drawing.Point(15, 5);
            this.labelVoltageChargerCurrentConstant.Name = "labelVoltageChargerCurrentConstant";
            this.labelVoltageChargerCurrentConstant.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.labelVoltageChargerCurrentConstant.Size = new System.Drawing.Size(161, 40);
            this.labelVoltageChargerCurrentConstant.TabIndex = 97;
            this.labelVoltageChargerCurrentConstant.Text = "Current Constant";
            // 
            // pnLabelHighMM
            // 
            this.pnLabelHighMM.Controls.Add(this.pnHighMMText);
            this.pnLabelHighMM.Controls.Add(this.labelVoltageChargerMinMaxCut);
            this.pnLabelHighMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLabelHighMM.Location = new System.Drawing.Point(0, 179);
            this.pnLabelHighMM.Name = "pnLabelHighMM";
            this.pnLabelHighMM.Padding = new System.Windows.Forms.Padding(60, 15, 0, 0);
            this.pnLabelHighMM.Size = new System.Drawing.Size(411, 62);
            this.pnLabelHighMM.TabIndex = 100;
            // 
            // pnHighMMText
            // 
            this.pnHighMMText.Controls.Add(this.txtVoltageChargerMinMaxHigh);
            this.pnHighMMText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnHighMMText.Location = new System.Drawing.Point(263, 15);
            this.pnHighMMText.Name = "pnHighMMText";
            this.pnHighMMText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnHighMMText.Size = new System.Drawing.Size(148, 47);
            this.pnHighMMText.TabIndex = 84;
            // 
            // txtVoltageChargerMinMaxCut
            // 
            this.txtVoltageChargerMinMaxHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoltageChargerMinMaxHigh.Enabled = false;
            this.txtVoltageChargerMinMaxHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVoltageChargerMinMaxHigh.Location = new System.Drawing.Point(5, 10);
            this.txtVoltageChargerMinMaxHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoltageChargerMinMaxHigh.Name = "txtVoltageChargerMinMaxCut";
            this.txtVoltageChargerMinMaxHigh.ReadOnly = true;
            this.txtVoltageChargerMinMaxHigh.Size = new System.Drawing.Size(133, 45);
            this.txtVoltageChargerMinMaxHigh.TabIndex = 92;
            // 
            // labelVoltageChargerMinMaxCut
            // 
            this.labelVoltageChargerMinMaxCut.AutoSize = true;
            this.labelVoltageChargerMinMaxCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageChargerMinMaxCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelVoltageChargerMinMaxCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVoltageChargerMinMaxCut.Location = new System.Drawing.Point(60, 15);
            this.labelVoltageChargerMinMaxCut.Name = "labelVoltageChargerMinMaxCut";
            this.labelVoltageChargerMinMaxCut.Size = new System.Drawing.Size(93, 25);
            this.labelVoltageChargerMinMaxCut.TabIndex = 93;
            this.labelVoltageChargerMinMaxCut.Text = "High (ตัด)";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pnLowMMText);
            this.panel9.Controls.Add(this.labelVoltageChargerMinMaxConnect);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 117);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(60, 15, 0, 0);
            this.panel9.Size = new System.Drawing.Size(411, 62);
            this.panel9.TabIndex = 99;
            // 
            // pnLowMMText
            // 
            this.pnLowMMText.Controls.Add(this.txtVoltageChargerMinMaxLow);
            this.pnLowMMText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLowMMText.Location = new System.Drawing.Point(263, 15);
            this.pnLowMMText.Name = "pnLowMMText";
            this.pnLowMMText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnLowMMText.Size = new System.Drawing.Size(148, 47);
            this.pnLowMMText.TabIndex = 84;
            // 
            // txtVoltageChargerMinMaxConnect
            // 
            this.txtVoltageChargerMinMaxLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoltageChargerMinMaxLow.Enabled = false;
            this.txtVoltageChargerMinMaxLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVoltageChargerMinMaxLow.Location = new System.Drawing.Point(5, 10);
            this.txtVoltageChargerMinMaxLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoltageChargerMinMaxLow.Name = "txtVoltageChargerMinMaxConnect";
            this.txtVoltageChargerMinMaxLow.ReadOnly = true;
            this.txtVoltageChargerMinMaxLow.Size = new System.Drawing.Size(133, 45);
            this.txtVoltageChargerMinMaxLow.TabIndex = 78;
            // 
            // labelVoltageChargerMinMaxConnect
            // 
            this.labelVoltageChargerMinMaxConnect.AutoSize = true;
            this.labelVoltageChargerMinMaxConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVoltageChargerMinMaxConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelVoltageChargerMinMaxConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVoltageChargerMinMaxConnect.Location = new System.Drawing.Point(60, 15);
            this.labelVoltageChargerMinMaxConnect.Name = "labelVoltageChargerMinMaxConnect";
            this.labelVoltageChargerMinMaxConnect.Size = new System.Drawing.Size(87, 25);
            this.labelVoltageChargerMinMaxConnect.TabIndex = 79;
            this.labelVoltageChargerMinMaxConnect.Text = "Low (ต่อ)";
            // 
            // pnStage
            // 
            this.pnStage.Controls.Add(this.pnStageText);
            this.pnStage.Controls.Add(this.labelStage);
            this.pnStage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStage.Location = new System.Drawing.Point(0, 55);
            this.pnStage.Name = "pnStage";
            this.pnStage.Size = new System.Drawing.Size(411, 62);
            this.pnStage.TabIndex = 98;
            // 
            // pnStageText
            // 
            this.pnStageText.Controls.Add(this.txtStage);
            this.pnStageText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnStageText.Location = new System.Drawing.Point(148, 0);
            this.pnStageText.Name = "pnStageText";
            this.pnStageText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnStageText.Size = new System.Drawing.Size(263, 62);
            this.pnStageText.TabIndex = 84;
            // 
            // txtStage
            // 
            this.txtStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStage.Enabled = false;
            this.txtStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtStage.Location = new System.Drawing.Point(5, 10);
            this.txtStage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStage.Name = "txtStage";
            this.txtStage.ReadOnly = true;
            this.txtStage.Size = new System.Drawing.Size(248, 45);
            this.txtStage.TabIndex = 82;
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStage.Location = new System.Drawing.Point(0, 0);
            this.labelStage.Name = "labelStage";
            this.labelStage.Padding = new System.Windows.Forms.Padding(60, 15, 0, 0);
            this.labelStage.Size = new System.Drawing.Size(124, 40);
            this.labelStage.TabIndex = 83;
            this.labelStage.Text = "Stage";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.lblspecifiations);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 45);
            this.panel3.TabIndex = 97;
            // 
            // lblspecifiations
            // 
            this.lblspecifiations.AutoSize = true;
            this.lblspecifiations.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblspecifiations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblspecifiations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblspecifiations.Location = new System.Drawing.Point(0, 0);
            this.lblspecifiations.Name = "lblspecifiations";
            this.lblspecifiations.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblspecifiations.Size = new System.Drawing.Size(158, 34);
            this.lblspecifiations.TabIndex = 98;
            this.lblspecifiations.Text = "Specification";
            this.lblspecifiations.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.pnConnection);
            this.tabConnection.Location = new System.Drawing.Point(4, 4);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(413, 958);
            this.tabConnection.TabIndex = 5;
            this.tabConnection.Text = "WiFi Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // pnConnection
            // 
            this.pnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnConnection.Controls.Add(this.pnLedStage);
            this.pnConnection.Controls.Add(this.pnWiFiConnection);
            this.pnConnection.Controls.Add(this.pnChangeIPAdress);
            this.pnConnection.Controls.Add(this.pnFindESP);
            this.pnConnection.Controls.Add(this.pnStateConnection);
            this.pnConnection.Controls.Add(this.pnRelay);
            this.pnConnection.Controls.Add(this.pnPasswordLabel);
            this.pnConnection.Controls.Add(this.pnSSID);
            this.pnConnection.Controls.Add(this.pnCommunication);
            this.pnConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConnection.Location = new System.Drawing.Point(0, 0);
            this.pnConnection.Name = "pnConnection";
            this.pnConnection.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnConnection.Size = new System.Drawing.Size(413, 961);
            this.pnConnection.TabIndex = 109;
            this.pnConnection.Paint += new System.Windows.Forms.PaintEventHandler(this.pnConnection_Paint);
            // 
            // pnLedStage
            // 
            this.pnLedStage.Controls.Add(this.pnToggleLED);
            this.pnLedStage.Controls.Add(this.pnLEDStateLabel);
            this.pnLedStage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLedStage.Location = new System.Drawing.Point(0, 784);
            this.pnLedStage.Name = "pnLedStage";
            this.pnLedStage.Padding = new System.Windows.Forms.Padding(10);
            this.pnLedStage.Size = new System.Drawing.Size(411, 430);
            this.pnLedStage.TabIndex = 127;
            this.pnLedStage.Visible = false;
            // 
            // pnToggleLED
            // 
            this.pnToggleLED.Controls.Add(this.btnToggleLed);
            this.pnToggleLED.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnToggleLED.Location = new System.Drawing.Point(10, 69);
            this.pnToggleLED.Name = "pnToggleLED";
            this.pnToggleLED.Size = new System.Drawing.Size(391, 65);
            this.pnToggleLED.TabIndex = 1;
            // 
            // btnToggleLed
            // 
            this.btnToggleLed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnToggleLed.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnToggleLed.IconColor = System.Drawing.Color.Black;
            this.btnToggleLed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToggleLed.Location = new System.Drawing.Point(0, 0);
            this.btnToggleLed.Name = "btnToggleLed";
            this.btnToggleLed.Padding = new System.Windows.Forms.Padding(10);
            this.btnToggleLed.Size = new System.Drawing.Size(391, 65);
            this.btnToggleLed.TabIndex = 110;
            this.btnToggleLed.Text = "Toggle LED";
            this.btnToggleLed.UseVisualStyleBackColor = true;
            // 
            // pnLEDStateLabel
            // 
            this.pnLEDStateLabel.Controls.Add(this.lblLedState);
            this.pnLEDStateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLEDStateLabel.Location = new System.Drawing.Point(10, 10);
            this.pnLEDStateLabel.Name = "pnLEDStateLabel";
            this.pnLEDStateLabel.Padding = new System.Windows.Forms.Padding(10);
            this.pnLEDStateLabel.Size = new System.Drawing.Size(391, 59);
            this.pnLEDStateLabel.TabIndex = 0;
            // 
            // lblLedState
            // 
            this.lblLedState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLedState.AutoSize = true;
            this.lblLedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLedState.Location = new System.Drawing.Point(17, 19);
            this.lblLedState.Name = "lblLedState";
            this.lblLedState.Size = new System.Drawing.Size(119, 25);
            this.lblLedState.TabIndex = 111;
            this.lblLedState.Text = "LED State: -";
            // 
            // pnWiFiConnection
            // 
            this.pnWiFiConnection.Controls.Add(this.btnConnect);
            this.pnWiFiConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnWiFiConnection.Location = new System.Drawing.Point(0, 643);
            this.pnWiFiConnection.Name = "pnWiFiConnection";
            this.pnWiFiConnection.Padding = new System.Windows.Forms.Padding(10);
            this.pnWiFiConnection.Size = new System.Drawing.Size(411, 141);
            this.pnWiFiConnection.TabIndex = 125;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnect.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConnect.IconColor = System.Drawing.Color.Black;
            this.btnConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnect.Location = new System.Drawing.Point(10, 10);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 15, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(391, 121);
            this.btnConnect.TabIndex = 68;
            this.btnConnect.Text = "Connect WiFi";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pnChangeIPAdress
            // 
            this.pnChangeIPAdress.Controls.Add(this.btnChangeIPAdress);
            this.pnChangeIPAdress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChangeIPAdress.Location = new System.Drawing.Point(0, 569);
            this.pnChangeIPAdress.Name = "pnChangeIPAdress";
            this.pnChangeIPAdress.Padding = new System.Windows.Forms.Padding(10);
            this.pnChangeIPAdress.Size = new System.Drawing.Size(411, 74);
            this.pnChangeIPAdress.TabIndex = 124;
            this.pnChangeIPAdress.Visible = false;
            // 
            // btnChangeIPAdress
            // 
            this.btnChangeIPAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeIPAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnChangeIPAdress.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChangeIPAdress.IconColor = System.Drawing.Color.Black;
            this.btnChangeIPAdress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeIPAdress.Location = new System.Drawing.Point(10, 10);
            this.btnChangeIPAdress.Name = "btnChangeIPAdress";
            this.btnChangeIPAdress.Size = new System.Drawing.Size(391, 54);
            this.btnChangeIPAdress.TabIndex = 113;
            this.btnChangeIPAdress.Text = "Change IP Address";
            this.btnChangeIPAdress.UseVisualStyleBackColor = true;
            this.btnChangeIPAdress.Click += new System.EventHandler(this.btnChangeIPAdress_Click);
            // 
            // pnFindESP
            // 
            this.pnFindESP.Controls.Add(this.btnFindDevice);
            this.pnFindESP.Controls.Add(this.panel18);
            this.pnFindESP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFindESP.Location = new System.Drawing.Point(0, 443);
            this.pnFindESP.Name = "pnFindESP";
            this.pnFindESP.Padding = new System.Windows.Forms.Padding(10);
            this.pnFindESP.Size = new System.Drawing.Size(411, 126);
            this.pnFindESP.TabIndex = 123;
            this.pnFindESP.Visible = false;
            // 
            // btnFindDevice
            // 
            this.btnFindDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFindDevice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFindDevice.IconColor = System.Drawing.Color.Black;
            this.btnFindDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindDevice.Location = new System.Drawing.Point(10, 69);
            this.btnFindDevice.Name = "btnFindDevice";
            this.btnFindDevice.Size = new System.Drawing.Size(391, 47);
            this.btnFindDevice.TabIndex = 109;
            this.btnFindDevice.Text = "Find Device";
            this.btnFindDevice.UseVisualStyleBackColor = true;
            this.btnFindDevice.Click += new System.EventHandler(this.btnFindDevice_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.cboEsp32Devices);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(10, 10);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(10);
            this.panel18.Size = new System.Drawing.Size(391, 59);
            this.panel18.TabIndex = 0;
            // 
            // cboEsp32Devices
            // 
            this.cboEsp32Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEsp32Devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEsp32Devices.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboEsp32Devices.FormattingEnabled = true;
            this.cboEsp32Devices.Location = new System.Drawing.Point(10, 10);
            this.cboEsp32Devices.Name = "cboEsp32Devices";
            this.cboEsp32Devices.Size = new System.Drawing.Size(371, 46);
            this.cboEsp32Devices.TabIndex = 112;
            this.cboEsp32Devices.SelectedIndexChanged += new System.EventHandler(this.cboEsp32Devices_SelectedIndexChanged);
            // 
            // pnStateConnection
            // 
            this.pnStateConnection.Controls.Add(this.lblStatus);
            this.pnStateConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStateConnection.Location = new System.Drawing.Point(0, 388);
            this.pnStateConnection.Name = "pnStateConnection";
            this.pnStateConnection.Size = new System.Drawing.Size(411, 55);
            this.pnStateConnection.TabIndex = 122;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(14, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(252, 29);
            this.lblStatus.TabIndex = 108;
            this.lblStatus.Text = "Status: Not Connected";
            // 
            // pnRelay
            // 
            this.pnRelay.Controls.Add(this.pnBtnRelay);
            this.pnRelay.Controls.Add(this.pnRelayLabel);
            this.pnRelay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRelay.Location = new System.Drawing.Point(0, 215);
            this.pnRelay.Name = "pnRelay";
            this.pnRelay.Padding = new System.Windows.Forms.Padding(10);
            this.pnRelay.Size = new System.Drawing.Size(411, 173);
            this.pnRelay.TabIndex = 126;
            // 
            // pnBtnRelay
            // 
            this.pnBtnRelay.Controls.Add(this.btnToggleRelay);
            this.pnBtnRelay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBtnRelay.Location = new System.Drawing.Point(10, 69);
            this.pnBtnRelay.Name = "pnBtnRelay";
            this.pnBtnRelay.Size = new System.Drawing.Size(391, 65);
            this.pnBtnRelay.TabIndex = 1;
            // 
            // btnToggleRelay
            // 
            this.btnToggleRelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleRelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnToggleRelay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnToggleRelay.IconColor = System.Drawing.Color.Black;
            this.btnToggleRelay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToggleRelay.Location = new System.Drawing.Point(0, 0);
            this.btnToggleRelay.Name = "btnToggleRelay";
            this.btnToggleRelay.Padding = new System.Windows.Forms.Padding(10);
            this.btnToggleRelay.Size = new System.Drawing.Size(391, 65);
            this.btnToggleRelay.TabIndex = 113;
            this.btnToggleRelay.Text = "Toggle Relay";
            this.btnToggleRelay.UseVisualStyleBackColor = true;
            this.btnToggleRelay.Click += new System.EventHandler(this.btnToggleRelay_Click);
            // 
            // pnRelayLabel
            // 
            this.pnRelayLabel.Controls.Add(this.lblRelayState);
            this.pnRelayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRelayLabel.Location = new System.Drawing.Point(10, 10);
            this.pnRelayLabel.Name = "pnRelayLabel";
            this.pnRelayLabel.Padding = new System.Windows.Forms.Padding(10);
            this.pnRelayLabel.Size = new System.Drawing.Size(391, 59);
            this.pnRelayLabel.TabIndex = 0;
            // 
            // lblRelayState
            // 
            this.lblRelayState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelayState.AutoSize = true;
            this.lblRelayState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRelayState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRelayState.Location = new System.Drawing.Point(13, 19);
            this.lblRelayState.Name = "lblRelayState";
            this.lblRelayState.Size = new System.Drawing.Size(167, 25);
            this.lblRelayState.TabIndex = 114;
            this.lblRelayState.Text = "EMER AC state: -";
            this.lblRelayState.TextChanged += new System.EventHandler(this.lblRelayState_TextChanged);
            // 
            // pnPasswordLabel
            // 
            this.pnPasswordLabel.Controls.Add(this.panel13);
            this.pnPasswordLabel.Controls.Add(this.lblPassword);
            this.pnPasswordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPasswordLabel.Location = new System.Drawing.Point(0, 147);
            this.pnPasswordLabel.Name = "pnPasswordLabel";
            this.pnPasswordLabel.Size = new System.Drawing.Size(411, 68);
            this.pnPasswordLabel.TabIndex = 121;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtPassword);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(218, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.panel13.Size = new System.Drawing.Size(193, 68);
            this.panel13.TabIndex = 84;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPassword.Location = new System.Drawing.Point(5, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 45);
            this.txtPassword.TabIndex = 98;
            this.txtPassword.Text = "admin123";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(14, 15);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 107;
            this.lblPassword.Text = "Password";
            // 
            // pnSSID
            // 
            this.pnSSID.Controls.Add(this.pnSSIDText);
            this.pnSSID.Controls.Add(this.lblSSID);
            this.pnSSID.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSSID.Location = new System.Drawing.Point(0, 66);
            this.pnSSID.Name = "pnSSID";
            this.pnSSID.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnSSID.Size = new System.Drawing.Size(411, 81);
            this.pnSSID.TabIndex = 120;
            // 
            // pnSSIDText
            // 
            this.pnSSIDText.Controls.Add(this.txtSSID);
            this.pnSSIDText.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSSIDText.Location = new System.Drawing.Point(218, 10);
            this.pnSSIDText.Name = "pnSSIDText";
            this.pnSSIDText.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pnSSIDText.Size = new System.Drawing.Size(193, 71);
            this.pnSSIDText.TabIndex = 84;
            // 
            // txtSSID
            // 
            this.txtSSID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSSID.Location = new System.Drawing.Point(5, 10);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(178, 45);
            this.txtSSID.TabIndex = 99;
            this.txtSSID.Text = "SunnySSID";
            // 
            // lblSSID
            // 
            this.lblSSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSSID.AutoSize = true;
            this.lblSSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSSID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSSID.Location = new System.Drawing.Point(55, 25);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(68, 29);
            this.lblSSID.TabIndex = 106;
            this.lblSSID.Text = "SSDI";
            // 
            // pnCommunication
            // 
            this.pnCommunication.BackColor = System.Drawing.Color.DarkRed;
            this.pnCommunication.Controls.Add(this.lblCommunications);
            this.pnCommunication.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCommunication.Location = new System.Drawing.Point(0, 10);
            this.pnCommunication.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnCommunication.Name = "pnCommunication";
            this.pnCommunication.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnCommunication.Size = new System.Drawing.Size(411, 56);
            this.pnCommunication.TabIndex = 97;
            // 
            // lblCommunications
            // 
            this.lblCommunications.AutoSize = true;
            this.lblCommunications.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCommunications.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCommunications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCommunications.Location = new System.Drawing.Point(0, 0);
            this.lblCommunications.Name = "lblCommunications";
            this.lblCommunications.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCommunications.Size = new System.Drawing.Size(213, 36);
            this.lblCommunications.TabIndex = 98;
            this.lblCommunications.Text = "WiFi Connection";
            this.lblCommunications.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // splitContainerMid
            // 
            this.splitContainerMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitContainerMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMid.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMid.Name = "splitContainerMid";
            this.splitContainerMid.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMid.Panel1
            // 
            this.splitContainerMid.Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainerMid.Panel1.Controls.Add(this.zedPlot);
            this.splitContainerMid.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // splitContainerMid.Panel2
            // 
            this.splitContainerMid.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainerMid.Panel2.Controls.Add(this.listDataPlot);
            this.splitContainerMid.Size = new System.Drawing.Size(1168, 966);
            this.splitContainerMid.SplitterDistance = 593;
            this.splitContainerMid.TabIndex = 0;
            // 
            // zedPlot
            // 
            this.zedPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedPlot.Location = new System.Drawing.Point(0, 0);
            this.zedPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedPlot.Name = "zedPlot";
            this.zedPlot.ScrollGrace = 0D;
            this.zedPlot.ScrollMaxX = 0D;
            this.zedPlot.ScrollMaxY = 0D;
            this.zedPlot.ScrollMaxY2 = 0D;
            this.zedPlot.ScrollMinX = 0D;
            this.zedPlot.ScrollMinY = 0D;
            this.zedPlot.ScrollMinY2 = 0D;
            this.zedPlot.Size = new System.Drawing.Size(1168, 593);
            this.zedPlot.TabIndex = 0;
            this.zedPlot.UseExtendedPrintDialog = true;
            // 
            // listDataPlot
            // 
            this.listDataPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.listDataPlot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sequence,
            this.time,
            this.voltage,
            this.average,
            this.current,
            this.adcCurrent,
            this.derivative});
            this.listDataPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDataPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listDataPlot.HideSelection = false;
            this.listDataPlot.Location = new System.Drawing.Point(0, 0);
            this.listDataPlot.Name = "listDataPlot";
            this.listDataPlot.Size = new System.Drawing.Size(1168, 369);
            this.listDataPlot.TabIndex = 89;
            this.listDataPlot.UseCompatibleStateImageBehavior = false;
            this.listDataPlot.View = System.Windows.Forms.View.Details;
            // 
            // sequence
            // 
            this.sequence.Text = "No.";
            this.sequence.Width = 93;
            // 
            // time
            // 
            this.time.Text = "Time(s)";
            this.time.Width = 162;
            // 
            // voltage
            // 
            this.voltage.Text = "Voltage";
            this.voltage.Width = 183;
            // 
            // average
            // 
            this.average.Text = "Average Voltage";
            this.average.Width = 211;
            // 
            // current
            // 
            this.current.Text = "Current";
            this.current.Width = 150;
            // 
            // adcCurrent
            // 
            this.adcCurrent.Text = "ADC Current";
            this.adcCurrent.Width = 236;
            // 
            // derivative
            // 
            this.derivative.Text = "dv/dt";
            this.derivative.Width = 106;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabQualityCheck);
            this.tabControl1.Controls.Add(this.tabMeasurement);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 966);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQualityCheck
            // 
            this.tabQualityCheck.Controls.Add(this.pnQualityCheck);
            this.tabQualityCheck.Location = new System.Drawing.Point(39, 4);
            this.tabQualityCheck.Name = "tabQualityCheck";
            this.tabQualityCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabQualityCheck.Size = new System.Drawing.Size(245, 958);
            this.tabQualityCheck.TabIndex = 0;
            this.tabQualityCheck.Text = "Quality Check";
            this.tabQualityCheck.UseVisualStyleBackColor = true;
            // 
            // pnQualityCheck
            // 
            this.pnQualityCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnQualityCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnQualityCheck.Controls.Add(this.pnManualCheck);
            this.pnQualityCheck.Controls.Add(this.pnAutoCheck);
            this.pnQualityCheck.Controls.Add(this.txtComment);
            this.pnQualityCheck.Controls.Add(this.btnSubmitComment);
            this.pnQualityCheck.Controls.Add(this.pnHeaderProductQuality);
            this.pnQualityCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnQualityCheck.Location = new System.Drawing.Point(3, 3);
            this.pnQualityCheck.Name = "pnQualityCheck";
            this.pnQualityCheck.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnQualityCheck.Size = new System.Drawing.Size(239, 952);
            this.pnQualityCheck.TabIndex = 109;
            // 
            // pnManualCheck
            // 
            this.pnManualCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnManualCheck.Controls.Add(this.panel10);
            this.pnManualCheck.Controls.Add(this.cboManualCheck);
            this.pnManualCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManualCheck.Location = new System.Drawing.Point(0, 154);
            this.pnManualCheck.Name = "pnManualCheck";
            this.pnManualCheck.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnManualCheck.Size = new System.Drawing.Size(237, 107);
            this.pnManualCheck.TabIndex = 99;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelManualCheck);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(8, 10);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel10.Size = new System.Drawing.Size(219, 29);
            this.panel10.TabIndex = 92;
            // 
            // labelManualCheck
            // 
            this.labelManualCheck.AutoSize = true;
            this.labelManualCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelManualCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelManualCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManualCheck.Location = new System.Drawing.Point(30, 0);
            this.labelManualCheck.Name = "labelManualCheck";
            this.labelManualCheck.Size = new System.Drawing.Size(165, 29);
            this.labelManualCheck.TabIndex = 90;
            this.labelManualCheck.Text = "Manual Check";
            // 
            // pnAutoCheck
            // 
            this.pnAutoCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAutoCheck.Controls.Add(this.txtAutoCheck);
            this.pnAutoCheck.Controls.Add(this.pnAutoCheckText);
            this.pnAutoCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAutoCheck.Location = new System.Drawing.Point(0, 54);
            this.pnAutoCheck.Name = "pnAutoCheck";
            this.pnAutoCheck.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnAutoCheck.Size = new System.Drawing.Size(237, 100);
            this.pnAutoCheck.TabIndex = 98;
            // 
            // pnAutoCheckText
            // 
            this.pnAutoCheckText.Controls.Add(this.labelAutoCheck);
            this.pnAutoCheckText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAutoCheckText.Location = new System.Drawing.Point(8, 10);
            this.pnAutoCheckText.Name = "pnAutoCheckText";
            this.pnAutoCheckText.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.pnAutoCheckText.Size = new System.Drawing.Size(219, 29);
            this.pnAutoCheckText.TabIndex = 90;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtComment.Enabled = false;
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtComment.Location = new System.Drawing.Point(0, 603);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(237, 254);
            this.txtComment.TabIndex = 0;
            // 
            // btnSubmitComment
            // 
            this.btnSubmitComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitComment.Enabled = false;
            this.btnSubmitComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSubmitComment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitComment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubmitComment.IconColor = System.Drawing.Color.Black;
            this.btnSubmitComment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmitComment.Location = new System.Drawing.Point(0, 857);
            this.btnSubmitComment.Name = "btnSubmitComment";
            this.btnSubmitComment.Size = new System.Drawing.Size(237, 93);
            this.btnSubmitComment.TabIndex = 1;
            this.btnSubmitComment.Text = "Submit Comment";
            this.btnSubmitComment.UseVisualStyleBackColor = true;
            this.btnSubmitComment.Click += new System.EventHandler(this.btnSubmitComment_Click);
            // 
            // pnHeaderProductQuality
            // 
            this.pnHeaderProductQuality.BackColor = System.Drawing.Color.DarkRed;
            this.pnHeaderProductQuality.Controls.Add(this.lblHeaderCheck);
            this.pnHeaderProductQuality.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderProductQuality.Location = new System.Drawing.Point(0, 10);
            this.pnHeaderProductQuality.Name = "pnHeaderProductQuality";
            this.pnHeaderProductQuality.Size = new System.Drawing.Size(237, 44);
            this.pnHeaderProductQuality.TabIndex = 97;
            // 
            // lblHeaderCheck
            // 
            this.lblHeaderCheck.AutoSize = true;
            this.lblHeaderCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeaderCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeaderCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeaderCheck.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderCheck.Name = "lblHeaderCheck";
            this.lblHeaderCheck.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblHeaderCheck.Size = new System.Drawing.Size(176, 34);
            this.lblHeaderCheck.TabIndex = 98;
            this.lblHeaderCheck.Text = "Quality Check";
            this.lblHeaderCheck.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabMeasurement
            // 
            this.tabMeasurement.Controls.Add(this.pnMeasurement);
            this.tabMeasurement.Location = new System.Drawing.Point(39, 4);
            this.tabMeasurement.Name = "tabMeasurement";
            this.tabMeasurement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeasurement.Size = new System.Drawing.Size(245, 958);
            this.tabMeasurement.TabIndex = 1;
            this.tabMeasurement.Text = "Measurement";
            this.tabMeasurement.UseVisualStyleBackColor = true;
            // 
            // pnMeasurement
            // 
            this.pnMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMeasurement.Controls.Add(this.pnClear);
            this.pnMeasurement.Controls.Add(this.pnStop);
            this.pnMeasurement.Controls.Add(this.pnbtnStart);
            this.pnMeasurement.Controls.Add(this.pnStopTold);
            this.pnMeasurement.Controls.Add(this.pnStopWatch);
            this.pnMeasurement.Controls.Add(this.panel8);
            this.pnMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMeasurement.Location = new System.Drawing.Point(3, 3);
            this.pnMeasurement.Name = "pnMeasurement";
            this.pnMeasurement.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnMeasurement.Size = new System.Drawing.Size(239, 952);
            this.pnMeasurement.TabIndex = 108;
            // 
            // pnClear
            // 
            this.pnClear.Controls.Add(this.btnClearTime_PC);
            this.pnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnClear.Location = new System.Drawing.Point(0, 386);
            this.pnClear.Name = "pnClear";
            this.pnClear.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.pnClear.Size = new System.Drawing.Size(237, 111);
            this.pnClear.TabIndex = 114;
            // 
            // btnClearTime_PC
            // 
            this.btnClearTime_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearTime_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearTime_PC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearTime_PC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearTime_PC.IconColor = System.Drawing.Color.Black;
            this.btnClearTime_PC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearTime_PC.Location = new System.Drawing.Point(10, 30);
            this.btnClearTime_PC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTime_PC.Name = "btnClearTime_PC";
            this.btnClearTime_PC.Size = new System.Drawing.Size(217, 71);
            this.btnClearTime_PC.TabIndex = 109;
            this.btnClearTime_PC.Text = "Clear";
            this.btnClearTime_PC.UseVisualStyleBackColor = true;
            this.btnClearTime_PC.Click += new System.EventHandler(this.btnClearTime_PC_Click);
            // 
            // pnStop
            // 
            this.pnStop.Controls.Add(this.btnStop);
            this.pnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStop.Location = new System.Drawing.Point(0, 312);
            this.pnStop.Name = "pnStop";
            this.pnStop.Padding = new System.Windows.Forms.Padding(10);
            this.pnStop.Size = new System.Drawing.Size(237, 74);
            this.pnStop.TabIndex = 113;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStop.IconColor = System.Drawing.Color.Black;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.Location = new System.Drawing.Point(10, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(217, 54);
            this.btnStop.TabIndex = 108;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnbtnStart
            // 
            this.pnbtnStart.Controls.Add(this.btnStart);
            this.pnbtnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnbtnStart.Location = new System.Drawing.Point(0, 239);
            this.pnbtnStart.Name = "pnbtnStart";
            this.pnbtnStart.Padding = new System.Windows.Forms.Padding(10);
            this.pnbtnStart.Size = new System.Drawing.Size(237, 73);
            this.pnbtnStart.TabIndex = 112;
            // 
            // pnStopTold
            // 
            this.pnStopTold.Controls.Add(this.lblTimerStatusDashboardPic);
            this.pnStopTold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStopTold.Location = new System.Drawing.Point(0, 166);
            this.pnStopTold.Name = "pnStopTold";
            this.pnStopTold.Padding = new System.Windows.Forms.Padding(10);
            this.pnStopTold.Size = new System.Drawing.Size(237, 73);
            this.pnStopTold.TabIndex = 111;
            // 
            // pnStopWatch
            // 
            this.pnStopWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStopWatch.Controls.Add(this.panel21);
            this.pnStopWatch.Controls.Add(this.txtTimer1);
            this.pnStopWatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStopWatch.Location = new System.Drawing.Point(0, 54);
            this.pnStopWatch.Name = "pnStopWatch";
            this.pnStopWatch.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnStopWatch.Size = new System.Drawing.Size(237, 112);
            this.pnStopWatch.TabIndex = 110;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.lbtime_pc);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(8, 10);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.panel21.Size = new System.Drawing.Size(219, 29);
            this.panel21.TabIndex = 90;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkRed;
            this.panel8.Controls.Add(this.lblHeaderMeasurement);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 44);
            this.panel8.TabIndex = 97;
            // 
            // lblHeaderMeasurement
            // 
            this.lblHeaderMeasurement.AutoSize = true;
            this.lblHeaderMeasurement.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeaderMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeaderMeasurement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeaderMeasurement.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderMeasurement.Name = "lblHeaderMeasurement";
            this.lblHeaderMeasurement.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblHeaderMeasurement.Size = new System.Drawing.Size(168, 34);
            this.lblHeaderMeasurement.TabIndex = 98;
            this.lblHeaderMeasurement.Text = "Measurement";
            this.lblHeaderMeasurement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseForm.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnCloseForm.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseForm.Location = new System.Drawing.Point(4061, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(66, 30);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.btnMiniSize.FlatAppearance.BorderSize = 0;
            this.btnMiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMiniSize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMiniSize.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMiniSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiniSize.IconSize = 24;
            this.btnMiniSize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMiniSize.Location = new System.Drawing.Point(4010, 5);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(49, 25);
            this.btnMiniSize.TabIndex = 3;
            this.btnMiniSize.UseVisualStyleBackColor = false;
            // 
            // panelBackGround
            // 
            this.panelBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBackGround.Controls.Add(this.splitContainerMain);
            this.panelBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackGround.Location = new System.Drawing.Point(0, 52);
            this.panelBackGround.Name = "panelBackGround";
            this.panelBackGround.Size = new System.Drawing.Size(1920, 966);
            this.panelBackGround.TabIndex = 4;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.DarkRed;
            this.pnTop.Controls.Add(this.btnMinimum);
            this.pnTop.Controls.Add(this.btnRestore);
            this.pnTop.Controls.Add(this.btnCLose);
            this.pnTop.Controls.Add(this.pnSubTopMenu);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1920, 52);
            this.pnTop.TabIndex = 5;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            // 
            // btnMinimum
            // 
            this.btnMinimum.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimum.FlatAppearance.BorderSize = 0;
            this.btnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMinimum.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimum.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimum.IconSize = 20;
            this.btnMinimum.Location = new System.Drawing.Point(1683, 0);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(79, 52);
            this.btnMinimum.TabIndex = 2;
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestore.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 20;
            this.btnRestore.Location = new System.Drawing.Point(1762, 0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(79, 52);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCLose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCLose.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCLose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCLose.IconSize = 20;
            this.btnCLose.Location = new System.Drawing.Point(1841, 0);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(79, 52);
            this.btnCLose.TabIndex = 4;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // pnSubTopMenu
            // 
            this.pnSubTopMenu.Controls.Add(this.menuStrip1);
            this.pnSubTopMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSubTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnSubTopMenu.Name = "pnSubTopMenu";
            this.pnSubTopMenu.Size = new System.Drawing.Size(489, 52);
            this.pnSubTopMenu.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(489, 52);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.BackColor = System.Drawing.Color.DarkRed;
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.toolStripSeparator,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(56, 48);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(218, 32);
            this.newToolStripMenuItem1.Text = "&New";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.openGraphFileToolStripMenuItem});
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(218, 32);
            this.openToolStripMenuItem1.Text = "&Open";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // openGraphFileToolStripMenuItem
            // 
            this.openGraphFileToolStripMenuItem.Name = "openGraphFileToolStripMenuItem";
            this.openGraphFileToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.openGraphFileToolStripMenuItem.Text = "Open File";
            this.openGraphFileToolStripMenuItem.Click += new System.EventHandler(this.openGraphFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(215, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(218, 32);
            this.saveToolStripMenuItem1.Text = "&Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(218, 32);
            this.saveAsToolStripMenuItem1.Text = "Save &As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(218, 32);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.BackColor = System.Drawing.Color.DarkRed;
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(60, 48);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closePanelToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(67, 48);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // closePanelToolStripMenuItem
            // 
            this.closePanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftPanelToolStripMenuItem,
            this.rightPanelToolStripMenuItem});
            this.closePanelToolStripMenuItem.Name = "closePanelToolStripMenuItem";
            this.closePanelToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.closePanelToolStripMenuItem.Text = "Close Panel";
            // 
            // leftPanelToolStripMenuItem
            // 
            this.leftPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movingAverageBufferToolStripMenuItem,
            this.pToolStripMenuItem,
            this.specificationMinMaxToolStripMenuItem,
            this.specificationMeanToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.realTimeDataToolStripMenuItem});
            this.leftPanelToolStripMenuItem.Name = "leftPanelToolStripMenuItem";
            this.leftPanelToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.leftPanelToolStripMenuItem.Text = "Left Panel";
            // 
            // movingAverageBufferToolStripMenuItem
            // 
            this.movingAverageBufferToolStripMenuItem.Name = "movingAverageBufferToolStripMenuItem";
            this.movingAverageBufferToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.movingAverageBufferToolStripMenuItem.Text = "Moving Average Buffer";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.pToolStripMenuItem.Text = "Product Input";
            // 
            // specificationMinMaxToolStripMenuItem
            // 
            this.specificationMinMaxToolStripMenuItem.Name = "specificationMinMaxToolStripMenuItem";
            this.specificationMinMaxToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.specificationMinMaxToolStripMenuItem.Text = "Specification Min Max";
            // 
            // specificationMeanToolStripMenuItem
            // 
            this.specificationMeanToolStripMenuItem.Name = "specificationMeanToolStripMenuItem";
            this.specificationMeanToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.specificationMeanToolStripMenuItem.Text = "Specification Mean";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // realTimeDataToolStripMenuItem
            // 
            this.realTimeDataToolStripMenuItem.Name = "realTimeDataToolStripMenuItem";
            this.realTimeDataToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.realTimeDataToolStripMenuItem.Text = "Real Time Data";
            // 
            // rightPanelToolStripMenuItem
            // 
            this.rightPanelToolStripMenuItem.Name = "rightPanelToolStripMenuItem";
            this.rightPanelToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.rightPanelToolStripMenuItem.Text = "Right Panel";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.productMangamentToolStripMenuItem,
            this.portToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 48);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // productMangamentToolStripMenuItem
            // 
            this.productMangamentToolStripMenuItem.Name = "productMangamentToolStripMenuItem";
            this.productMangamentToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.productMangamentToolStripMenuItem.Text = "&Product Mangament";
            this.productMangamentToolStripMenuItem.Click += new System.EventHandler(this.productMangamentToolStripMenuItem_Click);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.BackColor = System.Drawing.Color.DarkRed;
            this.helpToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.helpToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(67, 48);
            this.helpToolStripMenuItem2.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1018);
            this.Controls.Add(this.panelBackGround);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunny Automatic Detect Self-Emergency Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okDisplay)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabLeftControl.ResumeLayout(false);
            this.tabProductInput.ResumeLayout(false);
            this.subPanelToPutData.ResumeLayout(false);
            this.pnBatteryCapacity.ResumeLayout(false);
            this.pnBatteryCapacity.PerformLayout();
            this.pnBatteryType.ResumeLayout(false);
            this.pnBatteryType.PerformLayout();
            this.pnSeries.ResumeLayout(false);
            this.pnSeries.PerformLayout();
            this.pnModel.ResumeLayout(false);
            this.pnModel.PerformLayout();
            this.pnProductGroup.ResumeLayout(false);
            this.pnProductGroup.PerformLayout();
            this.pnPerson.ResumeLayout(false);
            this.pnPerson.PerformLayout();
            this.pnMfgDate.ResumeLayout(false);
            this.pnMfgDate.PerformLayout();
            this.pnLot.ResumeLayout(false);
            this.pnLot.PerformLayout();
            this.pnSerialNumber.ResumeLayout(false);
            this.pnSerialNumber.PerformLayout();
            this.pnJobNumber.ResumeLayout(false);
            this.pnJobNumber.PerformLayout();
            this.pnHeaderDataInput.ResumeLayout(false);
            this.pnHeaderDataInput.PerformLayout();
            this.tabBuffer.ResumeLayout(false);
            this.pnMovingAverage.ResumeLayout(false);
            this.pnCurrentAxis.ResumeLayout(false);
            this.pnChbCurrentVisibility.ResumeLayout(false);
            this.pnChbCurrentVisibility.PerformLayout();
            this.pnCurrentAxisLabel.ResumeLayout(false);
            this.pnCurrentAxisLabel.PerformLayout();
            this.pnMAAxis.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnMAlabel.ResumeLayout(false);
            this.pnMAlabel.PerformLayout();
            this.pnVoltageAxis.ResumeLayout(false);
            this.pnChbVoltageVisibility.ResumeLayout(false);
            this.pnChbVoltageVisibility.PerformLayout();
            this.pnLabelVoltageAxis.ResumeLayout(false);
            this.pnLabelVoltageAxis.PerformLayout();
            this.pnVoltageBuffer.ResumeLayout(false);
            this.pnHeaderMovingAverage.ResumeLayout(false);
            this.pnHeaderMovingAverage.PerformLayout();
            this.tabSpecificationsMM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabRealtimeData.ResumeLayout(false);
            this.pnSpecificationMean.ResumeLayout(false);
            this.pnLowCutOffMean.ResumeLayout(false);
            this.pnLowCutOffMean.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.pnLowMeanlable.ResumeLayout(false);
            this.pnLowMeanlable.PerformLayout();
            this.pnLowMeanText.ResumeLayout(false);
            this.pnLowMeanText.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnRealTimeData.ResumeLayout(false);
            this.pnAlternativeCurrent.ResumeLayout(false);
            this.pnVoltageAc.ResumeLayout(false);
            this.pnVoltageAc.PerformLayout();
            this.pnVoltageAcText.ResumeLayout(false);
            this.pnVoltageAcText.PerformLayout();
            this.pnCurrentAc.ResumeLayout(false);
            this.pnCurrentAc.PerformLayout();
            this.pnCurrentAcText.ResumeLayout(false);
            this.pnCurrentAcText.PerformLayout();
            this.pnDirectCurrent.ResumeLayout(false);
            this.pnCurrentDc.ResumeLayout(false);
            this.pnCurrentDc.PerformLayout();
            this.pnCurrentDCText.ResumeLayout(false);
            this.pnCurrentDCText.PerformLayout();
            this.pnVoltageDc.ResumeLayout(false);
            this.pnVoltageDc.PerformLayout();
            this.pnVoltageDcText.ResumeLayout(false);
            this.pnVoltageDcText.PerformLayout();
            this.pnDericative.ResumeLayout(false);
            this.pnDericative.PerformLayout();
            this.pnTextDerivative.ResumeLayout(false);
            this.pnTextDerivative.PerformLayout();
            this.pnMaVolage.ResumeLayout(false);
            this.pnMaVolage.PerformLayout();
            this.pnMAvoltageText.ResumeLayout(false);
            this.pnMAvoltageText.PerformLayout();
            this.pnHeaderRealTimeData.ResumeLayout(false);
            this.pnHeaderRealTimeData.PerformLayout();
            this.pnSpecifications.ResumeLayout(false);
            this.pnLowCutOffMM.ResumeLayout(false);
            this.pnLowCutOffMM.PerformLayout();
            this.pnLowVoltageCutOff.ResumeLayout(false);
            this.pnLowVoltageCutOff.PerformLayout();
            this.pnCurrentConstantMM.ResumeLayout(false);
            this.pnCurrentConstantMM.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.pnLabelHighMM.ResumeLayout(false);
            this.pnLabelHighMM.PerformLayout();
            this.pnHighMMText.ResumeLayout(false);
            this.pnHighMMText.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnLowMMText.ResumeLayout(false);
            this.pnLowMMText.PerformLayout();
            this.pnStage.ResumeLayout(false);
            this.pnStage.PerformLayout();
            this.pnStageText.ResumeLayout(false);
            this.pnStageText.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabConnection.ResumeLayout(false);
            this.pnConnection.ResumeLayout(false);
            this.pnLedStage.ResumeLayout(false);
            this.pnToggleLED.ResumeLayout(false);
            this.pnLEDStateLabel.ResumeLayout(false);
            this.pnLEDStateLabel.PerformLayout();
            this.pnWiFiConnection.ResumeLayout(false);
            this.pnChangeIPAdress.ResumeLayout(false);
            this.pnFindESP.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.pnStateConnection.ResumeLayout(false);
            this.pnStateConnection.PerformLayout();
            this.pnRelay.ResumeLayout(false);
            this.pnBtnRelay.ResumeLayout(false);
            this.pnRelayLabel.ResumeLayout(false);
            this.pnRelayLabel.PerformLayout();
            this.pnPasswordLabel.ResumeLayout(false);
            this.pnPasswordLabel.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnSSID.ResumeLayout(false);
            this.pnSSID.PerformLayout();
            this.pnSSIDText.ResumeLayout(false);
            this.pnSSIDText.PerformLayout();
            this.pnCommunication.ResumeLayout(false);
            this.pnCommunication.PerformLayout();
            this.splitContainerMid.Panel1.ResumeLayout(false);
            this.splitContainerMid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMid)).EndInit();
            this.splitContainerMid.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabQualityCheck.ResumeLayout(false);
            this.pnQualityCheck.ResumeLayout(false);
            this.pnQualityCheck.PerformLayout();
            this.pnManualCheck.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.pnAutoCheck.ResumeLayout(false);
            this.pnAutoCheck.PerformLayout();
            this.pnAutoCheckText.ResumeLayout(false);
            this.pnAutoCheckText.PerformLayout();
            this.pnHeaderProductQuality.ResumeLayout(false);
            this.pnHeaderProductQuality.PerformLayout();
            this.tabMeasurement.ResumeLayout(false);
            this.pnMeasurement.ResumeLayout(false);
            this.pnClear.ResumeLayout(false);
            this.pnStop.ResumeLayout(false);
            this.pnbtnStart.ResumeLayout(false);
            this.pnStopTold.ResumeLayout(false);
            this.pnStopWatch.ResumeLayout(false);
            this.pnStopWatch.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainRawMeasurementBindingSource)).EndInit();
            this.panelBackGround.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnSubTopMenu.ResumeLayout(false);
            this.pnSubTopMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errDisplay;
        private System.Windows.Forms.ErrorProvider okDisplay;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.Timer backUpTimer;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer timerDerivative;
        private FontAwesome.Sharp.IconDropDownButton iDropDownButtonMenu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.Label lblTimerStatusDashboardPic;
        private System.Windows.Forms.TextBox txtTimer1;
        private System.Windows.Forms.Label lbtime_pc;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label labelAutoCheck;
        private System.Windows.Forms.TextBox txtAutoCheck;
        private System.Windows.Forms.BindingSource frmMainRawMeasurementBindingSource;
        private FontAwesome.Sharp.IconButton btnMiniSize;
        private FontAwesome.Sharp.IconButton btnCloseForm;
        private System.Windows.Forms.Panel panelBackGround;
        private System.Windows.Forms.Panel pnQualityCheck;
        private System.Windows.Forms.Panel pnHeaderProductQuality;
        private System.Windows.Forms.Label lblHeaderCheck;
        private System.Windows.Forms.Panel pnMeasurement;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblHeaderMeasurement;
        private System.Windows.Forms.Panel pnTop;
        private FontAwesome.Sharp.IconButton btnMinimum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGraphFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closePanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMangamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnSubTopMenu;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnCLose;
        public FontAwesome.Sharp.IconButton btnSubmitComment;
        internal System.Windows.Forms.TextBox txtComment;
        public System.Windows.Forms.ComboBox cboManualCheck;
        public FontAwesome.Sharp.IconButton btnStart;
        public FontAwesome.Sharp.IconButton btnStop;
        private FontAwesome.Sharp.IconButton btnClearTime_PC;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movingAverageBufferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificationMinMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificationMeanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeDataToolStripMenuItem;
        private System.Windows.Forms.Panel pnManualCheck;
        private System.Windows.Forms.Panel pnAutoCheck;
        private System.Windows.Forms.Panel pnAutoCheckText;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelManualCheck;
        private System.Windows.Forms.Panel pnStop;
        private System.Windows.Forms.Panel pnbtnStart;
        private System.Windows.Forms.Panel pnStopTold;
        private System.Windows.Forms.Panel pnStopWatch;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel pnClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQualityCheck;
        private System.Windows.Forms.TabPage tabMeasurement;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainerMid;
        public ZedGraph.ZedGraphControl zedPlot;
        private System.Windows.Forms.TabControl tabLeftControl;
        private System.Windows.Forms.TabPage tabProductInput;
        private System.Windows.Forms.Panel subPanelToPutData;
        private System.Windows.Forms.Panel pnBatteryCapacity;
        private System.Windows.Forms.Label labelBatteryCapacity;
        public System.Windows.Forms.ComboBox cboBatteryCapacityM;
        private System.Windows.Forms.Panel pnBatteryType;
        private System.Windows.Forms.Label labelBatteryType;
        public System.Windows.Forms.ComboBox cboBatteryTypeM;
        private System.Windows.Forms.Panel pnSeries;
        private System.Windows.Forms.Label labelProductSeries;
        public System.Windows.Forms.ComboBox cboModelM;
        private System.Windows.Forms.Panel pnModel;
        private System.Windows.Forms.Label labelSeriesModel;
        public System.Windows.Forms.ComboBox cboSeriesM;
        private System.Windows.Forms.Panel pnProductGroup;
        public System.Windows.Forms.ComboBox cboProductGroupM;
        private System.Windows.Forms.Label labelProductGroup;
        private System.Windows.Forms.Panel pnPerson;
        private System.Windows.Forms.Label labelMeasureBy;
        public System.Windows.Forms.TextBox txtMeasureBy;
        private System.Windows.Forms.Panel pnMfgDate;
        public System.Windows.Forms.TextBox txtManufacDate;
        private System.Windows.Forms.Label labelManufactorData;
        private System.Windows.Forms.Panel pnLot;
        public System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label labelLot;
        private System.Windows.Forms.Panel pnSerialNumber;
        private System.Windows.Forms.Label labelSerialNumber;
        public System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Panel pnJobNumber;
        private System.Windows.Forms.Label labelJobNumber;
        public System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.Panel pnHeaderDataInput;
        private System.Windows.Forms.Label lblHeaderInputData;
        internal FontAwesome.Sharp.IconButton btnSubmitMeasurement;
        private System.Windows.Forms.TabPage tabBuffer;
        private System.Windows.Forms.Panel pnMovingAverage;
        private System.Windows.Forms.Panel pnCurrentAxis;
        private System.Windows.Forms.Panel pnChbCurrentVisibility;
        private System.Windows.Forms.CheckBox chbVisibleCurrentAxis;
        private System.Windows.Forms.Panel pnCurrentAxisLabel;
        private System.Windows.Forms.Label labelCurrentFocus;
        private System.Windows.Forms.Panel pnVoltageAxis;
        private System.Windows.Forms.Panel pnChbVoltageVisibility;
        private System.Windows.Forms.CheckBox chbVisibleVoltageAxis;
        private System.Windows.Forms.Panel pnLabelVoltageAxis;
        private System.Windows.Forms.Label labelVoltageFocus;
        private System.Windows.Forms.Panel pnVoltageBuffer;
        public System.Windows.Forms.ComboBox cboSelectBuffer;
        private System.Windows.Forms.Panel pnHeaderMovingAverage;
        private System.Windows.Forms.Label lbHeaderMovingAverage;
        private System.Windows.Forms.TabPage tabSpecificationsMM;
        private System.Windows.Forms.TabPage tabRealtimeData;
        private System.Windows.Forms.Panel pnRealTimeData;
        private System.Windows.Forms.Panel pnAlternativeCurrent;
        private System.Windows.Forms.Panel pnVoltageAc;
        private System.Windows.Forms.Panel pnVoltageAcText;
        public System.Windows.Forms.TextBox txtAcCurrent;
        private System.Windows.Forms.Label labelAcVoltage;
        private System.Windows.Forms.Panel pnCurrentAc;
        private System.Windows.Forms.Panel pnCurrentAcText;
        public System.Windows.Forms.TextBox txtAcVoltage;
        private System.Windows.Forms.Label labelAcCurrent;
        private System.Windows.Forms.Panel pnDirectCurrent;
        private System.Windows.Forms.Panel pnCurrentDc;
        private System.Windows.Forms.Panel pnCurrentDCText;
        public System.Windows.Forms.TextBox txtCurrentText;
        private System.Windows.Forms.Label labelCurrentDataText;
        private System.Windows.Forms.Panel pnVoltageDc;
        private System.Windows.Forms.Panel pnVoltageDcText;
        public System.Windows.Forms.TextBox txtVoltageText;
        private System.Windows.Forms.Label labelVoltageDataText;
        private System.Windows.Forms.Panel pnMaVolage;
        private System.Windows.Forms.Panel pnMAvoltageText;
        public System.Windows.Forms.TextBox txtMovingAverageText;
        private System.Windows.Forms.Label labelMovingAVGVoltageDataText;
        private System.Windows.Forms.Panel pnHeaderRealTimeData;
        private System.Windows.Forms.Label lblHeaderRealTimeData;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.Panel pnConnection;
        private System.Windows.Forms.Panel pnWiFiConnection;
        public FontAwesome.Sharp.IconButton btnConnect;
        private System.Windows.Forms.Panel pnChangeIPAdress;
        private System.Windows.Forms.Panel pnStateConnection;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnPasswordLabel;
        private System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnSSID;
        private System.Windows.Forms.Panel pnSSIDText;
        public System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.Panel pnCommunication;
        private System.Windows.Forms.Label lblCommunications;
        public System.Windows.Forms.ListView listDataPlot;
        private System.Windows.Forms.ColumnHeader sequence;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader voltage;
        private System.Windows.Forms.ColumnHeader average;
        private System.Windows.Forms.ColumnHeader current;
        private FontAwesome.Sharp.IconButton btnChangeIPAdress;
        private System.Windows.Forms.Panel pnFindESP;
        private FontAwesome.Sharp.IconButton btnFindDevice;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.ComboBox cboEsp32Devices;
        private System.Windows.Forms.Panel pnRelay;
        private System.Windows.Forms.Panel pnBtnRelay;
        private FontAwesome.Sharp.IconButton btnToggleRelay;
        private System.Windows.Forms.Panel pnRelayLabel;
        private System.Windows.Forms.Label lblRelayState;
        private System.Windows.Forms.Panel pnLedStage;
        private System.Windows.Forms.Panel pnToggleLED;
        private FontAwesome.Sharp.IconButton btnToggleLed;
        private System.Windows.Forms.Panel pnLEDStateLabel;
        private System.Windows.Forms.Label lblLedState;
        private System.Windows.Forms.Panel pnMAAxis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chbMAVoltageAxis;
        private System.Windows.Forms.Panel pnMAlabel;
        private System.Windows.Forms.Label lblMovingAverage;
        private System.Windows.Forms.ColumnHeader adcCurrent;
        private System.Windows.Forms.Panel pnSpecifications;
        private System.Windows.Forms.Panel pnLowCutOffMM;
        private System.Windows.Forms.Panel pnLowVoltageCutOff;
        internal System.Windows.Forms.TextBox txtLowVoltageCutOffMinMax;
        private System.Windows.Forms.Label labelLowVoltageCutOffMinMax;
        private System.Windows.Forms.Panel pnCurrentConstantMM;
        private System.Windows.Forms.Panel panel11;
        internal System.Windows.Forms.TextBox txtVoltageChargerMinMaxCurrentConstant;
        private System.Windows.Forms.Label labelVoltageChargerCurrentConstant;
        private System.Windows.Forms.Panel pnLabelHighMM;
        private System.Windows.Forms.Panel pnHighMMText;
        internal System.Windows.Forms.TextBox txtVoltageChargerMinMaxHigh;
        private System.Windows.Forms.Label labelVoltageChargerMinMaxCut;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnLowMMText;
        internal System.Windows.Forms.TextBox txtVoltageChargerMinMaxLow;
        private System.Windows.Forms.Label labelVoltageChargerMinMaxConnect;
        private System.Windows.Forms.Panel pnStage;
        private System.Windows.Forms.Panel pnStageText;
        internal System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblspecifiations;
        private System.Windows.Forms.Panel pnSpecificationMean;
        private System.Windows.Forms.Panel pnLowCutOffMean;
        private System.Windows.Forms.Panel panel19;
        internal System.Windows.Forms.TextBox txtMeanVoltageCutOff;
        private System.Windows.Forms.Label labelMeanVoltageCutOff;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        internal System.Windows.Forms.TextBox txtMeanVoltageChargerCurrentConstant;
        private System.Windows.Forms.Label pnCurrentConstantLabel;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        internal System.Windows.Forms.TextBox txtMeanVoltageChargerHigh;
        private System.Windows.Forms.Label pnHighMeanLabel;
        private System.Windows.Forms.Panel pnLowMeanlable;
        private System.Windows.Forms.Panel pnLowMeanText;
        internal System.Windows.Forms.TextBox txtMeanVoltageChargerLow;
        private System.Windows.Forms.Label labelVoltageChargerConnectMean;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSpeMean;
        private System.Windows.Forms.Panel pnDericative;
        private System.Windows.Forms.Panel pnTextDerivative;
        public System.Windows.Forms.TextBox txtDerivative;
        private System.Windows.Forms.Label lblDvDt;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton hotSpot;
        private System.Windows.Forms.ColumnHeader derivative;
    }
}

