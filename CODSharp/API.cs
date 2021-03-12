using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CODSharp
{
    public class API
    {
        public static readonly string defaultUri = "https://my.callofduty.com/api/papi-client";
        public static readonly string defaultAuthUri = "https://profile.callofduty.com/cod/mapp";
        public static string defaultCookies = "new_SiteId=cod; ACT_SSO_LOCALE=en_US;country=US;XSRF-TOKEN=68e8b62e-1d9d-4ce1-b93f-cbe5ff31a041;";
        public static readonly HttpClient _wc = new HttpClient();
        public static bool isLoggedIn { get; set; }
        public class Auth
        {
            private static async Task<bool> DeviceAuth()
            {
                try
                {
                    var deviceId = Guid.NewGuid().ToString().ToUpper().Replace("-", string.Empty);
                    var jsonObj = JsonConvert.SerializeObject(new { deviceId });
                    var parsedData = await Handler.POST<AuthResponse>($"{defaultAuthUri}/registerDevice", jsonObj);
                    _wc.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", parsedData.data.authHeader);
                    _wc.DefaultRequestHeaders.Add("x_cod_device_id", deviceId);
                    return parsedData.status == "success";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return false;
                }
            }
            public static async Task<bool> Login(string email, string password)
            {
                try
                {
                    _wc.DefaultRequestHeaders.Add("Cookies", defaultCookies);
                    _wc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var _AuthPassed = await DeviceAuth();
                    if (!_AuthPassed) throw new Exception("Failed Authentication.");
                    var jsonObj = JsonConvert.SerializeObject(new { email, password });
                    var parsedData = await Handler.POST<LoginResponse>($"{defaultAuthUri}/login", jsonObj);
                    if (!parsedData.success) throw new Exception("Unsuccessful login.");
                    defaultCookies = $"{defaultCookies}rtkn={parsedData.rtkn};ACT_SSO_COOKIE={parsedData.s_ACT_SSO_COOKIE};atkn={parsedData.atkn};";
                    _wc.DefaultRequestHeaders.Remove("Cookies");
                    _wc.DefaultRequestHeaders.Add("Cookies", defaultCookies);
                    Console.WriteLine("Successful Login.");
                    isLoggedIn = parsedData.success;
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
     }
}
