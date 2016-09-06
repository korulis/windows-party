namespace WindowsParty.Infrastructure.Communication
{
    public class Authenticator : IAuthenticator
    {
        public string Authenticate(string user, string pass)
        {
            return "a";
        }
    }
}