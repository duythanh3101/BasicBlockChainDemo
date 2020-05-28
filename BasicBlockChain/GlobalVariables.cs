using BasicBlockChain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBlockChain
{
    public static class GlobalVariables
    {
        public static string MyAdrress = "0xf51645f07f5014C42f1B45e5E7f3a423a3AAE421";

        public static MyKey Key = new MyKey();

        public static Block SelectedBlock;
    }
}
