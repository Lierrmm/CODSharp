using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
          
            var converter = TypeDescriptor.GetConverter(typeof(T));

            var request = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Cookie", defaultCookies }
                }
            };

            if (!string.IsNullOrEmpty(body))
            {
                var content = new StringContent(body, Encoding.UTF8, contentType);
                request.Content = content;
            }

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var response = await _wc.SendAsync(request);
                stopwatch.Stop();
                var happyChap = response.IsSuccessStatusCode;
                var responseStr = await response.Content.ReadAsStringAsync();
                if (debug)
                {
                    var timeTaken = stopwatch.ElapsedMilliseconds;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"[DEBUG] Built URI: {url}");
                    Console.WriteLine($"[DEBUG] Round trip took: {timeTaken}ms.");
                    Console.WriteLine($"[DEBUG] Response size: {responseStr.Length} bytes.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                stopwatch = null;
                try
                {
                    var dataMap = JsonConvert.DeserializeObject<baseResponse>(responseStr);
                    if (dataMap.data.message == "Not permitted: rate limit exceeded") isRateLimited = true;
                } catch { }

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

    public static class Helpers
    {
        public static T CastClass<T>(this object myobj)
        {
            var objectType = myobj.GetType();
            var target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                where source.MemberType == MemberTypes.Property
                select source;
            var d = from source in target.GetMembers().ToList()
                where source.MemberType == MemberTypes.Property
                select source;
            var members = d.Where(memberInfo => d.Select(c => c.Name)
                .ToList().Contains(memberInfo.Name)).ToList();
            foreach (var memberInfo in members)
            {
                var propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                var value = myobj.GetType().GetProperty(memberInfo.Name).GetValue(myobj, null);

                propertyInfo.SetValue(x, value, null);
            }

            return (T) x;
        }
    }
}