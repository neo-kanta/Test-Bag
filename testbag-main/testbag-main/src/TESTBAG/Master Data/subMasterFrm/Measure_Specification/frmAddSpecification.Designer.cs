namespace TESTBAG.Master_Data.subMasterFrm.Measure_Specification
{
    partial class frmAddSpecification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSpecification));
            this.panelAddSpecifications = new System.Windows.Forms.Panel();
            this.labelMeasureNameASpecification = new System.Windows.Forms.Label();
            this.txtMeasureNameASpecifications = new System.Windows.Forms.TextBox();
            this.master_SPECIFICATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMinValueASpecifications = new System.Windows.Forms.Label();
            this.txtMinValueASpecifications = new System.Windows.Forms.TextBox();
            this.labelHeaderAddSpecificationtForm = new System.Windows.Forms.Label();
            this.btnAddASpecify = new FontAwesome.Sharp.IconButton();
            this.btnCancelASpecify = new FontAwesome.Sharp.IconButton();
            this.labelMaxValueASpecifications = new System.Windows.Forms.Label();
            this.labelPreferredValueASpecifications = new System.Windows.Forms.Label();
            this.labelStageText = new System.Windows.Forms.Label();
            this.labelProductIDASpecifications = new System.Windows.Forms.Label();
            this.txtMaxValueASpecifications = new System.Windows.Forms.TextBox();
            this.txtPreferredValueValueASpecifications = new System.Windows.Forms.TextBox();
            this.txtStageASpecifications = new System.Windows.Forms.TextBox();
            this.txtProductIDASpecifications = new System.Windows.Forms.TextBox();
            this.master_SPECIFICATIONSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panelAddSpecifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingNavigator)).BeginInit();
            this.master_SPECIFICATIONSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddSpecifications
            // 
            this.panelAddSpecifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.panelAddSpecifications.Controls.Add(this.labelMeasureNameASpecification);
            this.panelAddSpecifications.Controls.Add(this.txtMeasureNameASpecifications);
            this.panelAddSpecifications.Controls.Add(this.labelMinValueASpecifications);
            this.panelAddSpecifications.Controls.Add(this.txtMinValueASpecifications);
            this.panelAddSpecifications.Controls.Add(this.labelHeaderAddSpecificationtForm);
            this.panelAddSpecifications.Controls.Add(this.btnAddASpecify);
            this.panelAddSpecifications.Controls.Add(this.btnCancelASpecify);
            this.panelAddSpecifications.Controls.Add(this.labelMaxValueASpecifications);
            this.panelAddSpecifications.Controls.Add(this.labelPreferredValueASpecifications);
            this.panelAddSpecifications.Controls.Add(this.labelStageText);
            this.panelAddSpecifications.Controls.Add(this.labelProductIDASpecifications);
            this.panelAddSpecifications.Controls.Add(this.txtMaxValueASpecifications);
            this.panelAddSpecifications.Controls.Add(this.txtPreferredValueValueASpecifications);
            this.panelAddSpecifications.Controls.Add(this.txtStageASpecifications);
            this.panelAddSpecifications.Controls.Add(this.txtProductIDASpecifications);
            this.panelAddSpecifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddSpecifications.Location = new System.Drawing.Point(0, 0);
            this.panelAddSpecifications.Name = "panelAddSpecifications";
            this.panelAddSpecifications.Size = new System.Drawing.Size(623, 591);
            this.panelAddSpecifications.TabIndex = 0;
            // 
            // labelMeasureNameASpecification
            // 
            this.labelMeasureNameASpecification.AutoSize = true;
            this.labelMeasureNameASpecification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMeasureNameASpecification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMeasureNameASpecification.Location = new System.Drawing.Point(44, 140);
            this.labelMeasureNameASpecification.Name = "labelMeasureNameASpecification";
            this.labelMeasureNameASpecification.Size = new System.Drawing.Size(123, 20);
            this.labelMeasureNameASpecification.TabIndex = 44;
            this.labelMeasureNameASpecification.Text = "Measure Name";
            // 
            // txtMeasureNameASpecifications
            // 
            this.txtMeasureNameASpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "MEASUREMENT_NAME", true));
            this.txtMeasureNameASpecifications.Location = new System.Drawing.Point(188, 140);
            this.txtMeasureNameASpecifications.Name = "txtMeasureNameASpecifications";
            this.txtMeasureNameASpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtMeasureNameASpecifications.TabIndex = 43;
            // 
            // labelMinValueASpecifications
            // 
            this.labelMinValueASpecifications.AutoSize = true;
            this.labelMinValueASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMinValueASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMinValueASpecifications.Location = new System.Drawing.Point(80, 349);
            this.labelMinValueASpecifications.Name = "labelMinValueASpecifications";
            this.labelMinValueASpecifications.Size = new System.Drawing.Size(83, 20);
            this.labelMinValueASpecifications.TabIndex = 42;
            this.labelMinValueASpecifications.Text = "Min Value";
            // 
            // txtMinValueASpecifications
            // 
            this.txtMinValueASpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "MIN_VALUE", true));
            this.txtMinValueASpecifications.Location = new System.Drawing.Point(188, 347);
            this.txtMinValueASpecifications.Name = "txtMinValueASpecifications";
            this.txtMinValueASpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtMinValueASpecifications.TabIndex = 41;
            // 
            // labelHeaderAddSpecificationtForm
            // 
            this.labelHeaderAddSpecificationtForm.AutoSize = true;
            this.labelHeaderAddSpecificationtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelHeaderAddSpecificationtForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeaderAddSpecificationtForm.Location = new System.Drawing.Point(165, 26);
            this.labelHeaderAddSpecificationtForm.Name = "labelHeaderAddSpecificationtForm";
            this.labelHeaderAddSpecificationtForm.Size = new System.Drawing.Size(316, 39);
            this.labelHeaderAddSpecificationtForm.TabIndex = 25;
            this.labelHeaderAddSpecificationtForm.Text = "Add Specifications";
            // 
            // btnAddASpecify
            // 
            this.btnAddASpecify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddASpecify.IconColor = System.Drawing.Color.Black;
            this.btnAddASpecify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddASpecify.Location = new System.Drawing.Point(443, 475);
            this.btnAddASpecify.Name = "btnAddASpecify";
            this.btnAddASpecify.Size = new System.Drawing.Size(120, 47);
            this.btnAddASpecify.TabIndex = 24;
            this.btnAddASpecify.Text = "Add";
            this.btnAddASpecify.UseVisualStyleBackColor = true;
            this.btnAddASpecify.Click += new System.EventHandler(this.btnAddASpecify_Click);
            // 
            // btnCancelASpecify
            // 
            this.btnCancelASpecify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelASpecify.IconColor = System.Drawing.Color.Black;
            this.btnCancelASpecify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelASpecify.Location = new System.Drawing.Point(317, 475);
            this.btnCancelASpecify.Name = "btnCancelASpecify";
            this.btnCancelASpecify.Size = new System.Drawing.Size(120, 47);
            this.btnCancelASpecify.TabIndex = 23;
            this.btnCancelASpecify.Text = "Cancel";
            this.btnCancelASpecify.UseVisualStyleBackColor = true;
            this.btnCancelASpecify.Click += new System.EventHandler(this.btnCancelASpecify_Click);
            // 
            // labelMaxValueASpecifications
            // 
            this.labelMaxValueASpecifications.AutoSize = true;
            this.labelMaxValueASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMaxValueASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMaxValueASpecifications.Location = new System.Drawing.Point(76, 298);
            this.labelMaxValueASpecifications.Name = "labelMaxValueASpecifications";
            this.labelMaxValueASpecifications.Size = new System.Drawing.Size(87, 20);
            this.labelMaxValueASpecifications.TabIndex = 22;
            this.labelMaxValueASpecifications.Text = "Max Value";
            // 
            // labelPreferredValueASpecifications
            // 
            this.labelPreferredValueASpecifications.AutoSize = true;
            this.labelPreferredValueASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPreferredValueASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPreferredValueASpecifications.Location = new System.Drawing.Point(39, 244);
            this.labelPreferredValueASpecifications.Name = "labelPreferredValueASpecifications";
            this.labelPreferredValueASpecifications.Size = new System.Drawing.Size(126, 20);
            this.labelPreferredValueASpecifications.TabIndex = 21;
            this.labelPreferredValueASpecifications.Text = "Preferred Value";
            // 
            // labelStageText
            // 
            this.labelStageText.AutoSize = true;
            this.labelStageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStageText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStageText.Location = new System.Drawing.Point(111, 190);
            this.labelStageText.Name = "labelStageText";
            this.labelStageText.Size = new System.Drawing.Size(52, 20);
            this.labelStageText.TabIndex = 20;
            this.labelStageText.Text = "Stage";
            // 
            // labelProductIDASpecifications
            // 
            this.labelProductIDASpecifications.AutoSize = true;
            this.labelProductIDASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelProductIDASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductIDASpecifications.Location = new System.Drawing.Point(76, 90);
            this.labelProductIDASpecifications.Name = "labelProductIDASpecifications";
            this.labelProductIDASpecifications.Size = new System.Drawing.Size(89, 20);
            this.labelProductIDASpecifications.TabIndex = 18;
            this.labelProductIDASpecifications.Text = "Product ID";
            // 
            // txtMaxValueASpecifications
            // 
            this.txtMaxValueASpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "MAX_VALUE", true));
            this.txtMaxValueASpecifications.Location = new System.Drawing.Point(188, 296);
            this.txtMaxValueASpecifications.Name = "txtMaxValueASpecifications";
            this.txtMaxValueASpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtMaxValueASpecifications.TabIndex = 17;
            // 
            // txtPreferredValueValueASpecifications
            // 
            this.txtPreferredValueValueASpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "PREFERRED_VALUE", true));
            this.txtPreferredValueValueASpecifications.Location = new System.Drawing.Point(188, 242);
            this.txtPreferredValueValueASpecifications.Name = "txtPreferredValueValueASpecifications";
            this.txtPreferredValueValueASpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtPreferredValueValueASpecifications.TabIndex = 16;
            // 
            // txtStageASpecifications
            // 
            this.txtStageASpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "STAGE_TEXT", true));
            this.txtStageASpecifications.Location = new System.Drawing.Point(188, 188);
            this.txtStageASpecifications.Name = "txtStageASpecifications";
            this.txtStageASpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtStageASpecifications.TabIndex = 15;
            // 
            // txtProductIDASpecifications
            // 
            this.txtProductIDASpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "PRODUCT_ID", true));
            this.txtProductIDASpecifications.Location = new System.Drawing.Point(188, 88);
            this.txtProductIDASpecifications.Name = "txtProductIDASpecifications";
            this.txtProductIDASpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtProductIDASpecifications.TabIndex = 13;
            // 
            // master_SPECIFICATIONSBindingNavigator
            // 
            this.master_SPECIFICATIONSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.master_SPECIFICATIONSBindingNavigator.BindingSource = this.master_SPECIFICATIONSBindingSource;
            this.master_SPECIFICATIONSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.master_SPECIFICATIONSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.master_SPECIFICATIONSBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.master_SPECIFICATIONSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.master_SPECIFICATIONSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem});
            this.master_SPECIFICATIONSBindingNavigator.Location = new System.Drawing.Point(0, 564);
            this.master_SPECIFICATIONSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.master_SPECIFICATIONSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.master_SPECIFICATIONSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.master_SPECIFICATIONSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.master_SPECIFICATIONSBindingNavigator.Name = "master_SPECIFICATIONSBindingNavigator";
            this.master_SPECIFICATIONSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.master_SPECIFICATIONSBindingNavigator.Size = new System.Drawing.Size(623, 27);
            this.master_SPECIFICATIONSBindingNavigator.TabIndex = 1;
            this.master_SPECIFICATIONSBindingNavigator.Text = "bindingNavigator1";
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
            // mASTER_SPECIFICATIONSBindingNavigatorSaveItem
            // 
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem.Enabled = false;
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mASTER_SPECIFICATIONSBindingNavigatorSaveItem.Image")));
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem.Name = "mASTER_SPECIFICATIONSBindingNavigatorSaveItem";
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.mASTER_SPECIFICATIONSBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // frmAddSpecification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(623, 591);
            this.Controls.Add(this.master_SPECIFICATIONSBindingNavigator);
            this.Controls.Add(this.panelAddSpecifications);
            this.Name = "frmAddSpecification";
            this.Text = "frmAddSpecification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddSpecification_FormClosing);
            this.panelAddSpecifications.ResumeLayout(false);
            this.panelAddSpecifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingNavigator)).EndInit();
            this.master_SPECIFICATIONSBindingNavigator.ResumeLayout(false);
            this.master_SPECIFICATIONSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAddSpecifications;
        private System.Windows.Forms.Label labelHeaderAddSpecificationtForm;
        private FontAwesome.Sharp.IconButton btnAddASpecify;
        private FontAwesome.Sharp.IconButton btnCancelASpecify;
        private System.Windows.Forms.Label labelMaxValueASpecifications;
        private System.Windows.Forms.Label labelPreferredValueASpecifications;
        private System.Windows.Forms.Label labelStageText;
        private System.Windows.Forms.Label labelProductIDASpecifications;
        private System.Windows.Forms.TextBox txtMaxValueASpecifications;
        private System.Windows.Forms.TextBox txtPreferredValueValueASpecifications;
        private System.Windows.Forms.TextBox txtStageASpecifications;
        private System.Windows.Forms.TextBox txtProductIDASpecifications;
        private System.Windows.Forms.BindingSource master_SPECIFICATIONSBindingSource;
        private System.Windows.Forms.BindingNavigator master_SPECIFICATIONSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mASTER_SPECIFICATIONSBindingNavigatorSaveItem;
        private System.Windows.Forms.Label labelMeasureNameASpecification;
        private System.Windows.Forms.TextBox txtMeasureNameASpecifications;
        private System.Windows.Forms.Label labelMinValueASpecifications;
        private System.Windows.Forms.TextBox txtMinValueASpecifications;
    }
}