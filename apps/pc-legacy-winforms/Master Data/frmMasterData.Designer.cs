namespace TESTBAG.Master_Data
{
    partial class DataManagement
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
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTGRUOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bATTERYTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bATTERYCAPACITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewProduct = new FontAwesome.Sharp.IconButton();
            this.btnRefreshProduct = new FontAwesome.Sharp.IconButton();
            this.masterSPECIFICATIONSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master_SPECIFICATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewSpecify = new FontAwesome.Sharp.IconButton();
            this.btnRefreshSpecify = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlProductManagement = new System.Windows.Forms.TabControl();
            this.tabProductPage = new System.Windows.Forms.TabPage();
            this.panelProductDataView = new System.Windows.Forms.Panel();
            this.panelProductControl = new System.Windows.Forms.Panel();
            this.tabSpecificationPage = new System.Windows.Forms.TabPage();
            this.panelSpecificationsData = new System.Windows.Forms.Panel();
            this.panelControlSpecifications = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSPECIFICATIONSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.tabControlProductManagement.SuspendLayout();
            this.tabProductPage.SuspendLayout();
            this.panelProductDataView.SuspendLayout();
            this.panelProductControl.SuspendLayout();
            this.tabSpecificationPage.SuspendLayout();
            this.panelSpecificationsData.SuspendLayout();
            this.panelControlSpecifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pRODUCTGRUOPDataGridViewTextBoxColumn,
            this.sERIESDataGridViewTextBoxColumn,
            this.mODELDataGridViewTextBoxColumn,
            this.bATTERYTYPEDataGridViewTextBoxColumn,
            this.bATTERYCAPACITYDataGridViewTextBoxColumn,
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.masterProductBindingSource;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(1316, 585);
            this.productDataGridView.TabIndex = 2;
            this.productDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTGRUOPDataGridViewTextBoxColumn
            // 
            this.pRODUCTGRUOPDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_GRUOP";
            this.pRODUCTGRUOPDataGridViewTextBoxColumn.HeaderText = "PRODUCT_GRUOP";
            this.pRODUCTGRUOPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTGRUOPDataGridViewTextBoxColumn.Name = "pRODUCTGRUOPDataGridViewTextBoxColumn";
            this.pRODUCTGRUOPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sERIESDataGridViewTextBoxColumn
            // 
            this.sERIESDataGridViewTextBoxColumn.DataPropertyName = "SERIES";
            this.sERIESDataGridViewTextBoxColumn.HeaderText = "SERIES";
            this.sERIESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sERIESDataGridViewTextBoxColumn.Name = "sERIESDataGridViewTextBoxColumn";
            this.sERIESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            this.mODELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bATTERYTYPEDataGridViewTextBoxColumn
            // 
            this.bATTERYTYPEDataGridViewTextBoxColumn.DataPropertyName = "BATTERY_TYPE";
            this.bATTERYTYPEDataGridViewTextBoxColumn.HeaderText = "BATTERY_TYPE";
            this.bATTERYTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bATTERYTYPEDataGridViewTextBoxColumn.Name = "bATTERYTYPEDataGridViewTextBoxColumn";
            this.bATTERYTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bATTERYCAPACITYDataGridViewTextBoxColumn
            // 
            this.bATTERYCAPACITYDataGridViewTextBoxColumn.DataPropertyName = "BATTERY_CAPACITY";
            this.bATTERYCAPACITYDataGridViewTextBoxColumn.HeaderText = "BATTERY_CAPACITY";
            this.bATTERYCAPACITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bATTERYCAPACITYDataGridViewTextBoxColumn.Name = "bATTERYCAPACITYDataGridViewTextBoxColumn";
            this.bATTERYCAPACITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mASTERSPECIFICATIONSDataGridViewTextBoxColumn
            // 
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn.DataPropertyName = "MASTER_SPECIFICATIONS";
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn.HeaderText = "MASTER_SPECIFICATIONS";
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn.Name = "mASTERSPECIFICATIONSDataGridViewTextBoxColumn";
            this.mASTERSPECIFICATIONSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masterProductBindingSource
            // 
            //this.masterProductBindingSource.DataSource = typeof(TESTBAG.Master_Data.ProductDB.PRODUCT);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNewProduct.IconColor = System.Drawing.Color.Black;
            this.btnNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewProduct.Location = new System.Drawing.Point(1103, 27);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(167, 45);
            this.btnNewProduct.TabIndex = 2;
            this.btnNewProduct.Text = "Add New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefreshProduct.IconColor = System.Drawing.Color.Black;
            this.btnRefreshProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshProduct.Location = new System.Drawing.Point(947, 27);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(117, 45);
            this.btnRefreshProduct.TabIndex = 1;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = true;
            this.btnRefreshProduct.Click += new System.EventHandler(this.btnRefreshProduct_Click);
            // 
            // masterSPECIFICATIONSDataGridView
            // 
            this.masterSPECIFICATIONSDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.masterSPECIFICATIONSDataGridView.AutoGenerateColumns = false;
            this.masterSPECIFICATIONSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.masterSPECIFICATIONSDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.masterSPECIFICATIONSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterSPECIFICATIONSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.masterSPECIFICATIONSDataGridView.DataSource = this.master_SPECIFICATIONSBindingSource;
            this.masterSPECIFICATIONSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterSPECIFICATIONSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.masterSPECIFICATIONSDataGridView.Name = "masterSPECIFICATIONSDataGridView";
            this.masterSPECIFICATIONSDataGridView.RowHeadersWidth = 51;
            this.masterSPECIFICATIONSDataGridView.RowTemplate.Height = 24;
            this.masterSPECIFICATIONSDataGridView.Size = new System.Drawing.Size(1316, 585);
            this.masterSPECIFICATIONSDataGridView.TabIndex = 5;
            this.masterSPECIFICATIONSDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.masterSPECIFICATIONSDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PRODUCT_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "PRODUCT_ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MEASUREMENT_NAME";
            this.dataGridViewTextBoxColumn12.HeaderText = "MEASUREMENT_NAME";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "STAGE_TEXT";
            this.dataGridViewTextBoxColumn13.HeaderText = "STAGE_TEXT";
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
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MAX_VALUE";
            this.dataGridViewTextBoxColumn15.HeaderText = "MAX_VALUE";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MIN_VALUE";
            this.dataGridViewTextBoxColumn16.HeaderText = "MIN_VALUE";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "PRODUCT";
            this.dataGridViewTextBoxColumn17.HeaderText = "PRODUCT";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // master_SPECIFICATIONSBindingSource
            // 
            //this.master_SPECIFICATIONSBindingSource.DataSource = typeof(TESTBAG.Master_Data.ProductDB.MASTER_SPECIFICATIONS);
            // 
            // btnNewSpecify
            // 
            this.btnNewSpecify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNewSpecify.IconColor = System.Drawing.Color.Black;
            this.btnNewSpecify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewSpecify.Location = new System.Drawing.Point(1070, 21);
            this.btnNewSpecify.Name = "btnNewSpecify";
            this.btnNewSpecify.Size = new System.Drawing.Size(214, 45);
            this.btnNewSpecify.TabIndex = 5;
            this.btnNewSpecify.Text = "Add New Specifications";
            this.btnNewSpecify.UseVisualStyleBackColor = true;
            this.btnNewSpecify.Click += new System.EventHandler(this.btnNewSpecify_Click);
            // 
            // btnRefreshSpecify
            // 
            this.btnRefreshSpecify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefreshSpecify.IconColor = System.Drawing.Color.Black;
            this.btnRefreshSpecify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshSpecify.Location = new System.Drawing.Point(932, 21);
            this.btnRefreshSpecify.Name = "btnRefreshSpecify";
            this.btnRefreshSpecify.Size = new System.Drawing.Size(117, 45);
            this.btnRefreshSpecify.TabIndex = 4;
            this.btnRefreshSpecify.Text = "Refresh";
            this.btnRefreshSpecify.UseVisualStyleBackColor = true;
            this.btnRefreshSpecify.Click += new System.EventHandler(this.btnMeausreSpecify_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tabControlProductManagement
            // 
            this.tabControlProductManagement.Controls.Add(this.tabProductPage);
            this.tabControlProductManagement.Controls.Add(this.tabSpecificationPage);
            this.tabControlProductManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProductManagement.Location = new System.Drawing.Point(0, 0);
            this.tabControlProductManagement.Name = "tabControlProductManagement";
            this.tabControlProductManagement.SelectedIndex = 0;
            this.tabControlProductManagement.Size = new System.Drawing.Size(1330, 720);
            this.tabControlProductManagement.TabIndex = 1;
            // 
            // tabProductPage
            // 
            this.tabProductPage.Controls.Add(this.panelProductDataView);
            this.tabProductPage.Controls.Add(this.panelProductControl);
            this.tabProductPage.Location = new System.Drawing.Point(4, 25);
            this.tabProductPage.Name = "tabProductPage";
            this.tabProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductPage.Size = new System.Drawing.Size(1322, 691);
            this.tabProductPage.TabIndex = 0;
            this.tabProductPage.Text = "Product";
            this.tabProductPage.UseVisualStyleBackColor = true;
            // 
            // panelProductDataView
            // 
            this.panelProductDataView.Controls.Add(this.productDataGridView);
            this.panelProductDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDataView.Location = new System.Drawing.Point(3, 103);
            this.panelProductDataView.Name = "panelProductDataView";
            this.panelProductDataView.Size = new System.Drawing.Size(1316, 585);
            this.panelProductDataView.TabIndex = 4;
            // 
            // panelProductControl
            // 
            this.panelProductControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.panelProductControl.Controls.Add(this.btnRefreshProduct);
            this.panelProductControl.Controls.Add(this.btnNewProduct);
            this.panelProductControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductControl.Location = new System.Drawing.Point(3, 3);
            this.panelProductControl.Name = "panelProductControl";
            this.panelProductControl.Size = new System.Drawing.Size(1316, 100);
            this.panelProductControl.TabIndex = 3;
            // 
            // tabSpecificationPage
            // 
            this.tabSpecificationPage.Controls.Add(this.panelSpecificationsData);
            this.tabSpecificationPage.Controls.Add(this.panelControlSpecifications);
            this.tabSpecificationPage.Location = new System.Drawing.Point(4, 25);
            this.tabSpecificationPage.Name = "tabSpecificationPage";
            this.tabSpecificationPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecificationPage.Size = new System.Drawing.Size(1322, 691);
            this.tabSpecificationPage.TabIndex = 1;
            this.tabSpecificationPage.Text = "Specification";
            this.tabSpecificationPage.UseVisualStyleBackColor = true;
            // 
            // panelSpecificationsData
            // 
            this.panelSpecificationsData.Controls.Add(this.masterSPECIFICATIONSDataGridView);
            this.panelSpecificationsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpecificationsData.Location = new System.Drawing.Point(3, 103);
            this.panelSpecificationsData.Name = "panelSpecificationsData";
            this.panelSpecificationsData.Size = new System.Drawing.Size(1316, 585);
            this.panelSpecificationsData.TabIndex = 5;
            // 
            // panelControlSpecifications
            // 
            this.panelControlSpecifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.panelControlSpecifications.Controls.Add(this.btnRefreshSpecify);
            this.panelControlSpecifications.Controls.Add(this.btnNewSpecify);
            this.panelControlSpecifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlSpecifications.Location = new System.Drawing.Point(3, 3);
            this.panelControlSpecifications.Name = "panelControlSpecifications";
            this.panelControlSpecifications.Size = new System.Drawing.Size(1316, 100);
            this.panelControlSpecifications.TabIndex = 4;
            // 
            // MasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 720);
            this.Controls.Add(this.tabControlProductManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MasterData";
            this.Text = "MASTER DATA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterData_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSPECIFICATIONSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.tabControlProductManagement.ResumeLayout(false);
            this.tabProductPage.ResumeLayout(false);
            this.panelProductDataView.ResumeLayout(false);
            this.panelProductControl.ResumeLayout(false);
            this.tabSpecificationPage.ResumeLayout(false);
            this.panelSpecificationsData.ResumeLayout(false);
            this.panelControlSpecifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnNewProduct;
        private FontAwesome.Sharp.IconButton btnRefreshProduct;
        private FontAwesome.Sharp.IconButton btnNewSpecify;
        private FontAwesome.Sharp.IconButton btnRefreshSpecify;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridView masterSPECIFICATIONSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTGRUOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATTERYTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATTERYCAPACITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASTERSPECIFICATIONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEASUREMENTPRODUCTDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource masterProductBindingSource;
        private System.Windows.Forms.TabControl tabControlProductManagement;
        private System.Windows.Forms.TabPage tabProductPage;
        private System.Windows.Forms.Panel panelProductControl;
        private System.Windows.Forms.TabPage tabSpecificationPage;
        private System.Windows.Forms.Panel panelProductDataView;
        private System.Windows.Forms.Panel panelSpecificationsData;
        private System.Windows.Forms.Panel panelControlSpecifications;
        public System.Windows.Forms.BindingSource master_SPECIFICATIONSBindingSource;
    }
}