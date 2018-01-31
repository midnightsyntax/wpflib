using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfLib.Converter
{
    /// <summary>
    /// Takes a nullable bool and returns a safe bool.
    /// </summary>
    public class NullableBooleanToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool?)
            {
                return (bool)value;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is bool)
                return (bool)value;
            return false;
        }
    }
}