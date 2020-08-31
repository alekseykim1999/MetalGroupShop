using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Models;
using MusicShop.Models;

namespace MusicShop.Controllers
{
    public class ShopCartController : Controller
    {

        public RedirectToRouteResult AddToCart(Album alb, string returnUrl)
        {

            GetCart().AddItem(alb, 1);

            return RedirectToRoute("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Album alb, string returnUrl)
        {

            GetCart().RemoveLine(alb);

            return RedirectToRoute("Index", new { returnUrl });
        }

        public ShopCart GetCart()
        {
            
            ShopCart cart = (ShopCart)Session["Cart"];
            if (cart == null)
            {
                cart = new ShopCart();
                Session["ShopCart"] = cart;
            }
            return cart;
        }
    }

}





