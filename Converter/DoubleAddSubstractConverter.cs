using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfLib.Converter
{
    /// <summary>
    /// Add or substract to a double value. Use ConverterParameter. If ConverterParameter is set to a negative number that number will be substracted from the double.
    /// </summary>
    public class DoubleAddSubstractConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value + double.Parse((string)parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value;
        }
    }
}
