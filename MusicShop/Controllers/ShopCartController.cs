using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Models;
using MusicShop.Models;
using MusicShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

     public class ShopCartController : Controller
     {
        private readonly ShopCart ShopCart;


        public ShopCartController(ShopCart _shopCart)
        {
            ShopCart = _shopCart;
        }

        public ViewResult Index()
        { 
            var obj = new ShopCartViewModel { cart = ShopCart };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(Album _curAlb)
        {
            ShopCart.AddToCart(_curAlb);

            return RedirectToAction("Index");
        }

    }

   

