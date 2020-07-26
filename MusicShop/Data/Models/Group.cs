using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class MetalGroup
    {
        public int id { get; set; }
        public string GroupName { get; set; }
        public string CountryName { get; set; }
        public string GenreName { get; set; }



        public List<Album> albums { get; set; }

        public MetalGroup()
        {

        }

   
    }
}
