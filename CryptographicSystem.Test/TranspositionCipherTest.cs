
namespace CryptographicSystem.Test
{
    using CryptographicSystem.BLL.Ciphers;
    using NUnit.Framework;

    [TestFixture]
    public class TranspositionCipherTest : Variable
    {
        private TranspositionCipher transpositionCipher;

        [Test]
        public void OneTranspositionTest()
        {
            this.cryptogram = "DONT_SMOKE_HERE_PLEASE______";
            this.transpositionCipher = new TranspositionCipher(new int[] { 4, 3, 7, 1, 5, 6, 2 });
            this.encryptText = this.transpositionCipher.Encrypt(this.cryptogram);
            this.decryptText = this.transpositionCipher.Decrypt(this.encryptText);
            Assert.AreEqual(this.cryptogram, this.decryptText);
        }
    }
}