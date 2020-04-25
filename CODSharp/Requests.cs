using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace CODSharp
{
    public class Requests
    {
        readonly string defaultUri = "https://my.callofduty.com/api/papi-client";
        private readonly string defaultAuthUri = "https://profile.callofduty.com/cod/mapp";
        private string defaultCookies = "new_SiteId=cod; ACT_SSO_LOCALE=en_US;country=US;XSRF-TOKEN=68e8b62e-1d9d-4ce1-b93f-cbe5ff31a041;";
        private readonly HttpClient _wc = new HttpClient();

        private async Task<bool> Authenticate()
        {
            try
            {
                var deviceId = Guid.NewGuid().ToString().ToUpper().Replace("-", string.Empty);
                var jsonObj = JsonConvert.SerializeObject(new{deviceId});
                var content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                var response = await _wc.PostAsync($"{defaultAuthUri}/registerDevice", content);
                var contents = await response.Content.ReadAsStringAsync();
                var parsedData = JsonConvert.DeserializeObject<AuthResponse>(contents);
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


        public async Task<bool> Login(string email, string password)
        {
            try
            {
                _wc.DefaultRequestHeaders.Add("Cookies", defaultCookies);
                _wc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var _AuthPassed = await Authenticate();
                if (!_AuthPassed) throw new Exception("Failed Authentication.");
                var jsonObj = JsonConvert.SerializeObject(new {email, password});
                var content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                var response = await _wc.PostAsync($"{defaultAuthUri}/login", content);
                var contents = await response.Content.ReadAsStringAsync();
                var parsedData = JsonConvert.DeserializeObject<LoginResponse>(contents);
                if(!parsedData.success) throw new Exception("Unsuccessful login.");
                defaultCookies = $"{defaultCookies}rtkn={parsedData.rtkn};ACT_SSO_COOKIE={parsedData.s_ACT_SSO_COOKIE};atkn={parsedData.atkn};";
                _wc.DefaultRequestHeaders.Remove("Cookies");
                _wc.DefaultRequestHeaders.Add("Cookies", defaultCookies);
                Console.WriteLine("Successful Login.");
                return parsedData.success;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        public async Task<dynamic> MWwz(string gamertag, string platform)
        {
            try
            {
                gamertag = Uri.EscapeDataString(gamertag);
                var url = $"{defaultUri}/stats/cod/v1/title/mw/platform/{platform}/gamer/{gamertag}/profile/type/mp";
                return await Request(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }



        public async Task<string> Request(string uri)
        {
            try
            {
                var response = await _wc.GetAsync(uri);
                var data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
