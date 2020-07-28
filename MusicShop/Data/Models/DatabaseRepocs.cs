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
            List<Album> albums = new List<Album>();

            // получение данных с sql сервера
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT [id_album],[num_group],[title],[distributor],[release_date] FROM [Albums]";
                command.Connection = db;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    albums.Add(new Album
                    {
                        Id = (int)reader[0],
                        GroupId = (int)reader[1],
                        Name = reader[3].ToString(),
                        Distributor = reader[4].ToString(),
                        Release_date = (DateTime)reader[5],
                        Available=true,
                        Price = 4000
                    }
                    );
                }
                reader.Close();

            }
            Console.ReadLine();
        }
    }
}
