using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Models
{
    public class TreeviewModel
    {
        public int parent_id { get; set; }
        public int cat_id { get; set; }
        public string descript { get; set; }
    }
}
