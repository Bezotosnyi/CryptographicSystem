// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NGrammarSubstitutionCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the NGrammarSubstitutionCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Abstract;

    using CryptographicSystem.BLL.Extension;

    public sealed class NGrammarSubstitutionCipher : Cipher, ICipher
    {
        private readonly Dictionary<string, string> grammarDictionary = new Dictionary<string, string>();

        public NGrammarSubstitutionCipher(int grammarLength = 2)
        {
            this.FormationGrammarDictionary(grammarLength);
        }

        public Dictionary<string, string> GetGrammarDictionary()
        {
            return this.grammarDictionary;
        }

        public string Encrypt(string text)
        {
            string encryptText = string.Empty;

            if (text.Length % 2 != 0) text += " ";

            var textArray = text.Splitter(2);

            foreach (string letter in textArray)
            {
                if (this.grammarDictionary.ContainsKey(letter.ToLower()))
                {
                    var str = this.grammarDictionary
                            .Where(kvp => kvp.Key == letter.ToLower())
                            .Select(kvp => kvp.Value)
                            .ToStr();
                    if (char.IsUpper(letter[0]) && char.IsUpper(letter[1]))
                        encryptText += str.ToUpper();
                    else if (char.IsUpper(letter[0]) && !char.IsUpper(letter[1]))
                        encryptText += str[0].ToString().ToUpper() + str[1];
                    else if (!char.IsUpper(letter[0]) && char.IsUpper(letter[1]))
                        encryptText += str[0] + str[1].ToString().ToUpper();
                    else
                        encryptText += str;
                    continue;
                }

                #region 
                //string s1 = letter[0].ToString();
                //string s2 = letter[1].ToString();

                //string key = s1 + s1;
                //if (this.grammarDictionary.ContainsKey(key.ToLower()))
                //{
                //    var str = this.grammarDictionary
                //            .Where(kvp => kvp.Key == key.ToLower())
                //            .Select(kvp => kvp.Value)
                //            .ToStr();

                //    if (char.IsUpper(key[0]))
                //        encryptText += str.ToUpper() + s2;
                //    else
                //        encryptText += str + s2;
                //    continue;
                //}

                //key = s2 + s2;
                //if (this.grammarDictionary.ContainsKey(key.ToLower()))
                //{
                //    var str = this.grammarDictionary
                //            .Where(kvp => kvp.Key == key.ToLower())
                //            .Select(kvp => kvp.Value)
                //            .ToStr();

                //    if (char.IsUpper(key[0]))
                //        encryptText += s1 + str.ToUpper();
                //    else
                //        encryptText += s1 + str;
                //    continue;
                //}
                #endregion

                encryptText += letter;
            }

            return encryptText;
        }

        public string Decrypt(string text)
        {
            string decryptText = string.Empty;

            if (text.Length % 2 != 0) text += " ";

            var textArray = text.Splitter(2);

            foreach (string letter in textArray)
            {
                if (this.grammarDictionary.ContainsValue(letter.ToLower()))
                {
                    var str = this.grammarDictionary
                            .Where(kvp => kvp.Value == letter.ToLower())
                            .Select(kvp => kvp.Key)
                            .ToStr();

                    if (str[0] == str[1])
                    {
                        if (char.IsUpper(letter[0]))
                            decryptText += str[0].ToString().ToUpper();
                        else
                            decryptText += str[0];
                    }
                    else if (char.IsUpper(letter[0]) && char.IsUpper(letter[1]))
                        decryptText += str.ToUpper();
                    else if (char.IsUpper(letter[0]) && !char.IsUpper(letter[1]))
                        decryptText += str[0].ToString().ToUpper() + str[1];
                    else if (!char.IsUpper(letter[0]) && char.IsUpper(letter[1]))
                        decryptText += str[0] + str[1].ToString().ToUpper();
                    else
                        decryptText += str;
                    continue;
                }

                #region 
                //string s1 = letter[0].ToString();
                //string s2 = letter[1].ToString();

                //string key = s1 + s1;
                //if (this.grammarDictionary.ContainsValue(key.ToLower()))
                //{
                //    var str = this.grammarDictionary
                //            .Where(kvp => kvp.Value == key.ToLower())
                //            .Select(kvp => kvp.Key)
                //            .ToStr();

                //    if (char.IsUpper(key[0]))
                //        decryptText += str[0].ToString().ToUpper() + s2;
                //    else
                //        decryptText += str[0] + s2;
                //    continue;
                //}

                //key = s2 + s2;
                //if (this.grammarDictionary.ContainsValue(key.ToLower()))
                //{
                //    var str = this.grammarDictionary
                //            .Where(kvp => kvp.Value == key.ToLower())
                //            .Select(kvp => kvp.Key)
                //            .ToStr();

                //    if (char.IsUpper(key[0]))
                //        decryptText += s1 + str[0].ToString().ToUpper();
                //    else
                //        decryptText += s1 + str[0];
                //    continue;
                //}
                #endregion

                decryptText += letter;
            }

            //var s = decryptText.ToStringArray();
            //for (int i = 1; i < s.Length - 1; i++)
            //{
            //    if (s[i - 1] == " " && s[i] == " ") s[i] = string.Empty;
            //}

            return decryptText;
        }

        public string ShowGrammarDictionary()
        {
            var stringBuilder = new StringBuilder();
            int index = 0, i = 0;

            stringBuilder.Append(" ");
            foreach (var letter in Cipher.EnglishAlphabetic) stringBuilder.Append("|" + letter + " ");
            stringBuilder.AppendLine("|");

            stringBuilder.Append(" +");
            for (int j = 1; j < Cipher.EnglishAlphabetic.Length; j++) stringBuilder.Append("---");
            stringBuilder.AppendLine("--+");

            stringBuilder.Append(Cipher.EnglishAlphabetic[0] + "|");

            foreach (var kvp in this.grammarDictionary)
            {
                stringBuilder.Append(kvp.Value + "|");
                index++;
                if (index == Cipher.EnglishAlphabetic.Length)
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    if (i <= Cipher.EnglishAlphabetic.Length - 1) stringBuilder.AppendLine("|" + Cipher.EnglishAlphabetic[i]);
                    stringBuilder.Append(" +");
                    for (int j = 1; j < Cipher.EnglishAlphabetic.Length; j++) stringBuilder.Append("---");
                    stringBuilder.AppendLine("--+");
                    if (i <= Cipher.EnglishAlphabetic.Length - 2) stringBuilder.Append(Cipher.EnglishAlphabetic[++i] + "|");
                    index = 0;
                }
            }

            stringBuilder.Append(" ");
            foreach (var letter in Cipher.EnglishAlphabetic) stringBuilder.Append("|" + letter + " ");
            stringBuilder.AppendLine("|");

            return stringBuilder.ToString();
        }

        private void FormationGrammarDictionary(int grammarLength)
        {
            Random random = new Random();
            foreach (string t1 in Cipher.EnglishAlphabetic)
            {
                foreach (string t2 in Cipher.EnglishAlphabetic)
                {
                    string s1 = $"{t1}{t2}";
                    string s2;
                    do
                    {
                        s2 = string.Empty;
                        for (int k = 0; k < grammarLength; k++) s2 += Cipher.EnglishAlphabetic[random.Next(0, Cipher.EnglishAlphabetic.Length)];

                        if (this.grammarDictionary.Count == 0) break;
                    }
                    while (this.grammarDictionary.ContainsValue(s2));

                    this.grammarDictionary.Add(s1, s2);
                }
            }
        }
    }
}