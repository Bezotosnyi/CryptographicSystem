// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.Console
{
    using System;
    using System.ComponentModel;

    public class Program
    {
        public static void Main(string[] args)
        {
            //OutputResult.SubstitutionCipherTest();
            OutputResult.TranspositionCipherTest();
            //OutputResult.VigenereCipherTest();
            //OutputResult.VermanCipherTest();
            //OutputResult.RunningKeyCipherTest();
            //OutputResult.CaesarCipherTest();
            //OutputResult.AutoKeyCipherTest();
            //OutputResult.FractionalCipherTest();
            //OutputResult.NGrammarSubstitutionCipherTest();
            //OutputResult.PlayFairCipherTest();

            Task3();

            Console.ReadKey();
        }

        public static void Task3()
        {
            int k = 0, mult = 0, m = 0;
            int[] key1 = { 3, 1, 5, 7, 9, 4, 2, 6, 8 };
            int[] key2 = { 5, 4, 3, 2, 1 };
            char[] enterArray =
                {
                    'T', 'N', 'N', 'A', 'A', 'C', 'O', '_', 'I', 'L', '_', 'O', 'M', 'E', 'Y', 'C', '_',
                    'O', 'O', 'N', 'H', 'O', 'T', '_', 'F', 'N', '_', 'T', 'E', 'U', '_', 'Y', '_', 'R',
                    '_', '_', '_', '_', '_', '_'
                };

            var bufferArray1 = new char[key1.Length];
            var bufferArray2 = new char[key2.Length];
            for (int i = 0; i < enterArray.Length; i++)
            {
                bufferArray2[k] = enterArray[i];
                k++;
                if ((i + 1) % key2.Length == 0)
                {
                    for (int j = mult; j < key2.Length + mult; j++)
                    {
                        enterArray[j] = bufferArray2[key2[m] - 1];
                        Console.Write(enterArray[j]);
                        m++;
                    }

                    m = 0;
                    k = 0;
                    mult = mult + key2.Length;
                }
            }

            Console.Write('\n');
            k = 0;
            for (int i = 0; i < enterArray.Length; i++)
            {
                bufferArray1[k] = enterArray[i];
                k++;
                if ((i + 1) % key1.Length == 0)
                {
                    for (int j = 0; j < key1.Length; j++)
                    {
                        enterArray[j] = bufferArray1[key1[j] - 1];
                        Console.Write(enterArray[j]);
                    }

                    k = 0;
                }
            }

            Console.Write("____");
        }
    }
}