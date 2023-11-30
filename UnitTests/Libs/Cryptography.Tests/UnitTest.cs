namespace Cryptography.Tests
{
    public class UnitTest
    {
        private readonly string data = Guid.NewGuid().ToString();

        [Fact]
        public void SHA512()
        {
            var encoded = CFSDev.Libs.Cryptography.Functions.SHA512(data);
            Assert.NotNull(encoded); 
            Assert.NotEmpty(encoded); 
        }

        [Fact]
        public void EncodeToBase64()
        {
            var encoded = CFSDev.Libs.Cryptography.Functions.EncodeToBase64(data);
            Assert.NotNull(encoded);
            Assert.NotEmpty(encoded);
        }

        [Fact]
        public void DecodeFrom64()
        {
            var encoded = CFSDev.Libs.Cryptography.Functions.EncodeToBase64(data);
            Assert.NotNull(encoded);
            Assert.NotEmpty(encoded);

            var decoded = CFSDev.Libs.Cryptography.Functions.DecodeFrom64(encoded);
            Assert.NotNull(decoded);
            Assert.NotEmpty(decoded);
            Assert.Equal(data, decoded);
        }
    }
}