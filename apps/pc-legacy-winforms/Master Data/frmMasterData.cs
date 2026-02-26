using FontAwesome.Sharp;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
<<<<<<< HEAD
using TESTBAG.Data_Management.ProductDB;
using TESTBAG.Data_Management.Product;

namespace TESTBAG.Master_Data
{
    public partial class DataManagement : Form 
=======
=======
>>>>>>> parent of 17eed96 (New Submit Measurement and New Measurement for ease UX)
using TESTBAG.Master_Data.ProductDB;
using TESTBAG.Master_Data.subMasterFrm;
using TESTBAG.Master_Data.subMasterFrm.Measure_Specification;
using TESTBAG.Master_Data.subMasterFrm.Product;

namespace TESTBAG.Master_Data
{
    public partial class MasterData : Form
<<<<<<< HEAD
>>>>>>> parent of 17eed96 (New Submit Measurement and New Measurement for ease UX)
=======
>>>>>>> parent of 17eed96 (New Submit Measurement and New Measurement for ease UX)
    {
        public static DataManagement InstanceData ;
        public TESTBAG.Data_Management.ProductDB.TaiyouSenpuBagEntities masterDataContext = new Data_Management.ProductDB.TaiyouSenpuBagEntities();
        public Data_Management.ProductDB.TaiyouSenpuBagEntities MasterDataContext { get { return masterDataContext; } }
        public DataGridView MasterProductDataGridView { get { return productDataGridView; } }
        public DataGridView MasterSpecificationsDataGridView { get { return masterSPECIFICATIONSDataGridView; } }
        public BindingSource MasterBindingProduct { get { return masterProductBindingSource; } }

        #region MASTERDATA_FORM -------------------------------------------------------------------

        public DataManagement()
        {
            try
            {
                masterDataContext.PRODUCT.Load();
                masterProductBindingSource.DataSource = masterDataContext.PRODUCT.Local.ToBindingList();
                productDataGridView.DataSource = masterProductBindingSource;

                masterDataContext.MASTER_SPECIFICATIONS.Load();
                master_SPECIFICATIONSBindingSource.DataSource = masterDataContext.MASTER_SPECIFICATIONS.Local.ToBindingList();
                masterSPECIFICATIONSDataGridView.DataSource = master_SPECIFICATIONSBindingSource;
            }
            catch (SqlException ex) { MessageBox.Show($"A database error occurred: {ex.Message}"); }
        }
        private void MasterData_FormClosing(object sender, FormClosingEventArgs e)
        {
            //masterDataContext.Dispose();
        }
        #endregion MASTERDATA_FORM ................................................................


        #region PRODUCT ---------------------------------------------------------------------------

        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            MasterProductDataGridView.Refresh();
            productDataGridView.DataSource = masterProductBindingSource;
            this.masterProductBindingSource.DataSource = masterDataContext.PRODUCT.Local.ToBindingList();
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Form addProductForm = new frmAddProduct();
            addProductForm.ShowDialog();
        }
        private void productDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditProductData editProductForm = new frmEditProductData();
            editProductForm.txtProductGroupEPD.DataBindings.Clear();
            editProductForm.txtProductGroupEPD.DataBindings.Add("Text", DataManagement.InstanceData.masterProductBindingSource, "PRODUCT_GRUOP");
            editProductForm.txtSeriesEPD.DataBindings.Clear();
            editProductForm.txtSeriesEPD.DataBindings.Add("Text", DataManagement.InstanceData.masterProductBindingSource, "SERIES");
            editProductForm.txtModelEPD.DataBindings.Clear();
            editProductForm.txtModelEPD.DataBindings.Add("Text", DataManagement.InstanceData.masterProductBindingSource, "MODEL");
            editProductForm.txtBatteryTypeEPD.DataBindings.Clear();
            editProductForm.txtBatteryTypeEPD.DataBindings.Add("Text", DataManagement.InstanceData.masterProductBindingSource, "BATTERY_TYPE");
            editProductForm.txtBatteryCapacityEPD.DataBindings.Clear();
            editProductForm.txtBatteryCapacityEPD.DataBindings.Add("Text", DataManagement.InstanceData.masterProductBindingSource, "BATTERY_CAPACITY");
            editProductForm.ShowDialog();
        }
        #endregion PRODUCT ........................................................................


        #region MEASUREMENT_SPECIFICATION ---------------------------------------------------------

        private void btnMeausreSpecify_Click(object sender, EventArgs e)
        {
            MasterSpecificationsDataGridView.Refresh();
            masterSPECIFICATIONSDataGridView.DataSource = master_SPECIFICATIONSBindingSource;
            this.master_SPECIFICATIONSBindingSource.DataSource = masterDataContext.MASTER_SPECIFICATIONS.Local.ToBindingList();
        }
        private void btnNewSpecify_Click(object sender, EventArgs e)
        {
            Form frmAddSpecificationData = new frmAddSpecification();
            frmAddSpecificationData.ShowDialog();
        }
        private void masterSPECIFICATIONSDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditSpecificationData editMasterSpecifications = new frmEditSpecificationData();
            editMasterSpecifications.txtMeasureNameESpecifications.DataBindings.Clear();
            editMasterSpecifications.txtMeasureNameESpecifications.DataBindings.Add("Text", DataManagement.InstanceData.master_SPECIFICATIONSBindingSource, "MEASURE_ID");
            editMasterSpecifications.txtStageESpecifications.DataBindings.Clear();
            editMasterSpecifications.txtStageESpecifications.DataBindings.Add("Text", DataManagement.InstanceData.master_SPECIFICATIONSBindingSource, "STAGE_TEXT");
            editMasterSpecifications.txtPreferredValueESpecifications.DataBindings.Clear();
            editMasterSpecifications.txtPreferredValueESpecifications.DataBindings.Add("Text", DataManagement.InstanceData.master_SPECIFICATIONSBindingSource, "PREFERRED_VALUE");
            editMasterSpecifications.txtMaxValueESpecifications.DataBindings.Clear();
            editMasterSpecifications.txtMaxValueESpecifications.DataBindings.Add("Text", DataManagement.InstanceData.master_SPECIFICATIONSBindingSource, "MAX_VALUE");
            editMasterSpecifications.txtMinValueESpecifications.DataBindings.Clear();
            editMasterSpecifications.txtMinValueESpecifications.DataBindings.Add("Text", DataManagement.InstanceData.master_SPECIFICATIONSBindingSource, "MIN_VAlUE");
            editMasterSpecifications.ShowDialog();
        }
        #endregion MEASUREMENT_SPECIFICATION ........................................................................
    }
}
