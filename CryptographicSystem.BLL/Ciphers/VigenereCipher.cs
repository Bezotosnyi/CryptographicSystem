// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VigenereCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the VigenereCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Abstract;
    using Enum;
    using Extension;

    /// <summary>
    /// Шифр Виженера и его варианты
    /// </summary>
    public sealed class VigenereCipher : Cipher, ICipher
    {
        private readonly string[] keyArray;
        private readonly VigenereCipherType typeVigenereCipher;
        private readonly SubstitutionCipher substitutionCipher;

        /// <summary>
        /// Новый экземпляр класса <see cref="VigenereCipher"/>
        /// </summary>
        /// <param name="keyArray">Ключ</param>
        public VigenereCipher(params string[] keyArray)
            : this(keyArray, VigenereCipherType.None)
        {
        }

        /// <summary>
        /// Новый экземпляр класса <see cref="VigenereCipher"/>
        /// </summary>
        /// <param name="keyArray">Ключ</param>
        /// <param name="typeVigenereCipher">Тип шифра Виженера с перемешанным один раз алфавитом<code cref="VigenereCipherType"/></param>
        public VigenereCipher(string[] keyArray, VigenereCipherType typeVigenereCipher)
        {
            this.keyArray = keyArray;
            this.typeVigenereCipher = typeVigenereCipher;
            this.substitutionCipher = new SubstitutionCipher();
        }

        /// <summary>
        /// Шифрование шифром Виженера
        /// </summary>
        /// <param name="text">Обычный текст</param>
        /// <returns>Зашифрованый тест</returns>
        public string Encrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            string encryptText = string.Empty;
            int module = EnglishAlphabetic.Length;

            if (this.typeVigenereCipher == VigenereCipherType.Straight) this.substitutionCipher.Encrypt(text);

            var textPosition = this.GetPositionCharOfDictionary(text.ToStringArray());

            for (int k = 0; k < this.keyArray.Length; k++)
            {
                encryptText = string.Empty;

                var keyPosition = this.GetPositionCharOfDictionary(this.keyArray[k].ToStringArray());
                var indexUpperCase = this.GetIndexUpperCase(text);

                int index = 0;
                for (int i = 0; i < textPosition.Length; i++)
                {
                    if (!textPosition[i].HasValue)
                    {
                        encryptText += text[i];
                        continue;
                    }

                    int position;
                    while (true)
                    {
                        if (index >= keyPosition.Length) index = 0;

                        var o = keyPosition[index++];
                        if (o != null)
                        {
                            position = o.Value;
                            break;
                        }
                    }

                    int resultIndex = (textPosition[i].Value + position) % module;

                    if (indexUpperCase.Contains(i)) encryptText += this.GetCharPositionOfDictionary(resultIndex).ArrayToString().ToUpper();
                    else encryptText += this.GetCharPositionOfDictionary(resultIndex).ArrayToString();

                    if (index >= keyPosition.Length) index = 0;
                }
            }

            if (this.typeVigenereCipher == VigenereCipherType.Reverse) this.substitutionCipher.Encrypt(text);

            return encryptText;
        }

        /// <summary>
        /// Дешифрование шифром Виженера
        /// </summary>
        /// <param name="text">Зашифрованый текст</param>
        /// <returns>Обычный текст</returns>
        public string Decrypt(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            string decryptText = string.Empty;
            int module = EnglishAlphabetic.Length;
            var textPosition = this.GetPositionCharOfDictionary(text.ToStringArray());

            if (this.typeVigenereCipher == VigenereCipherType.Reverse) this.substitutionCipher.Decrypt(text);

            for (int k = 0; k < this.keyArray.Length; k++)
            {
                decryptText = string.Empty;

                var keyPosition = this.GetPositionCharOfDictionary(this.keyArray[k].ToStringArray());
                var indexUpperCase = this.GetIndexUpperCase(text);

                int index = 0;
                for (int i = 0; i < textPosition.Length; i++)
                {
                    if (!textPosition[i].HasValue)
                    {
                        decryptText += text[i];
                        continue;
                    }

                    int position;
                    while (true)
                    {
                        if (index >= keyPosition.Length) index = 0;

                        var o = keyPosition[index++];
                        if (o != null)
                        {
                            position = o.Value;
                            break;
                        }
                    }
                    int resultIndex = textPosition[i].Value - position;

                    if (resultIndex < 0) resultIndex += module;

                    if (indexUpperCase.Contains(i))
                        decryptText += this.GetCharPositionOfDictionary(resultIndex).ArrayToString().ToUpper();
                    else
                        decryptText += this.GetCharPositionOfDictionary(resultIndex).ArrayToString();

                    if (index >= keyPosition.Length) index = 0;
                }
            }

            if (this.typeVigenereCipher == VigenereCipherType.Straight) this.substitutionCipher.Decrypt(text);

            return decryptText;
        }

        /// <summary>
        /// Получаем массив с порядковыми номерами символа в алфавите
        /// </summary>
        /// <param name="strArray">Массив символов</param>
        /// <returns>Массив с порядковыми номерами символа в алфавите</returns>
        private int?[] GetPositionCharOfDictionary(params string[] strArray)
        {
            if (strArray == null) throw new ArgumentNullException(nameof(strArray));

            var positionCharArray = new int?[strArray.Length];

            for (int i = 0; i < positionCharArray.Length; i++)
            {
                for (int j = 0; j < Cipher.EnglishAlphabetic.Length; j++)
                {
                    if (strArray[i].ToLower() == Cipher.EnglishAlphabetic[j])
                    {
                        positionCharArray[i] = j;
                        break;
                    }
                }
            }

            return positionCharArray;
        }

        /// <summary>
        /// Получаем массив с символами по порядковому номеру в алфавите
        /// </summary>
        /// <param name="positionArray">Массив позиций</param>
        /// <returns>Массив с символами по порядковому номеру в алфавите</returns>
        private string[] GetCharPositionOfDictionary(params int?[] positionArray)
        {
            if (positionArray == null) throw new ArgumentNullException(nameof(positionArray));

            var charOfPositionArray = new string[positionArray.Length];

            for (int i = 0; i < charOfPositionArray.Length; i++)
            {
                if (!positionArray[i].HasValue) continue;
                charOfPositionArray[i] = Cipher.EnglishAlphabetic[positionArray[i].Value];
            }

            return charOfPositionArray;
        }

        /// <summary>
        /// Ищет где большие буквы
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Массив с номерами где большие буквы</returns>
        private int[] GetIndexUpperCase(string str)
        {
            List<int> upperPositionList = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (EnglishAlphabetic.Contains(char.ToLower(str[i]).ToString()) && char.IsUpper(str[i]))
                    upperPositionList.Add(i);
            }

            return upperPositionList.ToArray();
        }
    }
}