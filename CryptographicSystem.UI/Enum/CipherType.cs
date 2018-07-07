
namespace CryptographicSystem.UI.Enum
{
    /// <summary>
    /// Тип шифра
    /// </summary>
    public enum CipherType
    {
        /// <summary>
        /// Шифр подстановки
        /// </summary>
        SubstitutionCipher,

        /// <summary>
        /// Шифр перестановки
        /// </summary>
        TranspositionCipher,

        /// <summary>
        /// Шифр Виженера
        /// </summary>
        VigenereCipher,

        /// <summary>
        /// Шифр Вернама
        /// </summary>
        VermanCipher,

        /// <summary>
        /// Шифр бегущего ключа
        /// </summary>
        RunningKeyCipher,

        /// <summary>
        /// Шифр Цезаря
        /// </summary>
        CaesarCipher,

        /// <summary>
        /// Диграммные подстановки
        /// </summary>
        NGrammarSubstitutionCipher,

        /// <summary>
        /// Шифр “Плейфер” 
        /// </summary>
        PlayFairCipher,

        /// <summary>
        /// Шифр с автоключом
        /// </summary>
        AutoKeyCipher,

        /// <summary>
        /// Дробный шифр
        /// </summary>
        FractionalCipher
    }
}
