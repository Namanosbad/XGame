using System.Text;

namespace XGame.Domain.Extensions
{
    public static class StringExtension
    {
        public static string ConvertToMD5(this string passWord)
        {
            if (string.IsNullOrEmpty(passWord)) return "";
            var password = (passWord += "cc3a0280e4fc1415930899896574e118");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));
            {
                return sbString.ToString();
            }
        }
    }
}