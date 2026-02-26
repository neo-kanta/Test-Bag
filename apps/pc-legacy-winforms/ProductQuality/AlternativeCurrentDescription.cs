using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTBAG.ProductQuality
{
    public static class AlternativeCurrentDescription
    {
        public static string GetString(AlternativeCurrentState stage)
        {
            switch (stage)
            {
                case AlternativeCurrentState.ON:
                    return "ON";
                case AlternativeCurrentState.OFF:
                    return "OFF";
                case AlternativeCurrentState.Error:
                    return "Error";
                default:
                    throw new ArgumentOutOfRangeException(nameof(stage), stage, "Unknown AC State value.");
            }
        }

        public static AlternativeCurrentState GetState(string alternativeString)
        {
            if (string.IsNullOrEmpty(alternativeString))
            {
                throw new ArgumentNullException(nameof(alternativeString), "Quality string cannot be null or empty.");
            }

            switch (alternativeString)
            {
                case "ON":
                    return AlternativeCurrentState.ON;
                case "OFF":
                    return AlternativeCurrentState.OFF;
                case "Error":
                    return AlternativeCurrentState.Error;
                default:
                    throw new ArgumentException($"Unknown quality string: {alternativeString}", nameof(alternativeString));
            }
        }
    }
}
