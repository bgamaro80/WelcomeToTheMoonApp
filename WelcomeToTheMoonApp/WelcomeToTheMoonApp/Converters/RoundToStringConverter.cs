using System.Globalization;

namespace WelcomeToTheMoonApp.Converters
{

    public class RoundToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int round = (int)value;

            if (round < 10)
                return "0" + round.ToString();

            return round.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
