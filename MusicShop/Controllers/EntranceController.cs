using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicShop.WorkClasses;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace MusicShop.Controllers
{
    public class EntranceController : Controller
    {
        private HashCipher worker = new HashCipher();
        private UserRepository repo = new UserRepository();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectResult  CheckData(IFormCollection form)
        {
            string mainPath = "";           
            string login =form["_login"].ToString(); 
            string _hashPassword = worker.HashFunction(form["_password"].ToString()); 

            if (_hashPassword==repo.GetUserData(login))
            {
                mainPath = "/Album/Main";
            }
            else
            {
                mainPath = "/Entrance/Incorrect";
            }
               
            return Redirect(mainPath);
        }

        [HttpPost]
        public RedirectResult RegisterUser(IFormCollection form)
        {
            string login = form["_newLogin"].ToString();
            string password = worker.HashFunction(form["_newPassword"].ToString());
            repo.SaveUserData(login, password);
            return Redirect("/Entrance/Authorization");
        }


        public ViewResult Authorization() 
        {
            return View(); 
        }

        public ViewResult Incorrect()
        {
            return View();
        }

        public ViewResult Registration() 
        {
            return View();
        }
    }
}
