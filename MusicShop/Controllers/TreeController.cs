using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Data.Models;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.ViewModel;

namespace MusicShop.Controllers
{
    public class TreeController : Controller
    {

        public ActionResult GenresTree()
        {
            var query = InitData().ToList(); 
            return View(query);
        }


        [HttpPost]
        public JsonResult FilterNode(int parentid)
        {
            var query = InitData().Where(c => c.parent_id == parentid).ToList(); 
            return Json(query);
        }
        public List<TreeviewModel> InitData()
        {
            List<TreeviewModel> itemlist = new List<TreeviewModel>();
            itemlist.Add(new TreeviewModel() { cat_id = 101, parent_id = 0, descript = "Sports" });
            itemlist.Add(new TreeviewModel() { cat_id = 102, parent_id = 0, descript = "Fruits" });
            itemlist.Add(new TreeviewModel() { cat_id = 103, parent_id = 101, descript = "Football" });
            itemlist.Add(new TreeviewModel() { cat_id = 104, parent_id = 101, descript = "Basketball" });
            itemlist.Add(new TreeviewModel() { cat_id = 105, parent_id = 102, descript = "Apple" });
            itemlist.Add(new TreeviewModel() { cat_id = 106, parent_id = 102, descript = "Orange" });
            ViewBag.datasource = itemlist;
            return itemlist;
        }


    }
}

    

