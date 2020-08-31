using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Models
{
    public class ShopCartAlbum
    {
        public int itemId { get; set; }
        public Album album { get; set; }
        public int price { get; set; }
        public int Quantity { get; set; }
    }
}
