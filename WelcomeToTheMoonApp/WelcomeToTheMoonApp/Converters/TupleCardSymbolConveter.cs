using System.Globalization;
using WelcomeToTheMoon;

namespace WelcomeToTheMoonApp.Converters
{

    public class TupleCardSymbolConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tupleCard = (Tuple<int, Symbol, Symbol>)value;

            switch( tupleCard.Item2 )
            {
                case Symbol.Planificacion:
                    return "c";
                case Symbol.Energia:
                    return "e";
                case Symbol.Robot:
                    return "r";
                case Symbol.Agua:
                    return "a";
                case Symbol.Planta:
                    return "p";
                case Symbol.Astronauta:
                    return "h";
            }

            return "no_symbol";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
