using System;
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

        private static async Task Login()
        {
            await API.Auth.Login("user@gmail.com", "password");
            Console.WriteLine($"Is Logged In? {API.isLoggedIn}");
            if (API.isLoggedIn)
            {
                var friends = await Friends.friendList();
                Console.WriteLine(friends);
                var output = await Friends.friendAction("7293808333332651629", platforms.uno, friendActions.uninvite);//await MW.WZ.Stats("Swankykoala#21673", "battle");
                Console.WriteLine(JsonConvert.SerializeObject(output));
            }
        }
    }
}
