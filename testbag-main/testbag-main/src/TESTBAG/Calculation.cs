using System;
using System.Collections.Generic;

namespace TESTBAG
{
    public class Calculation
    {
        public static double DerivativeVoltage(double currentVoltage, double previousVoltage, double currentTime, double previousTime)
        {
            if (Math.Abs(currentTime - previousTime) < double.Epsilon)
            {
                return 0;
            }

            double timeDifference = currentTime - previousTime;
            double voltageDifference = currentVoltage - previousVoltage;
            double derivative = voltageDifference / timeDifference;
            return derivative;
        }
        public static double CalculateWeightedMovingAverage(List<double> values, List<double> weights)
        {
            if (values.Count != weights.Count)
            {
                throw new ArgumentException("Values and weights lists must have the same number of elements.");
            }

            double weightedSum = 0;
            double weightSum = 0;

            for (int i = 0; i < values.Count; i++)
            {
                weightedSum += values[i] * weights[i];
                weightSum += weights[i];
            }

            double weightedMovingAverage = weightedSum / weightSum;
            return weightedMovingAverage;
        }
        public static double CalculateStateOfCharge(double voltage, double minVoltage, double maxVoltage)
        {
            return (voltage - minVoltage) / (maxVoltage - minVoltage);
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