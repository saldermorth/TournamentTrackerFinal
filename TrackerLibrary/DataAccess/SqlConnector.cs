using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


 //   @PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
 //   @PricePercentage float,
 //   @Id int = 0 output

namespace TrackerLibrary.DataAccess
{
    
    public class SqlConnector : IDataConnection
    {
        private const string db = "TournamentTracker"; //Database name changes here 
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAdress", model.EmailAdress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("[dbo].[spPeople_Insert]", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");

                return model;
            }
              

            
        }

        //ToDO . make the create prize acctally save to the database
        /// <summary>
        /// Saves new prize to database
        /// </summary>
        /// <param name="model">The prize info</param>
        /// <returns>The Prize it and identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizeAmount);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                
                connection.Execute("[dbo].[spPrizes_Insert]", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");

                return model;
            }
           
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("[dbo].[spTeams_Insert]", p, commandType: CommandType.StoredProcedure);
                
                model.Id = p.Get<int>("@Id");

                foreach (PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamID", model.Id);
                    p.Add("@PersonId", tm.Id); 


                    connection.Execute("[dbo].[spTeamMembers_Insert]", p, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))  
            {
                saveTournament(model, connection);

                saveTournamentPrizes(model, connection);

                saveTournamentEntries(model, connection);
                                
                
            }
        }
        private void saveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("[dbo].[spTournamentEntries_Insert]", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void saveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
               var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("[dbo].[spTournamentPrizes_Insert]", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void saveTournament(TournamentModel model, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EnteryFee);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("[dbo].[spTournaments_Insert]", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@Id");
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
