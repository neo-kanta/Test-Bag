using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Data_Management
{
    public partial class mdiAddSpecifications : Form
    {
        public mdiAddSpecifications()
        {
            InitializeComponent();
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
                MASTER_SPECIFICATIONS submitData = new MASTER_SPECIFICATIONS
                {
                    MEASUREMENT_NAME = txtMeasureName.Text.Trim(),
                    STAGE_TEXT = txtStage.Text.Trim(),
                    MIN_VALUE = double.Parse(txtMinValue.Text.Trim()),
                    MAX_VALUE = double.Parse(txtMaxValue.Text.Trim()),
                    PREFERRED_VALUE = double.Parse(txtPreffered.Text.Trim()),
                };
                context.MASTER_SPECIFICATIONS.Add(submitData);
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
    }
}
