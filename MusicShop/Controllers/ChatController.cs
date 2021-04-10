using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;
using MusicShop.WorkClasses;

namespace MusicShop.Controllers
{
    public class ChatController : Controller
    {
        public ViewResult SendMessage() 
        {
            ChatViewModel obj = new ChatViewModel();
            obj.SessionKey = HttpContext.Session.Id.ToString();
            return View(obj); 
        }

    }
}

    

