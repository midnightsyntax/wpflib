using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp.Converter
{
    /// <summary>
    /// Takes a height double and outputs a Margin. Example: Height is "20". Margin value will be "20,20,20,20".
    /// </summary>
    public class HeightToMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Thickness t = new Thickness(0, double.IsNaN((double)value) ? 0 : (double)value, 0, 0);
            return t;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
