namespace TESTBAG.Zed
{
    public enum CurveType
    {
        VoltageDc,
        MovingAverageVoltageDc,
        CurrentDc,

        VoltageAc,
        CurrentAc,

        MaxValueLowCharge,
        MinValueLowCharge,

        MaxValueHighCharge,
        MinValueHighCharge,

        MaxValueCurrentConstant,
        MinValueCurrentConstant,

        MaxValueCutOff,
        MinValueCutOff
    }
}
