namespace TESTBAG.Data_Management
{
    partial class mdiEditProduct
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
            this.pnMainEditSpec = new System.Windows.Forms.Panel();
            this.chbIsDeacticated = new System.Windows.Forms.CheckBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSaveEdit = new FontAwesome.Sharp.IconButton();
            this.txtProductGroup = new System.Windows.Forms.TextBox();
            this.txtBatteryCapacity = new System.Windows.Forms.TextBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.txtBatteryType = new System.Windows.Forms.TextBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.lblBatteryType = new System.Windows.Forms.Label();
            this.lblBatteryCapacity = new System.Windows.Forms.Label();
            this.pnMainEditSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMainEditSpec
            // 
            this.pnMainEditSpec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMainEditSpec.Controls.Add(this.chbIsDeacticated);
            this.pnMainEditSpec.Controls.Add(this.txtCreateDate);
            this.pnMainEditSpec.Controls.Add(this.lblCreateDate);
            this.pnMainEditSpec.Controls.Add(this.btnCancel);
            this.pnMainEditSpec.Controls.Add(this.btnSaveEdit);
            this.pnMainEditSpec.Controls.Add(this.txtProductGroup);
            this.pnMainEditSpec.Controls.Add(this.txtBatteryCapacity);
            this.pnMainEditSpec.Controls.Add(this.lblProductGroup);
            this.pnMainEditSpec.Controls.Add(this.txtBatteryType);
            this.pnMainEditSpec.Controls.Add(this.lblStage);
            this.pnMainEditSpec.Controls.Add(this.txtModel);
            this.pnMainEditSpec.Controls.Add(this.lblModel);
            this.pnMainEditSpec.Controls.Add(this.txtSeries);
            this.pnMainEditSpec.Controls.Add(this.lblBatteryType);
            this.pnMainEditSpec.Controls.Add(this.lblBatteryCapacity);
            this.pnMainEditSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainEditSpec.Location = new System.Drawing.Point(0, 0);
            this.pnMainEditSpec.Name = "pnMainEditSpec";
            this.pnMainEditSpec.Size = new System.Drawing.Size(571, 490);
            this.pnMainEditSpec.TabIndex = 0;
            // 
            // chbIsDeacticated
            // 
            this.chbIsDeacticated.AutoSize = true;
            this.chbIsDeacticated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbIsDeacticated.Location = new System.Drawing.Point(348, 330);
            this.chbIsDeacticated.Name = "chbIsDeacticated";
            this.chbIsDeacticated.Size = new System.Drawing.Size(139, 24);
            this.chbIsDeacticated.TabIndex = 38;
            this.chbIsDeacticated.Text = "Is Deacticated";
            this.chbIsDeacticated.UseVisualStyleBackColor = true;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(239, 280);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(248, 22);
            this.txtCreateDate.TabIndex = 37;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCreateDate.Location = new System.Drawing.Point(98, 282);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(100, 20);
            this.lblCreateDate.TabIndex = 35;
            this.lblCreateDate.Text = "Create Date";
            // 
            // btnCancel
            // 
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(365, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 69);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSaveEdit.IconColor = System.Drawing.Color.Black;
            this.btnSaveEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveEdit.Location = new System.Drawing.Point(207, 385);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(122, 69);
            this.btnSaveEdit.TabIndex = 32;
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // txtProductGroup
            // 
            this.txtProductGroup.Location = new System.Drawing.Point(239, 40);
            this.txtProductGroup.Name = "txtProductGroup";
            this.txtProductGroup.Size = new System.Drawing.Size(248, 22);
            this.txtProductGroup.TabIndex = 27;
            // 
            // txtBatteryCapacity
            // 
            this.txtBatteryCapacity.Location = new System.Drawing.Point(239, 232);
            this.txtBatteryCapacity.Name = "txtBatteryCapacity";
            this.txtBatteryCapacity.Size = new System.Drawing.Size(248, 22);
            this.txtBatteryCapacity.TabIndex = 31;
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductGroup.Location = new System.Drawing.Point(80, 40);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(118, 20);
            this.lblProductGroup.TabIndex = 22;
            this.lblProductGroup.Text = "Product Group";
            // 
            // txtBatteryType
            // 
            this.txtBatteryType.Location = new System.Drawing.Point(239, 183);
            this.txtBatteryType.Name = "txtBatteryType";
            this.txtBatteryType.Size = new System.Drawing.Size(248, 22);
            this.txtBatteryType.TabIndex = 30;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStage.Location = new System.Drawing.Point(141, 87);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(57, 20);
            this.lblStage.TabIndex = 23;
            this.lblStage.Text = "Series";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(239, 134);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(248, 22);
            this.txtModel.TabIndex = 29;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModel.Location = new System.Drawing.Point(144, 134);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 20);
            this.lblModel.TabIndex = 24;
            this.lblModel.Text = "Model";
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(239, 87);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(248, 22);
            this.txtSeries.TabIndex = 28;
            // 
            // lblBatteryType
            // 
            this.lblBatteryType.AutoSize = true;
            this.lblBatteryType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBatteryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBatteryType.Location = new System.Drawing.Point(94, 183);
            this.lblBatteryType.Name = "lblBatteryType";
            this.lblBatteryType.Size = new System.Drawing.Size(104, 20);
            this.lblBatteryType.TabIndex = 25;
            this.lblBatteryType.Text = "Battery Type";
            // 
            // lblBatteryCapacity
            // 
            this.lblBatteryCapacity.AutoSize = true;
            this.lblBatteryCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBatteryCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBatteryCapacity.Location = new System.Drawing.Point(65, 232);
            this.lblBatteryCapacity.Name = "lblBatteryCapacity";
            this.lblBatteryCapacity.Size = new System.Drawing.Size(133, 20);
            this.lblBatteryCapacity.TabIndex = 26;
            this.lblBatteryCapacity.Text = "Battery Capacity";
            // 
            // mdiEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 490);
            this.Controls.Add(this.pnMainEditSpec);
            this.Name = "mdiEditProduct";
            this.Text = "mdiEditProduct";
            this.pnMainEditSpec.ResumeLayout(false);
            this.pnMainEditSpec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMainEditSpec;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label lblCreateDate;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSaveEdit;
        private System.Windows.Forms.TextBox txtProductGroup;
        private System.Windows.Forms.TextBox txtBatteryCapacity;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.TextBox txtBatteryType;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Label lblBatteryType;
        private System.Windows.Forms.Label lblBatteryCapacity;
        private System.Windows.Forms.CheckBox chbIsDeacticated;
    }
}