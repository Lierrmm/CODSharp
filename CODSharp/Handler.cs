using System;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace CODSharp
{
    public class Handler : API
    {
        public static async Task<string> GET(string uri)
        {
            return await GET<string>(uri);
        }
        
        public static async Task<T> GET<T>(string uri)
        {
            return await makeRequest<T>(uri, HttpMethod.Get);
        }

        public static async Task<string> POST(string uri, string body = null, string contentType = "application/json")
        {
            return await POST<string>(uri, body, contentType);
        }

        public static async Task<T> POST<T>(string uri, string body = null, string contentType = "application/json")
        {
            return await makeRequest<T>(uri, HttpMethod.Post, body, contentType);
        }


        private static async Task<T> makeRequest<T>(string url, HttpMethod method, string body = null, string contentType = "application/json")
        {
            var guid = Guid.NewGuid().ToString().ToLower();
            var newCookies = defaultCookies;
            newCookies += $"XSRF-TOKEN={xsrfToken};API_CSRF_TOKEN={guid};ACT_SSO_COOKIE={sso};atkn={atkn};";
            _wc.DefaultRequestHeaders.Add("Cookie", newCookies);
            _wc.DefaultRequestHeaders.Add("X-CSRF-TOKEN", guid);
            _wc.DefaultRequestHeaders.Add("User-Agent", "CODSharp/0.0.1");
            var converter = TypeDescriptor.GetConverter(typeof(T));

            var request = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(url)
            };

            if (!string.IsNullOrEmpty(body))
            {
                var content = new StringContent(body, Encoding.UTF8, contentType);
                request.Content = content;
            }

            try
            {
                var response = await _wc.SendAsync(request);
                var happyChap = response.IsSuccessStatusCode;
                var responseStr = await response.Content.ReadAsStringAsync();

                if (!happyChap) throw new WebException(responseStr, (WebExceptionStatus)response.StatusCode);
                var castToString = typeof(T) == typeof(string);

                if (castToString)
                    return (T)converter.ConvertFrom(responseStr);

                return JsonConvert.DeserializeObject<T>(responseStr);

            }
            catch (WebException wex)
            {
                throw new WebException(wex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}