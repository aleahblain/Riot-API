using System;
using System.Net.Http;

namespace Riot_API
{
    class RiotAPI
    {
        public readonly string APIKey;

        public SummonerV4 SummonerV4 { get; }

        public HttpClient Client { get; }

        public RiotAPI(string apiKey)
        {
            APIKey = apiKey;

            Client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
        }
    }
}
