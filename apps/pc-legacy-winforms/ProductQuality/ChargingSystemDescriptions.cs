using System;

namespace TESTBAG.ProductQuality
{
    public static class ChargingSystemDescriptions
    {
        public static string GetQualityString(ChargingSystem system)
        {
            switch (system)
            {
                case ChargingSystem.ThreeStepCharge:
                    return "Three Step Charge";
                case ChargingSystem.CurrentConstantAndLimitCurrent:
                    return "Current Constant and Limit Current";
                case ChargingSystem.Unknown:
                    return "Unknown";
                case ChargingSystem.Error:
                    return "Error";
                default:
                    throw new ArgumentOutOfRangeException(nameof(system), system, "Unknown Charging System Status value.");
            }
        }

        /// <summary>
        /// Converts a string to its corresponding ChargingSystem of Product.
        /// </summary>
        /// <param name="chargingSystemString">The string representing a ChargingSystems.</param>
        /// <returns>The ChargingSystem corresponding to the given string.</returns>
        public static ChargingSystem GetStringAsQualityStatus(string chargingSystemString)
        {
            if (string.IsNullOrEmpty(chargingSystemString))
            {
                throw new ArgumentNullException(nameof(chargingSystemString), "Charging System string cannot be null or empty.");
            }

            switch (chargingSystemString)
            {
                case "Three Step Charge":
                    return ChargingSystem.ThreeStepCharge;
                case "Current Constant and Limit Current":
                    return ChargingSystem.CurrentConstantAndLimitCurrent;
                case "Unknown":
                    return ChargingSystem.Unknown;
                case "Error":
                    return ChargingSystem.Error;
                default:
                    throw new ArgumentException($"Unknown quality string: {chargingSystemString}", nameof(chargingSystemString));
            }
        }
    }
}
