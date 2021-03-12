using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CODSharp;

namespace CodSharpTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("<email>", "<password>")]
        public async Task Authenticate(string email, string password)
        {
            var req = new Authenticate();
            await req.Login(email, password);
        }
    }
}
