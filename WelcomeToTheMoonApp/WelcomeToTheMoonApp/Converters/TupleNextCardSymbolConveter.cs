using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WelcomeToTheMoon;
using Xamarin.Forms;

namespace WelcomeToTheMoonApp.Converters
{

    public class TupleNextCardSymbolConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tupleCard = (Tuple<int, Symbol, Symbol>)value;

            switch (tupleCard.Item3)
            {
                case Symbol.Planificacion:
                    return "c_esq";
                case Symbol.Energia:
                    return "e_esq";
                case Symbol.Robot:
                    return "r_esq";
                case Symbol.Agua:
                    return "a_esq";
                case Symbol.Planta:
                    return "p_esq";
                case Symbol.Astronauta:
                    return "h_esq";
            }

            return "no_symbol";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
