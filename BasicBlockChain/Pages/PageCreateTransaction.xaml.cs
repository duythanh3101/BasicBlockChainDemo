using BasicBlockChain.Entities;
using BasicBlockChain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicBlockChain.Pages
{
    /// <summary>
    /// Interaction logic for PageCreateTransaction.xaml
    /// </summary>
    public partial class PageCreateTransaction : Page
    {
        public PageCreateTransaction()
        {
            InitializeComponent();

            FromAddressTextBox.Text = GlobalVariables.MyAdrress;
            notifyLabel.Visibility = Visibility.Hidden;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;
            string fromAddress = FromAddressTextBox.Text;
            string toAddress = ToAddressTextBox.Text;
            bool parseSuccess = int.TryParse(AmoutTextBox.Text, out amount);
            if (parseSuccess && !string.IsNullOrEmpty(fromAddress) && !string.IsNullOrEmpty(toAddress))
            {
                var trans = new Transaction(fromAddress, toAddress, amount);

                trans.SignTransaction(GlobalVariables.Key);
                bool isCreateSucceed = BlockChainService.Instance.CreateTransaction(trans);

                if (isCreateSucceed)
                {
                    notifyLabel.Content = "Create transaction successfully !";
                    notifyLabel.Visibility = Visibility.Visible;
                    notifyLabel.Foreground = new SolidColorBrush(Colors.Blue);
                }
                else
                {
                    notifyLabel.Content = "Create transaction failed !";
                    notifyLabel.Visibility = Visibility.Visible;
                    notifyLabel.Foreground = new SolidColorBrush(Colors.Red);
                }
            }

        }
    }
}
