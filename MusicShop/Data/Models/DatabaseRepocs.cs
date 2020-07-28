using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace MusicShop.GroupRepository
{
    //class for getting information from SQL Server
    //хранилище всех данных - группы и их альбомы
    public class DatabaseRepo
    {
        string connectionString = "Data Source=DESKTOP-OT44A5H\\SQLEXPRESS;Initial Catalog=MusicShop;Integrated Security=True";
        public void getAlbums()
        {
            List<string> albums = new List<string>();

            // получение данных с sql сервера
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT [title],[distributor] FROM [Albums]";
                command.Connection = db;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    albums.Add(reader[0].ToString());
                }
                reader.Close();

            }
            Console.ReadLine();
        }
    }
}
