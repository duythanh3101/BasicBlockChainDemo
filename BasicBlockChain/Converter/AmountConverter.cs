using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BasicBlockChain.Converter
{
    public class AmountConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string amount = string.Empty;
            if (values.Length > 1)
            {
                if (string.IsNullOrEmpty(values[1] as string))
                {
                    amount = values[0].ToString()  + " (Block Reward)";
                }
                else
                {
                    amount = values[0].ToString();
                }
            }
            return amount;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
