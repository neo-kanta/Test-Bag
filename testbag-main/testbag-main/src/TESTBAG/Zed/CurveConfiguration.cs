using System.Drawing;
using ZedGraph;

namespace TESTBAG.Zed
{
    public class CurveConfiguration
    {
        public CurveType Type { get; set; }
        public PointPairType PointType { get; set; }
        public string Label { get; set; }
        public bool LabelVisible { get; set; }
        public bool IsY2Axis { get; set; }
        public Color Color { get; set; }
        public SymbolType SymbolType { get; set; }
        public int YAxisIndex { get; set; }
        public float LineWidth { get; set; } = 3;
        public float[] DashPattern { get; set; } = null;
        public bool IsSmooth { get; set; } = false;
        public float FillAlpha { get; set; } = 1.0f;
        public Color FillColor { get; set; } = Color.Transparent;
        public TextObj TextObj { get; set; }
        public LineItem lineItem{get; set;}
    }
}