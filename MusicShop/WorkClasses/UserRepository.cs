using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Text;
using System.Data;
using Npgsql;

namespace MusicShop.WorkClasses
{
  
    public class UserRepository : DatabaseConnection
    {
        public void SaveUserData(string _name, string _password) 
        {
            myConnection.Open();
            worker.Connection = myConnection;
            worker.CommandType = CommandType.Text;
            worker.CommandText = ("INSERT INTO [UserData]([Login],[Password]) VALUES (@name,@pass)");
            worker.Parameters.AddWithValue("@name", _name);
            worker.Parameters.AddWithValue("@name", _password);
            worker.ExecuteNonQuery();
            myConnection.Close();
        }

        public string GetUserData(string _name) 
        {
            string answer = "";
            string pass = "";
            myConnection.Open();

            //string query = "SELECT [Password] FROM [UserData] WHERE [Login] = '" + _name + "'";
            //OleDbCommand command = new OleDbCommand(query, myConnection);
            //OleDbDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    pass = reader[0].ToString();
            //    break;
            //}
            string sql = "SELECT LastName FROM UserData WHERE Login = '" + _name + "'";
            var cmd = new NpgsqlCommand(sql, myConnection);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                pass = rdr[0].ToString();
                break;
            }
            rdr.Close();
            myConnection.Close();
            try
            {
                answer = pass.Substring(0, 47);
            }
            catch
            {
                answer = "error";
            }
            return answer;
            
        }
    }
}
