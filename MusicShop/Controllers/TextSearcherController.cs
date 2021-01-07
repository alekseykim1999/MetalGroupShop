using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicShop.Controllers
{
    public class TextSearcherController : Controller
    {

        public ViewResult SearchPage() //главная страница
        {
           
            return View(); 
        }
    }
}
