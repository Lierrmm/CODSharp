using System;
using System.Linq;
using System.Threading.Tasks;
using CODSharp;

namespace Games
{
    public class CW : API
    {
        public class MP
        {
            public static async Task<CWStats> Stats(string gamertag, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    if (string.IsNullOrEmpty(gamertag)) throw new Exception("Gamertag is a required parameter.");
                    var url = $"{defaultUri}/stats/cod/v1/title/cw/platform/{platform}/{type}/{gamertag}/profile/type/mp";
                    return await Handler.GET<CWStats>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
            public static async Task<CWMapList> MapList(platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    if (platform == platforms.acti) platform = platforms.uno;
                    var url = $"{defaultUri}/ce/v1/title/cw/platform/{platform}/gameType/mp/communityMapData/availability";
                    return await Handler.GET<CWMapList>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
            public static async Task<MatchInfo> MatchInfo(string gamertag, platforms platform, long start = 0, long end = 0)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/crm/cod/v2/title/cw/platform/{platform}/{type}/{gamertag}/matches/mp/start/{start}/end/{end}";
                    return await Handler.GET<MatchInfo>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
            public static async Task<CWDetailedMatchInfo> DetailedMatchInfo(string gamertag, platforms platform, long start = 0, long end = 0)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/crm/cod/v2/title/cw/platform/{platform}/{type}/{gamertag}/matches/mp/start/{start}/end/{end}/details";
                    return await Handler.GET<CWDetailedMatchInfo>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
            public static async Task<dynamic> FullMatchData(string matchId, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    if (platform == platforms.acti) platform = platforms.uno;
                    var url = $"{defaultUri}/crm/cod/v2/title/cw/platform/{platform}/fullMatch/mp/{matchId}/en";
                    return await Handler.GET<dynamic>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
            public static async Task<BPInfo> BPInfo(string gamertag, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/loot/title/cw/platform/{platform}/{type}/{gamertag}/status/en";
                    return await Handler.GET<BPInfo>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
