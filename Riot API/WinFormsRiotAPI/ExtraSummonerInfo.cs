using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WinFormsRiotAPI
{
    internal class ExtraSummonerInfo
    {
        [JsonProperty(PropertyName = "championName", Order = 1)]
        public string championName { get; set; }

        [JsonProperty(PropertyName = "summonerName", Order = 2)]
        public string summonerName { get; set; }

        [JsonProperty(PropertyName = "lane", Order =3)]
        public string lane { get; set; }

        [JsonProperty(PropertyName = "kills", Order = 4)]
        public int kills { get; set; }

        [JsonProperty(PropertyName = "deaths", Order = 5)]
        public int deaths { get; set; }

        [JsonProperty(PropertyName = "assists", Order = 6)]
        public int assists { get; set; }

        [JsonProperty(PropertyName = "win", Order = 7)]
        public string win { get; set; }

    }
}
