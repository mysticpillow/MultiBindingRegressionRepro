using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
using TemplateApp.MultiBindingTest.Models;

namespace TemplateApp.MultiBindingTest.Converters;

public class TestConverter : IMultiValueConverter
{
    public static TestConverter Instance { get; } = new();

    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values[0] is not TestModel model)
        {
            return string.Empty;
        }

        return model.Value.ToString();
    }
}