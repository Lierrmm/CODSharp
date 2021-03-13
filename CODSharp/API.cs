using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using RestSharp;

namespace CODSharp
{
    public class API
    {
        protected static readonly string defaultUri = "https://my.callofduty.com/api/papi-client";
        private static readonly string defaultAuthUriv2 = "https://profile.callofduty.com/cod";
        private static readonly string defaultLoginv2 = "https://profile.callofduty.com/do_login?new_SiteId=cod";
        private static readonly CookieContainer cookies = new CookieContainer { PerDomainCapacity =  45, Capacity = int.MaxValue };
        private static readonly HttpClientHandler handler = new HttpClientHandler { CookieContainer = cookies };
        protected static readonly HttpClient _wc = new HttpClient(handler);
        public static bool isLoggedIn;
        protected static string xsrfToken;
        protected static string atkn;
        protected static string sso;
        protected static string defaultCookies;

        public class Auth
        {
            public static async Task<bool> Login(string email, string password)
            {
                try
                {
                    await _wc.GetAsync("https://profile.callofduty.com/cod/login");
                    var uri = new Uri("https://callofduty.com");
                    defaultCookies = handler.CookieContainer.GetCookies(uri).Cast<Cookie>().ToList().Select(cookie => $"{cookie.Name}={cookie.Value}; ").Aggregate(string.Empty, (current, str) => current + str);
                    var xrsfToken = handler.CookieContainer.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "XSRF-TOKEN");
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
                    atkn = handler.CookieContainer.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "atkn")?.Value;
                    sso = handler.CookieContainer.GetCookies(uri).Cast<Cookie>().FirstOrDefault(x => x.Name == "ACT_SSO_COOKIE")?.Value;
                    if (string.IsNullOrEmpty(atkn) || string.IsNullOrEmpty(sso)) throw new Exception("Could not parse response.");
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
     }
}
