﻿using System;
using System.Threading.Tasks;
using CODSharp;
using Newtonsoft.Json;

namespace Account
{
    public class Friends : API
    {
        public static async Task<dynamic> friendList()
        {
            try
            {
                var url = $"{defaultUri}/codfriends/v1/compendium";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> friendEvents()
        {
            try
            {
                var url = $"{defaultUri}/userfeed/v1/friendFeed/rendered/en";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> friendAction(string gamertag, platforms platform, friendActions action)
        {
            try
            {
                var type = platform == platforms.uno ? "id" : "gamer";
                gamertag = Uri.EscapeDataString(gamertag);
                if (platform == platforms.acti) platform = platforms.uno;
                var url = $"{defaultUri}/codfriends/v1/{action}/{platform}/{type}/{gamertag}";
                return await Handler.POST(url, JsonConvert.SerializeObject(new {}), "text/plain");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> Search(string query, platforms platform = platforms.all)
        {
            try
            {
                query = Uri.EscapeDataString(query);
                var url = $"{defaultUri}/crm/cod/v2/platform/{platform}/username/{query}/search";
                return await Handler.GET(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    }
}
