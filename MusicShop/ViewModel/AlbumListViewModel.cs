using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.ViewModel
{
    //класс для хранения множества данных, которые можно передать одним объектом на страницу
    public class AlbumListViewModel
    {

        public IEnumerable<Album> AllAlbums { get; set; }

        public IEnumerable<MetalGroup> AllBands { get; set; }


        public int idAlbum { get; set; }
        public Album ConcreteAlbum
        {
            get
            {
                Album current = null;
                foreach(var cur_album in AllAlbums)
                {
                    if(cur_album.Id==idAlbum)
                    {
                        current = cur_album;
                    }
                }
                return current;
            }   
        }
        

       
    }
}
