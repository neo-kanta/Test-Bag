namespace TESTBAG.Data_Classes
{
    partial class mdiEdiSpecifications
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
            this.txtPreffered = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.txtMeasureName = new System.Windows.Forms.TextBox();
            this.lblPreffered = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.lblMeasureName = new System.Windows.Forms.Label();
            this.pnMainEditSpec = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSaveEdit = new FontAwesome.Sharp.IconButton();
            this.pnMainEditSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPreffered
            // 
            this.txtPreffered.Location = new System.Drawing.Point(231, 247);
            this.txtPreffered.Name = "txtPreffered";
            this.txtPreffered.Size = new System.Drawing.Size(248, 22);
            this.txtPreffered.TabIndex = 19;
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(231, 198);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(248, 22);
            this.txtMaxValue.TabIndex = 18;
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(231, 149);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(248, 22);
            this.txtMinValue.TabIndex = 17;
            // 
            // txtStage
            // 
            this.txtStage.Location = new System.Drawing.Point(231, 102);
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(248, 22);
            this.txtStage.TabIndex = 16;
            // 
            // txtMeasureName
            // 
            this.txtMeasureName.Location = new System.Drawing.Point(231, 55);
            this.txtMeasureName.Name = "txtMeasureName";
            this.txtMeasureName.Size = new System.Drawing.Size(248, 22);
            this.txtMeasureName.TabIndex = 15;
            // 
            // lblPreffered
            // 
            this.lblPreffered.AutoSize = true;
            this.lblPreffered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreffered.Location = new System.Drawing.Point(70, 247);
            this.lblPreffered.Name = "lblPreffered";
            this.lblPreffered.Size = new System.Drawing.Size(125, 20);
            this.lblPreffered.TabIndex = 14;
            this.lblPreffered.Text = "Preffered Value";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMax.Location = new System.Drawing.Point(108, 198);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(87, 20);
            this.lblMax.TabIndex = 13;
            this.lblMax.Text = "Max Value";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMin.Location = new System.Drawing.Point(112, 149);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(83, 20);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "Min Value";
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStage.Location = new System.Drawing.Point(143, 102);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(52, 20);
            this.lblStage.TabIndex = 11;
            this.lblStage.Text = "Stage";
            // 
            // lblMeasureName
            // 
            this.lblMeasureName.AutoSize = true;
            this.lblMeasureName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMeasureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMeasureName.Location = new System.Drawing.Point(72, 55);
            this.lblMeasureName.Name = "lblMeasureName";
            this.lblMeasureName.Size = new System.Drawing.Size(123, 20);
            this.lblMeasureName.TabIndex = 10;
            this.lblMeasureName.Text = "Measure Name";
            // 
            // pnMainEditSpec
            // 
            this.pnMainEditSpec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMainEditSpec.Controls.Add(this.btnCancel);
            this.pnMainEditSpec.Controls.Add(this.btnSaveEdit);
            this.pnMainEditSpec.Controls.Add(this.txtMeasureName);
            this.pnMainEditSpec.Controls.Add(this.txtPreffered);
            this.pnMainEditSpec.Controls.Add(this.lblMeasureName);
            this.pnMainEditSpec.Controls.Add(this.txtMaxValue);
            this.pnMainEditSpec.Controls.Add(this.lblStage);
            this.pnMainEditSpec.Controls.Add(this.txtMinValue);
            this.pnMainEditSpec.Controls.Add(this.lblMin);
            this.pnMainEditSpec.Controls.Add(this.txtStage);
            this.pnMainEditSpec.Controls.Add(this.lblMax);
            this.pnMainEditSpec.Controls.Add(this.lblPreffered);
            this.pnMainEditSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainEditSpec.Location = new System.Drawing.Point(0, 0);
            this.pnMainEditSpec.Name = "pnMainEditSpec";
            this.pnMainEditSpec.Size = new System.Drawing.Size(554, 480);
            this.pnMainEditSpec.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(324, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 84);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSaveEdit.IconColor = System.Drawing.Color.Black;
            this.btnSaveEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveEdit.Location = new System.Drawing.Point(74, 335);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(155, 84);
            this.btnSaveEdit.TabIndex = 20;
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // mdiEdiSpecifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 480);
            this.Controls.Add(this.pnMainEditSpec);
            this.Name = "mdiEdiSpecifications";
            this.Text = "mdiEdiSpecifications";
            this.pnMainEditSpec.ResumeLayout(false);
            this.pnMainEditSpec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreffered;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.TextBox txtMeasureName;
        private System.Windows.Forms.Label lblPreffered;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label lblMeasureName;
        private System.Windows.Forms.Panel pnMainEditSpec;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSaveEdit;
    }
}