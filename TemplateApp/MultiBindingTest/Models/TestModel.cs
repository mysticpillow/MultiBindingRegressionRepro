using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TemplateApp.MultiBindingTest.Models;

public partial class TestModel : ObservableObject
{
    /// <summary>
    /// Observable property to update MultiBinding
    /// </summary>
    [ObservableProperty]
    private object _dataUseStateUpdater;

    /// <summary>
    /// Non-observable value
    /// </summary>
    public int? Value { get; set; } = 0;

    /// <summary>
    /// Refresh bindings to properties
    /// </summary>
    /// <param name="propertyNames"> Property names </param>
    public void RefreshBindings(IEnumerable<string> propertyNames)
    {
        foreach (var propertyName in propertyNames)
        {
            OnPropertyChanged(propertyName);
        }
    }
}