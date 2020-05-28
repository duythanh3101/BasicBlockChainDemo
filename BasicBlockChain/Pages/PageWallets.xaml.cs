using BasicBlockChain.Entities;
using BasicBlockChain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for PageWallets.xaml
    /// </summary>
    public partial class PageWallets : Page
    {
        public PageWallets()
        {
            InitializeComponent();

            if (!GlobalVariables.isLogined)
            {
                GeneratorButton.Visibility = Visibility.Visible;
                BalanceContainer.Visibility = Visibility.Collapsed;
            }
            else
            {
                var myKey = GlobalVariables.Key;
                PublicKeyTextBox.Text = myKey.PublicKey;
                PrivateKeyTextBox.Text = myKey.PrivateKey;

                GeneratorButton.Visibility = Visibility.Collapsed;
                BalanceContainer.Visibility = Visibility.Visible;

                string balance = BlockChainService.Instance.GetBalance(myKey.PublicKey).ToString();
                BalanceTextBox.Text = !string.IsNullOrEmpty(balance) ? balance + " $" : "0 $";
            }
        }

        private Action onActivateAllScreen;
        public PageWallets(Action onActivateAllScreen = null)
        {
            InitializeComponent();

            this.onActivateAllScreen = onActivateAllScreen;
            if (!GlobalVariables.isLogined)
            {
                GeneratorButton.Visibility = Visibility.Visible;
                LoginButton.Visibility = Visibility.Visible;
                BalanceContainer.Visibility = Visibility.Collapsed;
            }
            else
            {
                var myKey = GlobalVariables.Key;
                PublicKeyTextBox.Text = myKey.PublicKey;
                PrivateKeyTextBox.Text = myKey.PrivateKey;

                GeneratorButton.Visibility = Visibility.Collapsed;
                LoginButton.Visibility = Visibility.Collapsed;
                BalanceContainer.Visibility = Visibility.Visible;

                string balance = BlockChainService.Instance.GetBalance(myKey.PublicKey).ToString();
                BalanceTextBox.Text = !string.IsNullOrEmpty(balance) ? balance + " $" : "0 $";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!GlobalVariables.isLogined)
            {
                var myKey = KeyGenerator.Generate();
                PublicKeyTextBox.Text = myKey.PublicKey;
                PrivateKeyTextBox.Text = myKey.PrivateKey;

                GeneratorButton.Visibility = Visibility.Collapsed;
                LoginButton.Visibility = Visibility.Collapsed;
                BalanceContainer.Visibility = Visibility.Visible;

                string balance = BlockChainService.Instance.GetBalance(myKey.PublicKey).ToString();
                BalanceTextBox.Text = !string.IsNullOrEmpty(balance) ? balance + " $" : "0 $";

                GlobalVariables.isLogined = true;
                GlobalVariables.Key = myKey;

                onActivateAllScreen?.Invoke();
                ErrorText.Visibility = Visibility.Collapsed;
            }

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var privateKey = PrivateKeyTextBox.Text.ToString();
            if (!string.IsNullOrEmpty(privateKey))
            {
                var account = new Nethereum.Web3.Accounts.Account(privateKey);
                if (account != null)
                {
                    var myKey = new MyKey
                    {
                        PublicKey = account.Address,
                        PrivateKey = privateKey
                    };

                    GeneratorButton.Visibility = Visibility.Collapsed;
                    LoginButton.Visibility = Visibility.Collapsed;
                    BalanceContainer.Visibility = Visibility.Visible;

                    string balance = BlockChainService.Instance.GetBalance(myKey.PublicKey).ToString();
                    BalanceTextBox.Text = !string.IsNullOrEmpty(balance) ? balance + " $" : "0 $";

                    GlobalVariables.isLogined = true;
                    GlobalVariables.Key = myKey;

                    onActivateAllScreen?.Invoke();

                    PublicKeyTextBox.Text = myKey.PublicKey;
                    ErrorText.Content = "Login Success !!!";
                    ErrorText.Visibility = Visibility.Visible;
                }
                else
                {
                    ErrorText.Visibility = Visibility.Visible;
                }
            }
            else
            {
                ErrorText.Visibility = Visibility.Visible;
            }
            
        }
    }
}
