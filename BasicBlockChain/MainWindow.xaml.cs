using BasicBlockChain.Pages;
using System.Windows;

namespace BasicBlockChain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Content = new PageBlockChain();

        }

        private void BlockChainButton_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PageBlockChain();
        }
   
        private void SettingsButton_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PageSettings();

        }

        private void CreateTransactionButton_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PageCreateTransaction();
        }

        private void WalletsButton_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PageWallets();
        }

        private void PendingTransactionsButton_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PagePendingTransactions();
        }
    }
}
