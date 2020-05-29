using Nethereum.Hex.HexConvertors.Extensions;

namespace BasicBlockChain.Entities
{
    public static class KeyGenerator
    {
        public static MyKey Generate()
        {
            var ecKey = Nethereum.Signer.EthECKey.GenerateKey();
            var privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
            var account = new Nethereum.Web3.Accounts.Account(privateKey);

            var myKey = new MyKey
            {
                PublicKey = account.Address,
                PrivateKey = privateKey
            };
            return myKey;
        }

        public static MyKey GetMyKeyFromPrivateKey(string privateKey)
        {
            var account = new Nethereum.Web3.Accounts.Account(privateKey);

            var key = new MyKey
            {
                PublicKey = account.Address,
                PrivateKey = privateKey
            };
            return key;
        }
    }
}
