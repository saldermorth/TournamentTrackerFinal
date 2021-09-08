using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //ToDO . make the create prize acctally save to the database
        /// <summary>
        /// Saves new prize to database
        /// </summary>
        /// <param name="model">The prize info</param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;

            return model;
            //Todo connect to database
        }    
        
    }
}
