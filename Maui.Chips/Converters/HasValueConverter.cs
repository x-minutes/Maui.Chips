using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Chips.Converters
{
    public class HasValueConverter : IValueConverter
    {
        public bool EmptyStringIsNull { get; set; } = true;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (this.EmptyStringIsNull)
            {
                var stringValue = value as string;
                if (stringValue != null)
                    return stringValue != string.Empty;
            }

            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
