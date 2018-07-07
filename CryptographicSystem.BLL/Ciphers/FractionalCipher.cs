// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FractionalCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the PlayFaFractionalCipherirCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    using System.Collections.Generic;

    using Abstract;
    using Extension;
    using Structure;

    public sealed class FractionalCipher : Cipher, ICipher
    {
        public string Encrypt(string text)
        {
            string encryptText = string.Empty;
            var textArray = text.ToStringArray();
            var letterList = new List<Letter>();

            foreach (string letter in textArray)
            {
                bool isAdd = false;
                for (int i = 0; i < Cipher.MatrixAlphabetic.Length; i++)
                {
                    for (int j = 0; j < Cipher.MatrixAlphabetic[i].Length; j++)
                    {
                        if (letter.ToLower() == Cipher.MatrixAlphabetic[i][j].ToString())
                        {
                            letterList.Add(new Letter($"{i}{j}", true));
                            isAdd = true;
                            break;
                        }
                    }

                    if (isAdd) break;
                }

                if (!isAdd) letterList.Add(new Letter(letter, false, char.IsUpper(char.Parse(letter))));
            }

            foreach (var value in letterList)
            {
                if (value.IsUpper && !value.IsNumber)
                    encryptText += value.Value.ToUpper();
                else
                    encryptText += value.Value;
            }

            return encryptText;
        }

        public string Decrypt(string text)
        {
            string decryptText = string.Empty;
            var textArray = text.ToStringArray();
            var letterList = new List<Letter>();

            int repeat = 0;
            for (int i = 0; i < textArray.Length; i++)
            {
                if (!char.IsDigit(char.Parse(textArray[i])))
                {
                    letterList.Add(new Letter(textArray[i], false));
                    repeat = 0;
                    continue;
                }

                repeat++;
                if (repeat == 2)
                {
                    letterList.Add(new Letter(Cipher.MatrixAlphabetic[int.Parse(textArray[i - 1])][int.Parse(textArray[i])].ToString(), true));
                    repeat = 0;
                }
            }

            foreach (var value in letterList)
            {
                decryptText += value.Value;
            }

            return decryptText;
        }
    }
}