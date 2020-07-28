using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Album
    {

          public int Id { get; set; }
          public string Name { get; set; }
          public DateTime Release_date { get; set; }
          public ushort Price { get; set; }
          public string Distributor { get; set; }
          public bool Available { get; set; }
          public string img { get; set; }
          

          public int GroupId { get; set; }

    }
}
