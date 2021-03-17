using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;

namespace MusicShop.Controllers
{
    public class AlbumController : Controller
    {

        private readonly IAllAlbums all_albums;
        public static IEnumerable<Album> help_albums;

        AlbumListViewModel obj = new AlbumListViewModel();

        private static int group_id;

        public AlbumController(IAllAlbums _iAllAlbums, IAllGroups _iAllGroups)
        {
            all_albums = _iAllAlbums;
            obj.AllBands = _iAllGroups.getAllGroups;
        }
        public ViewResult Main() //главная страница
        {
            ViewBag.Title = "Rock Portal";
            ViewBag.GroupName = "Metal Music"; 
            return View(obj); 
        }

        public ViewResult AlbumsOfGroup(int bandId) 
        {
            help_albums = all_albums.getConcreteAlbums(bandId);
            group_id = bandId;
            obj.AllAlbums = help_albums;
            return View(obj);
        }

        public ViewResult InfoAlbum(int albumId)
        {
            obj.AllAlbums = help_albums;
            obj.idAlbum = albumId;
            obj.idgroup = group_id;
            return View(obj);
        }


    }
}

    

