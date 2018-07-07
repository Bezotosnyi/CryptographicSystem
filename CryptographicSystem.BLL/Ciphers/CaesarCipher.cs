// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaesarCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the CaesarCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Abstract;
    using Extension;

    public sealed class CaesarCipher : Cipher, ICipher
    {
        private readonly int shiftLength;

        public CaesarCipher(int shiftLength)
        {
            if (!this.CheckShiftLength(shiftLength)) throw new ArgumentOutOfRangeException();
            this.shiftLength = shiftLength;
        }

        public string Encrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            string encryptText = string.Empty;

            var textArray = text.ToStringArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                var alphabetIndex = Cipher.EnglishAlphabetic.IndexOf(textArray[i].ToLower());

                if (alphabetIndex == -1)
                {
                    encryptText += textArray[i];
                    continue;
                }

                int index = (alphabetIndex + this.shiftLength + Cipher.EnglishAlphabetic.Length) % Cipher.EnglishAlphabetic.Length;

                if (char.IsUpper(char.Parse(textArray[i])))
                    encryptText += Cipher.EnglishAlphabetic[index].ToUpper();
                else
                    encryptText += Cipher.EnglishAlphabetic[index];
            }

            return encryptText;
        }

        public string Decrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            string decryptText = string.Empty;

            var textArray = text.ToStringArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                var alphabetIndex = Cipher.EnglishAlphabetic.IndexOf(textArray[i].ToLower());

                if (alphabetIndex == -1)
                {
                    decryptText += textArray[i];
                    continue;
                }

                int index = (alphabetIndex - this.shiftLength + Cipher.EnglishAlphabetic.Length) % Cipher.EnglishAlphabetic.Length;

                if (char.IsUpper(char.Parse(textArray[i])))
                    decryptText += Cipher.EnglishAlphabetic[index].ToUpper();
                else
                    decryptText += Cipher.EnglishAlphabetic[index];
            }

            return decryptText;
        }

        private bool CheckShiftLength(int shift)
        {
            if (shift >= 1 && shift <= Cipher.EnglishAlphabetic.Length) return true;
            return false;
        }
    }
}