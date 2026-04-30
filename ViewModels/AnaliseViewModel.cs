using Avalonia.Controls.Shapes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore.SkiaSharpView.Avalonia;
using projetoCep.ViewModels.Charts;

namespace projetoCep.ViewModels;

public partial class AnaliseViewModel : ViewModelBase
{
    public LineChartViewModel Line { get; } = new();

    public AnaliseViewModel()
    {
        AtualizarGraficos();
    }

    [RelayCommand]
    private void AtualizarGraficos()
    {
        double[] valores = { 10.2, 10.4, 10.1, 10.6, 10.5, 10.3 };
        Line.Atualizar(valores, valorFixo: 10.5);
    }

}