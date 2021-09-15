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
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availableTeameMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeameMembers = new List<PersonModel>();
        public CreateTeam()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }
        
        private void CreateSampleData()
        {
            availableTeameMembers.Add(new PersonModel { FirstName = "Gustav", LastName = "Berg" });
            availableTeameMembers.Add(new PersonModel { FirstName = "Carrrl", LastName = "essen" });

            selectedTeameMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Doe" });
            selectedTeameMembers.Add(new PersonModel { FirstName = "James", LastName = "Dove" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = availableTeameMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedTeameMembers;
            teamMembersListBox.DisplayMember = "FullName";

            
        }
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAdress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            availableTeameMembers.Remove(p);
            selectedTeameMembers.Add(p);

            selectTeamMemberDropDown.Refresh();
            teamMembersListBox.Refresh();
        }
    }
}
