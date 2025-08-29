using System.Collections.Generic;
using System.Drawing;
using ZedGraph;

namespace TESTBAG.Zed
{
    public class CurveConfigurationFactory
    {
        /// <summary>
        /// Configuration of the User Interface of the Graph
        /// </summary>
        /// <returns></returns>
        public static List<CurveConfiguration> GetCurveConfigurations()
        {
            return new List<CurveConfiguration>
            {
                new CurveConfiguration { Type = CurveType.VoltageDc, Label = "Voltage (V)", Color = Color.Blue, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false },
                new CurveConfiguration { Type = CurveType.MovingAverageVoltageDc, Label = "Moving Average Voltage (V)", Color = Color.Red, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false},
                new CurveConfiguration { Type = CurveType.CurrentDc, Label = "Current (I)", Color = Color.Green, SymbolType = SymbolType.None, YAxisIndex = 1 ,LineWidth = 3 ,IsY2Axis  = true},

                new CurveConfiguration { Type = CurveType.MaxValueLowCharge, Label = "Max Low Charge (V)", Color = Color.Orange, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 } ,IsY2Axis  = false}, // ต่อ
                new CurveConfiguration { Type = CurveType.MinValueLowCharge, Label = "Min Low Charge (V)", Color = Color.Orange, SymbolType = SymbolType.None, YAxisIndex = 0,LineWidth = 3, DashPattern = new float[] { 4, 2 } , IsY2Axis = false}, // ต่อ

                new CurveConfiguration { Type = CurveType.MaxValueHighCharge, Label = "Max High Charge (V)", Color = Color.Purple, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด
                new CurveConfiguration { Type = CurveType.MinValueHighCharge, Label = "Min High Charge (V)", Color = Color.Purple, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด

                new CurveConfiguration { Type = CurveType.MaxValueCurrentConstant, Label = "Max Current Constant Charge (V)", Color = Color.Magenta, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } ,IsY2Axis  = false},
                new CurveConfiguration { Type = CurveType.MinValueCurrentConstant, Label = "Min Current Constant Charge (V)", Color = Color.Magenta, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } , IsY2Axis = false},

                new CurveConfiguration { Type = CurveType.MaxValueCutOff, Label = "Max Cut-Off (V)", Color = Color.DarkCyan, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false},
                new CurveConfiguration { Type = CurveType.MinValueCutOff, Label = "Min Cut-Off (V)", Color = Color.DarkCyan, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false}
            };
        }
        public static List<CurveConfiguration> UpdateCurveConfigurations()
        {
            return new List<CurveConfiguration>
            {
                new CurveConfiguration { Type = CurveType.VoltageDc, Label = "Voltage (V)", Color = Color.Blue, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false },
                new CurveConfiguration { Type = CurveType.MovingAverageVoltageDc, Label = "Moving Average Voltage (V)", Color = Color.Red, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false},
                new CurveConfiguration { Type = CurveType.CurrentDc, Label = "Current (I)", Color = Color.Green, SymbolType = SymbolType.None, YAxisIndex = 1 ,LineWidth = 3 ,IsY2Axis  = true},

                new CurveConfiguration { Type = CurveType.MaxValueLowCharge, Label = "", Color = Color.Orange, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 } ,IsY2Axis  = false}, // ต่อ
                new CurveConfiguration { Type = CurveType.MinValueLowCharge, Label = "", Color = Color.Orange, SymbolType = SymbolType.None, YAxisIndex = 0,LineWidth = 3, DashPattern = new float[] { 4, 2 } , IsY2Axis = false}, // ต่อ

                new CurveConfiguration { Type = CurveType.MaxValueHighCharge, Label = "", Color = Color.Purple, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด
                new CurveConfiguration { Type = CurveType.MinValueHighCharge, Label = "", Color = Color.Purple, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด

                new CurveConfiguration { Type = CurveType.MaxValueCurrentConstant, Label = "", Color = Color.Magenta, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } ,IsY2Axis  = false},
                new CurveConfiguration { Type = CurveType.MinValueCurrentConstant, Label = "", Color = Color.Magenta, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } , IsY2Axis = false},

                new CurveConfiguration { Type = CurveType.MaxValueCutOff, Label = "", Color = Color.DarkCyan, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false},
                new CurveConfiguration { Type = CurveType.MinValueCutOff, Label = "", Color = Color.DarkCyan, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false}
            };
        }
        public static List<CurveConfiguration> VirsualBatteryConfiguration()
        {
            return new List<CurveConfiguration>
            {
                new CurveConfiguration { Type = CurveType.VoltageDc, Label = "Voltage (V)", Color = Color.Blue, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false },
                new CurveConfiguration { Type = CurveType.MovingAverageVoltageDc, Label = "Moving Average Voltage (V)", Color = Color.Red, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false},
                new CurveConfiguration { Type = CurveType.CurrentDc, Label = "", Color = Color.Green, SymbolType = SymbolType.None, YAxisIndex = 1 ,LineWidth = 3 ,IsY2Axis  = true},

                new CurveConfiguration { Type = CurveType.MaxValueLowCharge, Label = "", Color = Color.Orange, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 } ,IsY2Axis  = false}, // ต่อ
                new CurveConfiguration { Type = CurveType.MinValueLowCharge, Label = "", Color = Color.Orange, SymbolType = SymbolType.None, YAxisIndex = 0,LineWidth = 3, DashPattern = new float[] { 4, 2 } , IsY2Axis = false}, // ต่อ

                new CurveConfiguration { Type = CurveType.MaxValueHighCharge, Label = "", Color = Color.Purple, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด
                new CurveConfiguration { Type = CurveType.MinValueHighCharge, Label = "", Color = Color.Purple, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด

                new CurveConfiguration { Type = CurveType.MaxValueCurrentConstant, Label = "", Color = Color.Magenta, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } ,IsY2Axis  = false},
                new CurveConfiguration { Type = CurveType.MinValueCurrentConstant, Label = "", Color = Color.Magenta, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } , IsY2Axis = false},

                new CurveConfiguration { Type = CurveType.MaxValueCutOff, Label = "", Color = Color.DarkCyan, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false},
                new CurveConfiguration { Type = CurveType.MinValueCutOff, Label = "", Color = Color.DarkCyan, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false}
            };
        }
        public static List<CurveConfiguration> GetPointPairConfigurations()
        {
            return new List<CurveConfiguration>()
            {
                new CurveConfiguration { PointType = PointPairType.VoltageDcPoint, Label = "Voltage (V)", Color = Color.Blue, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3 ,IsY2Axis  = false},
                new CurveConfiguration { PointType = PointPairType.MovingAverageVoltageDcPoint, Label = "Moving Average Voltage (V)", Color = Color.Red, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false},
                new CurveConfiguration { PointType = PointPairType.CurrentDcPoint, Label = "Current (I)", Color = Color.Green, SymbolType = SymbolType.None, YAxisIndex = 1 ,LineWidth = 3 ,IsY2Axis  = true},

                new CurveConfiguration { PointType = PointPairType.MaxValueLowChargePoint, Label = "Max Low Charge (V)", Color = Color.Black, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ต่อ
                new CurveConfiguration { PointType = PointPairType.MinValueLowChargePoint, Label = "Min Low Charge (V)", Color = Color.Bisque, SymbolType = SymbolType.None, YAxisIndex = 0,LineWidth = 3, DashPattern = new float[] { 4, 2 } , IsY2Axis = false}, // ต่อ

                new CurveConfiguration { PointType = PointPairType.MaxValueHighChargePoint, Label = "Max High Charge (V)", Color = Color.Black, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด
                new CurveConfiguration { PointType = PointPairType.MinValueHighChargePoint, Label = "Min High Charge (V)", Color = Color.Bisque, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, DashPattern = new float[] { 4, 2 }, IsY2Axis = false}, // ตัด

                new CurveConfiguration { PointType = PointPairType.MaxValueCurrentConstantPoint, Label = "Max Current Constant Charge (V)", Color = Color.Green, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } , IsY2Axis = false},
                new CurveConfiguration { PointType = PointPairType.MinValueCurrentConstantPoint, Label = "Min Current Constant Charge (V)", Color = Color.Green, SymbolType = SymbolType.None,LineWidth = 3, YAxisIndex = 0, DashPattern = new float[] { 4, 2 } , IsY2Axis = false},

                new CurveConfiguration { PointType = PointPairType.MaxValueCutOffPoint, Label = "Max Cut-Off (V)", Color = Color.Green, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false},
                new CurveConfiguration { PointType = PointPairType.MinValueCutOffPoint, Label = "Min Cut-Off (V)", Color = Color.Green, SymbolType = SymbolType.None, YAxisIndex = 0 ,LineWidth = 3, IsY2Axis = false},
            };
        }

        public static TextObj CreateHigh(double x, double y)
        {
            return new TextObj("High(ตัด)", x, y, CoordType.ChartFraction);
        }

        public static TextObj CreateLow(double x, double y)
        {
            return new TextObj("Low(ต่อ)", x, y, CoordType.ChartFraction);
        }
        public static TextObj CreateDisChargeToLowCutOff(double x, double y)
        {
            return new TextObj("Low(ต่อ)", x, y, CoordType.ChartFraction);
        }
        public static TextObj CreateLowCutOff(double x, double y)
        {
            return new TextObj("Low Cut Off", x, y, CoordType.ChartFraction);
        }
    }
}