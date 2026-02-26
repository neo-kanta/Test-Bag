using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTBAG.ProductQuality;
using ZedGraph;

namespace TESTBAG.Zed
{
    public class ZedGraphManager : IZedGraphManager
    {
        private readonly ZedGraphControl _zedGraphControl;
        private readonly Dictionary<CurveType, RollingPointPairList> _rollingPointPairLists;
        private readonly Dictionary<PointPairType, PointPairList> _pointPairLists;

        public ZedGraphManager(ZedGraphControl zedGraphControl)
        {
            _zedGraphControl = zedGraphControl ?? throw new ArgumentNullException(nameof(zedGraphControl));
            _rollingPointPairLists = CurveTypeConfiguration.ResetToApplicationSettings();
            _pointPairLists = CurveTypeConfiguration.ResetPointPair();
        }
        public void ConfigureGraph()
        {
            var zedPane = _zedGraphControl.GraphPane;
            zedPane.Title.Text = "IV-Curve";
            zedPane.XAxis.Title.Text = "Time (seconds)";
            zedPane.YAxis.Title.Text = "Voltage (V)";
            zedPane.Y2Axis.Title.Text = "Current (I)";
            zedPane.XAxis.Scale.MaxAuto = true;
            zedPane.Y2AxisList[0].IsVisible = true;

            zedPane.XAxis.MajorGrid.IsVisible = true;
            zedPane.XAxis.MajorGrid.DashOn = 10;
            zedPane.XAxis.MajorGrid.DashOff = 5;
            zedPane.XAxis.MajorGrid.Color = Color.LightGray;

            // Setting up Y Axis grid
            zedPane.YAxis.MajorGrid.IsVisible = true;
            zedPane.YAxis.MajorGrid.DashOn = 10;
            zedPane.YAxis.MajorGrid.DashOff = 5;
            zedPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Setting up Second Y Axis grid
            zedPane.YAxis.MajorGrid.IsVisible = true;
            zedPane.YAxis.MajorGrid.DashOn = 10;
            zedPane.YAxis.MajorGrid.DashOff = 5;
            zedPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Optionally - Minor Grid
            zedPane.XAxis.MinorGrid.IsVisible = true;
            zedPane.XAxis.MinorGrid.DashOn = 1;
            zedPane.XAxis.MinorGrid.DashOff = 2;
            zedPane.XAxis.MinorGrid.Color = Color.LightGray;

            zedPane.YAxis.MinorGrid.IsVisible = true;
            zedPane.YAxis.MinorGrid.DashOn = 1;
            zedPane.YAxis.MinorGrid.DashOff = 2;
            zedPane.YAxis.MinorGrid.Color = Color.LightGray;


            ConfigureCurves(zedPane);

            zedPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(247, 245, 244), 45F);
            zedPane.Fill = new Fill(Color.White, Color.FromArgb(247, 245, 244), 45F);
        }
        public void UpdateConfigureGraph()
        {
            var zedPane = _zedGraphControl.GraphPane;
            zedPane.Title.Text = "IV-Curve";
            zedPane.XAxis.Title.Text = "Time (seconds)";
            zedPane.YAxis.Title.Text = "Voltage (V)";
            zedPane.Y2Axis.Title.Text = "Current (I)";
            zedPane.XAxis.Scale.MaxAuto = true;
            zedPane.Y2AxisList[0].IsVisible = true;

            zedPane.XAxis.MajorGrid.IsVisible = true;
            zedPane.XAxis.MajorGrid.DashOn = 10;
            zedPane.XAxis.MajorGrid.DashOff = 5;
            zedPane.XAxis.MajorGrid.Color = Color.LightGray;

            // Setting up Y Axis grid
            zedPane.YAxis.MajorGrid.IsVisible = true;
            zedPane.YAxis.MajorGrid.DashOn = 10;
            zedPane.YAxis.MajorGrid.DashOff = 5;
            zedPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Setting up Second Y Axis grid
            zedPane.YAxis.MajorGrid.IsVisible = true;
            zedPane.YAxis.MajorGrid.DashOn = 10;
            zedPane.YAxis.MajorGrid.DashOff = 5;
            zedPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Optionally - Minor Grid
            zedPane.XAxis.MinorGrid.IsVisible = true;
            zedPane.XAxis.MinorGrid.DashOn = 1;
            zedPane.XAxis.MinorGrid.DashOff = 2;
            zedPane.XAxis.MinorGrid.Color = Color.LightGray;

            zedPane.YAxis.MinorGrid.IsVisible = true;
            zedPane.YAxis.MinorGrid.DashOn = 1;
            zedPane.YAxis.MinorGrid.DashOff = 2;
            zedPane.YAxis.MinorGrid.Color = Color.LightGray;

            UpdateConfigureCurve(zedPane);

            zedPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(247, 245, 244), 45F);
            zedPane.Fill = new Fill(Color.White, Color.FromArgb(247, 245, 244), 45F);
        }
        public void ConfigureGraphPointPair()
        {
            var zedPane = _zedGraphControl.GraphPane;
            zedPane.Title.Text = "IV-Curve";
            zedPane.XAxis.Title.Text = "Time (seconds)";
            zedPane.YAxis.Title.Text = "Voltage (V)";
            zedPane.Y2Axis.Title.Text = "Current (I)";
            zedPane.XAxis.Scale.MaxAuto = true;
            zedPane.Y2AxisList[0].IsVisible = true;

            zedPane.XAxis.MajorGrid.IsVisible = true;
            zedPane.XAxis.MajorGrid.DashOn = 10;
            zedPane.XAxis.MajorGrid.DashOff = 5;
            zedPane.XAxis.MajorGrid.Color = Color.LightGray;

            // Setting up Y Axis grid
            zedPane.YAxis.MajorGrid.IsVisible = true;
            zedPane.YAxis.MajorGrid.DashOn = 10;
            zedPane.YAxis.MajorGrid.DashOff = 5;
            zedPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Setting up Second Y Axis grid
            zedPane.YAxis.MajorGrid.IsVisible = true;
            zedPane.YAxis.MajorGrid.DashOn = 10;
            zedPane.YAxis.MajorGrid.DashOff = 5;
            zedPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Optionally - Minor Grid
            zedPane.XAxis.MinorGrid.IsVisible = true;
            zedPane.XAxis.MinorGrid.DashOn = 1;
            zedPane.XAxis.MinorGrid.DashOff = 2;
            zedPane.XAxis.MinorGrid.Color = Color.LightGray;

            zedPane.YAxis.MinorGrid.IsVisible = true;
            zedPane.YAxis.MinorGrid.DashOn = 1;
            zedPane.YAxis.MinorGrid.DashOff = 2;
            zedPane.YAxis.MinorGrid.Color = Color.LightGray;

            ConfigurePointPair(zedPane);

            zedPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(247, 245, 244), 45F);
            zedPane.Fill = new Fill(Color.White, Color.FromArgb(247, 245, 244), 45F);
        }
        private static IEnumerable<CurveConfiguration> GetCurveConfigurations()
        {
            return CurveConfigurationFactory.GetCurveConfigurations();
        }
        private static IEnumerable<CurveConfiguration> GetPointPairConfigurations()
        {
            return CurveConfigurationFactory.GetPointPairConfigurations();
        }
        private static IEnumerable<CurveConfiguration> UpdateCurveConfigurations()
        {
            return CurveConfigurationFactory.UpdateCurveConfigurations();
        }
        private void ConfigureCurves(GraphPane zedPane)
        {
            foreach (var config in GetCurveConfigurations())
            {
                LineItem curve = zedPane.AddCurve(config.Label, GetRollingPointPairList(config.Type), config.Color, config.SymbolType);
                curve.Tag = config.Type;
                curve.YAxisIndex = config.YAxisIndex;
                curve.IsY2Axis = config.IsY2Axis ? true : false;
                curve.YAxisIndex = config.YAxisIndex;
                ConfigureCurveAppearance(curve);
            }
        }
        public void UpdateConfigureCurve(GraphPane zedPane)
        {
            foreach (var config in UpdateCurveConfigurations())
            {
                LineItem curve = zedPane.AddCurve(config.Label, GetRollingPointPairList(config.Type), config.Color, config.SymbolType);
                curve.Tag = config.Type;
                curve.YAxisIndex = config.YAxisIndex;
                curve.IsY2Axis = config.IsY2Axis ? true : false;
                curve.YAxisIndex = config.YAxisIndex;
                ConfigureCurveAppearance(curve);
            }
        }
        private void ConfigurePointPair(GraphPane zedPane)
        {
            foreach (var config in GetPointPairConfigurations())
            {
                var curve = zedPane.AddCurve(config.Label, GetPointPair(config.PointType), config.Color, config.SymbolType);
                curve.YAxisIndex = config.YAxisIndex;
                curve.IsY2Axis = config.IsY2Axis;
                curve.Tag = config.Type;
                curve.YAxisIndex = config.YAxisIndex;
                ConfigureCurveAppearance(curve);
            }
        }
        private RollingPointPairList GetRollingPointPairList(CurveType type)
        {
            if (_rollingPointPairLists.TryGetValue(type, out var list))
            {
                return list;
            }

            throw new ArgumentOutOfRangeException(nameof(type), "Invalid curve type.");
        }
        private PointPairList GetPointPair(PointPairType type)
        {
            if (_pointPairLists.TryGetValue(type, out var list))
            {
                return list;
            }

            throw new ArgumentOutOfRangeException(nameof(type), "Invalid curve type.");
        }

        private static void ConfigureCurveAppearance(LineItem curve)
        {
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Line.Width = 3;
        }
        public void UpdateGroupRollingPointPairList(CurveType[] curveType, int newRollingSize)
        {
            for (int i = 0; i < curveType.Length; i++)
            {
                UpdateRollingPointPairList(curveType[i], newRollingSize);
            }
        }
        public void UpdateRollingPointPairList(CurveType curveType, int newRollingSize)
        {
            if (_rollingPointPairLists.ContainsKey(curveType))
            {
                _rollingPointPairLists[curveType] = new RollingPointPairList(newRollingSize);
            }
            else
            {
                throw new ArgumentException("Invalid CurveType provided.");
            }
        }
        public void Plot(CurveType type, double x, double y, bool refreshGraph = true)
        {
            GetRollingPointPairList(type).Add(x, y);
            if (refreshGraph)
            {
                RefreshGraph();
            }
        }
        public void PlotListData(CurveType[] type, List<Tuple<double, double[], bool>> plotData)
        {
            foreach (var data in plotData)
            {
                PlotGroup(type, data.Item1, data.Item2, data.Item3);
            }
        }
        public void PlotListSpecifications(CurveType[] type, List<Tuple<double>> plotData, double[] spec)
        {
            foreach (var data in plotData)
            {
                PlotGroup(type, data.Item1, spec, false);
            }
        }
        public async Task PlotPointPair(PointPairType point, double x, double y, bool refreshGraph = true)
        {
            await Task.Run(() =>
            {
                GetPointPair(point).Add(x, y);
                if (refreshGraph)
                {
                    RefreshGraph();
                }
            });
        }
        public void PlotGroup(CurveType[] curveTypes, double time, double[] yAxisData, bool refreshGraph = true)
        {


            for (int i = 0; i < curveTypes.Length; i++)
            {
                Plot(curveTypes[i], time, yAxisData[i], false);
            }

            if (refreshGraph)
            {
                RefreshGraph();
            }
        }
        public void PlotGroupBatch(CurveType[] curveTypes, List<(double time, double[] yAxisData)> dataBuffer, bool refreshGraph = true)
        {
            foreach (var data in dataBuffer)
            {
                double time = data.time;
                double[] yAxisData = data.yAxisData;
                for (int i = 0; i < curveTypes.Length; i++)
                {
                    Plot(curveTypes[i], time, yAxisData[i], false);
                }
            }

            if (refreshGraph)
            {
                RefreshGraph();
            }
        }

        public async Task PlotGroupAsync(CurveType[] curveTypes, double time, double[] yAxisData, bool refreshGraph = true)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < curveTypes.Length; i++)
                {
                    Plot(curveTypes[i], time, yAxisData[i], false);
                }

                if (refreshGraph)
                {
                    RefreshGraph();
                }
            });
        }
        public async Task PlotGroupPointPairAsync(PointPairType[] curveTypes, double time, double[] yAxisData, bool refreshGraph = true)
        {

            for (int i = 0; i < curveTypes.Length; i++)
            {
                await PlotPointPair(curveTypes[i], time, yAxisData[i], false);
            }

            if (refreshGraph)
            {
                RefreshPointPair();
            }

        }

        public async Task PlotSpecificationThreeStepCharge(ChargingState chargingState, double time, double hightMinCharge, double highMaxCharge,
            double lowMinCharge, double lowMaxCharge, double cutoffMin, double cutoffMax)
        {
            double[] batteryHighSpecifications = { hightMinCharge, highMaxCharge };
            double[] batteryLowSpecifications = { lowMinCharge, lowMaxCharge };
            double[] batteryCutOffSpecifications = { cutoffMin, cutoffMax };

            //TextObj high = new TextObj("High(ตัด)", time, hightMinCharge, CoordType.ChartFraction);
            //TextObj low = new TextObj("Low(ต่อ)", time, hightMinCharge, CoordType.ChartFraction);

            if (chargingState == ChargingState.Charge || chargingState == ChargingState.Discharge || chargingState == ChargingState.Checking)
            {
                await PlotGroupAsync(CurveTypeConfiguration.HighChargeMinMaxTypes, time, batteryHighSpecifications);
                //CurveType.MaxValueHighCharge = new Fill(Color.Blue, Color.White, Color.Blue);
                //curve2.Line.Fill.Type = FillType.GradientByZ;
                //curve2.Line.Fill.RangeMin = curve1.MinY;
                //curve2.Line.Fill.RangeMax = curve2.MaxY;
                //_zedGraphControl.GraphPane.GraphObjList.Add(high);

                await PlotGroupAsync(CurveTypeConfiguration.LowChargeMinMaxTypes, time, batteryLowSpecifications);
                
                //_zedGraphControl.GraphPane.GraphObjList.Add(high);
            }
            else if (ChargingState.LowVoltageCutOff == chargingState)
            {
                await PlotGroupAsync(CurveTypeConfiguration.LowChargeMinMaxTypes, time, batteryLowSpecifications);
                await PlotGroupAsync(CurveTypeConfiguration.LowCutOffMinMaxTypes, time, batteryCutOffSpecifications);
            }
            else if (chargingState == ChargingState.OutOfRange)
            {
                await PlotGroupAsync(CurveTypeConfiguration.HighChargeMinMaxTypes, time, batteryHighSpecifications);
                await PlotGroupAsync(CurveTypeConfiguration.LowChargeMinMaxTypes, time, batteryLowSpecifications);
                await PlotGroupAsync(CurveTypeConfiguration.LowCutOffMinMaxTypes, time, batteryCutOffSpecifications);
            }
            else
            {
                throw new ArgumentNullException(nameof(chargingState));
            }
        }
        public async Task PlotSpecificationCurrentConstant(ChargingState chargingState, double time, double MinCharge, double MaxCharge,
            double cutoffMin, double cutoffMax)
        {
            double[] batteryCurrentConstantSpecifications = { MinCharge, MaxCharge };
            double[] batteryCutOffSpecifications = { cutoffMin, cutoffMax };

            if (chargingState == ChargingState.Charge || chargingState == ChargingState.Discharge || chargingState == ChargingState.Checking)
            {
                await PlotGroupAsync(CurveTypeConfiguration.CurrentConstantMinMaxTypes, time, batteryCurrentConstantSpecifications);
                await PlotGroupAsync(CurveTypeConfiguration.LowChargeMinMaxTypes, time, batteryCutOffSpecifications);
            }
            else if (ChargingState.LowVoltageCutOff == chargingState)
            {
                await PlotGroupAsync(CurveTypeConfiguration.CurrentConstantMinMaxTypes, time, batteryCurrentConstantSpecifications);
                await PlotGroupAsync(CurveTypeConfiguration.LowCutOffMinMaxTypes, time, batteryCutOffSpecifications);
            }
            else if (chargingState == ChargingState.OutOfRange)
            {
                await PlotGroupAsync(CurveTypeConfiguration.CurrentConstantMinMaxTypes, time, batteryCurrentConstantSpecifications);
                await PlotGroupAsync(CurveTypeConfiguration.LowCutOffMinMaxTypes, time, batteryCutOffSpecifications);
            }
            else
            {
                throw new ArgumentNullException(nameof(chargingState));
            }
        }
        public async Task PlotDataFromListView(ListView listDataPlot)
        {
            await Task.Run(() =>
            {
                foreach (ListViewItem item in listDataPlot.Items)
                {
                    double time = double.Parse(item.SubItems[1].Text);
                    double voltage = double.Parse(item.SubItems[2].Text);
                    double movingAverage = double.Parse(item.SubItems[3].Text);
                    double current = double.Parse(item.SubItems[4].Text);

                    double[] listViewData = { voltage, movingAverage, current };

                    // We need to synchronize access to the ZedGraphControl due to potential concurrent modifications.
                    lock (_zedGraphControl)
                    {
                        _zedGraphControl.Invoke((Action)(() =>
                        {
                            PlotGroupAsync(CurveTypeConfiguration.DcCurveTypes, time, listViewData, false).Wait();
                        }));
                    }
                }

                RefreshGraph();
            });
        }
        public async Task PlotRollingDataFromListView(ListView listDataPlot)
        {

            foreach (ListViewItem item in listDataPlot.Items)
            {
                double time = double.Parse(item.SubItems[1].Text);
                double voltage = double.Parse(item.SubItems[2].Text);
                double movingAverage = double.Parse(item.SubItems[3].Text);
                double current = double.Parse(item.SubItems[4].Text);

                double[] listViewData = { voltage, movingAverage, current };
                await PlotGroupAsync(CurveTypeConfiguration.DcCurveTypes, time, listViewData, false);
            }
            RefreshGraph();
        }
        public void ClearCurve(CurveType type, bool refreshGraph = true)
        {
            GetRollingPointPairList(type).Clear();
            if (refreshGraph)
            {
                RefreshGraph();
            }
        }
        public void ClearGroup(CurveType[] curveTypes, bool refreshGraph = true)
        {
            foreach (var curveType in curveTypes)
            {
                ClearCurve(curveType, false);
            }

            if (refreshGraph)
            {
                RefreshGraph();
            }
        }
        public void ClearEntireCurve()
        {
            foreach (var list in _rollingPointPairLists.Values)
            {
                list.Clear();
            }

            RefreshGraph();
        }
        public void SetCurveVisibility(CurveType type, bool isVisible)
        {
            var curve = _zedGraphControl.GraphPane.CurveList.Find(x => x.Label.Text == GetCurveByType(type));
            if (curve != null)
            {
                curve.IsVisible = isVisible;
                _zedGraphControl.AxisChange();
                _zedGraphControl.Invalidate();
            }
        }

        private string GetCurveByType(CurveType type)
        {
            var config = GetCurveConfigurations().FirstOrDefault(x => x.Type == type);
            if (config != null)
            {
                return config.Label;
            }

            throw new ArgumentOutOfRangeException(nameof(type), "Invalid curve type.");
        }
        internal void RefreshGraph()
        {
            UpdateAxes();
            _zedGraphControl.AxisChange();
            _zedGraphControl.Invalidate();
        }
        private void RefreshPointPair()
        {
            _zedGraphControl.AxisChange();
            _zedGraphControl.Invalidate();
        }
        private void UpdateAxes()
        {
            var xaxis = _zedGraphControl.GraphPane.XAxis;
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var list in _rollingPointPairLists.Values)
            {
                if (list.Count == 0) continue;

                min = Math.Min(min, list[0].X);
                max = Math.Max(max, list[list.Count - 1].X);
            }
            xaxis.Scale.Min = min;
            xaxis.Scale.Max = max;
        }
        public void ClearAllPointPairLists()
        {
            foreach (var list in _rollingPointPairLists.Values)
            {
                list.Clear();
            }

            foreach (var list in _pointPairLists.Values)
            {
                list.Clear();
            }

            RefreshGraph();
        }

        public void Clear()
        {
            _zedGraphControl.GraphPane.CurveList.Clear();
            _zedGraphControl.GraphPane.GraphObjList.Clear();
            _zedGraphControl.Refresh();
            //_zedGraphControl.Invalidate();
        }
    }
}