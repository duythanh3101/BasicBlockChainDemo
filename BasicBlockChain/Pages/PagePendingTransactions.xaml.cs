﻿using BasicBlockChain.Services;
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
    /// Interaction logic for PagePendingTransactions.xaml
    /// </summary>
    public partial class PagePendingTransactions : Page
    {
        public PagePendingTransactions()
        {
            InitializeComponent();

            lvTransactions.ItemsSource = BlockChainService.Instance.PendingTransactions;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var transactions = BlockChainService.Instance.PendingTransactions;
            if (transactions.Count > 0)
            {
                var address = GlobalVariables.MyAdrress;
                var res = BlockChainService.Instance.ProcessPendingTransactions(address);

                lvTransactions.ItemsSource = res;
                lvTransactions.Items.Refresh();
            }
        }

    
    }
}
