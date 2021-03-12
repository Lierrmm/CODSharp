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
            public static async Task<Stats> Stats(string gamertag, string platform)
            {
                try
                {
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/stats/cod/v1/title/mw/platform/{platform}/gamer/{gamertag}/profile/type/wz";
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
