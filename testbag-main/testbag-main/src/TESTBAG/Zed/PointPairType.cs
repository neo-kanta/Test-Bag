namespace TESTBAG.Zed
{
    public enum PointPairType
    {
        VoltageDcPoint,
        MovingAverageVoltageDcPoint,
        CurrentDcPoint,

        VoltageAcPoint,
        CurrentAcPoint,

        MaxValueLowChargePoint,
        MinValueLowChargePoint,

        MaxValueHighChargePoint,
        MinValueHighChargePoint,

        MaxValueCurrentConstantPoint,
        MinValueCurrentConstantPoint,

        MaxValueCutOffPoint,
        MinValueCutOffPoint
    }
}
