using System;

namespace TESTBAG.ProductQuality
{
    public static class BatteryMeasurementModeDescription
    {
        /// <summary>
        /// Define the mode of investigation product in IsOn IMPORT-EXPORT CO., LTD
        /// </summary>
        /// <param name="batteryMode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string GetString(BatteryMeasurementMode batteryMode)
        {
            switch (batteryMode)
            {
                case BatteryMeasurementMode.VirtualBattery:
                    return "Virtual Battery";
                case BatteryMeasurementMode.BatteryEfficiencyyMode:
                    return "Real Battery";
                case BatteryMeasurementMode.LowVoltageCutOffMode:
                    return "Low Voltage Cut Off";
                case BatteryMeasurementMode.Unknown:
                    return "Unknown";
                case BatteryMeasurementMode.Error:
                    return "Error";
                default:
                    throw new ArgumentOutOfRangeException(nameof(batteryMode), batteryMode, "Unknown Battery Measurement Mode Status value.");
            }
        }

        /// <summary>
        /// Converts a string to its corresponding chargingBatteryModeString of Product.
        /// </summary>
        /// <param name="chargingBatteryModeString">The string representing a chargingBatteryModeString.</param>
        /// <returns>The chargingBatteryModeString corresponding to the given string.</returns>
        public static BatteryMeasurementMode GetStringAsQualityStatus(string chargingBatteryModeString)
        {
            if (string.IsNullOrEmpty(chargingBatteryModeString))
            {
                throw new ArgumentNullException(nameof(chargingBatteryModeString), "Charging System string cannot be null or empty.");
            }

            switch (chargingBatteryModeString)
            {
                case "Virtual Battery":
                    return BatteryMeasurementMode.VirtualBattery;
                case "Real Battery":
                    return BatteryMeasurementMode.BatteryEfficiencyyMode;
                case "Low Voltage Cut Off":
                    return BatteryMeasurementMode.LowVoltageCutOffMode;
                case "Unknown":
                    return BatteryMeasurementMode.Unknown;
                case "Error":
                    return BatteryMeasurementMode.Error;
                default:
                    throw new ArgumentException($"Unknown Battery Measurement Mode string: {chargingBatteryModeString}", nameof(chargingBatteryModeString));
            }
        }
    }
}
