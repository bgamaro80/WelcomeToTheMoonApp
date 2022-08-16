using System.Globalization;

namespace WelcomeToTheMoonApp.Converters
{

    public class ObjectiveCardConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var objectiveCard = (Cards.ObjectiveCard)value;

            return objectiveCard.IsAccomplished ? objectiveCard.ImageBack : objectiveCard.ImageFront;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
