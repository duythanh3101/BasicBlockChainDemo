using BasicBlockChain.Entities;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Block = BasicBlockChain.Entities.Block;

namespace BasicBlockChain.UserControls
{
    /// <summary>
    /// Interaction logic for UCBlock.xaml
    /// </summary>
    public partial class UCBlock : UserControl
    {
        public UCBlock()
        {
            InitializeComponent();
        }
        private int index;
        private string previouseHash;
        private string currentHash;
        private long nonce;
        private DateTime timeStamp;
        private List<Transaction> transactions;
        private Block currentBlock;
        private Action<List<Transaction>, int> showTransactionTable;

        public UCBlock(Block block, Action<List<Transaction>, int> showTransactionTable = null)
        {
            InitializeComponent();
            this.index = block.Index;
            this.previouseHash = block.PreviousHash;
            this.currentHash = block.Hash;
            this.nonce = block.Nonce;
            this.timeStamp = block.TimeStamp;
            this.transactions = (List<Transaction>)block.Transactions;
            this.currentBlock = block;
            this.showTransactionTable = showTransactionTable;

            HashText.Text = currentHash;
            PreviousHashText.Text = previouseHash;
            NonceText.Text = nonce.ToString();
            TimeStampText.Text = timeStamp.Ticks.ToString();
            BlockName.Content = "Block " + index.ToString();

            if (index == 1)
            {
                GenesisText.Visibility = Visibility.Visible;
            }
            else
            {
                GenesisText.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (showTransactionTable != null)
            {
                showTransactionTable.Invoke(transactions, index);
            }
        }
    }
}
