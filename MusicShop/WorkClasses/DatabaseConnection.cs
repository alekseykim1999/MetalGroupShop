using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.WorkClasses
{
    public class DatabaseConnection
    {
        //protected static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";
        protected static string connectString = "Host=localhost;Username=postgres;Password=12345;Database=musicdatabase";
        //protected OleDbConnection myConnection = new OleDbConnection(connectString);
        protected NpgsqlConnection myConnection = new NpgsqlConnection(connectString);

        protected NpgsqlCommand worker = new NpgsqlCommand();
    }
}
