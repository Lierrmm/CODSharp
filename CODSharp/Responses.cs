namespace CODSharp
{
    public class AuthResponse
    {
        public string status { get; set; }
        public parsedAuthResponse data { get; set; }
    }

    public class parsedAuthResponse 
    {
        public string authHeader { get; set; }
    }


    public class LoginResponse
    {
        public bool success { get; set; }
        public string rtkn { get; set; }
        public string atkn { get; set; }
        public string s_ACT_SSO_COOKIE { get; set; }
    }

}
