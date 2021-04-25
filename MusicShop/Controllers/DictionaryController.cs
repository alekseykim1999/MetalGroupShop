using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Mocks;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;

namespace MusicShop.Controllers
{
    public class DictionaryController : Controller
    {

        private readonly IAllAlbums all_albums;
      
        AlbumListViewModel obj = new AlbumListViewModel();
        public ActionResult AllAlbums() 
        {
            MockAlbum library = new MockAlbum();
            obj.AllAlbums = library.getAllAlbums();
            return View(obj);
        }



    }
}

    

