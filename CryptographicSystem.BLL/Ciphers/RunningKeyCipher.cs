// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunningKeyCipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the RunningKeyCipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Ciphers
{
    public sealed class RunningKeyCipher : VermanCipher
    {
        public RunningKeyCipher(string sensText) 
            : base(sensText)
        {
        }
    }
}