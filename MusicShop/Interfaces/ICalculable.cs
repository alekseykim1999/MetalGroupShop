using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    interface ICalculable
    {
        int calculate(List<Album> items_in_basket);
    }
}
