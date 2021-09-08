using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {

            }
            //Todo connect to database
        }    
        
    }
}
