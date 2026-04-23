using System.Security.Cryptography;
using System.Text;

namespace ReelsCommerceSystem.Shared.Utilities;

public static class EncryptionHelper
{
    private static readonly string Key = Environment.GetEnvironmentVariable("CHAT_ENCRYPTION_KEY") ?? "rkejwhiuh@CsZbdfjs78fu!qw8uiqehfuih5"; // Must be 32 chars for AES-256

    public static string Encrypt(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return plainText;

        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(Key.PadRight(32).Substring(0, 32));
        aes.GenerateIV();

        var iv = aes.IV;

        using var encryptor = aes.CreateEncryptor(aes.Key, iv);
        var bytes = Encoding.UTF8.GetBytes(plainText);
        var encrypted = encryptor.TransformFinalBlock(bytes, 0, bytes.Length);

        return Convert.ToBase64String(iv.Concat(encrypted).ToArray());
    }

    public static string Decrypt(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText)) return cipherText;

        try
        {
            var full = Convert.FromBase64String(cipherText);

            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Key.PadRight(32).Substring(0, 32));

            var iv = full.Take(16).ToArray();
            var cipher = full.Skip(16).ToArray();

            aes.IV = iv;

            using var decryptor = aes.CreateDecryptor(aes.Key, iv);
            var decrypted = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);

            return Encoding.UTF8.GetString(decrypted);
        }
        catch
        {
            return cipherText; 
        }
    }
}
