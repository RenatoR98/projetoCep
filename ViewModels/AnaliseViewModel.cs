using CommunityToolkit.Mvvm.ComponentModel;
using projetoCep.ViewModels.Charts;

namespace projetoCep.ViewModels;

public partial class AnaliseViewModel : ViewModelBase
{
    public LineChartViewModel LineChart { get; private set; } = new();

    [ObservableProperty]
    private object? currentGraph1;

    public AnaliseViewModel()
    {
        SetLineChart();
    }

    private void SetLineChart()
    {
        CurrentGraph1 = LineChart;
    }
}