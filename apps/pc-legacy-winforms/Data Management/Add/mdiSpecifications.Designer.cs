namespace TESTBAG.Data_Management
{
    partial class mdiAddSpecifications
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSaveEdit = new FontAwesome.Sharp.IconButton();
            this.txtMeasureName = new System.Windows.Forms.TextBox();
            this.txtPreffered = new System.Windows.Forms.TextBox();
            this.lblMeasureName = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPreffered = new System.Windows.Forms.Label();
            this.pnMainAddSpec = new System.Windows.Forms.Panel();
            this.pnMainAddSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(285, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 84);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSaveEdit.IconColor = System.Drawing.Color.Black;
            this.btnSaveEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveEdit.Location = new System.Drawing.Point(35, 323);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(155, 84);
            this.btnSaveEdit.TabIndex = 32;
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // txtMeasureName
            // 
            this.txtMeasureName.Location = new System.Drawing.Point(192, 43);
            this.txtMeasureName.Name = "txtMeasureName";
            this.txtMeasureName.Size = new System.Drawing.Size(248, 22);
            this.txtMeasureName.TabIndex = 27;
            // 
            // txtPreffered
            // 
            this.txtPreffered.Location = new System.Drawing.Point(192, 235);
            this.txtPreffered.Name = "txtPreffered";
            this.txtPreffered.Size = new System.Drawing.Size(248, 22);
            this.txtPreffered.TabIndex = 31;
            // 
            // lblMeasureName
            // 
            this.lblMeasureName.AutoSize = true;
            this.lblMeasureName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMeasureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMeasureName.Location = new System.Drawing.Point(33, 43);
            this.lblMeasureName.Name = "lblMeasureName";
            this.lblMeasureName.Size = new System.Drawing.Size(123, 20);
            this.lblMeasureName.TabIndex = 22;
            this.lblMeasureName.Text = "Measure Name";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(192, 186);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(248, 22);
            this.txtMaxValue.TabIndex = 30;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStage.Location = new System.Drawing.Point(104, 90);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(52, 20);
            this.lblStage.TabIndex = 23;
            this.lblStage.Text = "Stage";
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(192, 137);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(248, 22);
            this.txtMinValue.TabIndex = 29;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMin.Location = new System.Drawing.Point(73, 137);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(83, 20);
            this.lblMin.TabIndex = 24;
            this.lblMin.Text = "Min Value";
            // 
            // txtStage
            // 
            this.txtStage.Location = new System.Drawing.Point(192, 90);
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(248, 22);
            this.txtStage.TabIndex = 28;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMax.Location = new System.Drawing.Point(69, 186);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(87, 20);
            this.lblMax.TabIndex = 25;
            this.lblMax.Text = "Max Value";
            // 
            // lblPreffered
            // 
            this.lblPreffered.AutoSize = true;
            this.lblPreffered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreffered.Location = new System.Drawing.Point(31, 235);
            this.lblPreffered.Name = "lblPreffered";
            this.lblPreffered.Size = new System.Drawing.Size(125, 20);
            this.lblPreffered.TabIndex = 26;
            this.lblPreffered.Text = "Preffered Value";
            // 
            // pnMainAddSpec
            // 
            this.pnMainAddSpec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMainAddSpec.Controls.Add(this.btnSaveEdit);
            this.pnMainAddSpec.Controls.Add(this.btnCancel);
            this.pnMainAddSpec.Controls.Add(this.lblPreffered);
            this.pnMainAddSpec.Controls.Add(this.lblMax);
            this.pnMainAddSpec.Controls.Add(this.txtMeasureName);
            this.pnMainAddSpec.Controls.Add(this.txtStage);
            this.pnMainAddSpec.Controls.Add(this.txtPreffered);
            this.pnMainAddSpec.Controls.Add(this.lblMin);
            this.pnMainAddSpec.Controls.Add(this.lblMeasureName);
            this.pnMainAddSpec.Controls.Add(this.txtMinValue);
            this.pnMainAddSpec.Controls.Add(this.txtMaxValue);
            this.pnMainAddSpec.Controls.Add(this.lblStage);
            this.pnMainAddSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainAddSpec.Location = new System.Drawing.Point(0, 0);
            this.pnMainAddSpec.Name = "pnMainAddSpec";
            this.pnMainAddSpec.Size = new System.Drawing.Size(492, 471);
            this.pnMainAddSpec.TabIndex = 34;
            // 
            // mdiSpecifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 471);
            this.Controls.Add(this.pnMainAddSpec);
            this.Name = "mdiSpecifications";
            this.Text = "mdiSpecifications";
            this.pnMainAddSpec.ResumeLayout(false);
            this.pnMainAddSpec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSaveEdit;
        private System.Windows.Forms.TextBox txtMeasureName;
        private System.Windows.Forms.TextBox txtPreffered;
        private System.Windows.Forms.Label lblMeasureName;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPreffered;
        private System.Windows.Forms.Panel pnMainAddSpec;
    }
}