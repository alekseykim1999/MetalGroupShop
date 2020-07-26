using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;

    //данный класс содержит функции, возвращающие ViewResult -  объект HTML страницы
    public class AlbumController : Controller
    {

        private readonly IAllAlbums all_albums;
        private readonly IAllGroups all_groups;

        public AlbumController(IAllAlbums _iAllAlbums, IAllGroups _iAllGroups)
        {
            all_albums = _iAllAlbums; //в Startup указана связь между классом и интерфейсом
            all_groups = _iAllGroups;
        }
        public ViewResult List()
        {
            var albums = all_albums.getAllAlbums;
            return View(albums);
    

        }

      
    }

