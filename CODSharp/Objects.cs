using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace CODSharp
{
    public class baseResponse
    {
        public string status { get; set; }
    }

    public class loginRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool remember_me { get; set; } = true;
        public string _csrf { get; set; }
    }

    public class Stats : baseResponse
    {
        public dynamic data { get; set; }
    }

    public enum platforms
    {
        xbl,
        psn,
        battle,
        uno,
        acti,
        all
    }

    public enum friendActions
    {
        invite,
        uninvite,
        remove,
        block,
        unblock
    }


    public static class Helpers
    {
        public static IDictionary<string, string> ToKeyValue(this object metaToken)
        {
            while (true)
            {
                if (metaToken == null)
                {
                    return null;
                }

                if (!(metaToken is JToken token))
                {
                    metaToken = JObject.FromObject(metaToken);
                    continue;
                }

                if (token.HasValues)
                {
                    var contentData = new Dictionary<string, string>();

                    return token.Children()
                        .ToList()
                        .Select(child => child.ToKeyValue())
                        .Where(childContent => childContent != null)
                        .Aggregate(contentData, (current, childContent) => current.Concat(childContent)
                            .ToDictionary(k => k.Key, v => v.Value));
                }

                var jValue = token as JValue;
                if (jValue?.Value == null)
                {
                    return null;
                }

                var value = jValue?.Type == JTokenType.Date ? jValue?.ToString("o", CultureInfo.InvariantCulture) : jValue?.ToString(CultureInfo.InvariantCulture);

                return new Dictionary<string, string> {{token.Path, value}};
            }
        }
    }
}
