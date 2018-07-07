// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayFairCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the PlayFairCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using Abstract;
    using Extension;

    public sealed class PlayFairCipher : Cipher, ICipher
    {
        public string Encrypt(string text)
        {
            string encryptText = string.Empty;

            if (text.Length % 2 != 0) text += " ";

            var textArray = text.Splitter(2);

            foreach (var element in textArray)
            {
                var s1 = element[0].ToString();
                var s2 = element[1].ToString();
                int i1, i2, j1, j2;

                // если буквы совпадают
                if (s1 == s2) 
                {
                    encryptText += element;
                    continue;
                }
                else if (this.GetIndex(s1.ToLower(), out i1, out j1) && this.GetIndex(s2.ToLower(), out i2, out j2))
                {
                    // не на одной горизонтали
                    if (i1 != i2)
                    {
                        // не на одной вертикали (ограничивают прямоугольную область)
                        if (j1 != j2)
                        {
                            s1 = Cipher.EnglishAlphabetic[i2][j1].ToString();
                            s2 = Cipher.EnglishAlphabetic[i1][j2].ToString();
                        }
                        else
                        {
                            // на одной вертикали
                            s1 = Cipher.EnglishAlphabetic[(i1 + 1) % Cipher.EnglishAlphabetic.Length][j1].ToString();
                            s2 = Cipher.EnglishAlphabetic[(i2 + 1) % Cipher.EnglishAlphabetic.Length][j2].ToString();
                        }
                    }
                    else
                    {
                        // на одной горизонтали
                        s1 = Cipher.EnglishAlphabetic[i1][(j1 + 1) % Cipher.EnglishAlphabetic.Length].ToString();
                        s2 = Cipher.EnglishAlphabetic[i2][(j2 + 1) % Cipher.EnglishAlphabetic.Length].ToString();
                    }
                }
                else
                {
                    encryptText += element;
                    continue;
                }

                if (char.IsUpper(element[0]) && char.IsUpper(element[1]))
                    encryptText += s1.ToUpper() + s2.ToUpper();
                else if (char.IsUpper(element[0]) && !char.IsUpper(element[1]))
                    encryptText += s1.ToUpper() + s2;
                else if (!char.IsUpper(element[0]) && char.IsUpper(element[1]))
                    encryptText += s1 + s2.ToUpper();
                else
                    encryptText += s1 + s2;
            }

            return encryptText;
        }

        public string Decrypt(string text)
        {
            string decryptText = string.Empty;

            if (text.Length % 2 != 0) text += " ";

            var textArray = text.Splitter(2);

            foreach (var element in textArray)
            {
                var s1 = element[0].ToString();
                var s2 = element[1].ToString();
                int i1, i2, j1, j2;

                // если буквы совпадают
                if (s1 == s2) 
                {
                    decryptText += element;
                    continue;
                }
                else if (this.GetIndex(s1.ToLower(), out i1, out j1) && this.GetIndex(s2.ToLower(), out i2, out j2))
                {
                    // не на одной горизонтали
                    if (i1 != i2)
                    {
                        // не на одной вертикали (ограничивают прямоугольную область)
                        if (j1 != j2)
                        {
                            s1 = Cipher.EnglishAlphabetic[i2][j1].ToString();
                            s2 = Cipher.EnglishAlphabetic[i1][j2].ToString();
                        }
                        else
                        {
                            // на одной вертикали
                            int index = (i1 - 1) % Cipher.EnglishAlphabetic.Length;
                            if (index < 0) index = Cipher.EnglishAlphabetic.Length - 1;
                            s1 = Cipher.EnglishAlphabetic[index][j1].ToString();

                            index = (i2 - 1) % Cipher.EnglishAlphabetic.Length;
                            if (index < 0) index = Cipher.EnglishAlphabetic.Length - 1;
                            s2 = Cipher.EnglishAlphabetic[index][j2].ToString();
                        }
                    }
                    else
                    {
                        // на одной горизонтали
                        int index = (j1 - 1) % Cipher.EnglishAlphabetic.Length;
                        if (index < 0) index = Cipher.EnglishAlphabetic.Length - 1;
                        s1 = Cipher.EnglishAlphabetic[i1][index].ToString();

                        index = (j2 - 1) % Cipher.EnglishAlphabetic.Length;
                        if (index < 0) index = Cipher.EnglishAlphabetic.Length - 1;
                        s2 = Cipher.EnglishAlphabetic[i2][index].ToString();
                    }
                }
                else
                {
                    decryptText += element;
                    continue;
                }

                if (char.IsUpper(element[0]) && char.IsUpper(element[1]))
                    decryptText += s1.ToUpper() + s2.ToUpper();
                else if (char.IsUpper(element[0]) && !char.IsUpper(element[1]))
                    decryptText += s1.ToUpper() + s2;
                else if (!char.IsUpper(element[0]) && char.IsUpper(element[1]))
                    decryptText += s1 + s2.ToUpper();
                else
                    decryptText += s1 + s2;
            }

            return decryptText;
        }

        private bool GetIndex(string s, out int i1, out int i2)
        {
            i1 = i2 = -1;

            for (int i = 0; i < Cipher.EnglishAlphabetic.Length; i++)
            {
                for (int j = 0; j < Cipher.EnglishAlphabetic[i].Length; j++)
                {
                    if (s == Cipher.EnglishAlphabetic[i][j].ToString())
                    {
                        i1 = i;
                        i2 = j;
                        break;
                    }
                }
            }

            return i1 != -1 && i2 != -1;
        }
    }
}