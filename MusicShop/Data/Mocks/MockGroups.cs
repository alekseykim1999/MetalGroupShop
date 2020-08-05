using MusicShop.Interfaces;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Mocks
{
    public class MockGroups : IAllGroups
    {
        string connectionString = "Data Source=DESKTOP-OT44A5H\\SQLEXPRESS;Initial Catalog=MusicShop;Integrated Security=True";
        List<MetalGroup> bands = new List<MetalGroup>();


        public IEnumerable<MetalGroup> getAllGroups
        {

            get{
                using (SqlConnection db = new SqlConnection(connectionString))
                {
                    db.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "SELECT [id_group],[name_group],[genre],[create_date] FROM [Groups]";
                    command.Connection = db;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        bands.Add(new MetalGroup
                        {
                            id=(int)reader[0],
                            GroupName = reader[1].ToString(),
                            GenreName = reader[2].ToString(),
                            born=(DateTime)reader[3]
                        }
                        
                        );
                    }
                    reader.Close();

                }

                return bands;
            }
        }

        
    }
}
