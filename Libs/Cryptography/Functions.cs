using System.Text;

namespace CFSDev.Libs.Cryptography
{
    public static class Functions
    {
        public static string SHA512(string data) => ParseByteArrayToSHA512String(ParseByteArrayToSHA512Hash(ParseStringToByteArray(data)));

        private static string ParseByteArrayToSHA512String(byte[] buffer)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i].ToString("x2"));
            }

            return builder.ToString();
        }

        private static byte[] ParseByteArrayToSHA512Hash(byte[] buffer) => System.Security.Cryptography.SHA512.Create().ComputeHash(buffer);

        private static byte[] ParseStringToByteArray(string data) => Encoding.UTF8.GetBytes(data);

        static public string EncodeToBase64(string data)
        {
            byte[] textoAsBytes = Encoding.ASCII.GetBytes(data);
            string resultado = Convert.ToBase64String(textoAsBytes);
            return resultado;
        }

        static public string DecodeFrom64(string data)
        {
            byte[] dadosAsBytes = Convert.FromBase64String(data);
            string resultado = ASCIIEncoding.ASCII.GetString(dadosAsBytes);
            return resultado;
        }
    }
}