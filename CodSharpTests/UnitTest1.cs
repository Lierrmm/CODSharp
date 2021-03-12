using System;
using System.Threading.Tasks;
using CODSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodSharpTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow("<email>", "<password>", true)]
        public static async Task Authenticate(string email, string password, bool shouldSucceed)
        {
            await API.Auth.Login(email, password);
            Assert.Equals(shouldSucceed, API.isLoggedIn);
        }
    }
}
