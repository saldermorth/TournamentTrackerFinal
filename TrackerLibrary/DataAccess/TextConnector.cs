using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the textfile 
            //Convert the text to List<Prizemdel>
            //Find the max Id
            //Add the new record with the new id (max + 1)
            //Convert the prizes to list<string>
            //Save the list<sting> to the text file
            

        }
    }
}
