using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Data_Classes
{
    public class SaveData : IDisposable
    {
        private readonly frmMain _mainDesk;
        private readonly Entities _context;
        public int LastMeasureProductIdPublic { get; set; }

        public SaveData(frmMain _mainDesk)
        {
            this._mainDesk = _mainDesk;
        }
        public void FirstTimeSaveMeasurementProduct(int? mpId, string jobNum, string serialNum, string manuDate, string lotNum, string ngList, string measureBy, string comment)
        {
            try
            {
                if (!DateTime.TryParseExact(manuDate, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime mfgDate))
                {
                    MessageBox.Show("Invalid manufacture date. Please enter valid date in the format of ddMMyy such as 130719.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                using (var submitMeasurementProduct = new Entities())
                {
                    DateTime nowTimeSave = DateTime.Now;
                    MEASUREMENT_PRODUCT submitData = new MEASUREMENT_PRODUCT
                    {
                        PRODUCT_ID = mpId,
                        JOB_NUMBER = jobNum,
                        SERIAL_NUMBER = serialNum,
                        MFG_DATE = mfgDate,
                        LOT_NUMBER = lotNum,
                        MEASURE_DATE_TIME = nowTimeSave,
                        NG_LIST = ngList,
                        CREATE_BY = measureBy,
                        COMMENT = comment
                    };
                    submitMeasurementProduct.MEASUREMENT_PRODUCT.Add(submitData);
                    submitMeasurementProduct.SaveChanges();
                    _mainDesk.measurementProductId = submitData.ID;
                    //mainDesk.forSaveAgain = lastMeasureProductIdPublic;
                };

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
        public void WhileThreadSaveComment(int rawId, string comment)
        {
            using (var commentText = new Entities())
            {
                var measurementComment = commentText.MEASUREMENT_PRODUCT.FirstOrDefault(mp => mp.ID == rawId);
                {
                    measurementComment.COMMENT = string.Join(",", comment);
                    try { commentText.SaveChanges(); }
                    catch (DbUpdateException ex)
                    {
                        var errorMessage = "";
                        if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        { errorMessage = ex.InnerException.InnerException.Message; }
                        else { errorMessage = ex.Message; }
                        MessageBox.Show("Cannot update measurement data: " + errorMessage, "Measurement Data Update Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        bool NGFlag = false;
        public void AutoSaveDetectNGList(int rawId, ComboBox manualCheck, string autoCheck)
        {
            using (var changeNGList = new Entities())
            {
                var measurementProduct = changeNGList.MEASUREMENT_PRODUCT.FirstOrDefault(mp => mp.ID == rawId);
                if (measurementProduct == null) { return; }
                if (manualCheck.SelectedIndex == -1)
                {
                    if (autoCheck == "NG" && !NGFlag)
                    {
                        NGFlag = true;
                        measurementProduct.NG_LIST = autoCheck;
                        changeNGList.SaveChanges();
                    }
                }
                else
                {
                    measurementProduct.NG_LIST = manualCheck.Text;
                    changeNGList.SaveChanges();
                }
            }
        }


        public void SaveRawData(double totalSeconds = 0.0,
                                double voltageDc = 0.0, double currentDc = 0.0, double averageVoltageDc = 0.0,double currentADC =0.0,double derivativeVoltage =0.0)
        {
            using (var measureRawValueContext = new Entities())
            {
                var measurementRows = new List<RAW_MEASUREMENT>
                {
                    new RAW_MEASUREMENT
                    {
                        MEASUREMENT_ID = _mainDesk.measurementProductId,
                        TOTAL_SECONDS = totalSeconds,
                        MEASUREMENT_NAME = "Voltage",
                        MEASUREMENT_VALUE = voltageDc
                    },
                    new RAW_MEASUREMENT
                    {
                        MEASUREMENT_ID = _mainDesk.measurementProductId,
                        TOTAL_SECONDS = totalSeconds,
                        MEASUREMENT_NAME = "Current",
                        MEASUREMENT_VALUE = currentDc
                    },
                    new RAW_MEASUREMENT
                    {
                        MEASUREMENT_ID = _mainDesk.measurementProductId,
                        TOTAL_SECONDS = totalSeconds,
                        MEASUREMENT_NAME = "Average_Voltage",
                        MEASUREMENT_VALUE = averageVoltageDc
                    },
                    new RAW_MEASUREMENT
                    {
                        MEASUREMENT_ID = _mainDesk.measurementProductId,
                        TOTAL_SECONDS = totalSeconds,
                        MEASUREMENT_NAME = "Current_ADC",
                        MEASUREMENT_VALUE = currentADC
                    },
                    new RAW_MEASUREMENT
                    {
                        MEASUREMENT_ID = _mainDesk.measurementProductId,
                        TOTAL_SECONDS = totalSeconds,
                        MEASUREMENT_NAME = "Derivative_Voltage",
                        MEASUREMENT_VALUE = derivativeVoltage
                    }
                };
                foreach (var measurementRow in measurementRows)
                {
                    measureRawValueContext.RAW_MEASUREMENT.Add(measurementRow);
                }
                try { measureRawValueContext.SaveChanges(); }
                catch (DbUpdateException ex)
                {
                    var errorMessage = "";
                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                    { errorMessage = ex.InnerException.InnerException.Message; }
                    else { errorMessage = ex.Message; }
                    MessageBox.Show("Cannot update measurement data: " + errorMessage, "Measurement Data Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException ex) { MessageBox.Show($"Error + {ex}"); }
            }
        }
        public async Task LoadDataGridViewAsync(DataGridView productGrid, DataGridView specGrid, DataGridView measureProductGrid)
        {
            using (var dbContext = new Entities())
            {
                await dbContext.PRODUCT.LoadAsync();
                productGrid.DataSource = dbContext.PRODUCT.Local.ToBindingList();
                await dbContext.MASTER_SPECIFICATIONS.LoadAsync();
                specGrid.DataSource = dbContext.MASTER_SPECIFICATIONS.Local.ToBindingList();
                await dbContext.MEASUREMENT_PRODUCT.LoadAsync();
                measureProductGrid.DataSource = dbContext.MEASUREMENT_PRODUCT.Local.ToBindingList();
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}