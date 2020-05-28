using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BasicBlockChain.Entities
{
    public class Transaction
    {
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set;  }

        private string signature;

        public Transaction(string fromAddress, string toAddress, int amount)
        {
            FromAddress = fromAddress;
            ToAddress = toAddress;
            Amount = amount;
            TimeStamp = DateTime.Now;
        }

        public void SignTransaction(MyKey signingKey)
        {
            if (signingKey.PublicKey != FromAddress)
            {
                Console.WriteLine("You cannot sign transactions for other wallets!");
            }
            signature = CalculateHash();
        }

        public bool isValid()
        {
            if (string.IsNullOrEmpty(FromAddress))
                return true;

            if (string.IsNullOrEmpty(signature))
                return false;

            return CalculateHash() == signature;
        }

        public string CalculateHash()
        {
            SHA256 sha256 = SHA256.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes($"{TimeStamp}-{FromAddress}-{ToAddress}-{Amount}");
            byte[] outputBytes = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(outputBytes);
        }
    }
}
