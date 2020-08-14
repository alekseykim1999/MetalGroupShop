using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.ViewModel
{
    public class ConcreteAlbumViewModel
    {

        //для вывода на странице
        public Album CurrentAlbum { get; set; }
        public MetalGroup CurrentGroup { get; set; }
    }
}
