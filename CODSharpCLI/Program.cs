using System;
using System.Configuration;
using System.Threading.Tasks;
using CODSharp;
using Games;

namespace CODSharpCLI
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Login();
            Console.ReadKey();
        }
        //"SwankyKoala#21673"
        private static async Task Login()
        {
            var email = ConfigurationManager.AppSettings["email"];
            var password = ConfigurationManager.AppSettings["password"];
            API.debug = Convert.ToBoolean(ConfigurationManager.AppSettings["debug"]);
            await API.Auth.Login(email,password);
            if (API.isLoggedIn)
            {
                //var output = await MW.Global.Analysis("Lierrmm#2364", platforms.battle);
                //var output1 = await MW.WZ.FullMatchData("SwankyKoala#21673", platforms.battle);
                //var output1 = await MW.WZ.FullMatchData("13248338508034314703", platforms.battle);
                //Console.WriteLine(output1.data.allPlayers[0].player.username);
                //File.WriteAllText(@"liam.txt", output);
                //File.WriteAllText(@"swanky.txt", output1);

                var output = await MW.Global.Leaderboard(1337, platforms.battle);
                Console.WriteLine(output);
                //File.WriteAllText(@"maps.txt", output);
            }
        }
    }
}
