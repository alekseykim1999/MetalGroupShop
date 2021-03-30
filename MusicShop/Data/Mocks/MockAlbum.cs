using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.WorkClasses;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Mocks
{
    public class MockAlbum : DatabaseConnection, IAllAlbums
    {
        List<Album> albumsOfBand = new List<Album>();
        public IEnumerable<Album> getAllAlbums()
        {
            myConnection.Open();
            List<Album> allAlbums = new List<Album>();
            var middleDate = new DateTime();
            string query = "SELECT id_album,name_group,title,distributor,release_date FROM Albums,Groups" +
            " WHERE Albums.num_group = Groups.id_group ORDER BY id_album";
            var cmd = new NpgsqlCommand(query, myConnection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                middleDate = (DateTime)reader[4];
                allAlbums.Add(new Album
                {
                    Id = (int)reader[0],
                    GroupName = reader[1].ToString(),
                    Name = reader[2].ToString(),
                    Distributor = reader[3].ToString(),
                    Release_date = middleDate.Date,
                    Available = true,
                    Price = 4000,
                    img = ""
                }
                );
            }
            reader.Close();
            myConnection.Close();


            //string query = "SELECT [id_album],[name_group],[title],[distributor],[release_date] FROM [Albums],[Groups]" +
            //    "WHERE [Albums].[num_group] = [Groups].[id_group] ORDER BY [id_album]";
            //OleDbCommand command = new OleDbCommand(query, myConnection);
            //OleDbDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    middleDate = (DateTime)reader[4];
            //    allAlbums.Add(new Album
            //    {
            //        Id = (int)reader[0],
            //        GroupName = reader[1].ToString(),
            //        Name = reader[2].ToString(),
            //        Distributor = reader[3].ToString(),
            //        Release_date = middleDate.Date,
            //        Available = true,
            //        Price = 4000,
            //        img = ""
            //    }
            //    );
            //}
            //reader.Close();
            //myConnection.Close();
            return allAlbums;
        }
        public IEnumerable<Album> getConcreteAlbums(int group_id)
        {
            
                myConnection.Open();
                string query = "SELECT id_album,num_group,title,distributor,release_date FROM Albums WHERE num_group = " + group_id
                + " ORDER BY release_date";
                var cmd = new NpgsqlCommand(query, myConnection);
                NpgsqlDataReader reader = cmd.ExecuteReader();
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

                //string query = "SELECT [id_album],[num_group],[title],[distributor],[release_date] FROM [Albums] WHERE [num_group] = " + group_id
                //+ " ORDER BY [release_date]";
                //OleDbCommand command = new OleDbCommand(query, myConnection);
                //OleDbDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    albumsOfBand.Add(new Album
                //    {
                //        Id = (int)reader[0],
                //        GroupId = (int)reader[1],
                //        Name = reader[2].ToString(),
                //        Distributor = reader[3].ToString(),
                //        Release_date = (DateTime)reader[4],
                //        Available = true,
                //        Price = 4000,
                //        img = "/img/" + group_id + "/" + reader[0] + ".jpg"
                //    }
                //    );
                //}
                //reader.Close();
                //myConnection.Close();
                return albumsOfBand;
            
                
            }

        public Album getObjectAlbum(int id)
        {
            return albumsOfBand[id]; // вернуть один альбом
        }
    }
}
