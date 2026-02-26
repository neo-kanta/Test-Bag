using System;
using System.Collections.Generic;

namespace TESTBAG
{
    public static class Calculation
    {
        public static double DerivativeVoltage(double currentVoltage, double previousVoltage, double currentTime, double previousTime)
        {
            var timeDifference = currentTime - previousTime;
            if (Math.Abs(timeDifference) < double.Epsilon)
            {
                return 0;
            }

            var voltageDifference = currentVoltage - previousVoltage;
            return voltageDifference / timeDifference;
        }

        public static double CalculateWeightedMovingAverage(IReadOnlyList<double> values, IReadOnlyList<double> weights)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            if (weights == null) throw new ArgumentNullException(nameof(weights));
            if (values.Count != weights.Count)
            {
                throw new ArgumentException("Values and weights lists must have the same number of elements.");
            }

            double weightedSum = 0;
            double weightSum = 0;
            for (var i = 0; i < values.Count; i++)
            {
                weightedSum += values[i] * weights[i];
                weightSum += weights[i];
            }

            if (Math.Abs(weightSum) < double.Epsilon)
            {
                throw new DivideByZeroException("The sum of weights must not be zero.");
            }

            return weightedSum / weightSum;
        }

        public static double CalculateStateOfCharge(double voltage, double minVoltage, double maxVoltage)
        {
            var range = maxVoltage - minVoltage;
            if (Math.Abs(range) < double.Epsilon)
            {
                return 0;
            }

            return (voltage - minVoltage) / range;
        }

        public static double CalculateCapacity(double current, double time)
        {
            return current * time;
        }

        public static double CalculateEnergy(double voltage, double current, double time)
        {
            return voltage * current * time;
        }
    }
}
