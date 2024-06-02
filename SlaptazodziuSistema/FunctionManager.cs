using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SlaptazodziuSistema
{
    public class FunctionManager
    {
        private static readonly string filePath = "passwords.txt";
        private static readonly string encryptionKey = "pAYjE6EDYPvh9WXDd4KmTG5vaKTLiYC6";

        //Funkcijos
        public static void SavePassword(string name, string password, string urlOrApp, string comment)
        {
            var encryptedPassword = EncryptString(password, encryptionKey);
            var entry = $"{name}:{encryptedPassword}:{urlOrApp}:{comment}";

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(entry);
            }
        }
        public static string SearchPassword(string name)
        {
            if (!File.Exists(filePath)) return null;
            var lines = File.ReadAllLines(filePath);
            return lines.FirstOrDefault(line => line.Split(':')[0] == name);
        }
        public static void UpdatePassword(string name, string newPassword)
        {
            if (!File.Exists(filePath)) return;
            var lines = File.ReadAllLines(filePath);
            var updatedLines = lines.Select(line =>
            {
                if (line.Split(':')[0] == name)
                {
                    var encryptedPassword = EncryptString(newPassword, encryptionKey);
                    return $"{name}:{encryptedPassword}";
                }
                return line;
            });
            File.WriteAllLines(filePath, updatedLines);
        }
        public static void DeletePassword(string name)
        {
            if (!File.Exists(filePath))
                return;
            var lines = File.ReadAllLines(filePath);
            var remainingLines = lines.Where(line => line.Split(':')[0] != name);
            File.WriteAllLines(filePath, remainingLines);
        }

        //Failo duomenu sifvravimas
        public static string EncryptString(string text, string keyString)
        {
            var key = Encoding.UTF8.GetBytes(keyString);

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }

                        var iv = aesAlg.IV;

                        var decryptedContent = msEncrypt.ToArray();

                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
        }
        public static string DecryptString(string cipherText, string keyString)
        {
            var fullCipher = Convert.FromBase64String(cipherText);

            var iv = new byte[16];
            var cipher = new byte[fullCipher.Length - iv.Length];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, cipher.Length);

            var key = Encoding.UTF8.GetBytes(keyString);

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        //Failo sifvravimas
        public static void EncryptFile(string filePath, string key)
        {
            var text = File.ReadAllText(filePath);
            var encryptedText = EncryptString(text, key);
            File.WriteAllText(filePath, encryptedText);
        }

        public static void DecryptFile(string filePath, string key)
        {
            var encryptedText = File.ReadAllText(filePath);
            var decryptedText = DecryptString(encryptedText, key);
            File.WriteAllText(filePath, decryptedText);
        }

        //Get
        public static string Key
        {
            get { return encryptionKey; }
        }
        public static string Path
        {
            get { return filePath; }
        }
    }
}
