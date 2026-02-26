using System;
using TESTBAG.ProductQuality;

namespace TESTBAG.Log
{
    public static class QualityDescription
    {
        /// <summary>
        /// Returns a string representation of the given CheckQualityStatus.
        /// </summary>
        /// <param name="quality">The CheckQualityStatus to convert to a string.</param>
        /// <param name="previousStatus">The previous CheckQualityStatus, used when the current status is SkipAutoCheck.</param>
        /// <returns>A string representing the CheckQualityStatus.</returns>
        public static string GetQualityString(CheckQualityStatus quality)
        {
            switch (quality)
            {
                case CheckQualityStatus.Good:
                    return "GOOD";
                case CheckQualityStatus.NG:
                    return "NG";
                case CheckQualityStatus.NotChecked:
                    return "Not Check";
                default:
                    throw new ArgumentOutOfRangeException(nameof(quality), quality, "Unknown Quality Status value.");
            }
        }

        /// <summary>
        /// Converts a string to its corresponding CheckQualityStatus.
        /// </summary>
        /// <param name="qualityString">The string representing a CheckQualityStatus.</param>
        /// <returns>The CheckQualityStatus corresponding to the given string.</returns>
        public static CheckQualityStatus GetStringAsQualityStatus(string qualityString)
        {
            if (string.IsNullOrEmpty(qualityString))
            {
                throw new ArgumentNullException(nameof(qualityString), "Quality string cannot be null or empty.");
            }

            switch (qualityString)
            {
                case "GOOD":
                    return CheckQualityStatus.Good;
                case "NG":
                    return CheckQualityStatus.NG;
                case "Not Check":
                    return CheckQualityStatus.NotChecked;
                default:
                    throw new ArgumentException($"Unknown quality string: {qualityString}", nameof(qualityString));
            }
        }
    }
}