using BasicBlockChain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBlockChain.Services
{
    public class BlockChainService
    {
        public static Blockchain instance = null;

        public static Blockchain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Blockchain();
                }
                return instance;
            }
        }

        //public static bool AddTransaction(Transaction tx)
        //{
        //    return instance.CreateTransaction(tx);
        //}
    }
}
