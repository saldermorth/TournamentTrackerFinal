using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewer : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        public TournamentViewer(TournamentModel tournamentModel)
        {
            tournament = tournamentModel;
            InitializeComponent();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundDropDown.DataSource = null;
            roundDropDown.DataSource = rounds;

            matchupListBox.DataSource = null;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "";

        }
        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);
            int currRounds = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRounds)
                {
                    currRounds = matchups.First().MatchupRound;
                    rounds.Add(currRounds);
                   
                }
            }

            WireUpLists();
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }
        }
    }
}
