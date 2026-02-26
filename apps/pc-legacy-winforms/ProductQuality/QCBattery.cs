using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTBAG.ProductQuality
{
    public static class QCBattery
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
            else
            {
                return (ChargingState.OutOfRange, CheckQualityStatus.NG);
            }
        }
    }
}
