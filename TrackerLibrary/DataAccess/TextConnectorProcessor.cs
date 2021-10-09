﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    //* Load the textfile 
    //* Convert the text to List<Prizemdel>
    //Find the max Id
    //Add the new record with the new id (max + 1)
    //Convert the prizes to list<string>
    //Save the list<sting> to the text file
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();//Todo problem
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);


            }
            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAdress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);//?
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines,string peopleFileName)//?
        {
            //id,team namle, list of ids seperated by the pipes
            //3,Tims team, 1|2|3. Do like this
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personId = cols[2].Split('|');

                foreach (string id in personId)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines,
            string teamFileName,
            string peopleFileName, 
            string prizeFileName)
        {
            // id = 0
            // TournamentName = 1
            // EnteryFee = 2
            // EnteredTeams = 3
            // Prizes = 4
            // Rounds = 5

            //id, TournamentName,EntryFee,(id|id|id - Entered Teams), (id|id|id - Prizes), (Rounds - id^id^id|id^id^id|id^id^id|)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);           
                tm.TournamentName = (cols[1]);
                tm.EnteryFee = decimal.Parse(cols[2]);
               
                
                

                string[] teamId = cols[3].Split('|');

                foreach (string id in teamId)
                {
                    //t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
               
                string[] rounds = cols[5].Split('|');
                

                foreach (string round in rounds)    
                {
                    string[] msText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();
                    foreach (string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }
                    tm.Rounds.Add(ms);
                }
                                
                output.Add(tm);
                
            }
            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models , string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }
        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAdress},{p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToStrings(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile)
        {
            //Loop through eatch Round
            //Loop through each Matchup
            //Get the id for the new matchup
            //Loop through each entrt, get the id, and save it.

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    //Load all of the matcajups from file
                    //Get the top id and add one
                    //store the id 
                    //Save the matchup records
                    matchup.SaveMatchupToFile(matchupFile, matchupEntryFile);                    
                }
            }
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModel(this List<string> lines)
        {
            //id = 0, TeamCompeting = 1, score = 2, ParentMatchup = 3
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel me = new MatchupEntryModel();
                me.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookUpTeamById(int.Parse(cols[1]));
                }
                
                me.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    me.ParentMatchup = null;
                }
                output.Add(me);
            }
            return output;
           
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();
            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');
                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModel();

            return output;
        }

        private static TeamModel LookUpTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels(GlobalConfig.PeopleFile).First();
                }
            }
            return null;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModel().First();
                }
            }
            return null;
        }

        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {
            //id=0,entries=1|(pipe deliminated by id), winner=2, matchupRound=3
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                if (cols[2].Length == 0)
                {
                    p.Winner = null;
                }
                else
                {
                    p.Winner = LookUpTeamById(int.Parse(cols[2]));
                }
               
                p.MatchupRound = int.Parse(cols[3]);               
                output.Add(p);
            }
            return output;
        }
        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFile, string matchupEntryFile)
        {
            
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = currentId;

            matchups.Add(matchup);


            foreach (MatchupEntryModel entrys in matchup.Entries)
            {
                entrys.SaveEntryToFile(GlobalConfig.MatchupEntryFile);
            }

            // save to file
            List<string>lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{""},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

            foreach (MatchupEntryModel entrys in matchup.Entries)
            {
                entrys.SaveEntryToFile(GlobalConfig.MatchupEntryFile);
            }
            // save to file
            lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }                
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry, string matchupEnteryFile)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModel();

            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;

            }
            entry.Id = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = ""; 
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
           
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EnteryFee},{ConvertTeamsToString(tm.EnteredTeams)},{ConvertPrizesListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {

                output += $"{ConvertMatchupListToString(r) }|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {

                output += $"{m.Id}^";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel e in entries)
            {

                output += $"{e.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPrizesListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {

                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertTeamsToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {

                output += $"{t.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPeopleListToStrings(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
