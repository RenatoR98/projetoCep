using System;
using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using projetoCep.ViewModels;
using projetoCep.Views;

namespace projetoCep;

public class ViewLocator : IDataTemplate
{
    public Control Build(object data)
    {
        return data switch
        {
            AnaliseViewModel => new AnaliseView(),
            _ => new TextBlock { Text = $"No view for {data.GetType().Name}" }
        };
    }

    public bool Match(object data) => data is ViewModelBase;
}