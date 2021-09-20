using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournament()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
         }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }                       

        }
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //CAll create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();            
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back the form a prizeModel.
            //Take the prizemodel ant put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
                        
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();

        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam frm = new CreateTeam(this);
            frm.Show();
        }

        private void removeSelectedPlayersButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
            //PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            //if (p != null)
            //{
            //    selectedTeameMembers.Remove(p);
            //    availableTeameMembers.Add(p);

            //    WireUpLists();
            //}
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
            }
            WireUpLists();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //Validate data
            decimal fee = 0;
            bool feeAcceptible = decimal.TryParse(enteryFeeValue.Text, out fee);


            if (!feeAcceptible)
            {
                MessageBox.Show("You need to enter a valid Entry Fee", 
                    "Invalid Fee",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            // Create out tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EnteryFee = fee;


            tm.Prizes = selectedPrizes;

            tm.EnteredTeames = selectedTeams;

            // Create tournament entries
            // Create all of the prizes entries
            // Create all of team entries

            // Create our matchups
        }
    }
    
}
