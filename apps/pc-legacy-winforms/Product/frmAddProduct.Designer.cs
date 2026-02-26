namespace TESTBAG.Master_Data.subMasterFrm.Product
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.panelMainAddProduct = new System.Windows.Forms.Panel();
            this.cboBatteryCapacityAP = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboBatteryTypeAP = new System.Windows.Forms.ComboBox();
            this.cboModelAP = new System.Windows.Forms.ComboBox();
            this.cboSeriesAP = new System.Windows.Forms.ComboBox();
            this.cboProductGroupAP = new System.Windows.Forms.ComboBox();
            this.labelHeaderAddProductForm = new System.Windows.Forms.Label();
            this.btnAddAP = new FontAwesome.Sharp.IconButton();
            this.btnCancelAP = new FontAwesome.Sharp.IconButton();
            this.labelBatteryCapacityAP = new System.Windows.Forms.Label();
            this.labelBatteryTypeAP = new System.Windows.Forms.Label();
            this.labelModelAP = new System.Windows.Forms.Label();
            this.labelSeriesAP = new System.Windows.Forms.Label();
            this.labelProductGroupAP = new System.Windows.Forms.Label();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pRODUCTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.panelMainAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainAddProduct
            // 
            this.panelMainAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.panelMainAddProduct.Controls.Add(this.cboBatteryCapacityAP);
            this.panelMainAddProduct.Controls.Add(this.cboBatteryTypeAP);
            this.panelMainAddProduct.Controls.Add(this.cboModelAP);
            this.panelMainAddProduct.Controls.Add(this.cboSeriesAP);
            this.panelMainAddProduct.Controls.Add(this.cboProductGroupAP);
            this.panelMainAddProduct.Controls.Add(this.labelHeaderAddProductForm);
            this.panelMainAddProduct.Controls.Add(this.btnAddAP);
            this.panelMainAddProduct.Controls.Add(this.btnCancelAP);
            this.panelMainAddProduct.Controls.Add(this.labelBatteryCapacityAP);
            this.panelMainAddProduct.Controls.Add(this.labelBatteryTypeAP);
            this.panelMainAddProduct.Controls.Add(this.labelModelAP);
            this.panelMainAddProduct.Controls.Add(this.labelSeriesAP);
            this.panelMainAddProduct.Controls.Add(this.labelProductGroupAP);
            this.panelMainAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainAddProduct.Location = new System.Drawing.Point(0, 0);
            this.panelMainAddProduct.Name = "panelMainAddProduct";
            this.panelMainAddProduct.Size = new System.Drawing.Size(623, 475);
            this.panelMainAddProduct.TabIndex = 0;
            // 
            // cboBatteryCapacityAP
            // 
            this.cboBatteryCapacityAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "BATTERY_CAPACITY", true));
            this.cboBatteryCapacityAP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productBindingSource, "BATTERY_CAPACITY", true));
            this.cboBatteryCapacityAP.FormattingEnabled = true;
            this.cboBatteryCapacityAP.Location = new System.Drawing.Point(188, 310);
            this.cboBatteryCapacityAP.Name = "cboBatteryCapacityAP";
            this.cboBatteryCapacityAP.Size = new System.Drawing.Size(375, 24);
            this.cboBatteryCapacityAP.TabIndex = 5;
            this.cboBatteryCapacityAP.SelectedIndexChanged += new System.EventHandler(this.cboBatteryCapacityAP_SelectedIndexChanged);
            // 
            // cboBatteryTypeAP
            // 
            this.cboBatteryTypeAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "BATTERY_TYPE", true));
            this.cboBatteryTypeAP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productBindingSource, "BATTERY_TYPE", true));
            this.cboBatteryTypeAP.FormattingEnabled = true;
            this.cboBatteryTypeAP.Location = new System.Drawing.Point(188, 256);
            this.cboBatteryTypeAP.Name = "cboBatteryTypeAP";
            this.cboBatteryTypeAP.Size = new System.Drawing.Size(375, 24);
            this.cboBatteryTypeAP.TabIndex = 4;
            this.cboBatteryTypeAP.SelectedIndexChanged += new System.EventHandler(this.cboBatteryTypeAP_SelectedIndexChanged);
            // 
            // cboModelAP
            // 
            this.cboModelAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MODEL", true));
            this.cboModelAP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productBindingSource, "MODEL", true));
            this.cboModelAP.FormattingEnabled = true;
            this.cboModelAP.Location = new System.Drawing.Point(188, 202);
            this.cboModelAP.Name = "cboModelAP";
            this.cboModelAP.Size = new System.Drawing.Size(375, 24);
            this.cboModelAP.TabIndex = 3;
            this.cboModelAP.SelectedIndexChanged += new System.EventHandler(this.cboModelAP_SelectedIndexChanged);
            // 
            // cboSeriesAP
            // 
            this.cboSeriesAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SERIES", true));
            this.cboSeriesAP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productBindingSource, "SERIES", true));
            this.cboSeriesAP.FormattingEnabled = true;
            this.cboSeriesAP.Location = new System.Drawing.Point(188, 144);
            this.cboSeriesAP.Name = "cboSeriesAP";
            this.cboSeriesAP.Size = new System.Drawing.Size(375, 24);
            this.cboSeriesAP.TabIndex = 2;
            this.cboSeriesAP.SelectedIndexChanged += new System.EventHandler(this.cboSeriesAP_SelectedIndexChanged);
            // 
            // cboProductGroupAP
            // 
            this.cboProductGroupAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "PRODUCT_GRUOP", true));
            this.cboProductGroupAP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productBindingSource, "PRODUCT_GRUOP", true));
            this.cboProductGroupAP.FormattingEnabled = true;
            this.cboProductGroupAP.Location = new System.Drawing.Point(188, 88);
            this.cboProductGroupAP.Name = "cboProductGroupAP";
            this.cboProductGroupAP.Size = new System.Drawing.Size(375, 24);
            this.cboProductGroupAP.TabIndex = 1;
            this.cboProductGroupAP.SelectedIndexChanged += new System.EventHandler(this.cboProductGroupAP_SelectedIndexChanged);
            // 
            // labelHeaderAddProductForm
            // 
            this.labelHeaderAddProductForm.AutoSize = true;
            this.labelHeaderAddProductForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelHeaderAddProductForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeaderAddProductForm.Location = new System.Drawing.Point(222, 26);
            this.labelHeaderAddProductForm.Name = "labelHeaderAddProductForm";
            this.labelHeaderAddProductForm.Size = new System.Drawing.Size(215, 39);
            this.labelHeaderAddProductForm.TabIndex = 12;
            this.labelHeaderAddProductForm.Text = "Add Product";
            // 
            // btnAddAP
            // 
            this.btnAddAP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddAP.IconColor = System.Drawing.Color.Black;
            this.btnAddAP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAP.Location = new System.Drawing.Point(443, 373);
            this.btnAddAP.Name = "btnAddAP";
            this.btnAddAP.Size = new System.Drawing.Size(120, 47);
            this.btnAddAP.TabIndex = 11;
            this.btnAddAP.Text = "Add";
            this.btnAddAP.UseVisualStyleBackColor = true;
            this.btnAddAP.Click += new System.EventHandler(this.btnAddAP_Click);
            // 
            // btnCancelAP
            // 
            this.btnCancelAP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelAP.IconColor = System.Drawing.Color.Black;
            this.btnCancelAP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelAP.Location = new System.Drawing.Point(317, 373);
            this.btnCancelAP.Name = "btnCancelAP";
            this.btnCancelAP.Size = new System.Drawing.Size(120, 47);
            this.btnCancelAP.TabIndex = 10;
            this.btnCancelAP.Text = "Cancel";
            this.btnCancelAP.UseVisualStyleBackColor = true;
            this.btnCancelAP.Click += new System.EventHandler(this.btnCancelAP_Click);
            // 
            // labelBatteryCapacityAP
            // 
            this.labelBatteryCapacityAP.AutoSize = true;
            this.labelBatteryCapacityAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBatteryCapacityAP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBatteryCapacityAP.Location = new System.Drawing.Point(30, 310);
            this.labelBatteryCapacityAP.Name = "labelBatteryCapacityAP";
            this.labelBatteryCapacityAP.Size = new System.Drawing.Size(133, 20);
            this.labelBatteryCapacityAP.TabIndex = 9;
            this.labelBatteryCapacityAP.Text = "Battery Capacity";
            // 
            // labelBatteryTypeAP
            // 
            this.labelBatteryTypeAP.AutoSize = true;
            this.labelBatteryTypeAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBatteryTypeAP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBatteryTypeAP.Location = new System.Drawing.Point(59, 256);
            this.labelBatteryTypeAP.Name = "labelBatteryTypeAP";
            this.labelBatteryTypeAP.Size = new System.Drawing.Size(104, 20);
            this.labelBatteryTypeAP.TabIndex = 8;
            this.labelBatteryTypeAP.Text = "Battery Type";
            // 
            // labelModelAP
            // 
            this.labelModelAP.AutoSize = true;
            this.labelModelAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelModelAP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelModelAP.Location = new System.Drawing.Point(106, 202);
            this.labelModelAP.Name = "labelModelAP";
            this.labelModelAP.Size = new System.Drawing.Size(54, 20);
            this.labelModelAP.TabIndex = 7;
            this.labelModelAP.Text = "Model";
            // 
            // labelSeriesAP
            // 
            this.labelSeriesAP.AutoSize = true;
            this.labelSeriesAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSeriesAP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSeriesAP.Location = new System.Drawing.Point(106, 144);
            this.labelSeriesAP.Name = "labelSeriesAP";
            this.labelSeriesAP.Size = new System.Drawing.Size(57, 20);
            this.labelSeriesAP.TabIndex = 6;
            this.labelSeriesAP.Text = "Series";
            // 
            // labelProductGroupAP
            // 
            this.labelProductGroupAP.AutoSize = true;
            this.labelProductGroupAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelProductGroupAP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductGroupAP.Location = new System.Drawing.Point(45, 88);
            this.labelProductGroupAP.Name = "labelProductGroupAP";
            this.labelProductGroupAP.Size = new System.Drawing.Size(118, 20);
            this.labelProductGroupAP.TabIndex = 5;
            this.labelProductGroupAP.Text = "Product Group";
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pRODUCTBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 448);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(623, 27);
            this.productBindingNavigator.TabIndex = 1;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pRODUCTBindingNavigatorSaveItem
            // 
            this.pRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCTBindingNavigatorSaveItem.Enabled = false;
            this.pRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCTBindingNavigatorSaveItem.Image")));
            this.pRODUCTBindingNavigatorSaveItem.Name = "pRODUCTBindingNavigatorSaveItem";
            this.pRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pRODUCTBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 475);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.panelMainAddProduct);
            this.Name = "frmAddProduct";
            this.Text = "frmAddProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProduct_FormClosing);
            this.panelMainAddProduct.ResumeLayout(false);
            this.panelMainAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainAddProduct;
        private FontAwesome.Sharp.IconButton btnAddAP;
        private FontAwesome.Sharp.IconButton btnCancelAP;
        private System.Windows.Forms.Label labelBatteryCapacityAP;
        private System.Windows.Forms.Label labelBatteryTypeAP;
        private System.Windows.Forms.Label labelModelAP;
        private System.Windows.Forms.Label labelSeriesAP;
        private System.Windows.Forms.Label labelProductGroupAP;
        private System.Windows.Forms.Label labelHeaderAddProductForm;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pRODUCTBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cboSeriesAP;
        private System.Windows.Forms.ComboBox cboProductGroupAP;
        private System.Windows.Forms.ComboBox cboBatteryCapacityAP;
        private System.Windows.Forms.ComboBox cboBatteryTypeAP;
        private System.Windows.Forms.ComboBox cboModelAP;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
    }
}