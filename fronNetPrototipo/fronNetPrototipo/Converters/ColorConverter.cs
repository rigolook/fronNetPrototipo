using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace fronNetPrototipo
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Aquí puedes implementar la lógica para convertir el nombre del color en un objeto Color
            switch ((string)value)
            {
                case "Blanco":
                    return Color.White;
                case "Rosa":
                    return Color.FromHex("#FDB4FF");
                case "Amarillo":
                    return Color.FromHex("#F1ff1E");
                default:
                    return Color.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
