using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieDatabaseV04
{
    class Database
    {
        public MySQLDatabaseInterface connect()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(true);
            mdi.setConnectionServerData("localhost", "movie_database", "3306");
            mdi.setConnectionUserData("root", "");
            mdi.makeConnectionToDatabase();

            return mdi;
        }
    }
}