﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;

//данный класс содержит функции, возвращающие ViewResult -  объект HTML страницы

//url - имя хоста/имя контроллера (в данном случае - Album)/имя функции (например, List())

//код ищет папку Views, в ней ищет папку с названием контроллера (Album), в ней ищет cshtml файл с названием функции (List)
public class AlbumController : Controller
    {

        private readonly IAllAlbums all_albums;


        public static IEnumerable<Album> help_albums;

        AlbumListViewModel obj = new AlbumListViewModel();

        public AlbumController(IAllAlbums _iAllAlbums, IAllGroups _iAllGroups)
        {
            all_albums = _iAllAlbums; //в Startup указана связь между классом и интерфейсом
            obj.AllBands = _iAllGroups.getAllGroups; //получить все группы
           

        }
        public ViewResult List() //главная страница
        {

            ViewBag.Title = "Hello Sinner";
            ViewBag.GroupName = "Metal Music"; //один из способов передачи информации на страницу. Желательно не использовать 

           
            return View(obj); //сначала вызовется ViewStart, затем Layout, затем сама страница с переданными параметрами
    

        }

        public ViewResult AllAlbums(int bandId) //страница, хранящая альбомы группы.
        {
            help_albums=all_albums.getConcreteAlbums(bandId);
            obj.AllAlbums = help_albums; //сюда надо передавать id выбранной группы
            return View(obj); 


        }

        public ViewResult InfoAlbum(int albumId) //страница, хранящая конкретный альбом
        {
            obj.AllAlbums = help_albums;
            obj.idAlbum = albumId;
            return View(obj); 
            

   
        }


}

