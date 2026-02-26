using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Protocol
{
    public class Calibration
    {
        public float AdcReadingVoltage { get; set; }
        public float Voltage { get; set; }
        public float AdcReadingCurrent { get; set; }
        public float Current { get; set; }
        private float[] adcReadings;
        private float[] voltages;
        private int numPoints;

        public Calibration(float[] adcReadings, float[] voltages)
        {
            this.adcReadings = adcReadings;
            this.voltages = voltages;
            this.numPoints = adcReadings.Length;
        }

        private Calibration calibration;

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    var (adcReadings, voltages) = ReadCalibrationData();

        //    calibration = new Calibration(adcReadings, voltages);
        //}

        public double InterpolateAdc(double adcReading)
        {
            int index = Array.FindIndex(adcReadings, x => x > adcReading);

            if (index == 0)
            {
                return voltages[0];
            }
            else if (index == -1)
            {
                return voltages[numPoints - 1];
            }

            double x1 = adcReadings[index - 1];
            double x2 = adcReadings[index];
            double y1 = voltages[index - 1];
            double y2 = voltages[index];
            double interpolatedVoltage = y1 + ((adcReading - x1) * (y2 - y1) / (x2 - x1));

            return interpolatedVoltage;
        }
        //public (float[] adcReadingsVoltage, float[] voltages, float[] adcReadingsCurrent, float[] currents) ReadCalibrationData()
        //{
        //    using (var context = new Entities())
        //    {
        //        var calibrationData = context.CalibrationData.OrderBy(c => c.Id).ToList();

        //        var adcReadingsVoltage = calibrationData.Select(c => c.AdcReadingVoltage).ToArray();
        //        var voltages = calibrationData.Select(c => c.Voltage).ToArray();
        //        var adcReadingsCurrent = calibrationData.Select(c => c.AdcReadingCurrent).ToArray();
        //        var currents = calibrationData.Select(c => c.Current).ToArray();

        //        return (adcReadingsVoltage, voltages, adcReadingsCurrent, currents);
        //    }
        //}

    }
}