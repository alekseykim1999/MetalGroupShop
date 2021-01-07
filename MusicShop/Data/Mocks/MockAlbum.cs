using MusicShop.Interfaces;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Mocks
{
    public class MockAlbum : IAllAlbums
    {

        //source to SQL Server
        string connectionString = "Data Source=DESKTOP-OT44A5H\\SQLEXPRESS;Initial Catalog=MusicShop;Integrated Security=True";
        
        List<Album> albumsOfBand = new List<Album>();
        private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";
        protected OleDbConnection myConnection = new OleDbConnection(connectString);

        public IEnumerable<Album> getConcreteAlbums(int group_id)
        {
            
                myConnection.Open();
                string query = "SELECT [id_album],[num_group],[title],[distributor],[release_date] FROM [Albums] WHERE [num_group] = " + group_id
                + " ORDER BY [release_date]";;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    albumsOfBand.Add(new Album
                    {
                        Id = (int)reader[0],
                        GroupId = (int)reader[1],
                        Name = reader[2].ToString(),
                        Distributor = reader[3].ToString(),
                        Release_date = (DateTime)reader[4],
                        Available = true,
                        Price = 4000,
                        img = "/img/" + group_id + "/" + reader[0] + ".jpg"
                    }
                    );
                }
                reader.Close();
                myConnection.Close();

                return albumsOfBand;
            
                //using (SqlConnection db = new SqlConnection(connectionString))
                //{
                //    db.Open();
                //    SqlCommand command = new SqlCommand();
                //    command.CommandText = "SELECT [id_album],[num_group],[title],[distributor],[release_date] FROM [Albums] WHERE [num_group] = " + group_id
                //        + " ORDER BY [release_date]";
                //    command.Connection = db;
                //    SqlDataReader reader = command.ExecuteReader();
                //    while (reader.Read())
                //    {
                //        albumsOfBand.Add(new Album
                //        {
                //            Id = (int)reader[0],
                //            GroupId = (int)reader[1],
                //            Name = reader[2].ToString(),
                //            Distributor = reader[3].ToString(),
                //            Release_date = (DateTime)reader[4],
                //            Available = true,
                //            Price = 4000,  
                //            img="/img/" + group_id + "/" + reader[0] +".jpg"
                //        }
                //        );
                //    }
                //    reader.Close();
                //    db.Close();
                //    return albumsOfBand;
                //}
            }

        public Album getObjectAlbum(int id)
        {
            return albumsOfBand[id]; // вернуть один альбом
        }
    }
}
