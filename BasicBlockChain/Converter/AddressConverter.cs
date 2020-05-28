using System.Windows.Controls;
using System.Windows.Data;

namespace BasicBlockChain.Converter
{
    public class AddressConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string address= value != null ? value.ToString() : "System";

            return address;

        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.InvalidOperationException();
        }
    }
}
