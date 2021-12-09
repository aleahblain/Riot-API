using System;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.ChampionV3;
using MingweiSamuel.Camille.SummonerV4;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille.Enums;
using System.Runtime.Serialization;

namespace WinFormsRiotAPI
{
    public partial class RiotAPI : Form
    {
        private RiotApi API;
        private Match match;
        private MatchData matchData;
        private Summoner summoner;
        private ChampionInfo champion;

        internal string APIKey { get; set; }
        private string summonerName;
        private string matchID;
        

        public RiotAPI()
        {
            InitializeComponent();
        }


        private void aPIKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (APIKeyForm APIKeyForm = new APIKeyForm())
            {
                APIKeyForm.ShowDialog(this);
                APIKey = APIKeyForm.APIKey;

            }
            API = RiotApi.NewInstance(APIKey);
        }


        private void summerNameInputTB_TextChanged(object sender, EventArgs e) => summonerName = summerNameInputTB.Text;   
    
        private void summonerInputButton_Click(object sender, EventArgs e)
        {
            RetrieveSummonerInfo();
        }
        void RetrieveSummonerInfo()
        {
            summoner = API.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerName);
            retrievedSummonerID.Text = summoner.Id;
            retrievedSummonerAccID.Text = summoner.AccountId;
            retrievedSummonerPUUID.Text = summoner.Puuid;
            retrievedSummonerName.Text = summoner.Name;
            retrievedSummonerIconID.Text = $"{summoner.ProfileIconId}";
            retrievedSummonerRevisionDate.Text = $"{summoner.RevisionDate}";
            retrievedSummonerLevel.Text = $"{summoner.SummonerLevel}";
            var latestMatches = API.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, summoner.Puuid);
            foreach (var match in latestMatches)
            {
                retrievedMatchesListBox.Items.Add(match);
            }
        }

        private void matchIDTB_TextChanged(object sender, EventArgs e) => matchID = matchIDTB.Text;

        private void matchIDButton_Click(object sender, EventArgs e)
        {
            RetrieveMatchInfo();
        }

        void RetrieveMatchInfo()
        {
            match = API.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
            foreach (KeyValuePair<string, object> entry in match._AdditionalProperties)
            {
                if (entry.Key == "info")
                {
                    matchData = (dynamic)JsonConvert.DeserializeObject<MatchData>(entry.Value.ToString());
                }
            }

            retrievedMatchTypeTB.Text = matchData.gameType;
            retrievedMatchTimeTB.Text = $"{matchData.gameDuration}";

            int counter = 0;

            foreach (ExtraSummonerInfo summoner in matchData.participants)
            {   
                if(counter < 5)
                {
                    teamOneListBox.Items.Add(summoner.summonerName);
                } else
                {
                    teamTwoListBox.Items.Add(summoner.summonerName);
                }
                counter++;
            }

        }

        private void teamOneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ExtraSummonerInfo summoner in matchData.participants)
            {
                if(summoner.summonerName.Equals(teamOneListBox.SelectedItem))
                {
                    teamOneLaneTB.Text = summoner.lane;
                    teamOneChampNameTB.Text = summoner.championName;
                    teamOneKillsTB.Text = $"{summoner.kills}";
                    teamOneDeathsTB.Text = $"{summoner.deaths}";
                    teamOneAssistsTB.Text = $"{summoner.assists}";
                }
            }
             
        }

        private void teamTwoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ExtraSummonerInfo summoner in matchData.participants)
            {
                if (summoner.summonerName.Equals(teamTwoListBox.SelectedItem))
                {
                    teamTwoLaneTB.Text = summoner.lane;
                    teamTwoChampNameTB.Text = summoner.championName;
                    teamTwoKillsTB.Text = $"{summoner.kills}";
                    teamTwoDeathsTB.Text = $"{summoner.deaths}";
                    teamTwoAssistsTB.Text = $"{summoner.assists}";
                }
            }
        }

        private void champRotationButton_Click(object sender, EventArgs e)
        {
            RetrieveChampRotation();
        }

        void RetrieveChampRotation()
        {
            champion = API.ChampionV3.GetChampionInfo(MingweiSamuel.Camille.Enums.Region.NA);
            foreach(int championID in champion.FreeChampionIds)
            {
                champRotationLB.Items.Add((Champion)championID);
            }
            foreach(int championID in champion.FreeChampionIdsForNewPlayers)
            {
                champRotationNewPlayerLB.Items.Add((Champion) championID);
            }
        }

        private void riotDeveloperPortalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://developer.riotgames.com/");
        }
    }
}
