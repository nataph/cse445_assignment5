using System;
using System.Security.Cryptography;
using System.Text;

namespace HobbyCollection
{
    public static class SecurityHelper
    {
        public static string CreatePasswordHash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public static string EncryptText(string text, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(16).Substring(0, 16));
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            for (int i = 0; i < textBytes.Length; i++)
            {
                textBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Convert.ToBase64String(textBytes);
        }

        public static string DecryptText(string encryptedText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(16).Substring(0, 16));
            byte[] textBytes = Convert.FromBase64String(encryptedText);
            for (int i = 0; i < textBytes.Length; i++)
            {
                textBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Encoding.UTF8.GetString(textBytes);
        }
    }
}