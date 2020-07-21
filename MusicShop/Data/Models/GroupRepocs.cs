using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MusicShop.GroupRepository
{
    //class for getting information from SQL Server
    //хранилище всех данных - группы и их альбомы
    public class GroupRepo
    {
      
        string connString = @"Data Source=DESKTOP-OT44A5H\SQLEXPRESS;Initial Catalog=MusicShop;Persist Security Info=True;User ID=Алексей;Password=123";
        SqlConnection connection;
        List<MetalGroup> list_group = new List<MetalGroup>();

        public GroupRepo()
        {
            connection = new SqlConnection(connString);
            connection.Open();
        }


        public void createGroups() //создание всех групп - взять с базы данных через SQL запрос
        {

            MetalGroup group = new MetalGroup() { id = 1 }; //получить группу
            group.albums.Add(new Album() { } ); //добавит в нее ее альбомы
            list_group.Add(group); //добавить саму группу в список
            

        }

        public List<MetalGroup> getAllGroups()
        {
            return list_group;
        }


        
    
        


    }
}
