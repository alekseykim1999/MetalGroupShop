using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    public interface IAllAlbums
    {
        Album getObjectAlbum(int id);
        IEnumerable<Album> getConcreteAlbums(int v); //вывести альбомы
    }
}
