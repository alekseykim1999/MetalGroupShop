using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicShop.WorkClasses;

namespace MusicShop.Controllers
{
    public class EntranceController : Controller
    {
        private HashCipher worker = new HashCipher();
        private UserRepository repo = new UserRepository();

        [HttpPost]
        public RedirectResult CheckData(IFormCollection form)
        {
            string mainPath = "";           
            string login =form["_login"].ToString(); //получить логин
            string _hashPassword = worker.HashFunction(form["_password"].ToString()); //получить захэшированный пароль

            if (_hashPassword==repo.GetUserData(login)) //если пароли совпали
                mainPath="/Album/Main";
            else
                mainPath = "...";
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


        public ViewResult Authorization() //главная страница
        {
            return View(); 
        }

        public ViewResult Registration() //главная страница
        {
            return View();
        }
    }
}
