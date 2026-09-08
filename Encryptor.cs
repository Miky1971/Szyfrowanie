using System;
using System.Security.Cryptography;

public static class Encryptor
{
	public Encryptor()
	{
	}

	private static void Encrypt(string fileIn, string fileOut, string pass)
	{
        // Szkic — wyprowadzenie klucza z hasła
        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] key = Rfc2898DeriveBytes.Pbkdf2(pass, salt, 100_000, HashAlgorithmName.SHA256, 32);

        // Szyfrowanie AES-GCM
        byte[] nonce = RandomNumberGenerator.GetBytes(12);
        byte[] tag = new byte[16];
        byte[] ciphertext = new byte[fileIn.Length];
        using var aes = new AesGcm(key, tag.Length);
        aes.Encrypt(nonce, fileIn, ciphertext, tag);

    }

    private static void Decrypt(string fileIn, string fileOut, string pass)
    {

    }
}
