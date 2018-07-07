
namespace CryptographicSystem.Test
{
    using CryptographicSystem.BLL.Ciphers;
    using NUnit.Framework;

    [TestFixture]
    public class SubstitutionCipherTest : Variable
    {
        private SubstitutionCipher substitutionCipher;

        /// <summary>
        /// Одна подстановка
        /// </summary>
        [Test]
        public void OneSubstitutionTest()
        {
            // одна подстановка
            this.cryptogram = "I study at DNU";
            this.substitutionCipher = new SubstitutionCipher();
            this.encryptText = this.substitutionCipher.Encrypt(this.cryptogram);
            this.decryptText = this.substitutionCipher.Decrypt(this.encryptText);
            Assert.AreEqual(this.cryptogram, this.decryptText);
        }

        /// <summary>
        /// Много подстановок
        /// </summary>
        [Test]
        public void MoreSubstitutionTest()
        {
            this.cryptogram = "I study at DNU";
            int n = 10;
            this.substitutionCipher = new SubstitutionCipher(n);
            this.encryptText = this.substitutionCipher.Encrypt(this.cryptogram);
            this.decryptText = this.substitutionCipher.Decrypt(this.encryptText);
            Assert.AreEqual(this.cryptogram, this.decryptText);
        }
    }
}
