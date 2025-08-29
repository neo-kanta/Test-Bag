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
    public partial class mdiEditProduct : Form
    {
        private readonly int _productEditId;
        public mdiEditProduct(int productEditId)
        {
            InitializeComponent();
            this._productEditId = productEditId;
            LoadEditProduct();
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
                var product = context.PRODUCT.Find(_productEditId);
                if (product == null)
                {
                    MessageBox.Show("Specification not found");
                    return;
                }
                if (!DateTime.TryParseExact(txtCreateDate.Text.Trim(), "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime productCreateDate))
                {
                    MessageBox.Show("Invalid manufacture date. Please enter valid date in the format of ddMMyy such as 130719.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                product.PRODUCT_GRUOP = txtProductGroup.Text.Trim();
                product.SERIES = txtSeries.Text.Trim();
                product.MODEL = txtModel.Text.Trim();
                product.BATTERY_TYPE = txtBatteryType.Text.Trim();
                product.BATTERY_CAPACITY = txtBatteryCapacity.Text.Trim();
                product.CREATE_DATE_TIME = productCreateDate;
                product.IS_DEACTICATED = chbIsDeacticated.Checked;
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
        public void LoadEditProduct()
        {
            var searchDataProduct = new NevigateProduct(_productEditId);
            txtProductGroup.Text = searchDataProduct.FindProductGroup();
            txtSeries.Text = searchDataProduct.FindSeries();
            txtModel.Text = searchDataProduct.FindModel();
            txtBatteryType.Text = searchDataProduct.FindBatteryType();
            txtBatteryCapacity.Text = searchDataProduct.FindBatteryCapacity();

            bool? isDeactivated = searchDataProduct.FindIsDeacticated();
            chbIsDeacticated.Checked = isDeactivated ?? false;
        }
        #endregion DATA ENTRY ........................................................................
    }
}
