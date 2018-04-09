using System.Security.Cryptography;
using System.Text;

namespace fr.soat.cleancode
{
    public class Block
    {
        public string hash;
        public string data;
        public string parentHash;

        //This constructor create a block with a parentHash and some data
        public Block(string parentHash, string data)
        {
            this.data = data;
            this.hash = parentHash == null ? CalculateHash(data) : CalculateHash(parentHash + data);
            this.parentHash = parentHash == null ? hash : parentHash;
        }

        private string CalculateHash(string d)
        {
            using (var sha256 = SHA256.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(d);
                var hash = sha256.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                foreach (var b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
