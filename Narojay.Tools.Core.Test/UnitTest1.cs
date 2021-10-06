using Microsoft.VisualStudio.TestTools.UnitTesting;
using Narojay.Tools.Core.Security;

namespace Narojay.Tools.Core.Test
{
    [TestClass]
    public class TestMd5EncryptClass
    {
        [TestMethod]
        public void TestMd5Encrypt()
        {
            string password = "1231";
            var md5Encrypt = Encrypt.Md5Encrypt(password);
        }
    }
}
