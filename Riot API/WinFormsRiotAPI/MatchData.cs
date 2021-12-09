using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WinFormsRiotAPI
{
    class MatchData
    {
        [JsonProperty(PropertyName = "gameDuration", Order = 1)]
        public long gameDuration { get; set; }

        [JsonProperty(PropertyName = "gameType", Order = 2)]
        public string gameType { get; set; }

        [JsonProperty(PropertyName = "participants", Order = 3)]
        public List<ExtraSummonerInfo> participants { get; set; }
  
        [JsonIgnore]
        public List<ExtraSummonerInfo> players { get; set; }

    }
}