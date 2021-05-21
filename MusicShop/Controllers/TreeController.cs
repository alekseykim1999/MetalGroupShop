using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Models;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;

namespace MusicShop.Controllers
{
    public class TreeController : Controller
    {
        public ActionResult GenresTree()
        {
            return View();
        }
    }
}

    

