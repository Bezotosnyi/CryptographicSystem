// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoKeyCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the AutoKeyCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using Abstract;
    using Enum;

    /// <summary>
    /// Шифр с автоключом
    /// </summary>
    public sealed class AutoKeyCipher : ICipher
    {
        private readonly AutoKeyCipherType typeAutoKeyCipher;
        private VigenereCipher vigenereCipher;

        public AutoKeyCipher(string primaryKey, AutoKeyCipherType typeAutoKeyCipher)
        {
            this.PrimaryKey = primaryKey;
            this.typeAutoKeyCipher = typeAutoKeyCipher;
        }

        public string PrimaryKey { get; private set; }

        public string Encrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            switch (this.typeAutoKeyCipher)
            {
                case AutoKeyCipherType.UseText:
                    this.PrimaryKey += text;
                    break;

                case AutoKeyCipherType.UseCryptogram:
                    this.vigenereCipher = new VigenereCipher(this.PrimaryKey + text);
                    this.PrimaryKey += this.vigenereCipher.Encrypt(text);
                    break;
            }

            this.vigenereCipher = new VigenereCipher(this.PrimaryKey);

            return this.vigenereCipher.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            switch (this.typeAutoKeyCipher)
            {
                case AutoKeyCipherType.UseText:
                    this.PrimaryKey += text;
                    break;

                case AutoKeyCipherType.UseCryptogram:
                    this.vigenereCipher = new VigenereCipher(this.PrimaryKey + text);
                    this.PrimaryKey += this.vigenereCipher.Encrypt(text);
                    break;
            }

            this.vigenereCipher = new VigenereCipher(this.PrimaryKey);

            return this.vigenereCipher.Decrypt(text);
        }
    }
}