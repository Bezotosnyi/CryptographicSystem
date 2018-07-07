// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TypeVigenereCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the TypeVigenereCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers.Enum
{
    /// <summary>
    /// Тип шифра Виженера с перемешанным один раз алфавитом
    /// </summary>
    public enum VigenereCipherType
    {
        /// <summary>
        /// Обычный вариант
        /// </summary>
        None,

        /// <summary>
        /// Прямой вариант
        /// </summary>
        Straight,

        /// <summary>
        /// Обратный вариант
        /// </summary>
        Reverse
    }
}