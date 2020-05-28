using BasicBlockChain.Entities;
using BasicBlockChain.Services;
using BasicBlockChain.UserControls;
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

            //var privateKey = "72d18582de595eba8ec4733c402428399ab3a4a2856678dd8967ac46e5d9d1fd";
            //var account = new Nethereum.Web3.Accounts.Account(privateKey);

            //var key = new MyKey
            //{
            //    PublicKey = account.Address,
            //    PrivateKey = privateKey
            //};
            ////var key = KeyGenerator.Generate();
            //var myWalletAddress = key.PublicKey;
            //Console.WriteLine("Public key: " + DateTime.Parse("2019-9-9"));
            //Console.WriteLine("Private key: " + key.PrivateKey);

            //var tx1 = new Transaction(myWalletAddress, "public key goes here", 50);
            //tx1.SignTransaction(key);

            //var blockChain = new Blockchain();
            //blockChain.CreateTransaction(tx1);

            //Console.WriteLine("\n Starting the miner ...");
            //blockChain.ProcessPendingTransactions(myWalletAddress);

            //Console.WriteLine("\n Balance of xavier is: " + blockChain.GetBalance(myWalletAddress));

            //tx1 = new Transaction(myWalletAddress, "public key goes here", 100);
            //tx1.SignTransaction(key);
            //Console.WriteLine("\n Starting the miner 22222...");
            //blockChain.ProcessPendingTransactions(myWalletAddress);

            //tx1 = new Transaction(myWalletAddress, "public key goes here", 160);
            //tx1.SignTransaction(key);
            //Console.WriteLine("\n Starting the miner 22222...");
            //blockChain.ProcessPendingTransactions(myWalletAddress);

            //tx1 = new Transaction(myWalletAddress, "public key goes here", 140);
            //tx1.SignTransaction(key);
            //Console.WriteLine("\n Starting the miner 22222...");
            //blockChain.ProcessPendingTransactions(myWalletAddress);

            //Console.WriteLine("\n Balance of xavier is2222: " + blockChain.GetBalance(myWalletAddress));

            //blockContainer.Children.Add(new UCBlock(1, "0", blockChain.Chain[0].Hash, 0, blockChain.Chain[0].TimeStamp));
            //blockContainer.Children.Add(new UCBlock(2, blockChain.Chain[0].Hash, blockChain.Chain[1].Hash, blockChain.Chain[1].Nonce, blockChain.Chain[1].TimeStamp));
            //blockContainer.Children.Add(new UCBlock(3, blockChain.Chain[1].Hash, blockChain.Chain[2].Hash, blockChain.Chain[2].Nonce, blockChain.Chain[2].TimeStamp));
            //blockContainer.Children.Add(new UCBlock(4, blockChain.Chain[2].Hash, blockChain.Chain[3].Hash, 0, blockChain.Chain[3].TimeStamp.ToString()));

            for (int i = 0; i < BlockChainService.Instance.Chain.Count; i++)
            {
                var block = BlockChainService.Instance.Chain[i];
                blockContainer.Children.Add(new UCBlock(i + 1, block.PreviousHash, block.Hash, 0, block.TimeStamp));
            }
        }
    }
}
