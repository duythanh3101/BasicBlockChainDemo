using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBlockChain.Entities
{
    public class Blockchain
    {
        public IList<Block> Chain { set; get; }
        public IList<Transaction> PendingTransactions = new List<Transaction>();
        public int Difficulty { set; get; } = 2;
        public int Reward = 200; //1 cryptocurrency

        public Blockchain()
        {
            InitializeChain();
            AddGenesisBlock();
        }

        public void InitializeChain()
        {
            Chain = new List<Block>();
            PendingTransactions = new List<Transaction>();
        }

        public Block CreateGenesisBlock()
        {
            return new Block(DateTime.Now, "0", new List<Transaction>());
        }

        public void AddGenesisBlock()
        {
            Chain.Add(CreateGenesisBlock());
        }

        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }

        public void AddBlock(Block block)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Mine(Difficulty);
            Chain.Add(block);
        }

        public bool CreateTransaction(Transaction transaction)
        {
            if (string.IsNullOrEmpty(transaction.ToAddress))
            {
                //throw new Exception("Transaction must include from and to address");
                return false;
            }

            if (!transaction.isValid())
            {
                //throw new Exception("Cannot add invalid transaction to chain");
                return false;
            }

            PendingTransactions.Add(transaction);
            return true;
        }

        public bool IsChainValid()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block currentBlock = Chain[i];
                Block previousBlock = Chain[i - 1];

                if (!currentBlock.HasValidTransactions())
                {
                    return false;
                }

                if (currentBlock.Hash != currentBlock.CalculateHash())
                {
                    return false;
                }

                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }
            return true;
        }

        public int GetBalance(string address)
        {
            int balance = 0;

            for (int i = 0; i < Chain.Count; i++)
            {
                for (int j = 0; j < Chain[i].Transactions.Count; j++)
                {
                    var transaction = Chain[i].Transactions[j];

                    if (transaction.FromAddress == address)
                    {
                        balance -= transaction.Amount;
                    }

                    if (transaction.ToAddress == address)
                    {
                        balance += transaction.Amount;
                    }
                }
            }

            return balance;
        }

        public List<Transaction> ProcessPendingTransactions(string minerAddress)
        {
            Block block = new Block(DateTime.Now, GetLatestBlock().Hash, PendingTransactions);
            AddBlock(block);
            Console.WriteLine("Block sucessfully mined!");
            // Reward
            CreateTransaction(new Transaction(null, minerAddress, Reward));

            var storeTransactions = (List<Transaction>)PendingTransactions;
            PendingTransactions = new List<Transaction>();

            return storeTransactions;
        }
    }
}
