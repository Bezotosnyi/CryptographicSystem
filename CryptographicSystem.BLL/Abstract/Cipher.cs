// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the Cipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Abstract
{
    using System.Collections.Generic;
    using System.Text;
    using Extension;

    public abstract class Cipher
    {
        #region Словарь шифров
        /// <summary>
        /// Словарь английского алфавита и ключей
        /// </summary>
        protected static readonly Dictionary<char, char> CipherDictionary = new Dictionary<char, char>()
                                                                                  {
                                                                                          { 'a', 'x' },
                                                                                          { 'b', 'g' },
                                                                                          { 'c', 'u' },
                                                                                          { 'd', 'a' },
                                                                                          { 'e', 'c' },
                                                                                          { 'f', 'd' },
                                                                                          { 'g', 't' },
                                                                                          { 'h', 'b' },
                                                                                          { 'i', 'f' },
                                                                                          { 'j', 'h' },
                                                                                          { 'k', 'r' },
                                                                                          { 'l', 's' },
                                                                                          { 'm', 'l' },
                                                                                          { 'n', 'm' },
                                                                                          { 'o', 'q' },
                                                                                          { 'p', 'v' },
                                                                                          { 'q', 'y' },
                                                                                          { 'r', 'z' },
                                                                                          { 's', 'w' },
                                                                                          { 't', 'i' },
                                                                                          { 'u', 'e' },
                                                                                          { 'v', 'j' },
                                                                                          { 'w', 'o' },
                                                                                          { 'x', 'k' },
                                                                                          { 'y', 'n' },
                                                                                          { 'z', 'p' }
                                                                                  };
        #endregion

        protected static readonly string[][] MatrixAlphabetic =
        {
                    new[] { "l", "z", "q", "c", "p" },
                    new[] { "a", "g", "n", "o", "u" },
                    new[] { "r", "d", "m", "i", "f" },
                    new[] { "k", "y", "h", "v", "s" },
                    new[] { "x", "b", "t", "e", "w" },
        };

        /// <summary>
        /// Английский словарь (получаем из словаря шифров)
        /// </summary>
        protected static readonly string[] EnglishAlphabetic = CipherDictionary.Keys.ToStringArray();

        public static string GetEnglishAlphabetic()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var letter in EnglishAlphabetic) stringBuilder.Append(letter + "  ");
            return stringBuilder.ToString();
        }

        public static string GetCipherDictionary()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var key in CipherDictionary) stringBuilder.Append(key.Key + "  ");
            stringBuilder.AppendLine();
            foreach (var value in CipherDictionary) stringBuilder.Append(value.Value + "  ");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }

        public static string GetMatrixAlphabetic()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var column in MatrixAlphabetic)
            {
                foreach (var letter in column) stringBuilder.Append(letter + "  ");
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }
    }
}