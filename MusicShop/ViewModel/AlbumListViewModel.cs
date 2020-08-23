using MusicShop.Models;
using MusicShop.WorkClasses;
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

        public int idgroup { get; set; }

        public Album ConcreteAlbum
        {
            get
            {
                return AllAlbums.First(a => a.Id == idAlbum);
            }   
        }

        public MetalGroup ConcreteGroup
        {
            get
            {
                return AllBands.First(a => a.id == idgroup);
            }
        }


        public List<string> getSongs()
        {
            return FileWorker.readFile(idgroup, idAlbum);
        }



    }
}
