using BasicBlockChain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace BasicBlockChain.UserControls
{
    /// <summary>
    /// Interaction logic for UCPendingTransactionsList.xaml
    /// </summary>
    public partial class UCPendingTransactionsList : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public UCPendingTransactionsList()
        {
            InitializeComponent();
        }

        private ObservableCollection<Transaction> transactionsList;
        public ObservableCollection<Transaction> TransactionsList
        {
            get { return transactionsList; }
            set { transactionsList = value; OnPropertyChanged("TransactionsList"); }
        }

        public UCPendingTransactionsList(List<Transaction> transactions)
        {
            InitializeComponent();
            DataContext = this;

            lvTransactions.ItemsSource = new ObservableCollection<Transaction>(transactions); ;
            lvTransactions.Items.Refresh();

        }

     
    }
}
