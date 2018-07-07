// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VermanCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the VermanCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using Abstract;

    public class VermanCipher : Cipher, ICipher
    {
        private readonly Random random;
        private readonly VigenereCipher vigenereCipher;

        public VermanCipher(int keyLength)
        {
            this.random = new Random();
            this.GeneratedKey = this.GetGeneratedKey(keyLength);
            this.vigenereCipher = new VigenereCipher(this.GeneratedKey);
        }

        protected VermanCipher(string sensText)
        {
            this.GeneratedKey = sensText;
            this.vigenereCipher = new VigenereCipher(this.GeneratedKey);
        }

        public string GeneratedKey { get; }

        public string Encrypt(string text)
        {
            return this.vigenereCipher.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            return this.vigenereCipher.Decrypt(text);
        }

        private string GetGeneratedKey(int keyLength)
        {
            var getGeneratedKey = string.Empty;

            for (int i = 0; i < keyLength; i++)
            {
                var index = this.random.Next(0, Cipher.EnglishAlphabetic.Length - 1);
                getGeneratedKey += Cipher.EnglishAlphabetic[index];
            }

            return getGeneratedKey;
        }
    }
}