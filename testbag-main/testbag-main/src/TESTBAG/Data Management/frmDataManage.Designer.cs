namespace TESTBAG.Data_Management
{
    partial class frmDataManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataManage));
            this.pnMainDataManage = new System.Windows.Forms.Panel();
            this.tabDataGrid = new System.Windows.Forms.TabControl();
            this.pageProduct = new System.Windows.Forms.TabPage();
            this.panelGridProduct = new System.Windows.Forms.Panel();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.gridProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelButtonProduct = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.btnProductRefresh = new FontAwesome.Sharp.IconButton();
            this.pageSpecifications = new System.Windows.Forms.TabPage();
            this.gridSpecifications = new System.Windows.Forms.DataGridView();
            this.gridSpecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterSpecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnRefreshSpecifications = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnAddSpecifications = new FontAwesome.Sharp.IconButton();
            this.pageMeasurementProduct = new System.Windows.Forms.TabPage();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.gridHistoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIALNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEASUREDATETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGLISTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnDeleteHistory = new FontAwesome.Sharp.IconButton();
            this.btnAddHistoryData = new FontAwesome.Sharp.IconButton();
            this.pnMainDataManage.SuspendLayout();
            this.tabDataGrid.SuspendLayout();
            this.pageProduct.SuspendLayout();
            this.panelGridProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panelButtonProduct.SuspendLayout();
            this.pageSpecifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSpecBindingSource)).BeginInit();
            this.pnButton.SuspendLayout();
            this.pageMeasurementProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementProductBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMainDataManage
            // 
            this.pnMainDataManage.BackColor = System.Drawing.Color.DarkRed;
            this.pnMainDataManage.Controls.Add(this.tabDataGrid);
            this.pnMainDataManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainDataManage.Location = new System.Drawing.Point(0, 0);
            this.pnMainDataManage.Name = "pnMainDataManage";
            this.pnMainDataManage.Size = new System.Drawing.Size(1265, 739);
            this.pnMainDataManage.TabIndex = 0;
            // 
            // tabDataGrid
            // 
            this.tabDataGrid.Controls.Add(this.pageProduct);
            this.tabDataGrid.Controls.Add(this.pageSpecifications);
            this.tabDataGrid.Controls.Add(this.pageMeasurementProduct);
            this.tabDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabDataGrid.HotTrack = true;
            this.tabDataGrid.ItemSize = new System.Drawing.Size(150, 45);
            this.tabDataGrid.Location = new System.Drawing.Point(0, 0);
            this.tabDataGrid.Multiline = true;
            this.tabDataGrid.Name = "tabDataGrid";
            this.tabDataGrid.SelectedIndex = 0;
            this.tabDataGrid.Size = new System.Drawing.Size(1265, 739);
            this.tabDataGrid.TabIndex = 0;
            // 
            // pageProduct
            // 
            this.pageProduct.AutoScroll = true;
            this.pageProduct.BackColor = System.Drawing.Color.White;
            this.pageProduct.Controls.Add(this.panelGridProduct);
            this.pageProduct.Controls.Add(this.panelButtonProduct);
            this.pageProduct.Location = new System.Drawing.Point(4, 49);
            this.pageProduct.Name = "pageProduct";
            this.pageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.pageProduct.Size = new System.Drawing.Size(1257, 686);
            this.pageProduct.TabIndex = 0;
            this.pageProduct.Text = "Product";
            // 
            // panelGridProduct
            // 
            this.panelGridProduct.Controls.Add(this.gridProduct);
            this.panelGridProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGridProduct.Location = new System.Drawing.Point(3, 78);
            this.panelGridProduct.Name = "panelGridProduct";
            this.panelGridProduct.Size = new System.Drawing.Size(1251, 608);
            this.panelGridProduct.TabIndex = 9;
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AutoGenerateColumns = false;
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridProduct.BackgroundColor = System.Drawing.Color.DimGray;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridProductId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gridProduct.DataSource = this.productBindingSource;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(0, 0);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.RowHeadersWidth = 51;
            this.gridProduct.RowTemplate.Height = 24;
            this.gridProduct.Size = new System.Drawing.Size(1251, 608);
            this.gridProduct.TabIndex = 3;
            this.gridProduct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_CellContentDoubleClick);
            // 
            // gridProductId
            // 
            this.gridProductId.DataPropertyName = "ID";
            this.gridProductId.HeaderText = "ID";
            this.gridProductId.MinimumWidth = 6;
            this.gridProductId.Name = "gridProductId";
            this.gridProductId.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRODUCT_GRUOP";
            this.dataGridViewTextBoxColumn2.HeaderText = "PRODUCT_GRUOP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 191;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SERIES";
            this.dataGridViewTextBoxColumn3.HeaderText = "SERIES";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MODEL";
            this.dataGridViewTextBoxColumn4.HeaderText = "MODEL";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BATTERY_TYPE";
            this.dataGridViewTextBoxColumn5.HeaderText = "BATTERY_TYPE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 165;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BATTERY_CAPACITY";
            this.dataGridViewTextBoxColumn6.HeaderText = "BATTERY_CAPACITY";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 204;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CREATE_DATE_TIME";
            this.dataGridViewTextBoxColumn7.HeaderText = "CREATE_DATE_TIME";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 207;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IS_DEACTICATED";
            this.dataGridViewTextBoxColumn8.HeaderText = "IS_DEACTICATED";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 180;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TESTBAG.Data_Management.Database.PRODUCT);
            // 
            // panelButtonProduct
            // 
            this.panelButtonProduct.Controls.Add(this.iconButton3);
            this.panelButtonProduct.Controls.Add(this.btnAddProduct);
            this.panelButtonProduct.Controls.Add(this.btnProductRefresh);
            this.panelButtonProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonProduct.Location = new System.Drawing.Point(3, 3);
            this.panelButtonProduct.Name = "panelButtonProduct";
            this.panelButtonProduct.Size = new System.Drawing.Size(1251, 75);
            this.panelButtonProduct.TabIndex = 8;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(123, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(123, 75);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddProduct.IconColor = System.Drawing.Color.Black;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(123, 75);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProductRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnProductRefresh.IconColor = System.Drawing.Color.Black;
            this.btnProductRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductRefresh.Location = new System.Drawing.Point(1128, 0);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(123, 75);
            this.btnProductRefresh.TabIndex = 1;
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // pageSpecifications
            // 
            this.pageSpecifications.Controls.Add(this.gridSpecifications);
            this.pageSpecifications.Controls.Add(this.pnButton);
            this.pageSpecifications.Location = new System.Drawing.Point(4, 49);
            this.pageSpecifications.Name = "pageSpecifications";
            this.pageSpecifications.Padding = new System.Windows.Forms.Padding(3);
            this.pageSpecifications.Size = new System.Drawing.Size(1257, 686);
            this.pageSpecifications.TabIndex = 1;
            this.pageSpecifications.Text = "Specification";
            this.pageSpecifications.UseVisualStyleBackColor = true;
            // 
            // gridSpecifications
            // 
            this.gridSpecifications.AllowUserToAddRows = false;
            this.gridSpecifications.AllowUserToDeleteRows = false;
            this.gridSpecifications.AutoGenerateColumns = false;
            this.gridSpecifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSpecifications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridSpecifications.BackgroundColor = System.Drawing.Color.DimGray;
            this.gridSpecifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSpecifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridSpecId,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.gridSpecifications.DataSource = this.masterSpecBindingSource;
            this.gridSpecifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridSpecifications.Location = new System.Drawing.Point(3, 78);
            this.gridSpecifications.Name = "gridSpecifications";
            this.gridSpecifications.RowHeadersWidth = 51;
            this.gridSpecifications.RowTemplate.Height = 24;
            this.gridSpecifications.Size = new System.Drawing.Size(1251, 824);
            this.gridSpecifications.TabIndex = 7;
            this.gridSpecifications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mASTER_SPECIFICATIONSDataGridView_CellContentClick);
            // 
            // gridSpecId
            // 
            this.gridSpecId.DataPropertyName = "ID";
            this.gridSpecId.HeaderText = "ID";
            this.gridSpecId.MinimumWidth = 6;
            this.gridSpecId.Name = "gridSpecId";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PRODUCT_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "PRODUCT_ID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MEASUREMENT_NAME";
            this.dataGridViewTextBoxColumn11.HeaderText = "MEASUREMENT_NAME";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "STAGE_TEXT";
            this.dataGridViewTextBoxColumn12.HeaderText = "STAGE_TEXT";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MAX_VALUE";
            this.dataGridViewTextBoxColumn13.HeaderText = "MAX_VALUE";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PREFERRED_VALUE";
            this.dataGridViewTextBoxColumn14.HeaderText = "PREFERRED_VALUE";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MIN_VALUE";
            this.dataGridViewTextBoxColumn15.HeaderText = "MIN_VALUE";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // masterSpecBindingSource
            // 
            this.masterSpecBindingSource.DataSource = typeof(TESTBAG.Data_Management.Database.MASTER_SPECIFICATIONS);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnRefreshSpecifications);
            this.pnButton.Controls.Add(this.iconButton4);
            this.pnButton.Controls.Add(this.btnAddSpecifications);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButton.Location = new System.Drawing.Point(3, 3);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1251, 75);
            this.pnButton.TabIndex = 7;
            // 
            // btnRefreshSpecifications
            // 
            this.btnRefreshSpecifications.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshSpecifications.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRefreshSpecifications.IconColor = System.Drawing.Color.Black;
            this.btnRefreshSpecifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshSpecifications.Location = new System.Drawing.Point(1104, 0);
            this.btnRefreshSpecifications.Name = "btnRefreshSpecifications";
            this.btnRefreshSpecifications.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRefreshSpecifications.Size = new System.Drawing.Size(147, 75);
            this.btnRefreshSpecifications.TabIndex = 4;
            this.btnRefreshSpecifications.UseVisualStyleBackColor = true;
            this.btnRefreshSpecifications.Click += new System.EventHandler(this.btnRefreshSpecifications_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(139, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(123, 75);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnAddSpecifications
            // 
            this.btnAddSpecifications.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddSpecifications.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddSpecifications.IconColor = System.Drawing.Color.Black;
            this.btnAddSpecifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSpecifications.Location = new System.Drawing.Point(0, 0);
            this.btnAddSpecifications.Name = "btnAddSpecifications";
            this.btnAddSpecifications.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddSpecifications.Size = new System.Drawing.Size(139, 75);
            this.btnAddSpecifications.TabIndex = 5;
            this.btnAddSpecifications.UseVisualStyleBackColor = true;
            this.btnAddSpecifications.Click += new System.EventHandler(this.btnAddSpecifications_Click);
            // 
            // pageMeasurementProduct
            // 
            this.pageMeasurementProduct.Controls.Add(this.gridHistory);
            this.pageMeasurementProduct.Controls.Add(this.panel1);
            this.pageMeasurementProduct.Location = new System.Drawing.Point(4, 49);
            this.pageMeasurementProduct.Name = "pageMeasurementProduct";
            this.pageMeasurementProduct.Size = new System.Drawing.Size(1257, 686);
            this.pageMeasurementProduct.TabIndex = 2;
            this.pageMeasurementProduct.Text = "History Data";
            this.pageMeasurementProduct.UseVisualStyleBackColor = true;
            // 
            // gridHistory
            // 
            this.gridHistory.AllowUserToAddRows = false;
            this.gridHistory.AllowUserToDeleteRows = false;
            this.gridHistory.AutoGenerateColumns = false;
            this.gridHistory.BackgroundColor = System.Drawing.Color.IndianRed;
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridHistoryId,
            this.productId,
            this.sERIALNUMBERDataGridViewTextBoxColumn,
            this.lOTNUMBERDataGridViewTextBoxColumn,
            this.mFGDATEDataGridViewTextBoxColumn,
            this.mEASUREDATETIMEDataGridViewTextBoxColumn,
            this.nGLISTDataGridViewTextBoxColumn,
            this.cREATEBYDataGridViewTextBoxColumn,
            this.jOBNUMBERDataGridViewTextBoxColumn,
            this.cOMMENTDataGridViewTextBoxColumn});
            this.gridHistory.DataSource = this.measurementProductBindingSource;
            this.gridHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridHistory.Location = new System.Drawing.Point(0, 75);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.RowHeadersWidth = 51;
            this.gridHistory.RowTemplate.Height = 24;
            this.gridHistory.Size = new System.Drawing.Size(1257, 732);
            this.gridHistory.TabIndex = 9;
            this.gridHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHistory_CellDoubleClick);
            // 
            // gridHistoryId
            // 
            this.gridHistoryId.DataPropertyName = "ID";
            this.gridHistoryId.HeaderText = "ID";
            this.gridHistoryId.MinimumWidth = 6;
            this.gridHistoryId.Name = "gridHistoryId";
            this.gridHistoryId.Width = 125;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "PRODUCT_ID";
            this.productId.HeaderText = "PRODUCT_ID";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.Width = 125;
            // 
            // sERIALNUMBERDataGridViewTextBoxColumn
            // 
            this.sERIALNUMBERDataGridViewTextBoxColumn.DataPropertyName = "SERIAL_NUMBER";
            this.sERIALNUMBERDataGridViewTextBoxColumn.HeaderText = "SERIAL_NUMBER";
            this.sERIALNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sERIALNUMBERDataGridViewTextBoxColumn.Name = "sERIALNUMBERDataGridViewTextBoxColumn";
            this.sERIALNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOTNUMBERDataGridViewTextBoxColumn
            // 
            this.lOTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "LOT_NUMBER";
            this.lOTNUMBERDataGridViewTextBoxColumn.HeaderText = "LOT_NUMBER";
            this.lOTNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOTNUMBERDataGridViewTextBoxColumn.Name = "lOTNUMBERDataGridViewTextBoxColumn";
            this.lOTNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // mFGDATEDataGridViewTextBoxColumn
            // 
            this.mFGDATEDataGridViewTextBoxColumn.DataPropertyName = "MFG_DATE";
            this.mFGDATEDataGridViewTextBoxColumn.HeaderText = "MFG_DATE";
            this.mFGDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mFGDATEDataGridViewTextBoxColumn.Name = "mFGDATEDataGridViewTextBoxColumn";
            this.mFGDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEASUREDATETIMEDataGridViewTextBoxColumn
            // 
            this.mEASUREDATETIMEDataGridViewTextBoxColumn.DataPropertyName = "MEASURE_DATE_TIME";
            this.mEASUREDATETIMEDataGridViewTextBoxColumn.HeaderText = "MEASURE_DATE_TIME";
            this.mEASUREDATETIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEASUREDATETIMEDataGridViewTextBoxColumn.Name = "mEASUREDATETIMEDataGridViewTextBoxColumn";
            this.mEASUREDATETIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGLISTDataGridViewTextBoxColumn
            // 
            this.nGLISTDataGridViewTextBoxColumn.DataPropertyName = "NG_LIST";
            this.nGLISTDataGridViewTextBoxColumn.HeaderText = "NG_LIST";
            this.nGLISTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGLISTDataGridViewTextBoxColumn.Name = "nGLISTDataGridViewTextBoxColumn";
            this.nGLISTDataGridViewTextBoxColumn.Width = 125;
            // 
            // cREATEBYDataGridViewTextBoxColumn
            // 
            this.cREATEBYDataGridViewTextBoxColumn.DataPropertyName = "CREATE_BY";
            this.cREATEBYDataGridViewTextBoxColumn.HeaderText = "CREATE_BY";
            this.cREATEBYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cREATEBYDataGridViewTextBoxColumn.Name = "cREATEBYDataGridViewTextBoxColumn";
            this.cREATEBYDataGridViewTextBoxColumn.Width = 125;
            // 
            // jOBNUMBERDataGridViewTextBoxColumn
            // 
            this.jOBNUMBERDataGridViewTextBoxColumn.DataPropertyName = "JOB_NUMBER";
            this.jOBNUMBERDataGridViewTextBoxColumn.HeaderText = "JOB_NUMBER";
            this.jOBNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBNUMBERDataGridViewTextBoxColumn.Name = "jOBNUMBERDataGridViewTextBoxColumn";
            this.jOBNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // cOMMENTDataGridViewTextBoxColumn
            // 
            this.cOMMENTDataGridViewTextBoxColumn.DataPropertyName = "COMMENT";
            this.cOMMENTDataGridViewTextBoxColumn.HeaderText = "COMMENT";
            this.cOMMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOMMENTDataGridViewTextBoxColumn.Name = "cOMMENTDataGridViewTextBoxColumn";
            this.cOMMENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // measurementProductBindingSource
            // 
            this.measurementProductBindingSource.DataSource = typeof(TESTBAG.Data_Management.Database.MEASUREMENT_PRODUCT);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteHistory);
            this.panel1.Controls.Add(this.btnAddHistoryData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 75);
            this.panel1.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(1110, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(147, 75);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteHistory
            // 
            this.btnDeleteHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteHistory.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnDeleteHistory.IconColor = System.Drawing.Color.Black;
            this.btnDeleteHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteHistory.Location = new System.Drawing.Point(139, 0);
            this.btnDeleteHistory.Name = "btnDeleteHistory";
            this.btnDeleteHistory.Size = new System.Drawing.Size(123, 75);
            this.btnDeleteHistory.TabIndex = 6;
            this.btnDeleteHistory.UseVisualStyleBackColor = true;
            // 
            // btnAddHistoryData
            // 
            this.btnAddHistoryData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddHistoryData.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddHistoryData.IconColor = System.Drawing.Color.Black;
            this.btnAddHistoryData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddHistoryData.Location = new System.Drawing.Point(0, 0);
            this.btnAddHistoryData.Name = "btnAddHistoryData";
            this.btnAddHistoryData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddHistoryData.Size = new System.Drawing.Size(139, 75);
            this.btnAddHistoryData.TabIndex = 5;
            this.btnAddHistoryData.UseVisualStyleBackColor = true;
            // 
            // frmDataManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 739);
            this.Controls.Add(this.pnMainDataManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataManage";
            this.Text = "DataManage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDataManage_FormClosing);
            this.pnMainDataManage.ResumeLayout(false);
            this.tabDataGrid.ResumeLayout(false);
            this.pageProduct.ResumeLayout(false);
            this.panelGridProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panelButtonProduct.ResumeLayout(false);
            this.pageSpecifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSpecBindingSource)).EndInit();
            this.pnButton.ResumeLayout(false);
            this.pageMeasurementProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementProductBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMainDataManage;
        private System.Windows.Forms.TabControl tabDataGrid;
        private System.Windows.Forms.TabPage pageProduct;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private FontAwesome.Sharp.IconButton btnProductRefresh;
        private System.Windows.Forms.TabPage pageSpecifications;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnAddSpecifications;
        private FontAwesome.Sharp.IconButton btnRefreshSpecifications;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource masterSpecBindingSource;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel panelButtonProduct;
        private System.Windows.Forms.TabPage pageMeasurementProduct;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.BindingSource measurementProductBindingSource;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnDeleteHistory;
        private FontAwesome.Sharp.IconButton btnAddHistoryData;
        private System.Windows.Forms.DataGridView gridSpecifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSpecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Panel panelGridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridHistoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIALNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEASUREDATETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGLISTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMENTDataGridViewTextBoxColumn;
    }
}