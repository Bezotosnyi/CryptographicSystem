// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputResult.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the OutputResult type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.Console
{
    using System;
    using BLL.Ciphers;
    using BLL.Ciphers.Enum;
    using BLL.Abstract;
    using BLL.Extension;

    public static class OutputResult
    {
        private static string encryptText;
        private static string decryptText;
        private static string cryptogram;
        private static SubstitutionCipher substitutionCipher;
        private static TranspositionCipher transpositionCipher;
        private static VigenereCipher vigenereCipher;
        private static VermanCipher vermanCipher;
        private static RunningKeyCipher runningKeyCipher;
        private static CaesarCipher caesarCipher;
        private static AutoKeyCipher autoKeyCipher;
        private static FractionalCipher fractionalCipher;
        private static NGrammarSubstitutionCipher grammarSubstitutionCipher;
        private static PlayFairCipher playFairCipher;

        /// <summary>
        /// Шифры простой и многократной подстановки
        /// </summary>
        public static void SubstitutionCipherTest()
        {
            Console.WriteLine("1. Шифры простой и многократной подстановки");

            // Шифр простой подстановки
            Console.WriteLine("Шифр простой подстановки");
            Console.WriteLine("Пример работы программы");
            cryptogram = "I study at DNU";
            Console.WriteLine("Текст: " + cryptogram);
            substitutionCipher = new SubstitutionCipher();
            encryptText = substitutionCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = substitutionCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            // Упражнение. Используя перестановку примера, расшифруйте криптограмму: 
            Console.WriteLine("Упражнение. Используя перестановку примера, расшифруйте криптограмму: ");
            cryptogram = "MEUSCXZOCXVQM";
            Console.WriteLine(cryptogram);
            Console.WriteLine(substitutionCipher.Decrypt(cryptogram));
            Console.WriteLine();

            // Шифр многократной подстановки
            Console.WriteLine("Шифр многократной подстановки");
            Console.WriteLine("Пример работы программы");
            cryptogram = "INPUT";
            Console.WriteLine("Текст: " + cryptogram);
            int n = 3;
            substitutionCipher = new SubstitutionCipher(n);
            encryptText = substitutionCipher.Encrypt(cryptogram);
            Console.WriteLine($"Зашифрованый текст при n = {n}: {encryptText}");
            decryptText = substitutionCipher.Decrypt(encryptText);
            Console.WriteLine($"Расшифрованый текст при n = {n}: {decryptText}");

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Перестановочные шифры с фиксированным периодом
        /// </summary>
        public static void TranspositionCipherTest()
        {
            Console.WriteLine("2. Перестановочные шифры с фиксированным периодом");

            cryptogram = "12345 qwer asdf";
            Console.WriteLine("Текст: " + cryptogram);
            Console.WriteLine("Перестановки: " + new[] { 2, 3, 1, 5, 4 }.ArrayToString(" "));
            transpositionCipher = new TranspositionCipher(new[] { 2, 3, 1, 5, 4 });
            encryptText = transpositionCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = transpositionCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            //// Одна перестановка
            //Console.WriteLine("Перестановочный шифр с одной перестановкой");
            //Console.WriteLine("Пример работы программы");
            //cryptogram = "My is Dimon!<3 йцукенгш1245";
            //Console.WriteLine("Текст: " + cryptogram);
            //Console.WriteLine("Перестановки: " + new int[] { 4, 3, 7, 1, 5, 6, 2 }.ArrayToString(" "));
            //transpositionCipher = new TranspositionCipher(new int[] { 4, 3, 7, 1, 5, 6, 2 });
            //encryptText = transpositionCipher.Encrypt(cryptogram);
            //Console.WriteLine("Зашифрованый текст: " + encryptText);
            //decryptText = transpositionCipher.Decrypt(encryptText);
            //Console.WriteLine("Расшифрованый текст: " + decryptText);

            //// Упражнение. Расшифруйте, используя ключ (перестановку) 4 3 7 1 5 6 2:
            //Console.WriteLine("\nУпражнение. Расшифруйте, используя ключ (перестановку) 4 3 7 1 5 6 2:");
            //cryptogram = "TMOD_SN_RKOHEELS_EEAP___E___";
            //Console.WriteLine(cryptogram);
            //transpositionCipher = new TranspositionCipher(new int[] { 4, 3, 7, 1, 5, 6, 2 });
            //decryptText = transpositionCipher.Decrypt(cryptogram);
            //Console.WriteLine(decryptText);

            //// Несколько перестановок
            //Console.WriteLine("\nПерестановочный шифр с несколько перестановками");

            //// Упражнение. Расшифруйте криптограмму, полученную двумя последовательными перестановками
            //Console.Write("Упражнение. Расшифруйте криптограмму, полученную двумя последовательными перестановками: ");
            //Console.WriteLine("3 1 5 7 9 4 2 6 8 и 5 4 3 2 1:");
            //cryptogram = "TNNAACO_IL_OMEYC_OONHOT_FN_TEU_Y_R___________";
            ////cryptogram = "My name is Dima! I study at DNU! Oh yeah azaz";
            //Console.WriteLine(cryptogram);
            //transpositionCipher = new TranspositionCipher(new int[] { 3, 1, 5, 7, 9, 4, 2, 6, 8 }, new int[] { 5, 4, 3, 2, 1 });
            //encryptText = transpositionCipher.Encrypt(cryptogram);
            //Console.WriteLine("Зашифрованый текст: " + encryptText);
            //decryptText = transpositionCipher.Decrypt(cryptogram);
            //Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Шифр Виженера и его варианты
        /// </summary>
        public static void VigenereCipherTest()
        {
            Console.WriteLine("3. Шифр Виженера и его варианты");

            // Простой шифр Виженера
            Console.WriteLine("\nПростой шифр Виженера");
            Console.WriteLine("Пример работы программы");
            cryptogram = "N  O  W  I  S  T  H  E";
            Console.WriteLine("Текст: " + cryptogram);
            Console.WriteLine("Ключ: " + "GAH");
            vigenereCipher = new VigenereCipher("GAH");
            encryptText = vigenereCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = vigenereCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            // Составной шифр Виженера 
            Console.WriteLine("\nСоставной шифр Виженера");
            Console.WriteLine("Пример работы программы");
            cryptogram = "My name is Dima";
            Console.WriteLine("Текст: " + cryptogram);
            Console.WriteLine("Ключ: " + string.Join(" ", "azaza", "dima"));
            vigenereCipher = new VigenereCipher("azaza", "dima");
            encryptText = vigenereCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = vigenereCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            // Шифр Виженера с перемешанным один раз алфавитом
            Console.WriteLine("\nШифр Виженера с перемешанным один раз алфавитом");

            // Прямой вариант
            Console.WriteLine("\nПрямой вариант");
            Console.WriteLine("Пример работы программы");
            cryptogram = "My name is Dima";
            Console.WriteLine("Текст: " + cryptogram);
            Console.WriteLine("Ключ: " + string.Join(" ", "azaza", "dima"));
            vigenereCipher = new VigenereCipher(new[] { "azaza", "dima" }, VigenereCipherType.Straight);
            encryptText = vigenereCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = vigenereCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            // Обратный вариант
            Console.WriteLine("\nОбратный вариант");
            Console.WriteLine("Пример работы программы");
            cryptogram = "My name is Dima";
            Console.WriteLine("Текст: " + cryptogram);
            var k = new[] { "azaza", "dima" };
            Console.WriteLine("Ключ: " + string.Join(" ", k));
            vigenereCipher = new VigenereCipher(k, VigenereCipherType.Reverse);
            encryptText = vigenereCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = vigenereCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Шифр Вернама
        /// </summary>
        public static void VermanCipherTest()
        {
            Console.WriteLine("4. Шифр Вернама");

            Console.WriteLine("Пример работы программы");
            cryptogram = "I study at DNU";
            Console.WriteLine("Текст: " + cryptogram);
            int lengthKey = 5;
            vermanCipher = new VermanCipher(lengthKey);
            Console.WriteLine($"Случайно сгенерированный ключ длиной {lengthKey}: {vermanCipher.GeneratedKey}");
            encryptText = vermanCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = vermanCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Шифр бегущего ключа
        /// </summary>
        public static void RunningKeyCipherTest()
        {
            Console.WriteLine("5. Шифр бегущего ключа");

            Console.WriteLine("Пример работы программы");
            cryptogram = "I study at DNU";
            Console.WriteLine("Текст: " + cryptogram);
            string sensText = "Tis is SPARTA!";
            Console.WriteLine("Осмысленный текст: " + sensText);
            runningKeyCipher = new RunningKeyCipher(sensText);
            encryptText = runningKeyCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = runningKeyCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");

        }

        /// <summary>
        /// Шифр Цезаря
        /// </summary>
        public static void CaesarCipherTest()
        {
            Console.WriteLine("6. Шифр Цезаря");

            Console.WriteLine("Пример работы программы");
            cryptogram = "I study at DNU!";
            Console.WriteLine("Текст: " + cryptogram);
            int shift = 2;
            Console.WriteLine("Длина сдвига алфавита: " + shift);
            caesarCipher = new CaesarCipher(shift);
            encryptText = caesarCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = caesarCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            // Расшифруйте криптограмму (n = 2)
            Console.WriteLine("\nРасшифруйте криптограмму (n = 2)");
            shift = 2;
            cryptogram = "YGBPGGFBOQTGBUPQYBHQTBDCVVGTBUMKKPI";
            Console.WriteLine("Текст: " + cryptogram);
            Console.WriteLine("Длина сдвига алфавита: " + shift);
            caesarCipher = new CaesarCipher(shift);
            decryptText = caesarCipher.Decrypt(cryptogram);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }

        public static void AutoKeyCipherTest()
        {
            Console.WriteLine("6. Шифр с автоключом");

            // Использование текста в качестве ключа
            Console.WriteLine("\nИспользование текста в качестве ключа");
            Console.WriteLine("Пример работы программы");
            cryptogram = "SENDSUPPLIES";
            Console.WriteLine("Текст: " + cryptogram);
            string key = "COMET";
            autoKeyCipher = new AutoKeyCipher(key, AutoKeyCipherType.UseText);
            encryptText = autoKeyCipher.Encrypt(cryptogram);
            Console.WriteLine("Ключ: " + key);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = autoKeyCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            // Использование криптограмы текста в качестве ключа
            Console.WriteLine("\nИспользование криптограмы текста в качестве ключа");
            Console.WriteLine("Пример работы программы");
            cryptogram = "SENDSUPPLIES";
            Console.WriteLine("Текст: " + cryptogram);
            key = "COMET";
            autoKeyCipher = new AutoKeyCipher(key, AutoKeyCipherType.UseCryptogram);
            encryptText = autoKeyCipher.Encrypt(cryptogram);
            Console.WriteLine("Ключ: " + key);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = autoKeyCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }

        public static void FractionalCipherTest()
        {
            Console.WriteLine("7. Дробный шифр");

            Console.WriteLine("Пример работы программы");
            cryptogram = "dima";
            Console.WriteLine("Текст: " + cryptogram);
            fractionalCipher = new FractionalCipher();
            encryptText = fractionalCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = fractionalCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);
        }

        public static void NGrammarSubstitutionCipherTest()
        {
            Console.WriteLine("8. N-граммные подстановки");

            Console.WriteLine("Пример работы программы");
            cryptogram = "Dima Bezotosnyi is the best";
            Console.WriteLine("Текст: " + cryptogram);
            grammarSubstitutionCipher = new NGrammarSubstitutionCipher();
            Console.WriteLine(grammarSubstitutionCipher.ShowGrammarDictionary());
            encryptText = grammarSubstitutionCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = grammarSubstitutionCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }

        public static void PlayFairCipherTest()
        {
            Console.WriteLine("9. Шифр \"Плейфер\"");

            Console.WriteLine("Пример работы программы");
            cryptogram = "Dima Bezotosnyi!@#$%^&*12345";
            Console.WriteLine("Текст: " + cryptogram);
            playFairCipher = new PlayFairCipher();
            encryptText = playFairCipher.Encrypt(cryptogram);
            Console.WriteLine("Зашифрованый текст: " + encryptText);
            decryptText = playFairCipher.Decrypt(encryptText);
            Console.WriteLine("Расшифрованый текст: " + decryptText);

            Console.WriteLine("\n");
        }
    }
}
