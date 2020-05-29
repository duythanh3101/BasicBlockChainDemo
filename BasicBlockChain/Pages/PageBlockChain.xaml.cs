using BasicBlockChain.Entities;
using BasicBlockChain.Services;
using BasicBlockChain.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace BasicBlockChain
{
    /// <summary>
    /// Interaction logic for PageBlockChain.xaml
    /// </summary>
    public partial class PageBlockChain : Page
    {

     
        public PageBlockChain()
        {
            InitializeComponent();
            for (int i = 0; i < BlockChainService.Instance.Chain.Count; i++)
            {
                var block = BlockChainService.Instance.Chain[i];
                blockContainer.Children.Add(new UCBlock(block, Show));
            }
            
        }

        public void Show(List<Transaction> transactions, int blockIndex)
        {
            if (transactions != null && transactions.Count > 0)
            {
                TransactionsContainer.Children.Clear();
                TransactionsContainer.Children.Add(new UCPendingTransactionsList(transactions));
                NotifyLabel.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                TransactionsContainer.Children.Clear();
                NotifyLabel.Visibility = System.Windows.Visibility.Visible;
            }
            numberLabel.Content = blockIndex.ToString();
        }
    }

    
}
