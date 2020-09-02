using MusicShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.ViewModel
{
    public class CartIndexViewModel
    {
        public ShopCart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
