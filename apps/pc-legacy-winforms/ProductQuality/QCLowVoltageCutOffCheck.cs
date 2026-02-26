using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTBAG.ProductQuality
{
    public static class QCLowVoltageCutOffCheck
    {
        #region QC_LOW_VOLTAGE_CUT_OFF _________________________________________________________________________________________________________________
        public static (ChargingState stage, CheckQualityStatus autoCheck) CheckCurrentConstant(
             double movingAverageVoltage, double derivative, double current,
             double cutoffMin, double cutoffMax,
             AlternativeCurrentState acState)
        {
            
            if (cutoffMin < movingAverageVoltage && movingAverageVoltage < cutoffMax && acState == AlternativeCurrentState.OFF)
            {
                return (ChargingState.LowVoltageCutOff, CheckQualityStatus.Good);
            }
            else if (cutoffMin < movingAverageVoltage && movingAverageVoltage < cutoffMax && acState == AlternativeCurrentState.ON)
            {
                return (ChargingState.LowVoltageCutOff, CheckQualityStatus.NG);
            }
            else if (movingAverageVoltage < cutoffMin)
            {
                return (ChargingState.LowVoltageCutOff, CheckQualityStatus.NG);
            }
            else
            {
                return (ChargingState.OutOfRange, CheckQualityStatus.NG);
            }
        }

        #endregion QC_LOW_VOLTAGE_CUT_OFFE -------------------------------------------------------------------------------------------------------------
    }
}