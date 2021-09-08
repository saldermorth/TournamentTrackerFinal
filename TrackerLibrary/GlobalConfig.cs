using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textfile)
        {
            if (database)
            {
                //ToDO - Setup the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textfile)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
                //To Do - create txt file connection
            }
        }
        public static string CnnString(string name)
        {
           return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

}
