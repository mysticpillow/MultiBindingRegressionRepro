using Avalonia.Controls;
using Avalonia.Interactivity;
using TemplateApp.MultiBindingTest.Models;

namespace TemplateApp.MultiBindingTest;

public partial class TestControl : UserControl
{
    public TestControl()
    {
        InitializeComponent();
    }

    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        var model = (TestModel)textBlock.DataContext;
        model.Value++;
        model.RefreshBindings([nameof(model.DataUseStateUpdater)]);
    }
}