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


            bool success = repo.GetUserData(login, _hashPassword);
            if(success) //если совпало все
            {
                mainPath="/Album/Main";
            }
            else
            {
                mainPath = "...";
            }
            return Redirect(mainPath);
        }

        [HttpPost]
        public RedirectResult RegisterUser(IFormCollection form)
        {

            string login = form["_bookName"].ToString();
            string password = form["_description"].ToString();




            return Redirect("/Album/Main");

        }


        public ViewResult Authorization() //главная страница
        {

            return View(); //сначала вызовется ViewStart, затем Layout, затем сама страница с переданными параметрами


        }
    }
}
