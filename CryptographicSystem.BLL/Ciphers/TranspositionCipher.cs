// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranspositionCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the TranspositionCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using System.Linq;

    using Abstract;
    using Extension;

    /// <summary>
    /// Перестановочные шифры
    /// </summary>
    public sealed class TranspositionCipher : ICipher
    {
        private readonly int[][] transpositionArray;

        /// <summary>
        /// Новый экземпляр класса <see cref="TranspositionCipher"/>
        /// </summary>
        /// <param name="transpositionArray">
        /// Двумерный ступенчатый массив индексов. Для удобства передачи используем params.
        /// (Указывает на то, что они передаются как одномерные)
        /// </param>
        public TranspositionCipher(params int[][] transpositionArray)
        {
            if (transpositionArray == null) throw new ArgumentNullException(nameof(transpositionArray));
            this.transpositionArray = transpositionArray;
        }

        /// <summary>
        /// Шифрование перестановочным шифром
        /// </summary>
        /// <param name="text">Обычный текст</param>
        /// <returns>Зашифрованый тест</returns>
        public string Encrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            var encryptText = text;

            for (int k = 0; k < this.transpositionArray.Length; k++)
            {
                var stringArray = encryptText.Splitter(this.transpositionArray[k].Length);
                for (int i = 0; i < stringArray.Length; i++)
                {
                    var s = stringArray[i].ToStringArray();
                    stringArray[i] = string.Empty;

                    for (int j = 0; j < s.Length; j++)
                        stringArray[i] += s[this.transpositionArray[k][j] - 1]; // -1 так как индексы с 0
                }

                encryptText = stringArray.ArrayToString();
            }

            return encryptText;
        }

        /// <summary>
        /// Дешифрование перестановочным шифром
        /// </summary>
        /// <param name="text">Зашифрованый текст</param>
        /// <returns>Обычный текст</returns>
        public string Decrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            string decryptText = text;

            for (int i = 0; i < this.transpositionArray.Length; i++)
            {
                for (int j = 0; j < decryptText.Length / this.transpositionArray[i].Length; j++)
                {
                    for (int k = 0; k < this.transpositionArray[i].Length; k++)
                    {
                        int index = (j * this.transpositionArray[i].Length) + this.transpositionArray[i][k] - 1;
                        decryptText += decryptText[index];
                    }
                }
            }
                    
            return decryptText;
        }
    }
}