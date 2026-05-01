using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Linq;

namespace projetoCep.ViewModels.Charts;

public partial class LineChartViewModel : ViewModelBase
{
    public double Min { get; set; } = 5;
    public double Max { get; set; } = 15;

    public ISeries[] Series { get; set; } = new ISeries[]
    {
        new LineSeries<double>
        {
            Values = new double[] {10,15,12,9,8,11,7,8,11,13,7,5,11,10,14,7,10}
        }
    };

    public Axis[] XAxes { get; set; } = new Axis[]
    {
        new Axis
        {
            TextSize = 7
        }
    };

    public Axis[] YAxes { get; set; } = new Axis[]
    {
        new Axis
        {
            TextSize = 7
        }
    };
}
