using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Data_Management
{
    public partial class mdiAddProduct : Form
    {

        public mdiAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveProduct(PRODUCT product)
        {
            using (var contextAddProduct = new Entities())
            {
                contextAddProduct.PRODUCT.Add(product);
                try
                {
                    contextAddProduct.SaveChanges();
                    MessageBox.Show("Changes saved successfully");
                }
                catch (DbEntityValidationException ex)
                {
                    string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                    MessageBox.Show($"Validation errors occurred while saving data: {errorMessages}", "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Cannot update the Measurement ID" + ex.Message, "Cannot Update Data",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(txtCreateDate.Text.Trim(), "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime productCreateDate))
            {
                MessageBox.Show("Invalid manufacture date. Please enter valid date in the format of ddMMyy such as 130719.", "Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            var submitAddData = new PRODUCT
            {
                PRODUCT_GRUOP = txtProductGroup.Text.Trim().ToUpper(),
                SERIES = txtSeries.Text.Trim().ToUpper(),
                MODEL = txtModel.Text.Trim().ToUpper(),
                BATTERY_TYPE = txtBatteryType.Text,
                BATTERY_CAPACITY = txtBatteryCapacity.Text,
                CREATE_DATE_TIME = productCreateDate,
                IS_DEACTICATED = chbIsDeacticated.Checked
            };

            SaveProduct(submitAddData);
        }
    }
}