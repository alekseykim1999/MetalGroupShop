using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;
using MusicShop.WorkClasses;

namespace MusicShop.Controllers
{
    public class NewsController : Controller
    {



        public ViewResult AllNews() //главная страница
        {
            NewsViewModel obj = new NewsViewModel();
            NewsWorker newsGetter = new NewsWorker();
            obj.allnews = newsGetter.getAllNews();

            return View(obj); //сначала вызовется ViewStart, затем Layout, затем сама страница с переданными параметрами
        }

    }
}

    

