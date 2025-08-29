using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTBAG.ProductQuality
{
    public static class QCChargingSystem
    {
    public static (ChargingState stage, CheckQualityStatus autoCheck) CheckThreeStepCharge(
            double movingAverageVoltage, double derivative,
            double hightMinCharge, double highMaxCharge,
            double lowMinCharge, double lowMaxCharge,
            AlternativeCurrentState acState)
        {
            if (highMaxCharge < movingAverageVoltage)
            {
                return (ChargingState.Discharge, CheckQualityStatus.NG);
            }
            else if (lowMinCharge <= movingAverageVoltage && movingAverageVoltage <= highMaxCharge && acState == AlternativeCurrentState.ON)
            {
                if (derivative > 0) // Charging
                {
                    if (lowMinCharge < movingAverageVoltage && movingAverageVoltage < lowMaxCharge)
                    {
                        return (ChargingState.Charge, CheckQualityStatus.Good);
                    }
                    else
                    {
                        return (ChargingState.Charge, CheckQualityStatus.Good);
                    }
                }
                else if (derivative < 0) // Float
                {
                    if (hightMinCharge < movingAverageVoltage && movingAverageVoltage < highMaxCharge)
                    {
                        return (ChargingState.Float, CheckQualityStatus.Good);
                    }
                    else
                    {
                        return (ChargingState.Float, CheckQualityStatus.Good);
                    }
                }
                else
                {
                    return (ChargingState.Checking, CheckQualityStatus.Good);
                }
            }
            else if (lowMinCharge <= movingAverageVoltage && movingAverageVoltage <= highMaxCharge && acState == AlternativeCurrentState.OFF)
            {
                if (derivative < 0) // Discharge
                {
                    if (hightMinCharge < movingAverageVoltage && movingAverageVoltage < highMaxCharge)
                    {
                        return (ChargingState.Discharge, CheckQualityStatus.Good);
                    }
                    else
                    {
                        return (ChargingState.Discharge, CheckQualityStatus.Good);
                    }
                }
                else if (derivative > 0)
                {
                    if (lowMinCharge < movingAverageVoltage && movingAverageVoltage < lowMaxCharge)
                    {
                        return (ChargingState.Charge, CheckQualityStatus.Good);
                    }
                    else
                    {
                        return (ChargingState.Charge, CheckQualityStatus.Good);
                    }
                }
                else
                {
                    return (ChargingState.Checking, CheckQualityStatus.Good);
                }
            }
            else
            {
                return (ChargingState.OutOfRange, CheckQualityStatus.NG);
            }
        }

        #region QC_CURRENT_CONSTANT _________________________________________________________________________________________________________________

        public static (ChargingState stage, CheckQualityStatus autoCheck) CheckCurrentConstant(
             double movingAverageVoltage, double derivative,
             double currentConstantMin, double CurrentConstantMax,
             AlternativeCurrentState acState)
        {
            if (CurrentConstantMax < movingAverageVoltage)
            {
                return (ChargingState.OutOfRange, CheckQualityStatus.NG);
            }
            else if (currentConstantMin <= movingAverageVoltage && movingAverageVoltage <= CurrentConstantMax && acState == AlternativeCurrentState.ON)
            {
                if (derivative > 0) // Charging
                {
                    return (ChargingState.Charge, CheckQualityStatus.Good);
                }
                else if (derivative < 0) // Discharging
                {
                    return (ChargingState.Discharge, CheckQualityStatus.Good);
                }
                else
                {
                    return (ChargingState.Checking, CheckQualityStatus.Good);
                }
            }
            else if (currentConstantMin <= movingAverageVoltage && movingAverageVoltage <= CurrentConstantMax && acState == AlternativeCurrentState.OFF)
            {
                if (derivative > 0) // Charging
                {
                    return (ChargingState.Charge, CheckQualityStatus.NG);
                }
                else if (derivative < 0) // Discharging
                {
                    return (ChargingState.Discharge, CheckQualityStatus.Good);
                }
                else
                {
                    return (ChargingState.Checking, CheckQualityStatus.Good);
                }
            }
            else
            {
                return (ChargingState.OutOfRange, CheckQualityStatus.NG);
            }
        }

        #endregion QC_THREE_STEP_CHARGE -------------------------------------------------------------------------------------------------------------
    }
}