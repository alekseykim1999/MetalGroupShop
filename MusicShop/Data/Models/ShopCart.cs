using System;
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
        private List<ShopCartAlbum> lineCollection = new List<ShopCartAlbum>();

        public void AddItem(Album alb, int quantity)
        {
            ShopCartAlbum line = lineCollection
                .Where(g => g.album.Id == alb.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new ShopCartAlbum
                {
                    itemId = alb.Id,
                    album = alb,
                    Quantity = quantity,
                    price = alb.Price
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Album alb)
        {
            lineCollection.RemoveAll(l => l.album.Id == alb.Id);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.album.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<ShopCartAlbum> Lines
        {
            get { return lineCollection; }
        }
    }

}
