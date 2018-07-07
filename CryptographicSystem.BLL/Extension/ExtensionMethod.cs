// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionMethod.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the ExtensionMethod type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Extension
{
    using System;
    using System.Collections.Generic;

    using CryptographicSystem.BLL.Ciphers;

    /// <summary>
    /// Вспомогательный класс. Расширяет некоторые возможности стандартных элементов
    /// </summary>
    public static class ExtensionMethod
    {
        /// <summary>
        /// Разбивает строку на заданное количество групп
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="count">Количество групп</param>
        /// <returns>Строка, которая разбита на count групп</returns>
        public static string[] Splitter(this string str, int count)
        {
            var stringArray = str.ToStringArray();

            var resultStingArray = new string[str.Length / count];

            int index = 0;
            for (int i = 0; i < resultStingArray.Length; i++)
            {
                resultStingArray[i] = string.Empty;
                for (int j = index; j < stringArray.Length; j++)
                {
                    resultStingArray[i] += stringArray[j];
                    index++;

                    if (index != 0 && (index == stringArray.Length || index % count == 0))
                        break;
                }
            }

            return resultStingArray;
        }

        /// <summary>
        /// Переводит строку в массив символов (string[], а не char[]!)
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Массив символов из строки</returns>
        public static string[] ToStringArray(this string str)
        {
            var stringArray = new string[str.Length];

            for (int i = 0; i < stringArray.Length; i++)
                stringArray[i] = char.ToString(str[i]);

            return stringArray;
        }

        /// <summary>
        /// Переводит ключи словаря в массив строк
        /// </summary>
        /// <typeparam name="TKey">Параметр ключа</typeparam>
        /// <typeparam name="TValue">Параметр значения</typeparam>
        /// <param name="keyCollection">Словарь</param>
        /// <returns>Массив ключей словаря</returns>
        public static string[] ToStringArray<TKey, TValue>(this Dictionary<TKey, TValue>.KeyCollection keyCollection)
        {
            var stringArray = new string[keyCollection.Count];
            int index = 0;

            var numerator = keyCollection.GetEnumerator();
            while (numerator.MoveNext()) stringArray[index++] = Convert.ToString(numerator.Current);
            numerator.Dispose();

            return stringArray;
        }

        /// <summary>
        /// Переводит значения словаря в массив строк
        /// </summary>
        /// <typeparam name="TKey">Параметр ключа</typeparam>
        /// <typeparam name="TValue">Параметр значения</typeparam>
        /// <param name="valueCollection">Словарь</param>
        /// <returns>Массив значений словаря</returns>
        public static string[] ToStringArray<TKey, TValue>(this Dictionary<TKey, TValue>.ValueCollection valueCollection)
        {
            var stringArray = new string[valueCollection.Count];
            int index = -1;

            var numerator = valueCollection.GetEnumerator();
            while (numerator.MoveNext()) stringArray[++index] = Convert.ToString(numerator.Current);
            numerator.Dispose();

            return stringArray;
        }

        /// <summary>
        /// Переводит массив строк в строку
        /// </summary>
        /// <param name="stringArray">Массив строк</param>
        /// <param name="separator">Разделитель между элементами. Не обязательный параметр (по умолчанию "")</param>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <returns>Строка</returns>
        public static string ArrayToString<T>(this T[] stringArray, string separator = "")
        {
            return string.Join(separator, stringArray);
        }

        public static T[] ToNormalArray<T>(this T?[] nullableArray) where T : struct
        {
            var normalArray = new List<T>();
            for (int i = 0; i < nullableArray.Length; i++)
            {
                if (nullableArray[i].HasValue) normalArray.Add(nullableArray[i].Value);
            }

            return normalArray.ToArray();
        }

        public static int IndexOf<T>(this T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (((IComparable)array[i]).CompareTo(element) == 0) return i;
            }

            return -1;
        }

        public static string ToStr<T>(this IEnumerable<T> enumerable)
        {
            string result = string.Empty;
            var numerator = enumerable.GetEnumerator();

            while (numerator.MoveNext()) result += numerator.Current;
            numerator.Dispose();

            return result;
        }
    }
}