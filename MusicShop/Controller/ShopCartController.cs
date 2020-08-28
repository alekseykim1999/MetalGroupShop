using MusicShop.Data.Models;
using MusicShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;


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

    }

