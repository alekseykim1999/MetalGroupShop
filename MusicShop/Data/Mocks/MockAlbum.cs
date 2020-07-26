using MusicShop.Interfaces;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Mocks
{
    public class MockAlbum : IAllAlbums
    {

        List<Album> alb = new List<Album>(); //список всех альбомов

        
        private readonly IAllGroups groupIdGetter = new MockGroups();


        public IEnumerable<Album> getAllAlbums
        {
            get
            {
                return new List<Album>
                {
                    new Album{Name="Korn", Release_date=new DateTime(1994, 7, 20), img="", Price=4000, Available=true, Group=groupIdGetter.getAllGroups.First()},
                    new Album{Name="Life Is Peachy", Release_date=new DateTime(1996, 7, 20), img="", Price=4000, Available=true, Group=groupIdGetter.getAllGroups.First()}                 
                };
            }
            

        }

        private void getAlbumFromDatabase()
        {
            //Album album = new Album { Name = "Korn", Release_date = new DateTime(1994, 7, 20), img = "", Price = 4000, Available = true, Group = groupIdGetter.getAllGroups.First() };

            //Иницализация полей проходит успешно
            //код для заполнения списка альбомов через SQL

            //Надо подключиться к серверу, через запросы получать все строки, создавать объект альбома и инициализоровать поля

            //В цикле создатся объекты, инициализируются поля и добавляются в список
        }

        public Album getObjectAlbum(int id)
        {
            throw new NotImplementedException();
        }
    }
}
