﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Net;

namespace CODSharp
{
    public class API
    {
        protected static readonly string defaultUri = "https://my.callofduty.com/api/papi-client";
        private static readonly string defaultAuthUriv2 = "https://profile.callofduty.com/cod";
        private static readonly string defaultLoginv2 = "https://profile.callofduty.com/do_login?new_SiteId=cod";
        private static readonly CookieContainer cookies = new CookieContainer { PerDomainCapacity =  45, Capacity = int.MaxValue };
        private static readonly HttpClientHandler handler = new HttpClientHandler { CookieContainer = cookies, UseCookies = true, AllowAutoRedirect = true };
        protected static readonly HttpClient _wc = new HttpClient(handler);
        public static bool isLoggedIn;
        private static string xsrfToken;
        private static string atkn;
        protected static string sso;
        private static string defaultCookies;
        public static bool debug = false;

        public class Auth
        {
            public static async Task<bool> Login(string email, string password)
            {
                try
                {
                    await _wc.GetAsync($"{defaultAuthUriv2}/login");
                    var uri = new Uri("https://callofduty.com");
                    defaultCookies = cookies.GetCookies(uri).Cast<Cookie>().ToList().Select(cookie => $"{cookie.Name}={cookie.Value}; ").Aggregate(string.Empty, (current, str) => current + str);
                    var xrsfToken = cookies.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "XSRF-TOKEN");
                    if (xrsfToken == null || string.IsNullOrEmpty(xrsfToken.Value)) throw new Exception("XSRF Not set.");
                    xsrfToken = xrsfToken.Value;
                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("username", email),
                        new KeyValuePair<string, string>("password", password),
                        new KeyValuePair<string, string>("remember_me", "true"),
                        new KeyValuePair<string, string>("_csrf", xsrfToken)
                    });
                    var request = await _wc.PostAsync(defaultLoginv2, formContent);
                    if (!request.IsSuccessStatusCode) throw new Exception("Failed to make request to login.");
                    if (request.Headers.Any(x => x.Key.ToLower().Contains("captcha"))) throw new Exception("Captcha required. Cannot complete request.");
                    atkn = cookies.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "atkn")?.Value;
                    sso = cookies.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "ACT_SSO_COOKIE")?.Value;
                    if (string.IsNullOrEmpty(atkn) || string.IsNullOrEmpty(sso)) throw new Exception("Could not parse response.");

                    #region cookies
                    var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    var guid = Guid.NewGuid().ToString().ToLower();
                    var newCookies = defaultCookies;
                    newCookies += $"XSRF-TOKEN={xsrfToken};API_CSRF_TOKEN={guid};ACT_SSO_COOKIE={sso};atkn={atkn};";
                    _wc.DefaultRequestHeaders.Add("Cookie", newCookies);
                    _wc.DefaultRequestHeaders.Add("X-CSRF-TOKEN", guid);
                    _wc.DefaultRequestHeaders.Add("X-XSRF-TOKEN", xsrfToken);
                    _wc.DefaultRequestHeaders.Add("User-Agent", "CODSharp/0.0.1");
                    cookies.Add(uri, new Cookie("API_CSRF_TOKEN", guid, "/", "callofduty.com"));
                    cookies.Add(uri, new Cookie("ACT_SSO_EVENT", $"\"LOGIN_SUCCESS:{timestamp}\"", "/", "callofduty.com"));
                    #endregion

                    defaultCookies += cookies.GetCookies(uri).Cast<Cookie>().ToList().Select(cookie => $"{cookie.Name}={cookie.Value}; ").Aggregate(string.Empty, (current, str) => current + str);
                    isLoggedIn = true;
                    return isLoggedIn;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return false;
                }
            }
        }
        public class MW : Games.MW { }
        public class Friends : Account.Friends { }
        public class User : Account.User { }
     }
}
