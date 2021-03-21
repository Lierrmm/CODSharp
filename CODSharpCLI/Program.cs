using System;
using System.Configuration;
using System.Threading.Tasks;
using Account;
using CODSharp;

namespace CODSharpCLI
{
    internal class Program
    {
        private static readonly string gamertag = "SwankyKoala#21673";

        private static async Task Main(string[] args)
        {
            await Login();
            Console.ReadKey();
        }

        private static async Task Login()
        {
            var email = ConfigurationManager.AppSettings["email"];
            var password = ConfigurationManager.AppSettings["password"];
            API.debug = Convert.ToBoolean(ConfigurationManager.AppSettings["debug"]);
            await API.Auth.Login(email,password);
            if (API.isLoggedIn)
            {
                var output = await User.getCodPoints(gamertag, platforms.battle);
                Console.WriteLine(output.data.codPoints);
            }
        }
    }
}
