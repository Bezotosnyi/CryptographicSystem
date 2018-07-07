// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogicCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the LogicCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.UI
{
    using System;
    using System.Windows.Forms;

    using BLL.Abstract;
    using BLL.Ciphers;
    using BLL.Ciphers.Enum;
    using BLL.Extension;
    using Enum;

    public static class LogicCipher
    {
        private static SubstitutionCipher substitutionCipher;
        private static TranspositionCipher transpositionCipher;
        private static VigenereCipher vigenereCipher;
        private static RunningKeyCipher runningKeyCipher;
        private static CaesarCipher caesarCipher;
        private static FractionalCipher fractionalCipher;
        private static PlayFairCipher playFairCipher;

        public static string SubstitutionCipher(string text, int n, CryptType cryptType)
        {
            string result = string.Empty;
            substitutionCipher = new SubstitutionCipher(n);
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = substitutionCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = substitutionCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string TranspositionCipher(string text, string transpositionArray, CryptType cryptType)
        {
            string result = string.Empty;
            var strArray = transpositionArray.Split(' ');
            var keyArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++) keyArray[i] = int.Parse(strArray[i]);
            transpositionCipher = new TranspositionCipher(keyArray);
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = transpositionCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = transpositionCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string VigenereCipher(string text, string key, VigenereCipherType vigenereCipherType, CryptType cryptType)
        {
            string result = string.Empty;
            vigenereCipher = new VigenereCipher(key.Split(' '), vigenereCipherType);
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = vigenereCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = vigenereCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string VermanCipher(string text, int keyLength, out string generatedKey, ref VermanCipher vermanCipher, CryptType cryptType)
        {
            string result = string.Empty;
            if (vermanCipher == null) vermanCipher = new VermanCipher(keyLength);
            generatedKey = vermanCipher.GeneratedKey;
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = vermanCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = vermanCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string RunningKeyCipher(string text, string sensText, CryptType cryptType)
        {
            string result = string.Empty;
            runningKeyCipher = new RunningKeyCipher(sensText);
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = runningKeyCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = runningKeyCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string CaesarCipher(string text, int shiftLength, CryptType cryptType)
        {
            string result = string.Empty;
            caesarCipher = new CaesarCipher(shiftLength);
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = caesarCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = caesarCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string NGrammarSubstitutionCipher(string text, out string showText, ref NGrammarSubstitutionCipher grammarSubstitutionCipher, CryptType cryptType)
        {
            string result = string.Empty;
            if (grammarSubstitutionCipher == null) grammarSubstitutionCipher = new NGrammarSubstitutionCipher();
            var dictionary = grammarSubstitutionCipher.GetGrammarDictionary();
            showText = string.Empty;
            int index = 0;
            foreach (var kvp in dictionary)
            {
                showText += kvp.Key + "=" + kvp.Value + "; ";
                index++;
                if (index == 26)
                {
                    showText += "\n";
                    index = 0;
                }
            }
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = grammarSubstitutionCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = grammarSubstitutionCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string PlayFairCipher(string text, CryptType cryptType)
        {
            string result = string.Empty;
            playFairCipher = new PlayFairCipher();
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = playFairCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = playFairCipher.Decrypt(text);
                    break;
            }

            return result;
        }

        public static string AutoKeyCipher(string text, string key, ref string generateKey, ref AutoKeyCipher autoKeyCipher, AutoKeyCipherType autoKeyCipherType, CryptType cryptType)
        {
            string result = string.Empty;
            if (autoKeyCipher == null) autoKeyCipher = new AutoKeyCipher(key, autoKeyCipherType);
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = autoKeyCipher.Encrypt(text);
                    generateKey = autoKeyCipher.PrimaryKey;
                    break;
                case CryptType.Decrypt:
                    result = autoKeyCipher.Decrypt(text);
                    generateKey = autoKeyCipher.PrimaryKey;
                    break;
            }

            return result;
        }

        public static string FractionalCipher(string text, CryptType cryptType)
        {
            string result = string.Empty;
            fractionalCipher = new FractionalCipher();
            switch (cryptType)
            {
                case CryptType.Encrypt:
                    result = fractionalCipher.Encrypt(text);
                    break;
                case CryptType.Decrypt:
                    result = fractionalCipher.Decrypt(text);
                    break;
            }

            return result;
        }
    }
}