using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TESTBAG.Data_Classes;
using TESTBAG.Data_Management.ProductDB;

namespace TESTBAG.Master_Data.subMasterFrm.Product
{
    public partial class frmAddProduct : Form
    {
        TESTBAG.Data_Management.ProductDB.TaiyouSenpuBagEntities productAddDataEntity = new Data_Management.ProductDB.TaiyouSenpuBagEntities();
        TESTBAG.Data_Management.ProductDB.PRODUCT productTableData = new Data_Management.ProductDB.PRODUCT();
        DataManagement masterDataForm = new DataManagement();

        #region MAIN_ADD_PRODUCT -----------------------------------------------------------------
        
        public frmAddProduct()
        {
            InitializeComponent();
            masterDataForm.MasterProductDataGridView.Refresh();
            this.productBindingSource.DataSource = masterDataForm.MasterDataContext.PRODUCT.Local.ToBindingList();
            this.productBindingSource.AddNew();
            //---------------------------------
            ComboxInit();
        }
        private async void ComboxInit()
        {
            var productSearch = new ProductComboBoxes(_productGroupM: cboProductGroupAP,
                                         _seriesM: cboSeriesAP,
                                         _modelM: cboModelAP,
                                         _batteryTypeM: cboBatteryTypeAP,
                                         _batteryCapacityM: cboBatteryCapacityAP);

            await productSearch.LoadProductTableData();
        }
        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            masterDataForm.MasterDataContext.Dispose();
        }
        #endregion MAIN_ADD_PRODUCT ............................................................

        #region ADD_DATA_ENTRY_BUTTON ----------------------------------------------------------
        private void btnAddAP_Click(object sender, EventArgs e)
        {
            this.productBindingSource.EndEdit();
            this.productBindingSource.DataSource = masterDataForm.MasterDataContext.PRODUCT.Local.ToBindingList();
            int addProductCount = masterDataForm.MasterDataContext.SaveChanges();
            if (addProductCount > 0)
            {
                masterDataForm.MasterProductDataGridView.Refresh();
                masterDataForm.MasterBindingProduct.ResetCurrentItem();
                MessageBox.Show("Are you sure to add this items ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("don't have any adding data", "Adding Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelAP_Click(object sender, EventArgs e)
        {
            masterDataForm.Refresh();
            this.Close();
        }
        #endregion ADD_DATA_ENTRY_BUTTON ........................................................

        #region COMBO_BOX ----------------------------------------------------------------------
      
        private void cboProductGroupAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductGroup = cboProductGroupAP.SelectedItem.ToString();
            cboSeriesAP.DataSource = masterDataForm.MasterDataContext.PRODUCT.
                Where(seriesOfGroup => seriesOfGroup.PRODUCT_GRUOP == selectedProductGroup).Select(pg => pg.SERIES).
                Distinct().ToList();
            cboSeriesAP.Text = string.Empty;
        }

        private void cboSeriesAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSeries = cboSeriesAP.SelectedItem.ToString();
            cboModelAP.DataSource = masterDataForm.MasterDataContext.PRODUCT.
                Where(ModelOfGroup => ModelOfGroup.SERIES == selectedSeries).
                Select(pg => pg.MODEL).Distinct().ToList();
            cboModelAP.Text = string.Empty;
        }

        private void cboModelAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = cboModelAP.SelectedItem.ToString();
            cboBatteryTypeAP.DataSource = masterDataForm.MasterDataContext.PRODUCT.
                Where(ModelOfGroup => ModelOfGroup.MODEL == selectedModel).
                Select(pg => pg.BATTERY_TYPE).Distinct().ToList();
            cboBatteryTypeAP.Text = string.Empty;
            cboBatteryCapacityAP.DataSource = masterDataForm.MasterDataContext.PRODUCT.
                Where(batteryCapacityOfGroup => batteryCapacityOfGroup.MODEL == selectedModel).
                Select(pg => pg.BATTERY_CAPACITY).Distinct().ToList();
            cboBatteryCapacityAP.DataSource = string.Empty;
        }
        private void cboBatteryCapacityAP_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }
        private void cboBatteryTypeAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBatteryType = cboBatteryTypeAP.SelectedItem.ToString();
            cboBatteryCapacityAP.DataSource = masterDataForm.MasterDataContext.PRODUCT.
                Where(batteryCapacityOfGroup => batteryCapacityOfGroup.BATTERY_TYPE == selectedBatteryType).
                Select(pg => pg.BATTERY_CAPACITY).Distinct().ToList();
            cboBatteryCapacityAP.DataSource= string.Empty;
        }
        #endregion COMBO_BOX ........................................................................
    }
}
