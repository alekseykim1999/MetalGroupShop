using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;
using MusicShop.WorkClasses;
using Parser.Models;
namespace MusicShop.Controllers
{
    public class NewsController : Controller
    {
        public ViewResult AllNews() 
        {
            try
            {
                NewsViewModel obj = new NewsViewModel();
                NewsWorker newsGetter = new NewsWorker();
                obj.allnews = newsGetter.getAllNews();
                return View(obj);
            }
            catch 
            {
                NewsViewModel obj = new NewsViewModel();
                obj.allnews = new List<NewsModel>() { new NewsModel { img = "", news = "Error" } };
                return View(obj);
            }
           
        }

    }
}

    

