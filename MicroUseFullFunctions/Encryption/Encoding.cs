using System.Security.Cryptography;
using System.Text;

namespace MicroUseFullFunctions.Encryption
{
    public static class AesEncryption
    {
        public struct AesBuilder : IAesBuilder
        {
            public byte[] key { get; set; }
            public byte[] iv { get; set; }

            public AesBuilder()
            {
                using (AesManaged aes = new AesManaged())
                {
                    aes.GenerateKey();
                    aes.GenerateIV();

                    this.key = aes.Key;
                    this.iv = aes.IV;
                }
            }
        }

        public interface IAesBuilder
        {
            byte[] key { get; set; }
            byte[] iv { get; set; }
        }

        public static string ToBase64(this byte[] crypto) => System.Convert.ToBase64String(crypto);

        public static IAesBuilder GetAESKeys() => new AesBuilder();

        public static byte[] Encrypt(this string plainText, IAesBuilder EncryptoData) => Encryption(plainText, EncryptoData);

        static byte[] Encryption(string plainText, IAesBuilder aesStorage)
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.Key = aesStorage.key;
                aes.IV = aesStorage.iv;

                ICryptoTransform encryptor = aes.CreateEncryptor();

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        return memoryStream.ToArray();
                    }
                }
            }
        }

        public static string Decrypt(this byte[] encryptedData, IAesBuilder EncryptoData) => Decryption(encryptedData, EncryptoData);

        static string Decryption(byte[] encryptedData, IAesBuilder aesStorage)
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.Key = aesStorage.key;
                aes.IV = aesStorage.iv;

                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream memoryStream = new MemoryStream(encryptedData))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}

