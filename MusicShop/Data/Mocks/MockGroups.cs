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
    public class MockGroups : IAllGroups
    {
        //string connectionString = "Data Source=KIMALEKSEY\\SQLEXPRESS;Initial Catalog=MusicShop;Integrated Security=True";
        List<MetalGroup> bands = new List<MetalGroup>();

        private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";
        protected OleDbConnection myConnection = new OleDbConnection(connectString);


        public IEnumerable<MetalGroup> getAllGroups
        {
            get{
                myConnection.Open();
                string query = "SELECT [id_group],[name_group],[genre],[create_date] FROM [Groups]";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bands.Add(new MetalGroup
                    {
                        id = (int)reader[0],
                        GroupName = reader[1].ToString(),
                        GenreName = reader[2].ToString(),
                        born = (DateTime)reader[3]
                    }

                  );
                }
                reader.Close();
                myConnection.Close();
               
                //using (SqlConnection db = new SqlConnection(connectionString))
                //{
                //    db.Open();
                //    SqlCommand command = new SqlCommand();
                //    command.CommandText = "SELECT [id_group],[name_group],[genre],[create_date] FROM [Groups]";
                //    command.Connection = db;

                //    SqlDataReader reader = command.ExecuteReader();

                //    while (reader.Read())
                //    {
                //        bands.Add(new MetalGroup
                //        {
                //            id=(int)reader[0],
                //            GroupName = reader[1].ToString(),
                //            GenreName = reader[2].ToString(),
                //            born=(DateTime)reader[3]
                //        }
                        
                //        );
                //    }
                //    reader.Close();
                //    db.Close();
                //}
                return bands.OrderBy(u=>u.GroupName);
            }
        }

        public MetalGroup getOneGroup(int id_band)
        {
            return bands[id_band];
        }
    }
}
