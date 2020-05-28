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

        public UCBlock(int index, string previouseHash, string currentHash, long nonce, DateTime timeStamp)
        {
            InitializeComponent();
            this.index = index;
            this.previouseHash = previouseHash;
            this.currentHash = currentHash;
            this.nonce = nonce;
            this.timeStamp = timeStamp;

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
    }
}
