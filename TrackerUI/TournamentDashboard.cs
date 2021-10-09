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
    public partial class TournamentDashboard : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboard()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournament frm = new CreateTournament();
            frm.Show();
        }
    }
}
