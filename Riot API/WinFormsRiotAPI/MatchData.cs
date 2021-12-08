using System;
using System.Collections.Generic;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.SummonerV4;
using Newtonsoft.Json;

namespace WinFormsRiotAPI
{
    internal class MatchData
    {
        public string gameType { get; set; }
        public long gameDuration { get; set; }

        public List<ExtraSummonerInfo> summoners { get; set; }

        internal MatchData()
        {
             
        }

        internal void DivideTeams(ExtraSummonerInfo summoner)
        {
            
        }
    }
}