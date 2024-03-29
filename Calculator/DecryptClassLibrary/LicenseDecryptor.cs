using System.Security.Cryptography;
using System.Text;

namespace DecryptClassLibrary
{
    public class LicenseDecryptor
    {
        // Decrypt function using AES-256-GCM algorithm
        public static string Decrypt(string encryptedData, string key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

            // Extract IV and tag from the encrypted data
            byte[] iv = encryptedBytes[..12]; // IV length is 12 bytes
            byte[] tag = encryptedBytes[12..28]; // GCM tag length is 16 bytes
            byte[] cipherText = encryptedBytes[28..]; // Rest is cipher text

            // Convert key to bytes
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            // Create AesGcm instance
            using AesGcm aesGcm = new AesGcm(keyBytes);

            // Create plaintext buffer
            byte[] decryptedBytes = new byte[cipherText.Length];

            // Decrypt the data
            aesGcm.Decrypt(iv, cipherText, tag, decryptedBytes);

            // Convert decrypted bytes to string
            string decryptedData = Encoding.UTF8.GetString(decryptedBytes);

            return decryptedData;
        }
    }
}
