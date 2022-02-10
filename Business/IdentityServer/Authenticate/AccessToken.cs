namespace IdentityServer.Authenticate
{
    public class AccessToken
    {
        public string Access_token { get; set; }
        // public string Refresh_token { get; set; }
        public string Token_type { get; set; }
        public int Expires_in { get; set; }

        public AccessToken(string access_token, string token_type, int expires_in)
        {
            Access_token = access_token;
            Token_type = token_type;
            Expires_in = expires_in;
        }
    }
}
