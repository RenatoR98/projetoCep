using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Linq;

namespace projetoCep.ViewModels.Charts;

public partial class LineChartViewModel : ViewModelBase
{
    [ObservableProperty]
    private ISeries[] series = [];

    [ObservableProperty]
    private Axis[] xAxes =
    [
        new Axis
        {
            Name = "Medição",
            TextSize = 12,
            NameTextSize = 13
        }
    ];

    [ObservableProperty]
    private Axis[] yAxes =
    [
        new Axis
        {
            Name = "Valor",
            TextSize = 12,
            NameTextSize = 13
        }
    ];

    public void Atualizar(double[] valores, double valorFixo)
    {
        double[] linhaFixa = valores
            .Select(_ => valorFixo)
            .ToArray();

        Series =
        [
            new LineSeries<double>
            {
                Values = valores,
                Name = "Valor medido",
                DataLabelsSize = 12
            },

            new LineSeries<double>
            {
                Values = linhaFixa,
                Name = "Referência",
                GeometrySize = 0,
                DataLabelsSize = 12
            }
        ];
    }
}
