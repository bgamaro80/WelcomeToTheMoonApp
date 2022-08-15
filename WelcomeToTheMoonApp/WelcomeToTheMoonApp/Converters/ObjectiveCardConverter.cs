using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WelcomeToTheMoon;
using Xamarin.Forms;

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
