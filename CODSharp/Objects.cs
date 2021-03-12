namespace CODSharp
{
    public class baseResponse
    {
        public string status { get; set; }
    }
    
    public class AuthResponse : baseResponse
    {
        public parsedAuthResponse data { get; set; }
        public class parsedAuthResponse
        {
            public string authHeader { get; set; }
        }
    }
    
    public class LoginResponse 
    {
        public bool success { get; set; }
        public string rtkn { get; set; }
        public string atkn { get; set; }
        public string s_ACT_SSO_COOKIE { get; set; }
    }
    
    public class Stats : baseResponse
    {
        public dynamic data { get; set; }
    }
}
