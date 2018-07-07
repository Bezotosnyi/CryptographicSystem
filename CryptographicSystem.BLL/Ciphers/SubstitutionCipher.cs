// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubstitutionCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the SubstitutionCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using Abstract;

    /// <summary>
    /// Шифры простой и многократной подстановки
    /// </summary>
    public sealed class SubstitutionCipher : Cipher, ICipher
    {
        /// <summary>
        /// Количество подстановок
        /// </summary>
        private readonly int countSubstitution;

        /// <summary>
        /// Новый экземпляр класса <see cref="SubstitutionCipher"/>
        /// </summary>
        public SubstitutionCipher()
            : this(1)
        {
        }

        /// <summary>
        /// Новый экземпляр класса <see cref="SubstitutionCipher"/>
        /// </summary>
        /// <param name="countSubstitution">
        /// Количество подстановок
        /// </param>
        public SubstitutionCipher(int countSubstitution)
        {
            this.countSubstitution = countSubstitution;
        }

        /// <summary>
        /// Шифрование шифром подстановки
        /// </summary>
        /// <param name="text">Обычный текст</param>
        /// <returns>Зашифрованый текст</returns>
        public string Encrypt(string text)
        {
            // проверка не пустой ли текст. если пуст то ошибка ArgumentNullException
            if (text == null) throw new ArgumentNullException(nameof(text));

            // записываем пустую строку в перенную для накапливания результата
            string encryptText = string.Empty;

            var charArray = text.ToCharArray(); // переводим строку в массив символов

            int n = this.countSubstitution; // количество подстановок

            do
            {
                // цикл по символам
                foreach (var c in charArray)  
                {
                    bool replace = false; // переменная замены

                    // цикл по словарю
                    foreach (var kvp in Cipher.CipherDictionary)
                    {
                        // проверка на соответсвие символа с словаре
                        if (char.ToLower(c) == kvp.Key)
                        {
                            // проверка большая ли буква
                            if (char.IsUpper(c))
                                encryptText += char.ToUpper(kvp.Value);
                            else
                                encryptText += kvp.Value;
                            replace = true; // произошла замена
                            break;
                        }
                    }

                    // если не было замены то просто добавляем этот символ
                    if (!replace) encryptText += c;
                }

                n--; // уменьшаем количество подстановок

                // если количество подстановок не равно 0
                if (n != 0)
                {
                    charArray = encryptText.ToCharArray(); // переводим строку в массив символов
                    encryptText = string.Empty;
                }
            }
            while (n != 0); // выходим из цикла когда количество подстановок = 0

            return encryptText;
        }

        /// <summary>
        /// Расшифрование шифром подстановки
        /// </summary>
        /// <param name="text">Зашифрованый текст</param>
        /// <returns>Обычный текст</returns>
        public string Decrypt(string text)
        {
            // проверка не пустой ли текст. если пуст то ошибка ArgumentNullException
            if (text == null) throw new ArgumentNullException(nameof(text));

            // записываем пустую строку в перенную для накапливания результата
            string decryptText = string.Empty;

            var charArray = text.ToCharArray(); // переводим строку в массив символов

            int n = this.countSubstitution; // количество подстановок

            do
            {
                // цикл по символам
                foreach (var c in charArray)
                {
                    bool replace = false; // переменная замены

                    // цикл по словарю
                    foreach (var kvp in Cipher.CipherDictionary)
                    {
                        // проверка на соответсвие символа с словаре
                        if (char.ToLower(c) == kvp.Value)
                        {
                            // проверка большая ли буква
                            if (char.IsUpper(c))
                                decryptText += char.ToUpper(kvp.Key);
                            else
                                decryptText += kvp.Key;
                            replace = true; // произошла замена
                            break;
                        }
                    }

                    // если не было замены то просто добавляем этот символ
                    if (!replace) decryptText += c;
                }

                n--; // уменьшаем количество подстановок 

                // если количество подстановок не равно 0
                if (n != 0)
                {
                    charArray = decryptText.ToCharArray(); // переводим строку в массив символов
                    decryptText = string.Empty;
                }
            }
            while (n != 0); // выходим из цикла когда количество подстановок = 0

            return decryptText;
        }

        /// <summary>
        /// Поиск наименьшего общего кратного
        /// </summary>
        /// <param name="numbers">Числа для поиска НОК</param>
        /// <returns>Наименьшое общее кратное</returns>
        private int LeastCommonMultiple(params int[] numbers)
        {
            int leastMultiple = -1;
            int maxLeastMultiple = 1;

            foreach (int n in numbers)
                maxLeastMultiple *= n;

            for (int i = 1; i <= maxLeastMultiple; i++)
            {
                bool find = false;
                foreach (int n in numbers)
                {
                    if (i % n == 0) find = true;
                    else
                    {
                        find = false;
                        break;
                    }
                }

                if (find)
                {
                    leastMultiple = i;
                    break;
                }
            }

            return leastMultiple;
        }
    }
}