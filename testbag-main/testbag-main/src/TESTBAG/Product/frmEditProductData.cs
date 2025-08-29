using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.Master_Data;
using TESTBAG.Master_Data.ProductDB;

namespace TESTBAG.Master_Data.subMasterFrm.Product
{
    public partial class frmEditProductData : Form
    {
        TESTBAG.Master_Data.ProductDB.TaiyouSenpuBagEntities editProduct = new Master_Data.ProductDB.TaiyouSenpuBagEntities();
        public BindingNavigator EditProductNavigator { get { return editProductBindingNavigator; } }

        #region EDIT_PRODUCT_DATA_MAIN_FORM ------------------------------------------------
        public frmEditProductData()
        {
            InitializeComponent();
        }
        private void frmEditProductData_FormClosing(object sender, FormClosingEventArgs e)
        {
            editProduct.Dispose();
        }
        #endregion EDIT_PRODUCT_DATA_MAIN_FORM .............................................

        #region DATA_ENTRY_BUTTON ----------------------------------------------------------
        private void btnCancelEPD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEditAndSaveEPD_Click(object sender, EventArgs e)
        {
            try
            {
                string productGroup = txtProductGroupEPD.Text;
                string series = txtSeriesEPD.Text;
                string model = txtModelEPD.Text;
                string batteryType = txtBatteryTypeEPD.Text;
                string batteryCapacity = txtBatteryCapacityEPD.Text;
                if (string.IsNullOrWhiteSpace(productGroup))
                {
                    MessageBox.Show("Product Group cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(series))
                {
                    MessageBox.Show("Series cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(model))
                {
                    MessageBox.Show("Model cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(batteryType))
                {
                    MessageBox.Show("Battery Type cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(batteryCapacity))
                {
                    MessageBox.Show("Battery Capacity cannot be empty.");
                    return;
                }
                DataManagement.InstanceData.MasterBindingProduct.DataSource = DataManagement.InstanceData.MasterDataContext.PRODUCT.Local.ToBindingList();
                int editProductCount;
                editProductCount = DataManagement.InstanceData.MasterDataContext.SaveChanges();
                if (editProductCount > 0)
                {
                    DataManagement.InstanceData.MasterProductDataGridView.Refresh();
                    DataManagement.InstanceData.MasterBindingProduct.ResetCurrentItem();
                    MessageBox.Show("Are you sure to add this items ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                else
                {
                    DataManagement.InstanceData.MasterProductDataGridView.Refresh();
                    MessageBox.Show("don't have any adding data", "Adding Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
            #endregion DATA_ENTRY_BUTTON ........................................................
    }
}