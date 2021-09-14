﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the textfile 
            //Convert the text to List<Prizemdel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max Id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //Add the new record with the new id (max + 1)
            prizes.Add(model);



            //Convert the prizes to list<string>
            //Save the list<sting> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

            
        }
    }
}
