using System;
using System.Linq;
using System.Threading.Tasks;
using CODSharp;

namespace Account
{
    public class User : API
    {
        public static async Task<dynamic> Identities()
        {
            try
            {
                var url = $"{defaultUri}/crm/cod/v2/identities";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> UserInfo()
        {
            try
            {
                var url = $"https://profile.callofduty.com/cod/userInfo/{sso}";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> Preferences()
        {
            try
            {
                var url = $"https://profile.callofduty.com/cod/prefs";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> Relationships()
        {
            try
            {
                var url = $"{defaultUri}/relationships/v1/list";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> getPlatforms(string gamertag, platforms platform)
        {
            try
            {
                var type = platform == platforms.uno ? "id" : "gamer";
                if (platform == platforms.acti) platform = platforms.uno;
                gamertag = Uri.EscapeDataString(gamertag);
                var url = $"{defaultUri}/crm/cod/v2/accounts/platform/{platform}/{type}/{gamertag}";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> setProfileVisibility(platforms platform, friendVisibility visibility)
        {
            try
            {
                var blockedEnums = new[] {platforms.acti, platforms.uno, platforms.all};
                if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                var url = $"https://profile.callofduty.com/cod/setGamerPreference/{platform}/data_visible/{visibility}";
                return await Handler.POST(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    }
}
