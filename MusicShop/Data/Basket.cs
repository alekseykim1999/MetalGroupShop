using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Models;
using Supermarket.Item;
namespace Supermarket.Item
{
    class Basket
    {
        List<Album> list_of_items = new List<Album>();

        //adding basket into cart
        public void addItem(Album item)
        {
            list_of_items.Add(item);
        }
        public void removeLastItem()
        {
            list_of_items.RemoveAt(list_of_items.Count-1);
        }

        //get albums for calculation
        public List<Album> getItems()
        {
            return list_of_items;
        }
    }
}
