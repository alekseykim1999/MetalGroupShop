using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.GroupRepository;
using MusicShop.Interfaces;
using MusicShop.ViewModel;

//данный класс содержит функции, возвращающие ViewResult -  объект HTML страницы

//url - имя хоста/имя контроллера (в данном случае - Album)/имя функции (например, List())

//код ищет папку Views, в ней ищет папку с названием контроллера (Album), в ней ищет cshtml файл с названием функции (List)
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

            
            
            ViewBag.Title = "Hello Sinner";
            ViewBag.GroupName = "Metal Music"; //один из способов передачи информации на страницу. Желательно не использовать 
            //var albums = all_albums.getAllAlbums; также один из способов передачи - напрямую.

            AlbumListViewModel obj = new AlbumListViewModel();
            obj.AllAlbums = all_albums.getAllAlbums;
            obj.currGroup = "Korn";
            return View(obj); //сначала вызовется ViewStart, затем Layout, затем сама страница с переданными параметрами
    

        }

      
    }

