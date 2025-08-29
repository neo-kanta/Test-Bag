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
using TESTBAG.Data_Management.ProductDB;

namespace TESTBAG.Master_Data.subMasterFrm.Measure_Specification
{
    public partial class frmAddSpecification : Form
    {
        TESTBAG.Data_Management.ProductDB.TaiyouSenpuBagEntities specificationsAddDataEntry = new Data_Management.TaiyouSenpuBagEntities();
        TESTBAG.Data_Management.ProductDB.MASTER_SPECIFICATIONS dataMasterSpecifications = new Data_Management.MASTER_SPECIFICATIONS();

        #region MAIN_FORM_MEASURE_SPECIFICATION -----------------------------------------
        DataManagement masterDataForm = new DataManagement();
        public frmAddSpecification()
        {
            InitializeComponent();
            masterDataForm.MasterSpecificationsDataGridView.Refresh();
            this.master_SPECIFICATIONSBindingSource.DataSource = DataManagement.InstanceData.masterDataContext.MASTER_SPECIFICATIONS.Local.ToBindingList();
            this.master_SPECIFICATIONSBindingSource.AddNew();
        }

        private void frmAddSpecification_FormClosing(object sender, FormClosingEventArgs e)
        {
            specificationsAddDataEntry.Dispose();
        }
        #endregion MAIN_SPECIFICATION ......................................................

        #region TEXT BOX DATA ENTRY --------------------------------------------------------


        #endregion TEXT BOX DATA ENTRY .....................................................

        #region DATA_ENTRY_BUTTON ----------------------------------------------------------
        private void btnAddASpecify_Click(object sender, EventArgs e)
        {
            string productID = txtProductIDASpecifications.Text;
            string measureName = txtMeasureNameASpecifications.Text;
            string stage = txtStageASpecifications.Text;
            string maxValue = txtMaxValueASpecifications.Text;
            string minValue = txtMinValueASpecifications.Text;
            string meanValue = txtPreferredValueValueASpecifications.Text;

            if (string.IsNullOrWhiteSpace(productID) )
            {
                MessageBox.Show("Please enter the text", "Empty message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(measureName))
            {
                MessageBox.Show("Please enter the text in the Measurement Name", "Empty Message of Measurement Name box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(stage))
            {
                MessageBox.Show("Please enter the text in the stage box", "Empty Message of Stage name box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(string.IsNullOrWhiteSpace(maxValue))
            {
                MessageBox.Show("Please enter the text in the max value box", "Empty Message of Max Value box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(minValue))
            {
                MessageBox.Show("Please enter the text in the min value box", "Empty Message of Min Value box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(meanValue))
            {
                MessageBox.Show("Please enter the text in the mean value box", "Empty Message of Mean Value box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.master_SPECIFICATIONSBindingSource.EndEdit();
            this.master_SPECIFICATIONSBindingSource.DataSource = specificationsAddDataEntry.MASTER_SPECIFICATIONS.Local.ToBindingList();
            int addProductCount = specificationsAddDataEntry.SaveChanges();
            if (addProductCount > 0)
            {
                masterDataForm.MasterProductDataGridView.Refresh();
                masterDataForm.MasterBindingProduct.ResetCurrentItem();
                MessageBox.Show("Are you sure to add this items ?", "Warning Adding Specification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("don't have any adding data", "Adding Specofication Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancelASpecify_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion DATA_ENTRY_BUTTON .......................................................
    }
}