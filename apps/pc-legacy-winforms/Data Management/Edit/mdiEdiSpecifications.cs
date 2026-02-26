using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Data_Classes
{
    public partial class mdiEdiSpecifications : Form
    {
        private int _specificationsId;
        public mdiEdiSpecifications(int specificationsId)
        {
            InitializeComponent();
            this._specificationsId = specificationsId;
            LoadEditSpec();
        }
        #region DATA BUTTON ------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var specification = context.MASTER_SPECIFICATIONS.Find(_specificationsId);
                if (specification == null)
                {
                    MessageBox.Show("Specification not found");
                    return;
                }
                specification.MEASUREMENT_NAME = txtMeasureName.Text.Trim();
                specification.STAGE_TEXT = txtStage.Text.Trim();
                specification.MIN_VALUE = double.Parse(txtMinValue.Text.Trim());
                specification.MAX_VALUE = double.Parse(txtMaxValue.Text.Trim());
                specification.PREFERRED_VALUE = double.Parse(txtPreffered.Text.Trim());
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Changes saved successfully");
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
        }
        #endregion DATA BUTTON ........................................................................


        #region DATA ENTRY ------------------------------------------------------------------------------
        public void LoadEditSpec()
        {
            var searchDataSpec = new NevigateSpecification(_specificationsId);
            txtMeasureName.Text = searchDataSpec.FindMeasureName();
            txtStage.Text = searchDataSpec.FindStage();
            txtMinValue.Text = searchDataSpec.FindMinValue().ToString();
            txtMaxValue.Text = searchDataSpec.FindMaxValue().ToString();
            txtPreffered.Text = searchDataSpec.FindPreferredVaue().ToString();
        }
        #endregion DATA ENTRY ........................................................................
    }
}
