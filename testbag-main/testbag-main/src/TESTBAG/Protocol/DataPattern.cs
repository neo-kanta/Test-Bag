using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TESTBAG.Protocol
{
    public class DataPattern
    {
        private readonly frmMain _mainDesk;
        public DataPattern(frmMain mainDesk)
        {
            this._mainDesk = mainDesk ?? throw new ArgumentNullException(nameof(DataPattern._mainDesk));
        }
        public static (double currentDc, double voltageDc, double currentAc, double voltageAc, bool success) GetDataNano(string nanoData)
        {
            Match matchNano = Regex.Match(nanoData, @"CurrentDc : (\d+) A\|VoltageDc : (\d+) V\|CurrentAc (\d+\.\d+) A\|VoltageAc (\d+\.\d+)V");
            if (matchNano.Success)
            {
                double acsCurrent = double.Parse(matchNano.Groups[1].Value);
                double sensorVoltage = double.Parse(matchNano.Groups[2].Value);
                double pzemCurrent = double.Parse(matchNano.Groups[3].Value);
                double pzemVoltage = double.Parse(matchNano.Groups[4].Value);
                return (acsCurrent, sensorVoltage, pzemCurrent, pzemVoltage, true);
            }
            else { return (0.0, 0.0, 0.0, 0.0, false); }
        }

        public static (double currentDc, double voltageDc, double currentAc, double voltageAc, bool success) GetDataEsp(string espData)
        {
            Match matchEsp = Regex.Match(espData, @"DC(\d+)A\|DC(\d+)V\|AC(\d+\.\d+)A\|AC(\d+\.\d+)V");
            if (matchEsp.Success)
            {
                double acsCurrent = double.Parse(matchEsp.Groups[1].Value);
                double sensorVoltage = double.Parse(matchEsp.Groups[2].Value);
                double pzemCurrent = double.Parse(matchEsp.Groups[3].Value);
                double pzemVoltage = double.Parse(matchEsp.Groups[4].Value);
                return (acsCurrent, sensorVoltage, pzemCurrent, pzemVoltage, true);
            }
            else { return (0.0, 0.0, 0.0, 0.0, false); }
        }
        public static (double minCon, double maxCon, double meanCon, bool success) GetMinMaxMean(string minmaxData, string meanData)
        {
            Match matchMinMax = Regex.Match(minmaxData, @"(\d+\.\d+|\d+) - (\d+\.\d+|\d+)");
            Match matchMean = Regex.Match(meanData, @"(\d+\.\d+|\d+)");
            if (matchMinMax.Success && matchMean.Success)
            {
                double min = double.Parse(matchMinMax.Groups[1].Value);
                double max = double.Parse(matchMinMax.Groups[2].Value);
                double mean = double.Parse(matchMean.Groups[1].Value);
                bool matchSuccess = true;
                return (min, max, mean, matchSuccess);
            }
            else { return (0.0, 0.0, 0.0, false); }
        }
        public static string GetStageReg(string stage)
        {
            string chargeSystem = string.Empty;
            bool hasConstantCharge = false;
            bool hasThreeStepCharge = false;

            foreach (Match match in Regex.Matches
                (stage, @"(?:^|\s*,\s*)(Voltage Charger \(CC\)|Voltage Charger \(Connect\)|Voltage Charger \(Cut\)|Low Voltage Cut-Off)(?=\s*,|\s*$)"))
            {
                if (match.Value == "Voltage Charger (CC)" || match.Value == "Low Voltage Cut-Off") { hasConstantCharge = true; }
                else if (match.Value == "Voltage Charger (Low)" || match.Value == "Voltage Charger (High)" || match.Value == "Low Voltage Cut-Off")
                { hasThreeStepCharge = true; }
            }
            if (hasThreeStepCharge && !hasConstantCharge)
                throw new ArgumentNullException($"Don't have constant voltage and limit current charging system");

            if (hasConstantCharge && !hasThreeStepCharge)
                throw new ArgumentException($"Don't have 3 Steps Charging System");

            //if (hasThreeStepCharge && !hasConstantCharge) { chargeSystem = "Don't have constant voltage and limit current charging system"; }
            //else if (hasConstantCharge && !hasThreeStepCharge) { chargeSystem = "Don't have 3 Steps Charging System"; }
            //else
            //{
            //    MessageBox.Show("Cannot find the specifications of the product data", caption: "Cannot match the data",
            //        MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            //}
            return chargeSystem;
        }

        public static (string minmaxCon, string meanCon, string minmaxCut, string meanCut, string minmaxConst, string meanConst, string minmaxOff, string meanOff)
            GetSpecValue(string min, string max, string mean)
        {
            Match matchMinValue = Regex.Match(min, @"(\d+\.\d+|\d+),(\d+\.\d+|\d+),(\d+\.\d+|\d+)");
            Match matchMaxValue = Regex.Match(max, @"(\d+\.\d+|\d+),(\d+\.\d+|\d+),(\d+\.\d+|\d+)");
            Match matchMeanValue = Regex.Match(mean, @"(\d+\.\d+|\d+),(\d+\.\d+|\d+),(\d+\.\d+|\d+)");

            if (matchMinValue.Groups.Count == 4 && matchMaxValue.Groups.Count == 4 && matchMeanValue.Groups.Count == 4)
            {
                if (matchMinValue.Success && matchMaxValue.Success && matchMeanValue.Success)
                {
                    string conMinMax = $"{matchMinValue.Groups[1]} - {matchMaxValue.Groups[1]}";
                    string conMean = matchMeanValue.Groups[1].Value.ToString();
                    string cutMinMax = $"{matchMinValue.Groups[2]} - {matchMaxValue.Groups[2]}";
                    string cutMean = matchMeanValue.Groups[2].ToString();
                    string offMinMax = $"{matchMinValue.Groups[3]} - {matchMaxValue.Groups[3]}";
                    string offMean = matchMeanValue.Groups[3].ToString();
                    string[] constCurrent = new string[2] { "-", "-" };
                    return (conMinMax, conMean, cutMinMax, cutMean, constCurrent[0], constCurrent[1], offMinMax, offMean);
                }
                else { return ("-", "-", "-", "-", "-", "-", "-", "-"); }
            }
            else if (matchMinValue.Groups.Count == 1 && matchMaxValue.Groups.Count == 1 && matchMeanValue.Groups.Count == 1)
            {
                Match matchMinCurrentConstantTypeValue = Regex.Match(min, @"(\d+\.\d+|\d+),(\d+\.\d+|\d+)");
                Match matchMaxCurrentConstantTypeValue = Regex.Match(max, @"(\d+\.\d+|\d+),(\d+\.\d+|\d+)");
                Match matchMeanCurrentConstantTypeTwoValue = Regex.Match(mean, @"(\d+\.\d+|\d+),(\d+\.\d+|\d+)");
                if (matchMinValue.Success && matchMaxValue.Success && matchMeanValue.Success)
                {
                    string constMinMax = $"{matchMinCurrentConstantTypeValue.Groups[1]} - {matchMaxCurrentConstantTypeValue.Groups[1]}";
                    string constMean = matchMeanCurrentConstantTypeTwoValue.Groups[1].Value.ToString();
                    string offMinMax = $"{matchMinCurrentConstantTypeValue.Groups[2]} - {matchMaxCurrentConstantTypeValue.Groups[2]}";
                    string offMean = matchMeanCurrentConstantTypeTwoValue.Groups[2].ToString();
                    string[] threeStep = new string[4] { "-", "-", "-", "-" };
                    return (threeStep[0], threeStep[1], threeStep[2], threeStep[4], constMinMax, constMean, offMinMax, offMean);
                }
                else { return ("-", "-", "-", "-", "-", "-", "-", "-"); }
            }
            else { return ("-", "-", "-", "-", "-", "-", "-", "-"); }
        }
    }
}
