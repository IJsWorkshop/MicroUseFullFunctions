using static MicroUseFullFunctions.Encryption.AesEncryption;
using static System.Diagnostics.Debug;
using MicroUseFullFunctions.Utility;
using MicroUseFullFunctions.Output;
using ConsoleApp;

var alist = new List<Test>();

alist.Add(new Test { Name = "Ian", Description = "blahb", Height = "10" });
alist.Add(new Test { Name = "Steve", Description = "blasdfdsfdsfsdfb", Height = "5" });
alist.Add(new Test { Name = "John", Description = "bsdfsdflahb", Height = "20" });


alist.ToDebugWindow();

string testString = "said sai 1234567890-abcdefghijk blah blah blah blah";

WriteLine(testString);

var aList = testString.RemoveString( new string[] { "blah", "1","0", "k", "sai"});

WriteLine(aList);

// simple encode/decode example
string plainText = "This text will be encrypted";

// produce keys
var AESkeys = GetAESKeys();

// encrypt
byte[] encryptedData = plainText.Encrypt(AESkeys);
var encryptoString = encryptedData.ToBase64();

// decrypt
string decryptedText = encryptedData.Decrypt(AESkeys);

// display
WriteLine("");
WriteLine("Plain Text: " + plainText );
WriteLine("Encrypted Data: " + encryptoString );
WriteLine("Decrypted Text: " + decryptedText );
WriteLine("");


var cryptolist = new List<Test>() { 
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" },
new Test { Name = "Ian", DescriptionByte = "blahb".Encrypt(AESkeys), Height = "10" },
new Test { Name = "Steve", DescriptionByte = "blasdfdsfdsfsdfb".Encrypt(AESkeys), Height = "5" },
new Test { Name = "John", DescriptionByte = "bsdfsdflahb".Encrypt(AESkeys), Height = "20" }};

cryptolist.ToDebugWindow();

// decrypt
foreach (var rec in cryptolist) rec.Description = $"decrypted : {rec.DescriptionByte.Decrypt(AESkeys)}";

// display
cryptolist.ToDebugWindow();

