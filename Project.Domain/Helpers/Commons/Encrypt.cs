using System.Security.Cryptography;
using System.Text;

namespace Project.Domain.Helpers.Commons
{
    public class Encrypt
    {
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static bool Verify(string password, string hash)
        {
            var newHash = GetSHA256(password);

            return (newHash == hash);
        }

    }
}
