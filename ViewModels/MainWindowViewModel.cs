using Avalonia;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace projetoCep.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public AnaliseViewModel Analise { get; private set; } = new();

    [ObservableProperty]
    private bool _isDarkMode;

    [ObservableProperty]
    private object? currentPage;

    [ObservableProperty]
    private bool isAnalisesSelected;

    public IRelayCommand GoAnaliseCommand { get; private set; }

    public MainWindowViewModel() 
    {
        GoAnaliseCommand = new RelayCommand(() => GoAnalise());

        GoAnalise();
    }

    partial void OnIsDarkModeChanged(bool value)
    {
        if (Application.Current is { } app)
        {
            app.RequestedThemeVariant = value ? ThemeVariant.Dark : ThemeVariant.Light;
        }
    }

    private void GoAnalise()
    {
        CurrentPage = Analise;
        IsAnalisesSelected = true;
    }

}
