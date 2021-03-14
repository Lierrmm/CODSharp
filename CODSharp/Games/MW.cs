using System;
using System.Linq;
using System.Threading.Tasks;
using CODSharp;

namespace Games
{
    public class MW : API
    {
        public class MP
        {
            public static async Task<WZStats> Stats(string gamertag, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url =
                        $"{defaultUri}/stats/cod/v1/title/mw/platform/{platform}/{type}/{gamertag}/profile/type/mp";
                    return await Handler.GET<WZStats>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }

            public static async Task<MWMapList> MapList(platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    if (platform == platforms.acti) platform = platforms.uno;
                    var url = $"{defaultUri}/ce/v1/title/mw/platform/{platform}/gameType/mp/communityMapData/availability";
                    return await Handler.GET<MWMapList>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
        }

        public class WZ
        {
            public static async Task<WZStats> Stats(string gamertag, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url =
                        $"{defaultUri}/stats/cod/v1/title/mw/platform/{platform}/{type}/{gamertag}/profile/type/wz";
                    return await Handler.GET<WZStats>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }

            public static async Task<BRInfo> BRInfo(string gamertag, platforms platform)
            {
                try
                {
                    var stats = await Stats(gamertag, platform);
                    var lifetime = stats.data.lifetime;
                    if (lifetime == null) return null;
                    var br = lifetime.mode.br?.properties;
                    var plunder = lifetime.mode.br_dmz?.properties;
                    var all = lifetime.mode.br_all?.properties;
                    var info = new BRInfo
                    {
                        br = br.CastClass<BRInfo.Info>(),
                        plunder = plunder.CastClass<BRInfo.Info>(),
                        all = all.CastClass<BRInfo.Info>()
                    };
                    return info;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
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
                    var url = $"{defaultUri}/crm/cod/v2/title/mw/platform/{platform}/{type}/{gamertag}/matches/wz/start/{start}/end/{end}";
                    return await Handler.GET<MatchInfo>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }

            public static async Task<DetailedMatchInfo> DetailedMatchInfo(string gamertag, platforms platform, long start = 0, long end = 0)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/crm/cod/v2/title/mw/platform/{platform}/{type}/{gamertag}/matches/wz/start/{start}/end/{end}/details";
                    return await Handler.GET<DetailedMatchInfo>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }

            public static async Task<FullMatchData> FullMatchData(string matchId, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    if (platform == platforms.acti) platform = platforms.uno;
                    var url = $"{defaultUri}/crm/cod/v2/title/mw/platform/{platform}/fullMatch/wz/{matchId}/en";
                    return await Handler.GET<FullMatchData>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }
        }

        public class Global
        {
            public static async Task<BPInfo> BPInfo(string gamertag, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/loot/title/mw/platform/{platform}/{type}/{gamertag}/status/en";
                    return await Handler.GET<BPInfo>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }

            public static async Task<string> Leaderboard(int page, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.acti, platforms.uno, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var url = $"{defaultUri}/leaderboards/v2/title/mw/platform/{platform}/time/alltime/type/core/mode/career/page/{page}";
                    return await Handler.GET<string>(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            }

            [Obsolete("In progress. DO NOT USE!", true)]
            public static async Task<Analysis> Analysis(string gamertag, platforms platform)
            {
                try
                {
                    var blockedEnums = new[] { platforms.steam, platforms.all };
                    if (blockedEnums.Contains(platform)) throw new Exception($"{platform} not a valid platform for this endpoint.");
                    var type = platform == platforms.uno ? "id" : "gamer";
                    if (platform == platforms.acti) platform = platforms.uno;
                    gamertag = Uri.EscapeDataString(gamertag);
                    var url = $"{defaultUri}/ce/v2/title/mw/platform/{platform}/gametype/all/{type}/{gamertag}/summary/match_analysis/contentType/full/end/0/matchAnalysis/mobile/en";
                    return await Handler.GET<Analysis>(url);
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
