using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.Data_Management.ProductDB;

namespace TESTBAG.Master_Data.subMasterFrm.Measure_Specification
{

    public partial class frmEditSpecificationData : Form
    {
        public frmEditSpecificationData()
        {
            InitializeComponent();
        }

        private void frmEditSpecificationData_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var closingFormContext = new TaiyouSenpuBagEntities())
            {
                closingFormContext.Dispose();
            }
        }

        private void btnCancelESpecify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveESpecify_Click(object sender, EventArgs e)
        {
            try
            {
                string measureName = txtMeasureNameESpecifications.Text;
                string stageText = txtStageESpecifications.Text;
                double prefferedValue = double.Parse(txtPreferredValueESpecifications.Text);
                double minVlaue = double.Parse(txtMinValueESpecifications.Text);
                double maxValue = double.Parse(txtMinValueESpecifications.Text);
                if (string.IsNullOrWhiteSpace(measureName))
                {
                    MessageBox.Show("Measure Name box is empty please enter the name", caption : "Empty Box Message");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(stageText))
                {
                    MessageBox.Show("Stage text cannot be empty.");
                    return;
                }
                else if (double.IsNaN(prefferedValue))
                {
                    MessageBox.Show("Preffered Value cannot be empty or is a number only.");
                    return;
                }
                else if (double.IsNaN(minVlaue))
                {
                    MessageBox.Show("Min Value cannot be empty or is a number only.");
                    return;
                }
                else if (double.IsNaN(maxValue))
                {
                    MessageBox.Show("Max valuye cannot be empty or is a number only.");
                    return;
                }
                DataManagement.InstanceData.MasterBindingProduct.DataSource = DataManagement.InstanceData.MasterDataContext.MASTER_SPECIFICATIONS.Local.ToBindingList();
                int editMasterSpecificationCount;
                editMasterSpecificationCount = DataManagement.InstanceData.masterDataContext.SaveChanges();
                if (editMasterSpecificationCount > 0)
                {
                    DataManagement.InstanceData.MasterSpecificationsDataGridView.Refresh();
                    DataManagement.InstanceData.master_SPECIFICATIONSBindingSource.ResetCurrentItem();
                    MessageBox.Show("Are you sure to edit item ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    DataManagement.InstanceData.MasterSpecificationsDataGridView.Refresh();
                    MessageBox.Show("Don't have any editting data", "Adding Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
