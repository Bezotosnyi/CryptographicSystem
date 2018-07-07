// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICipher.cs" company="DNU">
//   Dima Bezotosnyi
// </copyright>
// <summary>
//   Defines the ICipher type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CryptographicSystem.BLL.Abstract
{
    public interface ICipher
    {
        string Encrypt(string text);

        string Decrypt(string text);
    }
}
