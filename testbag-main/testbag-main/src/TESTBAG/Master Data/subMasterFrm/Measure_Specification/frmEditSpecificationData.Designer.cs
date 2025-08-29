namespace TESTBAG.Master_Data.subMasterFrm.Measure_Specification
{
    partial class frmEditSpecificationData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSpecificationData));
            this.labelMeasureNameASpecification = new System.Windows.Forms.Label();
            this.txtMeasureNameESpecifications = new System.Windows.Forms.TextBox();
            this.master_SPECIFICATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMinValueASpecifications = new System.Windows.Forms.Label();
            this.txtMinValueESpecifications = new System.Windows.Forms.TextBox();
            this.labelHeaderEditSpecificationtForm = new System.Windows.Forms.Label();
            this.btnSaveESpecify = new FontAwesome.Sharp.IconButton();
            this.btnCancelESpecify = new FontAwesome.Sharp.IconButton();
            this.labelMaxValueASpecifications = new System.Windows.Forms.Label();
            this.labelPreferredValueASpecifications = new System.Windows.Forms.Label();
            this.labelStageText = new System.Windows.Forms.Label();
            this.labelProductIDASpecifications = new System.Windows.Forms.Label();
            this.txtMaxValueESpecifications = new System.Windows.Forms.TextBox();
            this.txtPreferredValueESpecifications = new System.Windows.Forms.TextBox();
            this.txtStageESpecifications = new System.Windows.Forms.TextBox();
            this.txtProductIDESpecifications = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingNavigator)).BeginInit();
            this.master_SPECIFICATIONSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMeasureNameASpecification
            // 
            this.labelMeasureNameASpecification.AutoSize = true;
            this.labelMeasureNameASpecification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMeasureNameASpecification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMeasureNameASpecification.Location = new System.Drawing.Point(49, 142);
            this.labelMeasureNameASpecification.Name = "labelMeasureNameASpecification";
            this.labelMeasureNameASpecification.Size = new System.Drawing.Size(123, 20);
            this.labelMeasureNameASpecification.TabIndex = 61;
            this.labelMeasureNameASpecification.Text = "Measure Name";
            // 
            // txtMeasureNameESpecifications
            // 
            this.txtMeasureNameESpecifications.Location = new System.Drawing.Point(193, 142);
            this.txtMeasureNameESpecifications.Name = "txtMeasureNameESpecifications";
            this.txtMeasureNameESpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtMeasureNameESpecifications.TabIndex = 60;
            // 
            // master_SPECIFICATIONSBindingSource
            // 
            this.master_SPECIFICATIONSBindingSource.DataSource = typeof(TESTBAG.Master_Data.ProductDB.MASTER_SPECIFICATIONS);
            // 
            // labelMinValueASpecifications
            // 
            this.labelMinValueASpecifications.AutoSize = true;
            this.labelMinValueASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMinValueASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMinValueASpecifications.Location = new System.Drawing.Point(85, 355);
            this.labelMinValueASpecifications.Name = "labelMinValueASpecifications";
            this.labelMinValueASpecifications.Size = new System.Drawing.Size(83, 20);
            this.labelMinValueASpecifications.TabIndex = 59;
            this.labelMinValueASpecifications.Text = "Min Value";
            // 
            // txtMinValueESpecifications
            // 
            this.txtMinValueESpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "MIN_VALUE", true));
            this.txtMinValueESpecifications.Location = new System.Drawing.Point(193, 353);
            this.txtMinValueESpecifications.Name = "txtMinValueESpecifications";
            this.txtMinValueESpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtMinValueESpecifications.TabIndex = 58;
            // 
            // labelHeaderEditSpecificationtForm
            // 
            this.labelHeaderEditSpecificationtForm.AutoSize = true;
            this.labelHeaderEditSpecificationtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelHeaderEditSpecificationtForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeaderEditSpecificationtForm.Location = new System.Drawing.Point(170, 28);
            this.labelHeaderEditSpecificationtForm.Name = "labelHeaderEditSpecificationtForm";
            this.labelHeaderEditSpecificationtForm.Size = new System.Drawing.Size(315, 39);
            this.labelHeaderEditSpecificationtForm.TabIndex = 57;
            this.labelHeaderEditSpecificationtForm.Text = "Edit Specifications";
            // 
            // btnSaveESpecify
            // 
            this.btnSaveESpecify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveESpecify.IconColor = System.Drawing.Color.Black;
            this.btnSaveESpecify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveESpecify.Location = new System.Drawing.Point(448, 480);
            this.btnSaveESpecify.Name = "btnSaveESpecify";
            this.btnSaveESpecify.Size = new System.Drawing.Size(120, 47);
            this.btnSaveESpecify.TabIndex = 56;
            this.btnSaveESpecify.Text = "Save";
            this.btnSaveESpecify.UseVisualStyleBackColor = true;
            this.btnSaveESpecify.Click += new System.EventHandler(this.btnSaveESpecify_Click);
            // 
            // btnCancelESpecify
            // 
            this.btnCancelESpecify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelESpecify.IconColor = System.Drawing.Color.Black;
            this.btnCancelESpecify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelESpecify.Location = new System.Drawing.Point(322, 480);
            this.btnCancelESpecify.Name = "btnCancelESpecify";
            this.btnCancelESpecify.Size = new System.Drawing.Size(120, 47);
            this.btnCancelESpecify.TabIndex = 55;
            this.btnCancelESpecify.Text = "Cancel";
            this.btnCancelESpecify.UseVisualStyleBackColor = true;
            this.btnCancelESpecify.Click += new System.EventHandler(this.btnCancelESpecify_Click);
            // 
            // labelMaxValueASpecifications
            // 
            this.labelMaxValueASpecifications.AutoSize = true;
            this.labelMaxValueASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMaxValueASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMaxValueASpecifications.Location = new System.Drawing.Point(81, 304);
            this.labelMaxValueASpecifications.Name = "labelMaxValueASpecifications";
            this.labelMaxValueASpecifications.Size = new System.Drawing.Size(87, 20);
            this.labelMaxValueASpecifications.TabIndex = 54;
            this.labelMaxValueASpecifications.Text = "Max Value";
            // 
            // labelPreferredValueASpecifications
            // 
            this.labelPreferredValueASpecifications.AutoSize = true;
            this.labelPreferredValueASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPreferredValueASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPreferredValueASpecifications.Location = new System.Drawing.Point(44, 250);
            this.labelPreferredValueASpecifications.Name = "labelPreferredValueASpecifications";
            this.labelPreferredValueASpecifications.Size = new System.Drawing.Size(126, 20);
            this.labelPreferredValueASpecifications.TabIndex = 53;
            this.labelPreferredValueASpecifications.Text = "Preferred Value";
            // 
            // labelStageText
            // 
            this.labelStageText.AutoSize = true;
            this.labelStageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStageText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStageText.Location = new System.Drawing.Point(116, 196);
            this.labelStageText.Name = "labelStageText";
            this.labelStageText.Size = new System.Drawing.Size(52, 20);
            this.labelStageText.TabIndex = 52;
            this.labelStageText.Text = "Stage";
            // 
            // labelProductIDASpecifications
            // 
            this.labelProductIDASpecifications.AutoSize = true;
            this.labelProductIDASpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelProductIDASpecifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductIDASpecifications.Location = new System.Drawing.Point(81, 92);
            this.labelProductIDASpecifications.Name = "labelProductIDASpecifications";
            this.labelProductIDASpecifications.Size = new System.Drawing.Size(89, 20);
            this.labelProductIDASpecifications.TabIndex = 50;
            this.labelProductIDASpecifications.Text = "Product ID";
            // 
            // txtMaxValueESpecifications
            // 
            this.txtMaxValueESpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "MAX_VALUE", true));
            this.txtMaxValueESpecifications.Location = new System.Drawing.Point(193, 302);
            this.txtMaxValueESpecifications.Name = "txtMaxValueESpecifications";
            this.txtMaxValueESpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtMaxValueESpecifications.TabIndex = 49;
            // 
            // txtPreferredValueESpecifications
            // 
            this.txtPreferredValueESpecifications.Location = new System.Drawing.Point(193, 248);
            this.txtPreferredValueESpecifications.Name = "txtPreferredValueESpecifications";
            this.txtPreferredValueESpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtPreferredValueESpecifications.TabIndex = 48;
            // 
            // txtStageESpecifications
            // 
            this.txtStageESpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "STAGE_TEXT", true));
            this.txtStageESpecifications.Location = new System.Drawing.Point(193, 194);
            this.txtStageESpecifications.Name = "txtStageESpecifications";
            this.txtStageESpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtStageESpecifications.TabIndex = 47;
            // 
            // txtProductIDESpecifications
            // 
            this.txtProductIDESpecifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_SPECIFICATIONSBindingSource, "PRODUCT_ID", true));
            this.txtProductIDESpecifications.Location = new System.Drawing.Point(193, 90);
            this.txtProductIDESpecifications.Name = "txtProductIDESpecifications";
            this.txtProductIDESpecifications.Size = new System.Drawing.Size(375, 22);
            this.txtProductIDESpecifications.TabIndex = 45;
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
            this.master_SPECIFICATIONSBindingNavigator.TabIndex = 62;
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
            // frmEditSpecificationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(623, 591);
            this.Controls.Add(this.master_SPECIFICATIONSBindingNavigator);
            this.Controls.Add(this.labelMeasureNameASpecification);
            this.Controls.Add(this.txtMeasureNameESpecifications);
            this.Controls.Add(this.labelMinValueASpecifications);
            this.Controls.Add(this.txtMinValueESpecifications);
            this.Controls.Add(this.labelHeaderEditSpecificationtForm);
            this.Controls.Add(this.btnSaveESpecify);
            this.Controls.Add(this.btnCancelESpecify);
            this.Controls.Add(this.labelMaxValueASpecifications);
            this.Controls.Add(this.labelPreferredValueASpecifications);
            this.Controls.Add(this.labelStageText);
            this.Controls.Add(this.labelProductIDASpecifications);
            this.Controls.Add(this.txtMaxValueESpecifications);
            this.Controls.Add(this.txtPreferredValueESpecifications);
            this.Controls.Add(this.txtStageESpecifications);
            this.Controls.Add(this.txtProductIDESpecifications);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmEditSpecificationData";
            this.Text = "frmEditSpecificationData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditSpecificationData_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_SPECIFICATIONSBindingNavigator)).EndInit();
            this.master_SPECIFICATIONSBindingNavigator.ResumeLayout(false);
            this.master_SPECIFICATIONSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMeasureNameASpecification;
        private System.Windows.Forms.Label labelMinValueASpecifications;
        private System.Windows.Forms.Label labelHeaderEditSpecificationtForm;
        private FontAwesome.Sharp.IconButton btnSaveESpecify;
        private FontAwesome.Sharp.IconButton btnCancelESpecify;
        private System.Windows.Forms.Label labelMaxValueASpecifications;
        private System.Windows.Forms.Label labelPreferredValueASpecifications;
        private System.Windows.Forms.Label labelStageText;
        private System.Windows.Forms.Label labelProductIDASpecifications;
        private System.Windows.Forms.TextBox txtProductIDESpecifications;
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
        public System.Windows.Forms.TextBox txtMeasureNameESpecifications;
        public System.Windows.Forms.TextBox txtMinValueESpecifications;
        public System.Windows.Forms.TextBox txtMaxValueESpecifications;
        public System.Windows.Forms.TextBox txtPreferredValueESpecifications;
        public System.Windows.Forms.TextBox txtStageESpecifications;
    }
}