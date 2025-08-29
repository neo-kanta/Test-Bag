using System;

namespace TESTBAG.ProductQuality
{

    public static class ChargingStageDescriptions
    {
        /// <summary>
        /// Gets the string representation of the ChargingStage enum value.
        /// </summary>
        /// <param name="stage">The ChargingStage enum value.</param>
        /// <returns>The string representation of the ChargingStage enum value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the stage value is not recognized.</exception>
        public static string GetString(ChargingState stage)
        {
            switch (stage)
            {
                case ChargingState.Charge:
                    return "Charge";
                case ChargingState.Float:
                    return "Float";
                case ChargingState.Discharge:
                    return "Discharge";
                case ChargingState.LowVoltageCutOff:
                    return "LowVoltageCutOff";
                case ChargingState.Checking:
                    return "Checking";
                case ChargingState.OutOfRange:
                    return "OutOfRange";
                default:
                    throw new ArgumentOutOfRangeException(nameof(stage), stage, "Unknown ChargingStage value.");
            }
        }
    }
}