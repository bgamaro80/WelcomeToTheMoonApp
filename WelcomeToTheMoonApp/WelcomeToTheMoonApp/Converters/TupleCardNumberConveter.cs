using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WelcomeToTheMoon;
using Xamarin.Forms;

namespace WelcomeToTheMoonApp.Converters
{

    public class TupleCardNumberConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tupleCard = (Tuple<int, Symbol, Symbol>)value;

            return $"c{tupleCard.Item1}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
