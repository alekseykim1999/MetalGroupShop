﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MusicShop.Data.Models;
using MusicShop.Models;
using Supermarket.Item;
namespace MusicShop.Data.Models
{
    public class ShopCart
    {
        public string cartId { get; set; }
        List<ShopCartAlbum> list_of_items { get; set; }

        private readonly AppDBContent appDbContent;

        public ShopCart(AppDBContent _content)
        {
            this.appDbContent = _content;
        }
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<HttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            return new ShopCart(context) { cartId = shopCartId};
        }


        public void AddToCart(Album _album)
        {
            if (list_of_items == null)
            {
                list_of_items = new List<ShopCartAlbum>();
            }

            list_of_items.Add(new ShopCartAlbum
            {
                shopCartId = cartId,
                album=_album,
                price = _album.Price
            });
        }

        public List<ShopCartAlbum> GetShopItems()
        {
            return list_of_items.Where(c => c.shopCartId == cartId).ToList();
        }


        
    }
}
