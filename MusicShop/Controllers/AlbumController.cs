using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;
using MusicShop.WorkClasses;

namespace MusicShop.Controllers
{
    public class AlbumController : Controller
    {

        private readonly IAllAlbums all_albums;
        public static IEnumerable<Album> help_albums;
        AlbumListViewModel obj = new AlbumListViewModel();
        private static int group_id;
        private static int album_id;

        private FileWorker fileWorker;
        public AlbumController(IAllAlbums _iAllAlbums, IAllGroups _iAllGroups, IHostingEnvironment env)
        {
            all_albums = _iAllAlbums;
            obj.AllBands = _iAllGroups.getAllGroups;
            this.fileWorker = new FileWorker(env);
        }
        public ViewResult Main() 
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
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
            obj.fileWorker = this.fileWorker;
            album_id = albumId;
            return View(obj);
        }


        public ViewResult CreateReview()
        {
            return View();
        }
        public RedirectResult WriteReview(IFormCollection form)
        {
            int idOfGroup = group_id;
            int idOfAlbum = album_id;
           
            string review = form["_review_text"].ToString();
            this.fileWorker.CreateData(idOfGroup, idOfAlbum, review);
            string mainPath = "/Album/InfoAlbum?albumId="+idOfAlbum;
            return Redirect(mainPath);
        }


    }
}

    

