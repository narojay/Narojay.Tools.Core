using Microsoft.VisualStudio.TestTools.UnitTesting;
using Narojay.Tools.Core.Security;

namespace Narojay.Tools.Test
{
    [TestClass]
    public class EncryptTest
    {
        [TestMethod]
        public void Md5Encrypt()
        {
            var password = "testpassword";
            var md5Encrypt1 = Encrypt.Md5Encrypt(password);
            var md5Encrypt2 = Encrypt.Md5Encrypt(password);
            Assert.AreEqual(md5Encrypt1,md5Encrypt2);
        }

        [TestMethod]
        public void Md5EncryptWithSalt()
        {
            var password = "testpassword";
            var salt = "salt";
            var md5Encrypt1 = Encrypt.Md5Encrypt(password, salt);
            var md5Encrypt2 = Encrypt.Md5Encrypt(password, salt);
            Assert.AreEqual(md5Encrypt1, md5Encrypt2);
        }
    }
}
