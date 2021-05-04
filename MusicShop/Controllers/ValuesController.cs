using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Mocks;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController
    {
        [HttpGet]
        public ActionResult<List<Album>> Get()
        {
            MockAlbum library = new MockAlbum();
            List<Album> AllAlbums = (List<Album>)library.getAllAlbums();
            return AllAlbums;
        }
    }
}
