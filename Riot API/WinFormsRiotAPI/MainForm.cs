using System;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.ChampionV3;
using MingweiSamuel.Camille.SummonerV4;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille.Enums;

namespace WinFormsRiotAPI
{
    public partial class MainForm : Form
    {
        private RiotApi API;
        private Match match;
        private MatchData matchData;
        private Summoner summoner;
        private ChampionInfo champion;

        internal string APIKey { get; set; }
        private string summonerName;
        private string summonerPUUID;
        private string summonerAccID;
        private string matchID;
        

        public MainForm()
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

        private void summonerIDTB_TextChanged(object sender, EventArgs e) => summonerPUUID = summonerIDTB.Text;

        private void summonerAccIDTB_TextChanged(object sender, EventArgs e) => summonerAccID = summonerAccIDTB.Text;
    
        private void summonerInputButton_Click(object sender, EventArgs e)
        {
            RetrieveSummonerInfo();
        }
        void RetrieveSummonerInfo()
        {
            //API = RiotApi.NewInstance(APIKey);
            if (summonerName != null)
            {
                summoner = API.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerName);
            } else if (summonerPUUID != null)
            {
                summoner = API.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerPUUID);
            } else
            {
                summoner = API.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerAccID);
            }
            
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

        private void matchIDButton_Click(object sender, EventArgs e) => matchID = matchIDTB.Text;

        void RetrieveMatchInfo()
        {
            match = API.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchIDTB.Text);
            foreach(KeyValuePair<string, object> entry in match._AdditionalProperties)
            {
                if(entry.Key == "info")
                {
                    matchData = (dynamic)JsonConvert.DeserializeObject<MatchData>(entry.Value.ToString());
                }
            }

            retrievedMatchTypeTB.Text = matchData.gameType;
            retreievedMatchTime.Text = $"{matchData.gameDuration}";

            foreach(ExtraSummonerInfo summoner in matchData.summoners)
            {
                matchData.DivideTeams(summoner);
            }

        }

        private void teamOneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSummoner = (ExtraSummonerInfo)teamOneListBox.SelectedItem;
            teamOneSummonerNameTB.Text = selectedSummoner.summonerName;
            teamOneChampNameTB.Text = selectedSummoner.championName;
            teamOneKillsTB.Text = $"{selectedSummoner.kills}";
            teamOneDeathsTB.Text = $"{selectedSummoner.deaths}";
            teamOneAssistsTB.Text = $"{selectedSummoner.assists}";
            
        }

        private void teamTwoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSummoner = (ExtraSummonerInfo)teamOneListBox.SelectedItem;
            teamTwoSummonerNameTB.Text = selectedSummoner.summonerName;
            teamTwoChampNameTB.Text = selectedSummoner.championName;
            teamTwoKillsTB.Text = $"{selectedSummoner.kills}";
            teamTwoDeathsTB.Text = $"{selectedSummoner.deaths}";
            teamTwoAssistsTB.Text = $"{selectedSummoner.assists}";
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
    }
}
