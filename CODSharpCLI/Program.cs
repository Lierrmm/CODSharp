using System;
using System.Configuration;
using System.Threading.Tasks;
using CODSharp;
using Account;
using Games;
using Newtonsoft.Json;

namespace CODSharpCLI
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Login();
            Console.ReadKey();
        }
        //"Swankykoala#21673"
        private static async Task Login()
        {
            var email = ConfigurationManager.AppSettings["email"];
            var password = ConfigurationManager.AppSettings["password"];
            API.debug = Convert.ToBoolean(ConfigurationManager.AppSettings["debug"]);
            await API.Auth.Login(email,password);
            if (API.isLoggedIn)
            {
                var output = await Friends.Search("SwankyKoala");
                Console.WriteLine(JsonConvert.SerializeObject(output));
            }
        }
    }
}
