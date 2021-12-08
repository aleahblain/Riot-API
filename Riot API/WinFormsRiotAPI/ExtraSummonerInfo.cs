using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRiotAPI
{
    internal class ExtraSummonerInfo
    {
        public string championName { get; set; }
        public string summonerName { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
    }
}
