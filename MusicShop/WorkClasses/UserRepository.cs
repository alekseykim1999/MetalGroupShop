using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Text;

namespace MusicShop.WorkClasses
{
    /*класс для получения логина и пароля и для их сохранения*/
    public class UserRepository
    {
        private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb;";

        protected OleDbConnection myConnection = new OleDbConnection(connectString);
        //public void SaveUserData(string _name, string _ppassword)
        //{

        //}

        public bool GetUserData(string _name, string _password)
        {

            StringBuilder pair = new StringBuilder();
            string query = "SELECT [Login],[Password] FROM [UserData] WHERE [Login] = '" + _name + "' AND [Password] = '" + _password + "'" ;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pair.Append(reader[0].ToString() + "|");
                pair.Append(reader[1].ToString());
            }
            reader.Close();

            myConnection.Close();

            if(pair==null)
            {
                return false; //строка с логином и паролем есть. Все совпало
            }
            else
            {
                return true;
            }
        }
    }
}
