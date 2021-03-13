using System;
using System.Threading.Tasks;
using CODSharp;

namespace Games
{
    public class MW : API
    {
        public class MP
        {

        }

        public class WZ
        {
            public static async Task<Stats> Stats(string gamertag, platforms platform)
            {
                try
                {
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/stats/cod/v1/title/mw/platform/{platform}/{type}/{gamertag}/profile/type/wz";
                    return await Handler.GET<Stats>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }

            public static async Task<Stats> FriendStats(string gamertag, platforms platform)
            {
                try
                {
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/stats/cod/v1/title/mw/platform/{platform}/{type}/{gamertag}/profile/friends/type/wz";
                    return await Handler.GET<Stats>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
