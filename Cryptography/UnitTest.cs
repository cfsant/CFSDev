using CFSDev.Libs.Cryptography;

namespace CFSDev.Libs.UnitTest.Cryptography.Tests
{
    public class UnitTest
    {
        public readonly string data = Guid.NewGuid().ToString();

        [Fact]
        public void SHA512()
        {
            string sha512 = Functions.SHA512(data);
            Assert.NotNull(sha512); 
            Assert.NotEmpty(sha512);
        }

        [Fact]
        public void Base64Encode()
        {
            string base64 = Functions.EncodeToBase64(data);
            Assert.NotNull(base64);
            Assert.NotEmpty(base64);
        }

        [Fact]
        public void Base64Decode()
        {
            string base64 = Functions.EncodeToBase64(data);
            Assert.NotNull(base64);
            Assert.NotEmpty(base64);

            string decoded = Functions.DecodeFrom64(base64);
            Assert.NotNull(decoded);
            Assert.NotEmpty(decoded);
            Assert.Equal(data, decoded);
        }
    }
}