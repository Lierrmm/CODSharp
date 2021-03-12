using System;
using System.Threading.Tasks;
using CODSharp;
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

        private static async Task Login()
        {
            await API.Auth.Login("email", "password");
            Console.WriteLine($"Is Logged In? {API.isLoggedIn}");
            if (API.isLoggedIn)
            {
                var output = await MW.WZ.Stats("Swankykoala#21673", "battle");
                Console.WriteLine(JsonConvert.SerializeObject(output.data));
            }
        }
    }
}
