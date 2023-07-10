using MicroUseFullFunctions.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static MicroUseFullFunctions.Encryption.AesEncryption;

namespace ConsoleApp
{
    public class Doc
    {
        public string Name { get; set; }

        public string Description { get; set; } = "";

        public byte[] DescriptionByte { get; set; }

    }
}
