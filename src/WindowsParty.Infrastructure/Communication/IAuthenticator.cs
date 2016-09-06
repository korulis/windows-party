namespace WindowsParty.Infrastructure.Communication
{
    public interface IAuthenticator
    {
        string Authenticate(string user, string pass);
    }
}
