using System.Threading.Tasks;

namespace TESTBAG.Zed
{
    public interface IZedGraphManager
    {
        void ConfigureGraph();
        void Plot(CurveType type, double x, double y, bool refreshGraph = true);
        Task PlotGroupAsync(CurveType[] curveTypes, double x, double[] y, bool refreshGraph = true);
        void ClearCurve(CurveType type, bool refreshGraph = true);
        void ClearGroup(CurveType[] curveTypes, bool refreshGraph = true);
        void ClearEntireCurve();
        void Clear();
    }
}
