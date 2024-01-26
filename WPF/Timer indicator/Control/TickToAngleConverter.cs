using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFControls
{
    public class TickToAngleConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double tick = (double)values[0];
            ProgressBar bar = values[1] as ProgressBar;
            return 359.98 * (tick / (bar.Maximum - bar.Minimum)) + 180;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
