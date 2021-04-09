﻿using MusicShop.Interfaces;
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
    public class MockGroups : DatabaseConnection, IAllGroups
    {
        List<MetalGroup> bands = new List<MetalGroup>();

        public IEnumerable<MetalGroup> getAllGroups
        {
            get
            {
                myConnection.Open();
                string query = "SELECT id_group,name_group,genre,create_date FROM Groups";
                var cmd = new NpgsqlCommand(query, myConnection);
                NpgsqlDataReader reader = cmd.ExecuteReader();
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



                //string query = "SELECT [id_group],[name_group],[genre],[create_date] FROM [Groups]";
                //OleDbCommand command = new OleDbCommand(query, myConnection);
                //OleDbDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    bands.Add(new MetalGroup
                //    {
                //        id = (int)reader[0],
                //        GroupName = reader[1].ToString(),
                //        GenreName = reader[2].ToString(),
                //        born = (DateTime)reader[3]
                //    }

                //  );
                //}
                //reader.Close();
                //myConnection.Close();            
                return bands.OrderBy(u=>u.GroupName);
            }
        }

        public MetalGroup getOneGroup(int id_band)
        {
            return bands[id_band];
        }
    }
}
