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
    /*класс для получения логина и пароля и для их сохранения*/
    public class UserRepository
    {
        private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        protected OleDbConnection myConnection = new OleDbConnection(connectString);
        OleDbCommand worker = new OleDbCommand();
        public void SaveUserData(string _name, string _password) // сохранить аккаунт в бд
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

        public string GetUserData(string _name) //получить данные для проверки
        {
            string answer = "";
            string pass = "";
            var cs = "Host=localhost;Username=postgres;Password=12345;Database=Music Data Base";
            var con = new NpgsqlConnection(cs);
            con.Open();
            string sql = "SELECT userpassword FROM userdata WHERE userlogin = '" + _name + "'";
            var cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                pass = rdr[0].ToString();
                break;
            }
            rdr.Close();
            con.Close();
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
