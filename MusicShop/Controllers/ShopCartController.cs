using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Models;
using MusicShop.Models;
using System.Collections;
using System.Net;
using Microsoft.AspNetCore.WebUtilities;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using MusicShop.ViewModel;

namespace MusicShop.Controllers
{
    public class ShopCartController : Controller
    {
        private string url = "/Album/Main";
        public RedirectToActionResult AddToCart(Album alb)
        {

            
            GetCart().AddItem(alb, 1);

            return RedirectToAction("Index", new { url });
        }

        public RedirectToRouteResult RemoveFromCart(Album alb)
        {

            GetCart().RemoveLine(alb);

            return RedirectToRoute("Index", new { url });
        }

        public ShopCart GetCart()
        {

            ShopCart cart;
            BinaryFormatter bf = new BinaryFormatter();


            byte[] cache = HttpContext.Session.Get("ShopCart");

            if (cache == null)
            {
                cart = new ShopCart();
                return cart;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(HttpContext.Session.Get("ShopCart")))
                {
                    object obj = bf.Deserialize(ms);
                    cart = (ShopCart)obj;
                }

                return cart;
            }
            
        }


        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

    }

}





