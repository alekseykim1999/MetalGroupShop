using Microsoft.EntityFrameworkCore;
using MusicShop.Interfaces;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Repository
{
    public class AlbumRepository : IAllAlbums
    {

        private readonly AppDBContent appDbContent;


        public AlbumRepository(AppDBContent _appdbcont)
        {
            this.appDbContent = _appdbcont;
        }


        public IEnumerable<Album> getAllAlbums => appDbContent.Album.Include(a=>a.GroupId);

        public Album getObjectAlbum(int AlbumId) => appDbContent.Album.FirstOrDefault(p => p.Id == AlbumId);
    }
}
