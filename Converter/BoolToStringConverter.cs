using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfLib.Converter
{
    /// <summary>
    /// Takes a bool and outputs a string according to the string value of ConverterParameter. The ConverterParameter should be used as "true|false" so if you want to convert 'true' to 'yes' and 'false' to 'no' set ConverterParameter to "yes|no".
    /// </summary>
    public class BoolToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool boolValue = (bool)value;
            string[] param = ((string)parameter).Split('|');
            return boolValue == true ? param[0] : param[1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value;
        }
    }
}
