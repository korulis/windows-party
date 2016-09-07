using System.Collections.Generic;
using WindowsParty.Infrastructure.Domain;
using Newtonsoft.Json;
using RestSharp;

namespace WindowsParty.Infrastructure.Communication
{
    public class ServerListProvider : IServerListProvider
    {
        private readonly IRestClient _client;

        public ServerListProvider(IRestClient client)
        {
            _client = client;
        }

        public IList<Server> GetServers(string token)
        {
            var request = new RestRequest("servers", Method.GET);
            request.AddHeader("Authorization", $"Bearer {token}");

            var response = _client.Execute(request);
            if (response == null ) return null;
            return JsonConvert.DeserializeObject<List<Server>>(response?.Content ?? "");
        }
    }
}
