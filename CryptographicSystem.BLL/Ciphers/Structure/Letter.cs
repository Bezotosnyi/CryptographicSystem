
namespace CryptographicSystem.BLL.Ciphers.Structure
{
    internal struct Letter
    {
        public Letter(string value, bool isNumber, bool isUpper = false)
        {
            this.Value = value;
            this.IsNumber = isNumber;
            this.IsUpper = isUpper;
        }

        public string Value { get; set; }

        public bool IsNumber { get; set; }

        public bool IsUpper { get; set; }
    }
}