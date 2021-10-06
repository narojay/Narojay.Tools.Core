using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Narojay.Tools.Core.Security
{
    public static class Encrypt
    {
        public static string Salt = "narojay";

        public static string Md5Encrypt(string message)
        {
            using MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            byte[] bytes = md5.ComputeHash(buffer);

            return bytes.Aggregate("", (current, item) => current + item.ToString("x2"));

        }

        public static string Md5Encrypt(string message, string salt)
        {
            var value = message;
            value += salt == string.Empty ? Salt : salt;
            using MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(value);
            byte[] bytes = md5.ComputeHash(buffer);
            return bytes.Aggregate("", (current, item) => current + item.ToString("x2"));
        }
    }
}
