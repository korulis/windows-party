using System.Collections.Generic;
using WindowsParty.Infrastructure.Domain;

namespace WindowsParty.Infrastructure.Communication
{
    public interface IServerListProvider
    {
        IList<Server> GetServers(string token);

        
    }
}