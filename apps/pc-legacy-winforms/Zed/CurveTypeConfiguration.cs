using System.Collections.Generic;
using ZedGraph;

namespace TESTBAG.Zed
{
    public static class CurveTypeConfiguration
    {
        public static readonly CurveType[] DcCurveTypes = { CurveType.VoltageDc, CurveType.MovingAverageVoltageDc, CurveType.CurrentDc };
        public static readonly CurveType[] AcCurveTypes = { CurveType.VoltageAc, CurveType.CurrentAc };
        public static readonly CurveType[] LowChargeMinMaxTypes = { CurveType.MinValueLowCharge, CurveType.MaxValueLowCharge };
        public static readonly CurveType[] HighChargeMinMaxTypes = { CurveType.MinValueHighCharge, CurveType.MaxValueHighCharge };
        public static readonly CurveType[] CurrentConstantMinMaxTypes = { CurveType.MinValueCurrentConstant, CurveType.MaxValueCurrentConstant };
        public static readonly CurveType[] LowCutOffMinMaxTypes = { CurveType.MinValueCutOff, CurveType.MaxValueCutOff };

        public static readonly PointPairType[] DcPointTypes = { PointPairType.VoltageDcPoint, PointPairType.MovingAverageVoltageDcPoint, PointPairType.CurrentDcPoint };
        public static readonly PointPairType[] AcPointTypes = { PointPairType.VoltageAcPoint, PointPairType.CurrentAcPoint };
        public static readonly PointPairType[] LowChargeMinMaxPointTypes = { PointPairType.MinValueLowChargePoint, PointPairType.MaxValueLowChargePoint };
        public static readonly PointPairType[] HighChargeMinMaxPointTypes = { PointPairType.MinValueHighChargePoint, PointPairType.MaxValueHighChargePoint };
        public static readonly PointPairType[] CurrentConstantMinMaxPointTypes = { PointPairType.MinValueCurrentConstantPoint, PointPairType.MaxValueCurrentConstantPoint };
        public static readonly PointPairType[] LowCutOffMinMaxPointTypes = { PointPairType.MinValueCutOffPoint, PointPairType.MaxValueCutOffPoint };

        public static Dictionary<CurveType, RollingPointPairList> ResetToApplicationSettings()
        {
            return new Dictionary<CurveType, RollingPointPairList>
            {
                { CurveType.VoltageDc, new RollingPointPairList(Properties.Settings.Default.RollingSize_VoltageDc) },
                { CurveType.MovingAverageVoltageDc , new RollingPointPairList(Properties.Settings.Default.RollingSize_MovingAverageVoltageDc) },
                { CurveType.CurrentDc , new RollingPointPairList(Properties.Settings.Default.RollingSize_CurrentDc) },

                { CurveType.VoltageAc , new RollingPointPairList(Properties.Settings.Default.RollingSize_VoltageAc) },
                { CurveType.CurrentAc , new RollingPointPairList(Properties.Settings.Default.RollingSize_CurrentAc) },

                { CurveType.MaxValueLowCharge , new RollingPointPairList(Properties.Settings.Default.RollingSize_MaxValueLowCharge) },
                { CurveType.MinValueLowCharge , new RollingPointPairList(Properties.Settings.Default.RollingSize_MinValueLowCharge) },

                { CurveType.MaxValueHighCharge , new RollingPointPairList(Properties.Settings.Default.RollingSize_MaxValueHighCharge) },
                { CurveType.MinValueHighCharge , new RollingPointPairList(Properties.Settings.Default.RollingSize_MinValueHighCharge) },

                { CurveType.MaxValueCurrentConstant , new RollingPointPairList(Properties.Settings.Default.RollingSize_MaxValueCurrentConstant) },
                { CurveType.MinValueCurrentConstant , new RollingPointPairList(Properties.Settings.Default.RollingSize_MinValueCurrentConstant) },

                { CurveType.MaxValueCutOff , new RollingPointPairList(Properties.Settings.Default.RollingSize_MaxValueCutOff) },
                { CurveType.MinValueCutOff , new RollingPointPairList(Properties.Settings.Default.RollingSize_MinValueCutOff) }
            };
        }

        public static Dictionary<PointPairType, PointPairList> ResetPointPair()
        {
            return new Dictionary<PointPairType, PointPairList>
            {
                { PointPairType.VoltageDcPoint, new PointPairList() },
                { PointPairType.MovingAverageVoltageDcPoint , new PointPairList() },
                { PointPairType.CurrentDcPoint , new PointPairList() },

                { PointPairType.VoltageAcPoint , new PointPairList() },
                { PointPairType.CurrentAcPoint , new PointPairList() },

                { PointPairType.MaxValueLowChargePoint , new PointPairList() },
                { PointPairType.MinValueLowChargePoint , new PointPairList() },

                { PointPairType.MaxValueHighChargePoint , new PointPairList() },
                { PointPairType.MinValueHighChargePoint , new PointPairList () },

                { PointPairType.MaxValueCurrentConstantPoint , new PointPairList () },
                { PointPairType.MinValueCurrentConstantPoint , new PointPairList () },

                { PointPairType.MaxValueCutOffPoint , new PointPairList () },
                { PointPairType.MinValueCutOffPoint , new PointPairList () }
            };
        }
    }
}
