using System;
using System.Globalization;
using Xamarin.Forms;

namespace CW
{
    public class FavBackgorundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is bool val)
            {
                if (val)
                    return Color.Green;
                return Color.Yellow;
            }
            return Color.Yellow;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}